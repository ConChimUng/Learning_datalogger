using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model
{
  public class ProductionChangedLoggings: Entity
  {
    #region Models
    public int station_id { get; set; }
    public string datetime { get; set; }
    public string reason { get; set; }

    #endregion
    #region Methods
    public static List<ProductionChangedLoggings> LoadAll(SQLiteConnection db)
    {
      List<ProductionChangedLoggings> data = new List<ProductionChangedLoggings>();
      try
      {
        data = db.Table<ProductionChangedLoggings>().Where(v => v.id > 0).ToList();
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, ProductionChangedLoggings src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, ProductionChangedLoggings src)
    {
      return (db.Update(src));
    }

    public static int Delete(SQLiteConnection db, ProductionChangedLoggings src)
    {
      return (db.Delete(src));
    }
    #endregion
  }
}
