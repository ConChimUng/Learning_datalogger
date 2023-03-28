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
      this.SuspendLayout();
      // 
      // tmr1
      // 
      this.tmr1.Interval = 1000;
      this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
      // 
      // flpDashboard
      // 
      this.flpDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flpDashboard.Location = new System.Drawing.Point(0, 0);
      this.flpDashboard.Name = "flpDashboard";
      this.flpDashboard.Size = new System.Drawing.Size(1449, 765);
      this.flpDashboard.TabIndex = 0;
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
      this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.FlowLayoutPanel flpDashboard;
  }
}