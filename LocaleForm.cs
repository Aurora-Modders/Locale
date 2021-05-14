using System.Windows.Forms;

namespace Locale
{
    public partial class LocaleForm : Form
    {
        public LocaleForm()
        {
            InitializeComponent();
        }

        private void dateTimeFormatLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings");
        }
    }
}
