using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model
{
//  CREATE TABLE "ShiftTypes" (
//	"id"	INTEGER UNIQUE,
//	"name"	TEXT,
//	"code"	TEXT,
//	PRIMARY KEY("id" AUTOINCREMENT)
//);
  public class ShiftTypes
  {
    #region Models

    [PrimaryKey, AutoIncrement]
    public int id { get; set; }
    public string name { get; set; }
    public string code { get; set; }

    public bool isCurrent { get; set; }
    #endregion

    public List<Shifts> Shifts = new List<Shifts>();
   
    #region Methods
    private static ShiftTypes Clone(ShiftTypes src)
    {
      ShiftTypes dst = new ShiftTypes()
      {
        id = src.id,
        //--------------------       
        name = src.name,
        code = src.code,
      };
      return dst;
    }

    public static List<ShiftTypes> LoadAll(SQLiteConnection db)
    {
      List<ShiftTypes> data = new List<ShiftTypes>();
      try
      {
        data = db.Table<ShiftTypes>().Where(v => v.id > 0).ToList();
        data.ForEach(x=>x.Shifts = Model.Shifts.LoadAll(db).Where(v=>v.shift_type_id == x.id).ToList());
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, ShiftTypes src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, ShiftTypes src)
    {
      return (db.Update(src));
    }


    public Shifts GetCurrentShift()
    {
      int curHour = DateTime.Now.Hour;
      Shifts shift = Shifts.Where(x=>x.start_hour <= curHour && curHour < x.end_hour ).FirstOrDefault();
      shift = (shift != null) ? shift : Shifts.LastOrDefault();
      return shift;
    }
    #endregion
  }
}
