namespace DataLogger.SettingViews
{
    partial class FormSetting
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
            this.flpSetting = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpSetting
            // 
            this.flpSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSetting.Location = new System.Drawing.Point(0, 0);
            this.flpSetting.Name = "flpSetting";
            this.flpSetting.Size = new System.Drawing.Size(1098, 571);
            this.flpSetting.TabIndex = 0;
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 571);
            this.Controls.Add(this.flpSetting);
            this.Name = "FormSetting";
            this.Text = "FormSetting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSetting;
    }
}