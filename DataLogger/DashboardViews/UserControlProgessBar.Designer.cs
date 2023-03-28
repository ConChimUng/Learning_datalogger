namespace DataLogger.DashboardViews
{
    partial class UserControlProgessBar
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
      this.cprBar1 = new CircularProgressBar.CircularProgressBar();
      this.lblNameMachine = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cprBar1
      // 
      this.cprBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
      this.cprBar1.AnimationSpeed = 500;
      this.cprBar1.BackColor = System.Drawing.Color.Navy;
      this.cprBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cprBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.cprBar1.InnerColor = System.Drawing.Color.Navy;
      this.cprBar1.InnerMargin = 2;
      this.cprBar1.InnerWidth = -1;
      this.cprBar1.Location = new System.Drawing.Point(47, 52);
      this.cprBar1.MarqueeAnimationSpeed = 2000;
      this.cprBar1.Name = "cprBar1";
      this.cprBar1.OuterColor = System.Drawing.Color.Black;
      this.cprBar1.OuterMargin = -25;
      this.cprBar1.OuterWidth = 26;
      this.cprBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.cprBar1.ProgressWidth = 15;
      this.cprBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cprBar1.Size = new System.Drawing.Size(258, 247);
      this.cprBar1.StartAngle = 270;
      this.cprBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
      this.cprBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
      this.cprBar1.SubscriptText = "";
      this.cprBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
      this.cprBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
      this.cprBar1.SuperscriptText = "°C";
      this.cprBar1.TabIndex = 0;
      this.cprBar1.Text = "22";
      this.cprBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
      this.cprBar1.Value = 20;
      // 
      // lblNameMachine
      // 
      this.lblNameMachine.AutoSize = true;
      this.lblNameMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNameMachine.ForeColor = System.Drawing.SystemColors.Control;
      this.lblNameMachine.Location = new System.Drawing.Point(19, 29);
      this.lblNameMachine.Name = "lblNameMachine";
      this.lblNameMachine.Size = new System.Drawing.Size(139, 25);
      this.lblNameMachine.TabIndex = 1;
      this.lblNameMachine.Text = "NameMachine";
      // 
      // UserControlProgessBar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Navy;
      this.Controls.Add(this.lblNameMachine);
      this.Controls.Add(this.cprBar1);
      this.Name = "UserControlProgessBar";
      this.Size = new System.Drawing.Size(350, 350);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        public CircularProgressBar.CircularProgressBar cprBar1;
        private System.Windows.Forms.Label lblNameMachine;
  }
}
