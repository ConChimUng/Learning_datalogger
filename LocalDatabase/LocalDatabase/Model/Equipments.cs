using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model
{
//  CREATE TABLE "Equipments" (
//	"id"	INTEGER,
//	"name"	TEXT,
//	"serial"	TEXT,
//	"category_id"	INTEGER,
//	"station_id"	INTEGER,
//	"machine_id"	INTEGER,
//	"enable"	INTEGER,
//	"createdAt"	TEXT,
//	"updatedAt"	TEXT,
//	"createdBy"	INTEGER,
//	"updatedBy"	INTEGER,
//	PRIMARY KEY("id" AUTOINCREMENT)
//);
  public class Equipments: Entity
  {
    #region Models

    public string name { get; set; }
    public string serial { get; set; }
    public int category_id { get; set; }
    public int station_id { get; set; }
    public int machine_id { get; set; }
    public bool enable { get; set; }
   

    #endregion
    #region Methods
    private static Equipments Clone(Equipments src)
    {
      Equipments dst = new Equipments()
      {
        id = src.id,
        createdAt = src.createdAt,
        updatedAt = src.updatedAt,
        createdBy = src.createdBy,
        updatedBy = src.updatedBy,

        //--------------------      
        name = src.name,
        serial = src.serial,
        category_id = src.category_id,
        station_id = src.station_id,
        machine_id = src.machine_id,
        enable = src.enable,
      };
      return dst;
    }

    public static List<Equipments> LoadAll(SQLiteConnection db)
    {
      List<Equipments> data = new List<Equipments>();
      try
      {
        data = db.Table<Equipments>().Where(v => v.id > 0).ToList();
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, Equipments src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, Equipments src)
    {
      return (db.Update(src));
    }
    #endregion
  }
}
