using LocalDatabase.Model.Consumption;
using LocalDatabase.Model.Datalog;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
namespace LocalDatabase.Model
{
//  CREATE TABLE "Stations" (
//	"id"	INTEGER,
//	"name"	TEXT,
//	"serial"	TEXT,
//	"location"	TEXT,
//	"factory_id"	INTEGER,
//	"unique_key"	INTEGER,
//	"enable"	INTEGER,
//	"createdAt"	TEXT,
//	"updatedAt"	TEXT,
//	"createdBy"	INTEGER,
//	"updatedBy"	INTEGER,
//	PRIMARY KEY("id" AUTOINCREMENT)
//);
  public class Stations:Entity
  {
    #region Models

    public string name { get; set; }
    public string serial { get; set; }
    public string location { get; set; }
    public int factory_id { get; set; }
    public int unique_key { get; set; }
    public bool enable { get; set; }
    public bool is_active { get; set; }

    

    public StationSettings stationSetting = null;
    public List<LocalDatabase.Model.ShiftTypes> ShiftTypes = new List<LocalDatabase.Model.ShiftTypes>();
    public List<LocalDatabase.Model.Productions> Productions = new List<LocalDatabase.Model.Productions>();
    public List<LocalDatabase.Model.Equipments> Equipments = new List<LocalDatabase.Model.Equipments>();
    public List<LocalDatabase.Model.Machines> Machines = new List<LocalDatabase.Model.Machines>();




    /// <summary>
    /// ghi nhận lý do đổi thông số sp
    /// </summary>
    public List<ProductionChangedLoggings> ProductionChangedLoggings = new List<ProductionChangedLoggings>();

    /// <summary>
    /// Tổng hợp báo cáo của trạm
    /// </summary>
    public List<consumption_data> Consumptions = new List<consumption_data>();


    private List<Extra.SeriesColors> _seriesColors = new List<Extra.SeriesColors>();

    /// <summary>
    /// Giá trị cân trong ngày
    /// </summary>
    public List<data_log> DataLogs = new List<data_log>();


    /// <summary>
    /// Giá trị Tare trong ngày
    /// </summary>
    public List<tare> Tares = new List<tare>();


    public List<Roles> UserAndRoles = new List<Roles>();









    private int _tare_groupId = 0;
    private int _samples_groupId = 0;


    private Roles _current_role = null;
    private Users _current_user = null;



    #endregion
    #region Methods

    public List<Extra.SeriesColors> SeriesColorsGet()
    {
      return _seriesColors;
    }
    public void SeriesColorsSet(List<Extra.SeriesColors> seriesColors)
    {
      this._seriesColors = seriesColors;
    }

    public Users CurrentUserGet()
    {
      return _current_user;
    }
    public int CurrentUserGetId()
    {
      int id = 0;
      if (_current_user != null)
      {
        id = _current_user.id;
      }
      return id;
    }

    public void CurrentUserSet(Users user)
    {
      this._current_user = user;
    }



    public Roles CurrentRoleGet()
    {
      if (_current_role == null)
      {
        _current_role = (UserAndRoles.Find(x => ((Roles.eUserRole)(x.id)) == Roles.eUserRole.OP));
      }
      return _current_role;
    }
    public void CurrentRoleSet(Roles user)
    {
      _current_role = user;
    }


    public int TareGroupGet()
    {
      return _tare_groupId;
    }
    public void TareGroupSet(int value)
    {
      this._tare_groupId = value;
    }


    public int SamplesGroupGet()
    {
      return _samples_groupId;
    }
    public void SamplesGroupSet(int value)
    {
      this._samples_groupId = value;
    }



    public static Stations Clone(Stations src)
    {
      Stations dst = new Stations()
      {
        id = src.id,
        createdAt = src.createdAt,
        updatedAt = src.updatedAt,
        createdBy = src.createdBy,
        updatedBy = src.updatedBy,
        //--------------------       
        name = src.name,
        serial = src.serial,
        location = src.location,
        factory_id = src.factory_id,
        unique_key = src.unique_key,
        enable = src.enable,
        is_active = src.is_active,       
      };
      return dst;
    }

    public static List<Stations> LoadAll(SQLiteConnection db)
    {
      List<Stations> data = new List<Stations>();
      try
      {
        data = db.Table<Stations>().Where(v => v.id > 0).ToList();
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, Stations src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, Stations src)
    {
      return (db.Update(src));
    }
    public static int Delete(SQLiteConnection db, Stations src)
    {
      return (db.Delete(src));
    }

    public Shifts GetShift(int shiftId)
    {
      Shifts shift = null;
      for (int i = 0; (i < ShiftTypes.Count) && (shift == null); i++)
      {
        shift = ShiftTypes[i].Shifts.Find(x => x.id == shiftId);
      }
      return shift;
    }

    public string GetShiftName(int shiftId)
    {
      string ret = "";
      Shifts shift = GetShift(shiftId);
      ret = (shift != null)? shift.name: ret;
      return ret;
    }


    

   
    /// <summary>
    /// Tính trung bình giá trị đo
    /// </summary>
    //public double SumAvgByStt()
    //{
    //  double ret = 0;
    //  if (DataLogs.Count > 0)
    //  {
    //    ret = DataLogs.Select(x => x.AvgRaw).Average();
    //  }
    //  return ret;
    //}

    //public double SumAvgTotalSamples()
    //{
    //  double ret = 0;
    //  if (DataLogs.Count > 0)
    //  {
    //    ret = DataLogs.SelectMany(x => x.Samples).Where(x => x.isHasValue).Select(y => y.value).Average();
    //  }
    //  return ret;
    //}

    //public double StdevTotalSamples()
    //{
    //  double ret = 0;
    //  if (DataLogs.Count > 0)
    //  {
    //    List<sample> tmp1 = DataLogs.SelectMany(x => x.Samples).ToList().Where(m => m.isHasValue == true).ToList().Select(x => x.value).StandardDeviation();
    //    double stb = tmp1.Select(x => x.value).StandardDeviation();

    //    ret = DataLogs.SelectMany(x => x.Samples).Where(x => x.isHasValue).Select(y => y.value).Average();
    //  }
    //  return ret;
    //}


    #endregion
  }
}
