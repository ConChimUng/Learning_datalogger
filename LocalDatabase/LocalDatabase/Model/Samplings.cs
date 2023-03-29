using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model
{
//  CREATE TABLE "Samplings" (
//	"id"	INTEGER,
//	"code"	TEXT,
//	"datetimestart"	TEXT,
//	"datetimeend"	TEXT,
//	"createdAt"	TEXT,
//	"updatedAt"	TEXT,
//	"createdBy"	INTEGER,
//	"updatedBy"	INTEGER,
//	PRIMARY KEY("id" AUTOINCREMENT)
//);
  public class Samplings:Entity
  {
    #region Models

    public string code { get; set; }
    public string datetimestart { get; set; }
    public string datetimeend { get; set; }

    private DateTime _datetimestart = DateTime.Now;
    public DateTime DateTimeStart
    {
      get { return this._datetimestart; }
      set
      {
        this._datetimestart = value;
        datetimestart = value.ToyyyyMMddHHmmss();
      }
    }

    private DateTime _datetimeend = DateTime.Now;
    public DateTime DateTimeEnd
    {
      get { return this._datetimeend; }
      set
      {
        this._datetimeend = value;
        datetimeend = value.ToyyyyMMddHHmmss();
      }
    }


    #endregion
    #region Methods
    private static Samplings Clone(Samplings src)
    {
      Samplings dst = new Samplings()
      {
        id = src.id,
        createdAt = src.createdAt,
        updatedAt = src.updatedAt,
        createdBy = src.createdBy,
        updatedBy = src.updatedBy,
        //--------------------       
        code = src.code,
        datetimestart = src.datetimestart,
        datetimeend = src.datetimeend,
      };
      return dst;
    }

    public static List<Samplings> LoadAll(SQLiteConnection db)
    {
      List<Samplings> data = new List<Samplings>();
      try
      {
        data = db.Table<Samplings>().Where(v => v.id > 0 && v.datetimestart != "" && v.datetimeend != "").ToList();
        data.ForEach(x => x.DateTimeStart = Convert.ToDateTime(x.datetimestart));
        data.ForEach(x => x.DateTimeEnd = Convert.ToDateTime(x.datetimeend));
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, Samplings src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, Samplings src)
    {
      return (db.Update(src));
    }

    public static int Delete(SQLiteConnection db, Samplings src)
    {
      return (db.Delete(src));
    }
    #endregion

  }
}
