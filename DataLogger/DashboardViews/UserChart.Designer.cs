namespace DataLogger.DashboardViews
{
  partial class UserChart
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // chart1
      // 
      this.chart1.BackColor = System.Drawing.Color.Navy;
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.chart1.Location = new System.Drawing.Point(0, 0);
      this.chart1.Name = "chart1";
      series1.BorderWidth = 2;
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series1.Color = System.Drawing.Color.Blue;
      series1.LabelBackColor = System.Drawing.Color.Black;
      series1.MarkerBorderWidth = 4;
      series1.MarkerSize = 10;
      series1.Name = "Chart1";
      this.chart1.Series.Add(series1);
      this.chart1.Size = new System.Drawing.Size(991, 308);
      this.chart1.TabIndex = 0;
      this.chart1.Text = "chart1";
      // 
      // UserChart
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Navy;
      this.Controls.Add(this.chart1);
      this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.Name = "UserChart";
      this.Size = new System.Drawing.Size(991, 308);
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
  }
}
