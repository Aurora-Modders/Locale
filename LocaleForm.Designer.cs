
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
            this.saveButton = new System.Windows.Forms.Button();
            this.dateTimeFormatTextBox = new System.Windows.Forms.TextBox();
            this.helpLabel = new System.Windows.Forms.Label();
            this.dateTimeFormatLinkLabel = new System.Windows.Forms.LinkLabel();
            this.cultureLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cultureSettingsDropdown
            // 
            this.cultureSettingsDropdown.FormattingEnabled = true;
            this.cultureSettingsDropdown.Location = new System.Drawing.Point(110, 12);
            this.cultureSettingsDropdown.Name = "cultureSettingsDropdown";
            this.cultureSettingsDropdown.Size = new System.Drawing.Size(164, 21);
            this.cultureSettingsDropdown.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(110, 94);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // dateTimeFormatTextBox
            // 
            this.dateTimeFormatTextBox.Location = new System.Drawing.Point(110, 45);
            this.dateTimeFormatTextBox.Name = "dateTimeFormatTextBox";
            this.dateTimeFormatTextBox.Size = new System.Drawing.Size(164, 20);
            this.dateTimeFormatTextBox.TabIndex = 4;
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Location = new System.Drawing.Point(133, 68);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(98, 13);
            this.helpLabel.TabIndex = 5;
            this.helpLabel.Text = "ie: MMMM dd, yyyy";
            // 
            // dateTimeFormatLinkLabel
            // 
            this.dateTimeFormatLinkLabel.AutoSize = true;
            this.dateTimeFormatLinkLabel.Location = new System.Drawing.Point(12, 48);
            this.dateTimeFormatLinkLabel.Name = "dateTimeFormatLinkLabel";
            this.dateTimeFormatLinkLabel.Size = new System.Drawing.Size(91, 13);
            this.dateTimeFormatLinkLabel.TabIndex = 7;
            this.dateTimeFormatLinkLabel.TabStop = true;
            this.dateTimeFormatLinkLabel.Text = "DateTime Format:";
            this.dateTimeFormatLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dateTimeFormatLinkLabel_LinkClicked);
            // 
            // cultureLabel
            // 
            this.cultureLabel.AutoSize = true;
            this.cultureLabel.Location = new System.Drawing.Point(60, 15);
            this.cultureLabel.Name = "cultureLabel";
            this.cultureLabel.Size = new System.Drawing.Size(43, 13);
            this.cultureLabel.TabIndex = 8;
            this.cultureLabel.Text = "Culture:";
            // 
            // LocaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 127);
            this.Controls.Add(this.cultureLabel);
            this.Controls.Add(this.dateTimeFormatLinkLabel);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.dateTimeFormatTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cultureSettingsDropdown);
            this.Name = "LocaleForm";
            this.Text = "Locale Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox cultureSettingsDropdown;
        public System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.LinkLabel dateTimeFormatLinkLabel;
        public System.Windows.Forms.TextBox dateTimeFormatTextBox;
        private System.Windows.Forms.Label cultureLabel;
    }
}