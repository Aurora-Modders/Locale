using System;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;

using HarmonyLib;

namespace Locale
{
    public class Locale : AuroraPatch.Patch
    {
        public override string Description => "Patch used to set Aurora locale/internationalization settings.";
        private CultureInfo[] Cultures = CultureInfo.GetCultures(CultureTypes.AllCultures & ~CultureTypes.SpecificCultures);

        protected override void ChangeSettings()
        {
            var form = new LocaleForm();
            form.cultureSettingsDropdown.Items.AddRange(Cultures);
            form.saveButton.Click += (object sender, EventArgs e) => {
                CultureInfo ci = (CultureInfo)form.cultureSettingsDropdown.SelectedItem;
                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;
                form.Close();
                form.Dispose();
            };
            form.ShowDialog();
        }
    }
}
