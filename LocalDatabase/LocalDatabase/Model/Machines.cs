using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model
{
//  CREATE TABLE "Machines" (
//	"id"	INTEGER,
//	"name"	TEXT,
//	"serial"	TEXT,
//	"location"	TEXT,
//	"station_id"	INTEGER,
//	"unique_key"	INTEGER,
//	"enable"	INTEGER,
//	"createdAt"	TEXT,
//	"updatedAt"	TEXT,
//	"createdBy"	INTEGER,
//	"updatedBy"	INTEGER,
//	PRIMARY KEY("id" AUTOINCREMENT)
//);
  public class Machines:Entity
  {
    #region Models

    public string name { get; set; }
    public string serial { get; set; }
    public string location { get; set; }
    public int station_id { get; set; }
    public int unique_key { get; set; }
    public bool enable { get; set; }
    #endregion
    #region Methods
    private static Machines Clone(Machines src)
    {
      Machines dst = new Machines()
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
        station_id = src.station_id,
        unique_key = src.unique_key,
        enable = src.enable,
      };
      return dst;
    }

    public static List<Machines> LoadAll(SQLiteConnection db)
    {
      List<Machines> data = new List<Machines>();
      try
      {
        data = db.Table<Machines>().Where(v => v.id > 0).ToList();
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, Machines src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, Machines src)
    {
      return (db.Update(src));
    }

    public static int Delete(SQLiteConnection db, Machines src)
    {
      return (db.Delete(src));
    }
    #endregion
  }
}
