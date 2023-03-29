using LocalDatabase;
using LocalDatabase.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalDatabaseTester
{
  public partial class Form1 : Form
  {

    private const string db_name = "LoggerConfiguration.s3db"; //--> đổi tên db ở đây nếu muốn
    /// <summary>
    /// Db chia làm 2:
    /// 1. Configuration (SqliteConfigurationContext)--> cấu hình phần mềm, hệ thống
    /// 2. Datalogger (SqliteDataLogContext) --> lưu data log theo ngày
    /// </summary>
    public Form1()
    {
      InitializeComponent();
      this.Load += Form1_Load;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      Test_Configuration();
    }

    private string GetFileDB()
    {
      string configPath = Path.Combine(Application.StartupPath, db_name);
      return configPath;
    }
    public void Test_Configuration()
    {
      // Test Load all stattions
      SqliteConfigurationContext configurationContext = new SqliteConfigurationContext(GetFileDB());
      foreach(Stations station in configurationContext.Stations) 
      { 
        Console.WriteLine($"station_id: {station.id} , name: {station.name}");

      }
      var StationSettings = configurationContext.StationSettings;
      var equitment = configurationContext.Equipments;


       


      // Map station_settings vô đúng station theo id
      configurationContext.Stations.ForEach(station => { station.stationSetting = configurationContext.StationSettings.Find(x => x.station_id == station.id); });

      //load sản phẩm của trạm
      configurationContext.Stations.ForEach(station => { station.Productions = configurationContext.Productions.FindAll(x => x.station_id == station.id); });

      //ShiftTypes --> ca sản xuất
      configurationContext.Stations.ForEach(station => { station.ShiftTypes = configurationContext.ShiftTypes; });

      //Equipments --> thiết bị nẳm trong trạm
      configurationContext.Stations.ForEach(station => { station.Equipments = configurationContext.Equipments.FindAll(x => x.station_id == station.id); });

      //Machines --> các máy có trong trạm
      configurationContext.Stations.ForEach(station => { station.Machines = configurationContext.Machines.FindAll(x => x.station_id == station.id); });

      //



      configurationContext.Close();
    }
  }
}
