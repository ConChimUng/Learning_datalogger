using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model
{
//  CREATE TABLE "UsersStations" (
//	"id"	INTEGER,
//	"user_id"	INTEGER,
//	"station_id"	INTEGER,
//	"createdAt"	TEXT,
//	"updatedAt"	TEXT,
//	"createdBy"	INTEGER,
//	"updatedBy"	INTEGER,
//	PRIMARY KEY("id" AUTOINCREMENT)
//);
  public class UsersStations:Entity
  {
    #region Models

    public string name { get; set; }
    public int user_id { get; set; }
    public int station_id { get; set; }
    
    #endregion
    #region Methods
    private static UsersStations Clone(UsersStations src)
    {
      UsersStations dst = new UsersStations()
      {
        id = src.id,
        createdAt = src.createdAt,
        updatedAt = src.updatedAt,
        createdBy = src.createdBy,
        updatedBy = src.updatedBy,
        //--------------------       
        name = src.name,
        user_id = src.user_id,
        station_id = src.station_id,
      };
      return dst;
    }

    public static List<UsersStations> LoadAll(SQLiteConnection db)
    {
      List<UsersStations> data = new List<UsersStations>();
      try
      {
        data = db.Table<UsersStations>().Where(v => v.id > 0).ToList();
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, UsersStations src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, UsersStations src)
    {
      return (db.Update(src));
    }
    public static int Delete(SQLiteConnection db, UsersStations src)
    {
      return (db.Delete(src));
    }
    #endregion
  }
}
