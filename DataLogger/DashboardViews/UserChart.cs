using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DataLogger.eNum;

namespace DataLogger.DashboardViews
{
  public partial class UserChart : UserControl
  {
    //private eProgessBarType _eProgessBarType = eProgessBarType.Speed;
    public UserChart()
    {
      InitializeComponent();
      


      


    }
    public static Series series = new Series();

    public void setDataChart(string NameChart, string nameSeries, string nameX, string nameY, SeriesChartType type)
    {
      series.Name = nameSeries;
      series.ChartType = SeriesChartType.Line;
      series.ChartType = type;

      // Đặt tiêu đề cho biểu đồ
      chart1.Titles.Add(NameChart);

      // Đặt tên trục X và trục Y
      chart1.ChartAreas[0].AxisX.Title = nameX;
      chart1.ChartAreas[0].AxisY.Title = nameY;

      // Đặt giá trị tối thiểu và tối đa cho trục Y
      chart1.ChartAreas[0].AxisY.Minimum = 0;
      chart1.ChartAreas[0].AxisY.Maximum = 50;


      // Đặt màu cho cột
      chart1.Series[nameSeries].Color = Color.Blue;
    }





    

    public void ChangeValueChart(string series, float valueX, float valueY)
    {
      chart1.Series[series].Points.AddXY(valueX, valueY);
       
    }


  }
}