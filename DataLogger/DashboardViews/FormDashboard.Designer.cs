namespace DataLogger.DashboardViews
{
    partial class FormDashboard
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
      this.components = new System.ComponentModel.Container();
      this.tmr1 = new System.Windows.Forms.Timer(this.components);
      this.flpDashboard = new System.Windows.Forms.FlowLayoutPanel();
      this.userSelectDevice1 = new DataLogger.DashboardViews.UserSelectDevice();
      this.userControlProgessBarTemperature = new DataLogger.DashboardViews.UserControlProgessBar();
      this.userControlProgessBarSpeed = new DataLogger.DashboardViews.UserControlProgessBar();
      this.userLich1 = new DataLogger.DashboardViews.UserLich();
      this.userChartTemperature = new DataLogger.DashboardViews.UserChart();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.userChartSpeed = new DataLogger.DashboardViews.UserChart();
      this.flpDashboard.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // tmr1
      // 
      this.tmr1.Interval = 1000;
      this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
      // 
      // flpDashboard
      // 
      this.flpDashboard.Controls.Add(this.userSelectDevice1);
      this.flpDashboard.Controls.Add(this.userControlProgessBarTemperature);
      this.flpDashboard.Controls.Add(this.userControlProgessBarSpeed);
      this.flpDashboard.Controls.Add(this.userLich1);
      this.flpDashboard.Controls.Add(this.userChartTemperature);
      this.flpDashboard.Controls.Add(this.dataGridView1);
      this.flpDashboard.Controls.Add(this.userChartSpeed);
      this.flpDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flpDashboard.Location = new System.Drawing.Point(0, 0);
      this.flpDashboard.Name = "flpDashboard";
      this.flpDashboard.Size = new System.Drawing.Size(1449, 765);
      this.flpDashboard.TabIndex = 0;
      // 
      // userSelectDevice1
      // 
      this.userSelectDevice1.BackColor = System.Drawing.Color.Navy;
      this.userSelectDevice1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.userSelectDevice1.Location = new System.Drawing.Point(3, 3);
      this.userSelectDevice1.Name = "userSelectDevice1";
      this.userSelectDevice1.Size = new System.Drawing.Size(350, 350);
      this.userSelectDevice1.TabIndex = 0;
      // 
      // userControlProgessBarTemperature
      // 
      this.userControlProgessBarTemperature.BackColor = System.Drawing.Color.Navy;
      this.userControlProgessBarTemperature.Location = new System.Drawing.Point(359, 3);
      this.userControlProgessBarTemperature.Name = "userControlProgessBarTemperature";
      this.userControlProgessBarTemperature.Size = new System.Drawing.Size(350, 350);
      this.userControlProgessBarTemperature.TabIndex = 1;
      // 
      // userControlProgessBarSpeed
      // 
      this.userControlProgessBarSpeed.BackColor = System.Drawing.Color.Navy;
      this.userControlProgessBarSpeed.Location = new System.Drawing.Point(715, 3);
      this.userControlProgessBarSpeed.Name = "userControlProgessBarSpeed";
      this.userControlProgessBarSpeed.Size = new System.Drawing.Size(350, 350);
      this.userControlProgessBarSpeed.TabIndex = 2;
      // 
      // userLich1
      // 
      this.userLich1.BackColor = System.Drawing.Color.Navy;
      this.userLich1.Location = new System.Drawing.Point(1071, 3);
      this.userLich1.Name = "userLich1";
      this.userLich1.Size = new System.Drawing.Size(350, 350);
      this.userLich1.TabIndex = 5;
      // 
      // userChartTemperature
      // 
      this.userChartTemperature.BackColor = System.Drawing.Color.Navy;
      this.userChartTemperature.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.userChartTemperature.Location = new System.Drawing.Point(3, 359);
      this.userChartTemperature.Name = "userChartTemperature";
      this.userChartTemperature.Size = new System.Drawing.Size(704, 308);
      this.userChartTemperature.TabIndex = 3;
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(713, 359);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 62;
      this.dataGridView1.RowTemplate.Height = 28;
      this.dataGridView1.Size = new System.Drawing.Size(708, 308);
      this.dataGridView1.TabIndex = 6;
     
      // 
      // userChartSpeed
      // 
      this.userChartSpeed.BackColor = System.Drawing.Color.Navy;
      this.userChartSpeed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.userChartSpeed.Location = new System.Drawing.Point(3, 673);
      this.userChartSpeed.Name = "userChartSpeed";
      this.userChartSpeed.Size = new System.Drawing.Size(704, 308);
      this.userChartSpeed.TabIndex = 4;
      // 
      // FormDashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Silver;
      this.ClientSize = new System.Drawing.Size(1449, 765);
      this.Controls.Add(this.flpDashboard);
      this.Name = "FormDashboard";
      this.Text = "FormDashboard";
      this.Load += new System.EventHandler(this.FormDashboard_Load_1);
      this.flpDashboard.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.FlowLayoutPanel flpDashboard;
    private UserSelectDevice userSelectDevice1;
    private UserControlProgessBar userControlProgessBarTemperature;
    private UserControlProgessBar userControlProgessBarSpeed;
    private UserChart userChartTemperature;
    private UserChart userChartSpeed;
    private UserLich userLich1;
    private System.Windows.Forms.DataGridView dataGridView1;
  }
}