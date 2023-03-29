using LocalDatabase.Model.Datalog;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model.Consumption
{
  public class consumption_data
  {
    #region Models
    [PrimaryKey, AutoIncrement]
    public int id { get; set; }
    public int station_id { get; set; }

    public int year { get; set; }
    public int month { get; set; }
    public int weekId { get; set; }
    public int day { get; set; }
    public int shiftId { get; set; }

    public int production_id { get; set; }
    /// <summary>
    /// Tổng mẫu trong ca
    /// </summary>
    public int total_samples { get; set; }
    
    /// <summary>
    /// Tỗng mẫu < lower-limit
    /// </summary>
    public int totalLowerLimit { get; set; }
    /// <summary>
    /// Tỗng mẫu > upper-limit
    /// </summary>
    public int totalUpperLimit { get; set; }

   

    /// <summary>
    /// % mẫu lỗi
    /// </summary>
    public double failsamplesPercent { get; set; }
    /// <summary>
    /// Hao hụt
    /// </summary>
    public double lossPercent { get; set; }
    /// <summary>
    /// Cpk
    /// </summary>
    public double cpk { get; set; }
    /// <summary>
    /// Stdev
    /// </summary>
    public double stdev { get; set; }

    public double avgRaw { get; set; }
    public double avg { get; set; }

    public int evaluate { get; set; }

    public double min_sample { get; set; }
    public double max_sample { get; set; }


    public double spare_1 { get; set; }
    public double spare_2 { get; set; }
    public double spare_3 { get; set; }
    public double spare_4 { get; set; }

    #endregion

    private Productions _production = null;
    private Shifts _shift = null;



    #region Methods

    public void SetProduction(Productions production)
    {
      this._production = production;
    }
    public Productions GetProduction()
    {
      return this._production;
    }
    public void SetShift(Shifts shift)
    {
      this._shift = shift;
    }
    public Shifts GetShift()
    {
      return this._shift;
    }


    public static List<consumption_data> LoadAll(SQLiteConnection db, int station_id)
    {
      List<consumption_data> data = new List<consumption_data>();
      try
      {
        data = db.Table<consumption_data>().Where(v => v.id > 0 && v.station_id == station_id).ToList();
      }
      catch
      {
      }
      return data;
    }

    public static int Insert(SQLiteConnection db, consumption_data src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, consumption_data src)
    {
      return (db.Update(src));
    }

    #endregion
  }

}
