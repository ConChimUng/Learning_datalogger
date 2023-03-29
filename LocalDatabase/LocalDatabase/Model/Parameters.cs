using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model
{
//  CREATE TABLE "Parameters" (
//	"id"	INTEGER,
//	"name"	TEXT,
//	"serial"	TEXT,
//	"description"	TEXT,
//	"paramLocalId"	INTEGER,
//	"value"	REAL,
//	"upperlimit"	REAL,
//	"lowerlimit"	REAL,
//	"standard"	REAL,
//	"unit"	TEXT,
//	"equipment_id"	INTEGER,
//	"enable"	INTEGER,
//	"created"	TEXT,
//	"updated"	TEXT,
//	PRIMARY KEY("id" AUTOINCREMENT)
//);
  public class Parameters:Entity
  {
    #region Models

    public string name { get; set; }
    public string serial { get; set; }
    public string description { get; set; }
    public int paramLocalId { get; set; }
    public double value { get; set; }
    public double upperlimit { get; set; }
    public double lowerlimit { get; set; }
    public double standard { get; set; }
    public string unit { get; set; }
    public int equipment_id { get; set; }
    public bool enable { get; set; }
    #endregion
    #region Methods
    private static Parameters Clone(Parameters src)
    {
      Parameters dst = new Parameters()
      {
        id = src.id,
        createdAt = src.createdAt,
        updatedAt = src.updatedAt,
        createdBy = src.createdBy,
        updatedBy = src.updatedBy,
        //--------------------       
        name = src.name,
        serial = src.serial,
        description = src.description,
        paramLocalId = src.paramLocalId,
        value = src.value,
        upperlimit = src.upperlimit,
        lowerlimit = src.lowerlimit,
        standard = src.standard,
        unit = src.unit,
        equipment_id = src.equipment_id,
        enable = src.enable,


      };
      return dst;
    }

    public static List<Parameters> LoadAll(SQLiteConnection db)
    {
      List<Parameters> data = new List<Parameters>();
      try
      {
        data = db.Table<Parameters>().Where(v => v.id > 0).ToList();
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, Parameters src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, Parameters src)
    {
      return (db.Update(src));
    }

    public static int Delete(SQLiteConnection db, Parameters src)
    {
      return (db.Delete(src));
    }
    #endregion

  }
}
