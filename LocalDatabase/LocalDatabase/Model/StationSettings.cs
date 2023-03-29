using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model
{
//  CREATE TABLE "StationSettings" (
//	"id"	INTEGER,
//	"responsibility"	INTEGER,
//	"createdAt"	TEXT,
//	"updatedAt"	TEXT,
//	"createdBy"	INTEGER,
//	"updatedBy"	INTEGER
//);
  public class StationSettings:Entity
  {
    #region Models

    public int station_id { get; set; }
    public int samplesMaximum { get; set; }
    public bool isTareWithOrNoLabel { get; set; }
    public bool is_weigherAutoMode { get; set; }
    public string responsibility { get; set; }
    public string templatePath { get; set; }
    public string databasePath { get; set; }
    public string reportPath { get; set; }

    public int user_active_id { get; set; }
    // public List<SerialControllers> SerialControllers { get; set; }
    #endregion

    private List<SerialControllers> _serialControllers = new List<SerialControllers>();

    private List<Users> _users = new List<Users>();


    #region Methods
    public void SerialControllersSet(List<SerialControllers> serialControllers)
    {
      this._serialControllers = serialControllers;
    }
    public List<SerialControllers> SerialControllersGet()
    {
      return (this._serialControllers);
    }
    public void UsersSet(List<Users> users)
    {
      this._users = users;
    }
    public List<Users> UsersGet()
    {
      return (this._users);
    }
    

    private static StationSettings Clone(StationSettings src)
    {
      StationSettings dst = new StationSettings()
      {
        id = src.id,
        createdAt = src.createdAt,
        updatedAt = src.updatedAt,
        createdBy = src.createdBy,
        updatedBy = src.updatedBy,
        //--------------------       
        station_id = src.station_id,
        responsibility = src.responsibility,
        isTareWithOrNoLabel = src.isTareWithOrNoLabel,
        templatePath = src.templatePath,
        databasePath = src.databasePath,
        reportPath = src.reportPath,
        samplesMaximum = src.samplesMaximum
      };
      return dst;
    }

    public static List<StationSettings> LoadAll(SQLiteConnection db)
    {
      List<StationSettings> data = new List<StationSettings>();
      try
      {
        data = db.Table<StationSettings>().Where(v => v.id > 0).ToList();
        data.ForEach(x => x.SerialControllersSet(Model.SerialControllers.LoadAll(db).Where(v => v.station_id ==x.station_id).ToList()));
        data.ForEach(x => x.UsersSet(Model.Users.LoadAll(db).Where(v => v.station_id == x.station_id).ToList()));
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, StationSettings src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, StationSettings src)
    {
      return (db.Update(src));
    }
    public static int Delete(SQLiteConnection db, StationSettings src)
    {
      return (db.Delete(src));
    }
    #endregion
  }
}
