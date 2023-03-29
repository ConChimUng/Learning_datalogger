using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model
{
//  CREATE TABLE "EquipmentLogs" (
//	"id"	INTEGER,
//	"datetime"	TEXT,
//	"value"	REAL,
//	"equipment_id"	INTEGER,
//	"sampling_id"	INTEGER,
//	"createdAt"	TEXT,
//	"updatedAt"	TEXT,
//	"createdBy"	INTEGER,
//	"updatedBy"	INTEGER,
//	PRIMARY KEY("id" AUTOINCREMENT)
//);
  public class EquipmentLogs: Entity
  {
    #region Models

    public string datetime { get; set; }
    public double value { get; set; }
    public int equipment_id { get; set; }
    public int sampling_id { get; set; }

    private DateTime _datetime = DateTime.Now;
    public DateTime DateTime
    {
      get { return _datetime; }
      set { _datetime = value;
        datetime = value.ToyyyyMMddHHmmss();
            }
    }
    #endregion
    #region Methods
    private static EquipmentLogs Clone(EquipmentLogs src)
    {
      EquipmentLogs dst = new EquipmentLogs()
      {
        createdAt = src.createdAt,
        updatedAt = src.updatedAt,
        createdBy = src.createdBy,
        updatedBy = src.updatedBy,

        //--------------------
        id = src.id,
        datetime = src.datetime,
        value = src.value,
        equipment_id = src.equipment_id,
        sampling_id = src.sampling_id,
      };
      return dst;
    }

    public static List<EquipmentLogs> LoadAll(SQLiteConnection db)
    {
      List<EquipmentLogs> data = new List<EquipmentLogs>();
      try
      {
        data = db.Table<EquipmentLogs>().Where(v => v.id > 0 && v.datetime != "").ToList();
        data.ForEach(x => x.DateTime = x.datetime != ""? Convert.ToDateTime(x.datetime):DateTime.MinValue);
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, EquipmentLogs src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, EquipmentLogs src)
    {
      return (db.Update(src));
    }

    public static int Delete(SQLiteConnection db, EquipmentLogs src)
    {
      return (db.Delete(src));
    }
    #endregion
  }
}
