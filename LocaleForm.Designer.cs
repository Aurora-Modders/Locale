
namespace Locale
{
    partial class LocaleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cultureSettingsDropdown = new System.Windows.Forms.ComboBox();
            this.cultureLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cultureSettingsDropdown
            // 
            this.cultureSettingsDropdown.FormattingEnabled = true;
            this.cultureSettingsDropdown.Location = new System.Drawing.Point(99, 12);
            this.cultureSettingsDropdown.Name = "cultureSettingsDropdown";
            this.cultureSettingsDropdown.Size = new System.Drawing.Size(121, 21);
            this.cultureSettingsDropdown.TabIndex = 0;
            // 
            // cultureLabel
            // 
            this.cultureLabel.AutoSize = true;
            this.cultureLabel.Location = new System.Drawing.Point(50, 15);
            this.cultureLabel.Name = "cultureLabel";
            this.cultureLabel.Size = new System.Drawing.Size(43, 13);
            this.cultureLabel.TabIndex = 1;
            this.cultureLabel.Text = "Culture:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(91, 45);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // LocaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 80);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cultureLabel);
            this.Controls.Add(this.cultureSettingsDropdown);
            this.Name = "LocaleForm";
            this.Text = "Locale Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cultureLabel;
        public System.Windows.Forms.ComboBox cultureSettingsDropdown;
        public System.Windows.Forms.Button saveButton;
    }
}