using DataLogger.DashboardViews;
using DataLogger.eNum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DataLogger.DashboardViews
{
  public partial class FormDashboard : Form
  {
    #region 
    public static FormDashboard _Instance = null;
    public static FormDashboard Instance
    {
      get
      {
        if (_Instance == null)
        {
          _Instance = new FormDashboard();
        }
        return _Instance;
      }
    }
    #endregion

    
    public FormDashboard()
    {
      InitializeComponent();
      int id = 0;
      this.userTemperature.SetData(id, "Temperature", eNum.eProgessBarType.Temperature);
      this.userSpeed.SetData(id++, "Speed", eNum.eProgessBarType.Speed);
      //this.userChart1.setDataChart("Chart Line", "Chart1", "AxisX", "AxisY", eTypechart.Spline);

      this.userChart1.setDataChart("Chart Line", "Chart1", "AxisX", "AxisY", SeriesChartType.Line);

      this.userTemperature.DisplayToUi();
      this.userSpeed.DisplayToUi();

    }



    int speed = 0;
    int temperature = 0;
    
    public void tmr1_Tick(object sender, EventArgs e)
    {
      Random rd = new Random();
      speed = rd.Next(1,50);
      temperature = rd.Next(1,50);
      DateTime dataTime = DateTime.Now;
      this.userTemperature.ChangeValue(temperature);
      this.userSpeed.ChangeValue(speed);
      this.userChart1.ChangeValueChart("Chart1",speed,temperature );
       
      tmr1.Start();
       
      






    }

    private void FormDashboard_Load_1(object sender, EventArgs e)
    {
      tmr1.Start();
       

    }
  }
}
