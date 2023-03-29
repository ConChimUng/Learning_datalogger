using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static DataLogger.Form1;
using LocalDatabase;
using LocalDatabase.Model;

namespace DataLogger
{
  public partial class Form1 : Form
  {
    public Form CurrentForm;
    private const string dbName = "LoggerConfiguration.s3db";
    /// <summary>
    /// Db chia làm 2:
    /// 1. Configuration (SqliteConfigurationContext)--> cấu hình phần mềm, hệ thống
    /// 2. Datalogger (SqliteDataLogContext) --> lưu data log theo ngày
    /// </summary>
     
    public enum AppModulSupport
    {
      Datalogger_Dashboard,
      Datalogger_Historical,
      Datalogger_Statics,
      Datalogger_Setting,
      Datalogger_Account,
      Datalogger_Information,
    }
    public Form1()
    {
      InitializeComponent();
      this.Load += Form1_Load;
    }

    

    public void OpenChildForm(AppModulSupport modulSupport, Form ChildForm)
    {
      bool Is_same_form = false;
      if (this.panelDesktopMain.Tag != null)
      {
        if (this.panelDesktopMain.Tag is Tuple<AppModulSupport, Form>)
        {
          Tuple<AppModulSupport, Form> TagAsForm = (Tuple<AppModulSupport, Form>)(this.panelDesktopMain.Tag);
          if (TagAsForm.Item1 == modulSupport)
          {
            Is_same_form = true;
          }

        }
      }
      if (Is_same_form == false)
      {
        if (CurrentForm != null)
        {
          CurrentForm.Visible = false;

        }
        this.panelDesktopMain.Tag = Tuple.Create(modulSupport, ChildForm);
        CurrentForm = ChildForm;
        ChildForm.TopLevel = false;
        ChildForm.FormBorderStyle = FormBorderStyle.None;
        ChildForm.Dock = DockStyle.Fill;
        ChildForm.BringToFront();
        this.panelDesktopMain.Controls.Add(ChildForm);
        ChildForm.Show();
      }
      else
      {
        //do not 
      }
    }
    private string getFileDb()
    {
      string configPath = Path.Combine(Application.StartupPath, dbName);
      return configPath;
    }
    public void MapDatabase()
    {
      SqliteConfigurationContext configContext = new SqliteConfigurationContext(getFileDb());
      //var factory = configContext.Factories;
      //var station = configContext.Stations;
      //var equitment = configContext.Equipments;


      // mapping factory to station
      configContext.Factories.ForEach(factories => { factories.Stations = configContext.Stations.FindAll(x => x.factory_id == factories.id); });


      // mapping station to stationSetting
      configContext.Stations.ForEach(stations => { stations.stationSetting = configContext.StationSettings.Find(x => x.station_id == stations.id); });
      // mapping station to equitment
      configContext.Stations.ForEach(stations => { stations.Equipments = configContext.Equipments.FindAll(x => x.station_id == stations.id); });
      // mapping station to production
      configContext.Stations.ForEach(stations => { stations.Productions = configContext.Productions.FindAll(x => x.station_id == stations.id); });
      // mapping station to machines
      configContext.Stations.ForEach(Stations => { Stations.Machines = configContext.Machines.FindAll(x => x.station_id == Stations.id); });

      // mapping machine to equipment
      configContext.Machines.ForEach(machines => {configContext.Equipments = configContext.Equipments.FindAll(x => x.machine_id == machines.id); });

      // mapping equipment to equipmentLog
      configContext.Equipments.ForEach(equipment => { configContext.EquipmentLogs = configContext.EquipmentLogs.FindAll(x=>x.equipment_id == equipment.id); });

      
      
      //foreach (Productions productions in configContext.Productions)
      //{
      //  Console.WriteLine($"stationId{productions.station_id}, Name: {productions.name}");

      //}
      //foreach (Stations stations1 in configContext.Stations)
      //{
      //  Console.WriteLine($"stationId:{stations1.id}, Name: {stations1.name}");


      //}

    }
    private void btDashboard_Click(object sender, EventArgs e)
    {
      OpenChildForm(AppModulSupport.Datalogger_Dashboard, DataLogger.DashboardViews.FormDashboard.Instance);

    }

    private void btHistorical_Click(object sender, EventArgs e)
    {
      OpenChildForm(AppModulSupport.Datalogger_Historical, DataLogger.HistoricalViews.FormHistical.Instance);
    }

    private void btStatics_Click(object sender, EventArgs e)
    {
      OpenChildForm(AppModulSupport.Datalogger_Statics, DataLogger.StaticViews.FormStatic.Instance);
    }

    private void btSetting_Click(object sender, EventArgs e)
    {
      OpenChildForm(AppModulSupport.Datalogger_Setting, DataLogger.SettingViews.FormSetting.Instance);
    }

    private void btInformation_Click(object sender, EventArgs e)
    {
      OpenChildForm(AppModulSupport.Datalogger_Information, DataLogger.InformationViews.FormInformation.Instance);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      MapDatabase();
    }
  }
}
