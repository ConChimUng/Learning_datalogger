namespace DataLogger.DashboardViews
{
  partial class UserSelectDevice
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.cbFactory = new System.Windows.Forms.ComboBox();
      this.cbLine = new System.Windows.Forms.ComboBox();
      this.cbDevice = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(19, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Device";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(19, 77);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(62, 20);
      this.label2.TabIndex = 0;
      this.label2.Text = "Factory";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(19, 165);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(39, 20);
      this.label3.TabIndex = 0;
      this.label3.Text = "Line";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(19, 254);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(57, 20);
      this.label4.TabIndex = 0;
      this.label4.Text = "Device";
      // 
      // cbFactory
      // 
      this.cbFactory.FormattingEnabled = true;
      this.cbFactory.Location = new System.Drawing.Point(87, 74);
      this.cbFactory.Name = "cbFactory";
      this.cbFactory.Size = new System.Drawing.Size(227, 28);
      this.cbFactory.TabIndex = 1;
      // 
      // cbLine
      // 
      this.cbLine.FormattingEnabled = true;
      this.cbLine.Location = new System.Drawing.Point(87, 162);
      this.cbLine.Name = "cbLine";
      this.cbLine.Size = new System.Drawing.Size(227, 28);
      this.cbLine.TabIndex = 1;
      // 
      // cbDevice
      // 
      this.cbDevice.FormattingEnabled = true;
      this.cbDevice.Location = new System.Drawing.Point(87, 251);
      this.cbDevice.Name = "cbDevice";
      this.cbDevice.Size = new System.Drawing.Size(227, 28);
      this.cbDevice.TabIndex = 1;
      // 
      // UserSelectDevice
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Navy;
      this.Controls.Add(this.cbDevice);
      this.Controls.Add(this.cbLine);
      this.Controls.Add(this.cbFactory);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.Name = "UserSelectDevice";
      this.Size = new System.Drawing.Size(350, 350);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cbFactory;
    private System.Windows.Forms.ComboBox cbLine;
    private System.Windows.Forms.ComboBox cbDevice;
  }
}
