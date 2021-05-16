using System;
using System.Linq;
using System.Threading;
using System.Reflection;
using System.Globalization;
using System.Collections.Generic;

using HarmonyLib;

namespace Locale
{
    public class Locale : AuroraPatch.Patch
    {
        public override string Description => "Patch used to set Aurora locale/internationalization settings.";
        private CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures & ~CultureTypes.SpecificCultures);
        private Dictionary<string, CultureInfo> CultureNameMap = new Dictionary<string, CultureInfo>();
        private static DateTime? Hooking = null;
        private static string Culture = null;
        private static string DateTimeFormat = null;

        protected override void Loaded(Harmony harmony)
        {
            LogInfo("Loading Locale...");
            // Ready our culture info map and datetime format.
            LoadSettings();
            ApplySettings();
            // Ready our DateTime format override hook.
            foreach (var datetime in typeof(DateTime).Assembly.GetTypes().Where(t => t == typeof(DateTime)))
            {
                try
                {
                    foreach (MethodBase method in datetime.GetMethods(AccessTools.all))
                    {
                        if (method.Name == "ToString")
                        {
                            var parameters = method.GetParameters();
                            if (parameters.Length == 1 && parameters[0].ParameterType == typeof(string))
                            {
                                HarmonyMethod datetimeToStringPostfixMethod = new HarmonyMethod(GetType().GetMethod("DateTimeToStringPostfix", AccessTools.all));
                                harmony.Patch(method, postfix: datetimeToStringPostfixMethod);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    LogError($"Locale failed to patch {datetime.Name}, exception: {e}");
                }
            }
        }

        /// <summary>
        /// Get our culture list ready.
        /// </summary>
        private void LoadSettings()
        {
            CultureNameMap.Clear();
            foreach (CultureInfo cultureInfo in cultures)
            {
                CultureNameMap[cultureInfo.DisplayName] = cultureInfo;
            }
            try
            {
                Culture = Deserialize<string>("local");
            }
            catch {
                LogInfo("No previous culture setting found");
            }
            try
            {
                DateTimeFormat = Deserialize<string>("datetime_format");
            }
            catch {
                LogInfo("No previous datetime_format setting found");
            }
        }

        /// <summary>
        /// Helper method to apply our culture settings.
        /// </summary>
        private void ApplySettings()
        {
            if (Culture != null)
            {
                CultureInfo ci = CultureNameMap[Culture];
                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;
            }
            if (DateTimeFormat.Length < 1)
            {
                DateTimeFormat = null;
            }
        }

        /// <summary>
        /// Our settings form. Exposes the CultureInfo dropdown and the DateTime format override.
        /// </summary>
        protected override void ChangeSettings()
        {
            LoadSettings();
            List<string> cultures = CultureNameMap.Keys.ToList();
            cultures.Sort();
            var form = new LocaleForm();
            form.cultureSettingsDropdown.Items.AddRange(cultures.ToArray());
            if (Culture != null) form.cultureSettingsDropdown.SelectedItem = Culture;
            if (!string.IsNullOrEmpty(DateTimeFormat)) form.dateTimeFormatTextBox.Text = DateTimeFormat;
            form.saveButton.Click += (object sender, EventArgs e) => {
                if (form.cultureSettingsDropdown.SelectedItem != null)
                {
                    Culture = form.cultureSettingsDropdown.SelectedItem.ToString();
                    Serialize("local", form.cultureSettingsDropdown.SelectedItem.ToString());
                }
                DateTimeFormat = form.dateTimeFormatTextBox.Text;
                Serialize("datetime_format", form.dateTimeFormatTextBox.Text);
                ApplySettings();
                form.Close();
                form.Dispose();
            };
            form.ShowDialog();
        }

        /// <summary>
        /// Our DateTime.ToString() postfix for format overriding.
        /// This method will call itself and we use the Hooking variable to stop recursing.
        /// We also ignore the parameter "F" as it's the default one used to show datetime of the Aurora universe.
        /// </summary>
        /// <param name="__instance"></param>
        /// <param name="__result"></param>
        private static void DateTimeToStringPostfix(DateTime __instance, ref string __result, string format)
        {
            if (DateTimeFormat != null && Hooking != __instance)
            {
                Hooking = __instance;
                if (format != "F") __result = __instance.ToString(DateTimeFormat, CultureInfo.InvariantCulture);
                else __result = __instance.ToString(DateTimeFormat + " HH:mm:ss", CultureInfo.InvariantCulture);
                Hooking = null;
            }
        }
    }
}
