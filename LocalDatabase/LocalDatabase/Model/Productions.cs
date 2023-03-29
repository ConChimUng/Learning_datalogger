using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace LocalDatabase.Model
{
//  CREATE TABLE "Productions" (
//	"id"	INTEGER UNIQUE,
//	"station_id"	INTEGER,
//	"name"	TEXT,
//	"code"	TEXT,
//	"upperlimit"	REAL,
//	"standard"	REAL,
//	"lowerlimit"	REAL,
//	"createdAt"	TEXT,
//	"updatedAt"	TEXT,
//	"createdBy"	INTEGER,
//	"updatedBy"	INTEGER,
//	PRIMARY KEY("id" AUTOINCREMENT)
//);
  public class Productions: Entity
  {
    #region Models
    public int station_id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    /// <summary>
    /// Mã sản phẩm
    /// </summary>
    public string serial { get; set; }
    /// <summary>
    /// Dây chuyền
    /// </summary>
    public string linename { get; set; }
    /// <summary>
    /// Số chai
    /// </summary>
    public int bottles { get; set; }
    /// <summary>
    /// Tỹ trọng
    /// </summary>
    public double density { get; set; }
   /// <summary>
   /// Dung tich chai
   /// </summary>
    public double packsize { get; set; }
    /// <summary>
    /// Dung tích chai - Giới hạn dưới
    /// </summary>
    public double packsize_lowerlimit { get; set; }
    /// <summary>
    /// Dung tích chai - Giới hạn trên
    /// </summary>
    public double packsize_upperlimit { get; set; }




    /// <summary>
    /// Loại chai
    /// </summary>
    public string bottle_type { get; set; }

    /// <summary>
    /// Sai số cho phép
    /// </summary>
    public int diff { get; set; }

    /// <summary>
    /// Trọng lượng chai cận dưới
    /// </summary>
    public double bottle_lowerlimit { get; set; }
    /// <summary>
    /// Trọng lượng chai cận trên
    /// </summary>
    public double bottle_upperlimit { get; set; }
    /// <summary>
    /// Trọng lượng chai chuẩn
    /// </summary>
    public double bottle_standard { get; set; }

    /// <summary>
    /// loại nắp
    /// </summary>
    public string capper_type { get; set; }
    /// <summary>
    /// trọng lượng nắp
    /// </summary>
    public double capper_standard { get; set; }

    /// <summary>
    /// loại nhãn
    /// </summary>
    public string label_type { get; set; }
    /// <summary>
    /// trọng lượng nhãn
    /// </summary>
    public double label_standard { get; set; }

    public double tare_no_label_lowerlimit { get; set; }
    public double tare_no_label_upperlimit { get; set; }
    public double tare_no_label_standard { get; set; }



   

    //public double tareWithLabelTotalSampels { get; set; }
    public double tare_with_label_standard { get; set; }
    public double tare_with_label_upperlimit { get; set; }
    public double tare_with_label_lowerlimit { get; set; }
    /// <summary>
    /// Khối lượng thuốc cận trên
    /// </summary>
    public double upperlimit { get; set; }
    public double lowerlimit { get; set; }
    public double standard { get; set; }


    public int fillerMax { get; set; }
   /// <summary>
   /// Tần suất cân
   /// </summary>
    public string minutes_to_weight { get; set; }
    /// <summary>
    /// Số lần cân trong ca
    /// </summary>
    public int weight_maximum_per_shift { get; set; }
    public bool enable { get; set; }
    public bool isCurrentProd { get; set; }

    public double currentTareValue { get; set; }
    public string currentTareAt { get; set; }
    #endregion


    private eAction _action = eAction.Donothing;

    private int _backcolor_id = 0;
    private int _forecolor_id = 0;

    private Extra.SeriesColors _seriesColor = null;
    #region Methods
    public void SetSeriesColor(Extra.SeriesColors sericolor)
    {
      this._seriesColor = sericolor;
    }
    
    public Extra.SeriesColors GetSeriesColor()
    {
      return this._seriesColor;
    }


    public void SetBackColorId(int colorId)
    {
      this._backcolor_id = colorId;
    }
    public int GetBackColorId()
    {
      return this._backcolor_id;
    }

    public void SetForeColorId(int colorId)
    {
      this._forecolor_id = colorId;
    }
    public int GetForeColorId()
    {
      return this._forecolor_id;
    }


    public void SetAction(eAction action)
    {
      this._action = action;
    }
    public eAction GetAction()
    {
      return this._action;
    }


    public static Productions Clone(Productions src)
    {
      Productions dst = new Productions()
      {
        id = src.id,
        createdAt = src.createdAt,
        updatedAt = src.updatedAt,
        createdBy = src.createdBy,
        updatedBy = src.updatedBy,
        //--------------------
        station_id = src.station_id,
        name = src.name,
        description = src.description,
        serial = src.serial,
        linename = src.linename,
        bottles = src.bottles,
        density = src.density,
        packsize = src.packsize,

        packsize_lowerlimit = src.packsize_lowerlimit,
        packsize_upperlimit = src.packsize_upperlimit,
        bottle_type = src.bottle_type,
        diff = src.diff,
        bottle_lowerlimit = src.bottle_lowerlimit,
        bottle_upperlimit = src.bottle_upperlimit,
        bottle_standard = src.bottle_standard,

        capper_type = src.capper_type,
        capper_standard = src.capper_standard,
        label_type = src.label_type,
        label_standard = src.label_standard,
        tare_no_label_lowerlimit = src.tare_no_label_lowerlimit,
        tare_no_label_upperlimit = src.tare_no_label_upperlimit,
        tare_no_label_standard = src.tare_no_label_standard,
        tare_with_label_standard = src.tare_with_label_standard,
        tare_with_label_upperlimit = src.tare_with_label_upperlimit,
        tare_with_label_lowerlimit = src.tare_with_label_lowerlimit,

        upperlimit = src.upperlimit,
        lowerlimit = src.lowerlimit,
        standard = src.standard,
        fillerMax = src.fillerMax,
        minutes_to_weight = src.minutes_to_weight,

        weight_maximum_per_shift = src.weight_maximum_per_shift,
        enable = src.enable,

        isCurrentProd = src.isCurrentProd,
        currentTareValue = src.currentTareValue,
        currentTareAt = src.currentTareAt,


      };
      return dst;
    }

    public static List<Productions> LoadAll(SQLiteConnection db)
    {
      List<Productions> data = new List<Productions>();
      try
      {
        data = db.Table<Productions>().Where(v => v.id > 0).ToList();
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, Productions src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, Productions src)
    {
      return (db.Update(src));
    }

    public static int Delete(SQLiteConnection db, Productions src)
    {
      return (db.Delete(src));
    }
    #endregion
  }
}
