namespace DataLogger
{
    partial class Form1
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
      this.panelLeftMenu = new System.Windows.Forms.Panel();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.btInformation = new System.Windows.Forms.Button();
      this.btSetting = new System.Windows.Forms.Button();
      this.btStatics = new System.Windows.Forms.Button();
      this.btHistorical = new System.Windows.Forms.Button();
      this.btDashboard = new System.Windows.Forms.Button();
      this.panelHeader = new System.Windows.Forms.Panel();
      this.button3 = new System.Windows.Forms.Button();
      this.btNotification = new System.Windows.Forms.Button();
      this.btAccount = new System.Windows.Forms.Button();
      this.panelDesktopMain = new System.Windows.Forms.Panel();
      this.panelLeftMenu.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panelHeader.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelLeftMenu
      // 
      this.panelLeftMenu.BackColor = System.Drawing.Color.Navy;
      this.panelLeftMenu.Controls.Add(this.pictureBox2);
      this.panelLeftMenu.Controls.Add(this.pictureBox1);
      this.panelLeftMenu.Controls.Add(this.btInformation);
      this.panelLeftMenu.Controls.Add(this.btSetting);
      this.panelLeftMenu.Controls.Add(this.btStatics);
      this.panelLeftMenu.Controls.Add(this.btHistorical);
      this.panelLeftMenu.Controls.Add(this.btDashboard);
      this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
      this.panelLeftMenu.Location = new System.Drawing.Point(0, 0);
      this.panelLeftMenu.Name = "panelLeftMenu";
      this.panelLeftMenu.Size = new System.Drawing.Size(210, 563);
      this.panelLeftMenu.TabIndex = 0;
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = global::DataLogger.Properties.Resources.th;
      this.pictureBox2.Location = new System.Drawing.Point(0, 58);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(210, 71);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox2.TabIndex = 2;
      this.pictureBox2.TabStop = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(120, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(38, 37);
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // btInformation
      // 
      this.btInformation.BackColor = System.Drawing.Color.Navy;
      this.btInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.btInformation.FlatAppearance.BorderSize = 0;
      this.btInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btInformation.ForeColor = System.Drawing.SystemColors.ControlLight;
      this.btInformation.Location = new System.Drawing.Point(0, 515);
      this.btInformation.Name = "btInformation";
      this.btInformation.Size = new System.Drawing.Size(210, 48);
      this.btInformation.TabIndex = 0;
      this.btInformation.Text = "Information";
      this.btInformation.UseVisualStyleBackColor = false;
      this.btInformation.Click += new System.EventHandler(this.btInformation_Click);
      // 
      // btSetting
      // 
      this.btSetting.BackColor = System.Drawing.Color.Navy;
      this.btSetting.FlatAppearance.BorderSize = 0;
      this.btSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btSetting.ForeColor = System.Drawing.SystemColors.ControlLight;
      this.btSetting.Location = new System.Drawing.Point(0, 267);
      this.btSetting.Name = "btSetting";
      this.btSetting.Size = new System.Drawing.Size(175, 48);
      this.btSetting.TabIndex = 0;
      this.btSetting.Text = "Setting";
      this.btSetting.UseVisualStyleBackColor = false;
      this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
      // 
      // btStatics
      // 
      this.btStatics.BackColor = System.Drawing.Color.Navy;
      this.btStatics.FlatAppearance.BorderSize = 0;
      this.btStatics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btStatics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btStatics.ForeColor = System.Drawing.SystemColors.ControlLight;
      this.btStatics.Location = new System.Drawing.Point(0, 220);
      this.btStatics.Name = "btStatics";
      this.btStatics.Size = new System.Drawing.Size(175, 48);
      this.btStatics.TabIndex = 0;
      this.btStatics.Text = "Statics";
      this.btStatics.UseVisualStyleBackColor = false;
      this.btStatics.Click += new System.EventHandler(this.btStatics_Click);
      // 
      // btHistorical
      // 
      this.btHistorical.BackColor = System.Drawing.Color.Navy;
      this.btHistorical.FlatAppearance.BorderSize = 0;
      this.btHistorical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btHistorical.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btHistorical.ForeColor = System.Drawing.SystemColors.ControlLight;
      this.btHistorical.Location = new System.Drawing.Point(0, 173);
      this.btHistorical.Name = "btHistorical";
      this.btHistorical.Size = new System.Drawing.Size(175, 48);
      this.btHistorical.TabIndex = 0;
      this.btHistorical.Text = "Historical";
      this.btHistorical.UseVisualStyleBackColor = false;
      this.btHistorical.Click += new System.EventHandler(this.btHistorical_Click);
      // 
      // btDashboard
      // 
      this.btDashboard.BackColor = System.Drawing.Color.Navy;
      this.btDashboard.FlatAppearance.BorderSize = 0;
      this.btDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btDashboard.ForeColor = System.Drawing.SystemColors.ControlLight;
      this.btDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btDashboard.Location = new System.Drawing.Point(0, 126);
      this.btDashboard.Name = "btDashboard";
      this.btDashboard.Size = new System.Drawing.Size(175, 48);
      this.btDashboard.TabIndex = 0;
      this.btDashboard.Text = "Dasboard";
      this.btDashboard.UseVisualStyleBackColor = false;
      this.btDashboard.Click += new System.EventHandler(this.btDashboard_Click);
      // 
      // panelHeader
      // 
      this.panelHeader.BackColor = System.Drawing.Color.Navy;
      this.panelHeader.Controls.Add(this.button3);
      this.panelHeader.Controls.Add(this.btNotification);
      this.panelHeader.Controls.Add(this.btAccount);
      this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelHeader.Location = new System.Drawing.Point(210, 0);
      this.panelHeader.Name = "panelHeader";
      this.panelHeader.Size = new System.Drawing.Size(927, 58);
      this.panelHeader.TabIndex = 1;
      // 
      // button3
      // 
      this.button3.Dock = System.Windows.Forms.DockStyle.Right;
      this.button3.FlatAppearance.BorderSize = 0;
      this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button3.Image = global::DataLogger.Properties.Resources.microsoft_excel_24px;
      this.button3.Location = new System.Drawing.Point(672, 0);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(92, 58);
      this.button3.TabIndex = 0;
      this.button3.UseVisualStyleBackColor = true;
      // 
      // btNotification
      // 
      this.btNotification.Dock = System.Windows.Forms.DockStyle.Right;
      this.btNotification.FlatAppearance.BorderSize = 0;
      this.btNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btNotification.Image = global::DataLogger.Properties.Resources.messaging_24px;
      this.btNotification.Location = new System.Drawing.Point(764, 0);
      this.btNotification.Name = "btNotification";
      this.btNotification.Size = new System.Drawing.Size(78, 58);
      this.btNotification.TabIndex = 0;
      this.btNotification.UseVisualStyleBackColor = true;
      // 
      // btAccount
      // 
      this.btAccount.Dock = System.Windows.Forms.DockStyle.Right;
      this.btAccount.FlatAppearance.BorderSize = 0;
      this.btAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btAccount.Image = global::DataLogger.Properties.Resources.male_user_26px;
      this.btAccount.Location = new System.Drawing.Point(842, 0);
      this.btAccount.Name = "btAccount";
      this.btAccount.Size = new System.Drawing.Size(85, 58);
      this.btAccount.TabIndex = 0;
      this.btAccount.UseVisualStyleBackColor = true;
      // 
      // panelDesktopMain
      // 
      this.panelDesktopMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.panelDesktopMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelDesktopMain.Location = new System.Drawing.Point(210, 58);
      this.panelDesktopMain.Name = "panelDesktopMain";
      this.panelDesktopMain.Size = new System.Drawing.Size(927, 505);
      this.panelDesktopMain.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1137, 563);
      this.Controls.Add(this.panelDesktopMain);
      this.Controls.Add(this.panelHeader);
      this.Controls.Add(this.panelLeftMenu);
      this.Name = "Form1";
      this.Text = "DataLogger";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panelLeftMenu.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panelHeader.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelDesktopMain;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btInformation;
        private System.Windows.Forms.Button btSetting;
        private System.Windows.Forms.Button btStatics;
        private System.Windows.Forms.Button btHistorical;
        private System.Windows.Forms.Button btDashboard;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btNotification;
        private System.Windows.Forms.Button btAccount;
    }
}

