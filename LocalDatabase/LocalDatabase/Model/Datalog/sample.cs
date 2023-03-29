using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model.Datalog
{
  public class sample
  {
    #region Models
    [PrimaryKey, AutoIncrement]
    public int id { get; set; }
    public int data_log_id { get; set; }
    public int local_id { get; set; }
    public double value  { get; set; }
    public double previous_value { get; set; }
    public bool isHasValue { get; set; }
    public bool isEnable { get; set; }
    /// <summary>
    /// Đã chỉnh sửa giá trị
    /// </summary>
    public bool isEdited { get; set; }
    public string createdAt { get; set; }
    public string updatedAt { get; set; }
    public int createdBy { get; set; }
    public int updatedBy { get; set; }
    #endregion

    public static List<sample> LoadAll(SQLiteConnection db)
    {
      List<sample> data = new List<sample>();
      try
      {
        data = db.Table<sample>().Where(v => v.id > 0).ToList();
      }
      catch
      {
      }
      return data;
    }
    public static int Insert(SQLiteConnection db, sample src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, sample src)
    {
      return (db.Update(src));
    }
  }
}
