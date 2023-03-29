using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model
{
//  CREATE TABLE "ParameterLogs" (
//	"id"	INTEGER,
//	"code"	TEXT,
//	"datetime"	TEXT,
//	"value"	REAL,
//	"parameter_id"	INTEGER,
//	"sampling_id"	INTEGER,
//	"created"	TEXT,
//	"updated"	TEXT,
//	PRIMARY KEY("id" AUTOINCREMENT)
//);
  public class ParameterLogs:Entity
  {
    #region Models

    public string code { get; set; }
    public string datetime { get; set; }
    public double value { get; set; }
    public int parameter_id { get; set; }
    public int sampling_id { get; set; }

    private DateTime _datetime = DateTime.Now;
    public DateTime DateTime
    {
      get { return _datetime; }
      set
      {
        _datetime = value;
        datetime = value.ToyyyyMMddHHmmss();
      }
    }
    #endregion
    #region Methods
    private static ParameterLogs Clone(ParameterLogs src)
    {
      ParameterLogs dst = new ParameterLogs()
      {
        id = src.id,
        createdAt = src.createdAt,
        updatedAt = src.updatedAt,
        createdBy = src.createdBy,
        updatedBy = src.updatedBy,
        //--------------------       
        code = src.code,
        datetime = src.datetime,
        sampling_id = src.sampling_id,
        parameter_id = src.parameter_id,

      };
      return dst;
    }

    public static List<ParameterLogs> LoadAll(SQLiteConnection db)
    {
      List<ParameterLogs> data = new List<ParameterLogs>();
      try
      {
        data = db.Table<ParameterLogs>().Where(v => v.id > 0 && v.datetime != "").ToList();
        data.ForEach(x => x.DateTime = x.datetime != "" ? Convert.ToDateTime(x.datetime) : DateTime.MinValue);
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, ParameterLogs src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, ParameterLogs src)
    {
      return (db.Update(src));
    }

    public static int Delete(SQLiteConnection db, ParameterLogs src)
    {
      return (db.Delete(src));
    }
    #endregion
  }
}
