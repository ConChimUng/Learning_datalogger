using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model.Datalog
{
  public class data_log 
  {
    #region Models
    [PrimaryKey, AutoIncrement]
    public int id { get; set; }
    public int station_id { get; set; }

    public string datetime { get; set; }

    public int groupId { get; set; }
    public int shift { get; set; }
    public int stt { get; set; }

    public double AvgRaw { get; set; }
    public double Avg { get; set; }
    public double Standard { get; set; }
    public int Evaluate { get; set; }
    /// <summary>
    /// STDEV
    /// </summary>
    public double Stb { get; set; }
    public double UpperLimit { get; set; }
    public double LowerLimit { get; set; }
    public double S { get; set; }

    public double tare { get; set; }
    public bool isTareWithLabel { get; set; }

    /// <summary>
    /// Tổ trưởng chuyền
    /// </summary>
    public int user_id { get; set; }
    public int production_id { get; set; }




    public double Cp { get; set; }
    public double CpkL { get; set; }
    public double CpkU { get; set; }
    public double Cpk { get; set; }

    public double hight_defects { get; set; }
    public double low_defects { get; set; }
    public double Z_high_defect { get; set; }
    public double Z_low_defect { get; set; }
    public bool Cpk_passed { get; set; }

    /// <summary>
    /// Id của ca sản xuất, lấy từ syngenta-oee
    /// </summary>
    public int operation_id { get; set; }

    public string createdAt { get; set; }
    public string updatedAt { get; set; }
    public int createdBy { get; set; }
    public int updatedBy { get; set; }

    //private DateTime _datetime = DateTime.Now;
    //public DateTime DateTime
    //{
    //  get { return _datetime; }
    //  set { _datetime = value;
    //    this.datetime = value.ToyyyyMMddHHmmss();
    //  }
    //}

    public List<sample> Samples = new List<sample>();
    public List<tare> Tares = new List<tare>();

   
    #endregion

    
    #region Methods
    //private static data_log Clone(data_log src)
    //{
    //  data_log dst = new data_log()
    //  {
    //    id = src.id,
    //    station_id = src.station_id,
    //    shift = src.shift,
    //    stt = src.stt,
    //    Sample_1 = src.Sample_1,
    //    Sample_2 = src.Sample_2,
    //    Sample_3 = src.Sample_3,
    //    Sample_4 = src.Sample_4,
    //    Sample_5 = src.Sample_5,
    //    Sample_6 = src.Sample_6,
    //    Sample_7 = src.Sample_7,
    //    Sample_8 = src.Sample_8,
    //    Avg = src.Avg,
    //    Standard = src.Standard,
    //    Evaluate = src.Evaluate,
    //    Stb = src.Stb,
    //    UpperLimit = src.UpperLimit,
    //    LowerLimit = src.LowerLimit,
    //    S = src.S,
    //    createdAt = src.createdAt,
    //    updatedAt = src.updatedAt,
    //    createdBy = src.createdBy,
    //    updatedBy = src.updatedBy,
    //  };
    //  return dst;
    //}

    public static List<data_log> LoadAll(SQLiteConnection db)
    {
      List<data_log> data = new List<data_log>();
      try
      {
        data = db.Table<data_log>().Where(v => v.id > 0 && (v.datetime != "")).ToList();
        data.ForEach(x => x.Samples = Model.Datalog.sample.LoadAll(db).Where(v=>v.data_log_id == x.id).ToList());
      }
      catch
      {
      }
      return data;
    }

    public static int Insert(SQLiteConnection db, data_log src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, data_log src)
    {
      return (db.Update(src));
    }

    #endregion
  }
}
