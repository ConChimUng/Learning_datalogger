using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model
{
//  CREATE TABLE "Shifts" (
//	"id"	INTEGER UNIQUE,
//	"merchant_code"	TEXT,
//	"delete_flag"	INTEGER,
//	"name"	TEXT,
//	"description"	TEXT,
//	"start_hour"	INTEGER,
//	"end_hour"	INTEGER,
//	"start_minute"	INTEGER,
//	"end_minute"	INTEGER,
//	"hours"	INTEGER,
//	"shift_type_id"	INTEGER,
//	"createdAt"	TEXT,
//	"updatedAt"	TEXT,
//	"createdBy"	INTEGER,
//	"updatedBy"	INTEGER,
//	PRIMARY KEY("id" AUTOINCREMENT)
//);
  public class Shifts: Entity
  {
    #region Models

    public string merchant_code { get; set; }
    public bool delete_flag { get; set; }
    public string name { get; set; }

    public string description { get; set; }

    public int start_hour { get; set; }
    public int end_hour { get; set; }

    public int start_minute { get; set; }
    public int end_minute { get; set; }
    public int hours { get; set; }
    public int shift_type_id { get; set; }

    #endregion
    #region Methods
    private static Shifts Clone(Shifts src)
    {
      Shifts dst = new Shifts()
      {
        id = src.id,
        createdAt = src.createdAt,
        updatedAt = src.updatedAt,
        createdBy = src.createdBy,
        updatedBy = src.updatedBy,
        //--------------------       
        merchant_code = src.merchant_code,
        delete_flag = src.delete_flag,
        name = src.name,
        description = src.description,
        start_hour = src.start_hour,
        end_hour = src.end_hour,
        start_minute = src.start_minute,
        end_minute = src.end_minute,
        hours = src.hours,
        shift_type_id = src.shift_type_id,
      };
      return dst;
    }

    public static List<Shifts> LoadAll(SQLiteConnection db)
    {
      List<Shifts> data = new List<Shifts>();
      try
      {
        data = db.Table<Shifts>().Where(v => v.id > 0).ToList();
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, Shifts src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, Shifts src)
    {
      return (db.Update(src));
    }
    #endregion
  }
}
