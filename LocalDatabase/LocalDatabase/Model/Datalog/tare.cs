using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model.Datalog
{
  public class tare
  {
    #region Models
    [PrimaryKey, AutoIncrement]
    public int id { get; set; }

    public int station_id { get; set; }

    public int group_id { get; set; }
    public int production_id { get; set; }
    public int shift { get; set; }
    public double value { get; set; }
    /// <summary>
    /// Tare có nhãn hay không nhãn
    /// </summary>
    public bool isWithLabel { get; set; }
    public string createdAt { get; set; }
    public string updatedAt { get; set; }
    public int createdBy { get; set; }
    public int updatedBy { get; set; }

    #endregion

    #region Methods


    public static List<tare> LoadAll(SQLiteConnection db)
    {
      List<tare> data = new List<tare>();
      try
      {
        data = db.Table<tare>().Where(v => v.id > 0 && (v.createdAt != "")).ToList();
        //data.ForEach(x => x.DateTime = Convert.ToDateTime(x.datetime));
      }
      catch
      {
      }
      return data;
    }
    public static int Insert(SQLiteConnection db, tare src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, tare src)
    {
      return (db.Update(src));
    }

    #endregion
  }
}
