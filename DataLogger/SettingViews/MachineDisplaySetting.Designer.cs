namespace DataLogger.SettingViews
{
    partial class MachineDisplaySetting
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMachineNameSetting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMachineNameSetting
            // 
            this.lblMachineNameSetting.AutoSize = true;
            this.lblMachineNameSetting.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMachineNameSetting.Location = new System.Drawing.Point(15, 14);
            this.lblMachineNameSetting.Name = "lblMachineNameSetting";
            this.lblMachineNameSetting.Size = new System.Drawing.Size(69, 20);
            this.lblMachineNameSetting.TabIndex = 0;
            this.lblMachineNameSetting.Text = "Machine";
            // 
            // MachineDisplaySetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.Controls.Add(this.lblMachineNameSetting);
            this.Name = "MachineDisplaySetting";
            this.Size = new System.Drawing.Size(462, 144);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMachineNameSetting;
    }
}
