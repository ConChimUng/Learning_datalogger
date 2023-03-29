using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model
{
//  CREATE TABLE "Roles" (
//	"id"	INTEGER,
//	"name"	TEXT,
//	"description"	TEXT,
//	"permission"	INTEGER,
//	"createdAt"	TEXT,
//	"updatedAt"	TEXT,
//	"createdBy"	INTEGER,
//	"updatedBy"	INTEGER,
//	PRIMARY KEY("id" AUTOINCREMENT)
//);
  public class Roles:Entity
  {
    #region Models

    public string name { get; set; }
    public string description { get; set; }
    public int permission { get; set; }
    public string passwords { get; set; }
    public bool enable { get; set; }
    
    #endregion
    #region Methods
    private static Roles Clone(Roles src)
    {
      Roles dst = new Roles()
      {
        id = src.id,
        createdAt = src.createdAt,
        updatedAt = src.updatedAt,
        createdBy = src.createdBy,
        updatedBy = src.updatedBy,
        //--------------------       
        name = src.name,
        description = src.description,
        permission = src.permission,
      };
      return dst;
    }

    public static List<Roles> LoadAll(SQLiteConnection db)
    {
      List<Roles> data = new List<Roles>();
      try
      {
        data = db.Table<Roles>().Where(v => v.id > 0).ToList();
        for(int i = 0; i < data.Count; i++)
        {
          data[i].SetPermission(ePermission.EnableProductionEditAndSetup, ((data[i].permission & (int)ePermission.EnableProductionEditAndSetup) == (int)ePermission.EnableProductionEditAndSetup));
          data[i].SetPermission(ePermission.EnableShiftTypeSetup, ((data[i].permission & (int)ePermission.EnableShiftTypeSetup) == (int)ePermission.EnableShiftTypeSetup));
          data[i].SetPermission(ePermission.EnableRolesSetup, ((data[i].permission & (int)ePermission.EnableRolesSetup) == (int)ePermission.EnableRolesSetup));
          data[i].SetPermission(ePermission.EnableStationChanged, ((data[i].permission & (int)ePermission.EnableStationChanged) == (int)ePermission.EnableStationChanged));
          data[i].SetPermission(ePermission.EnableMaxSamplesChanged, ((data[i].permission & (int)ePermission.EnableMaxSamplesChanged) == (int)ePermission.EnableMaxSamplesChanged));
          data[i].SetPermission(ePermission.EnableConsumptionsPage, ((data[i].permission & (int)ePermission.EnableConsumptionsPage) == (int)ePermission.EnableConsumptionsPage));
          data[i].SetPermission(ePermission.EnableExportExcelPage, ((data[i].permission & (int)ePermission.EnableExportExcelPage) == (int)ePermission.EnableExportExcelPage));
          data[i].SetPermission(ePermission.EnableSettingsPage, ((data[i].permission & (int)ePermission.EnableSettingsPage) == (int)ePermission.EnableSettingsPage));
        }
        int mm = 0;
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, Roles src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, Roles src)
    {
      return (db.Update(src));
    }

    public static int Delete(SQLiteConnection db, Roles src)
    {
      return (db.Delete(src));
    }
    #endregion
    public enum eUserRole
    {
      /// <summary>
      /// Nhân viên kiểm soát chất lượng
      /// </summary>
      QC = 1,
      /// <summary>
      /// Nhân viên cơ điện
      /// </summary>
      ME = 2,
      /// <summary>
      ///Trưởng ca
      /// </summary>
      ShiftLeader = 3,
      /// <summary>
      /// Công nhân vận hành
      /// </summary>
      OP = 4,
      /// <summary>
      /// Administrator
      /// </summary>
      Admin = 5,
    }

    public enum ePermission
    {
      /// <summary>
      /// cho phép chính sủa sản phẩm
      /// </summary>
      EnableProductionEditAndSetup = 0x01,

      /// <summary>
      /// cho phép đổi giờ loại ca
      /// </summary>
      EnableShiftTypeSetup = 0x02,

      /// <summary>
      /// Cho phép cài đặt phân quyền
      /// </summary>
      EnableRolesSetup = 0x04,
        /// <summary>
        /// Cho phép thay đổi dây chuyền
        /// </summary>
      EnableStationChanged = 0x08,
      /// <summary>
      /// cho phép thay đổi giá trị tối đa
      /// </summary>
      EnableMaxSamplesChanged = 0x10,
      /// <summary>
      /// cho phép try cập trang tổng hợp
      /// </summary>
      EnableConsumptionsPage = 0x20,
      /// <summary>
      /// cho phép try cập trang báo cáo excel
      /// </summary>
      EnableExportExcelPage = 0x40,
      /// <summary>
      /// cho phép try cập trang cài đặt
      /// </summary>
      EnableSettingsPage = 0x80,


    }

    private bool _isEnableProductionEditAndSetup = false;
    private bool _isEnableShiftTypeSetup = false;
    private bool _isEnableRolesSetup = false;
    private bool _isEnableStationChanged = false;
    private bool _isEnableMaxSamplesChanged = false;
    private bool _isEnableConsumptionsPage = false;
    private bool _isEnableExportExcelPage = false;
    private bool _isEnableSettingsPage = false;
    /// <summary>
    /// Cho phép chỉnh sửa, cài đặt sản phẩm
    /// </summary>
    public void SetPermission(ePermission ePermission, bool value)
    {
      if (ePermission == ePermission.EnableProductionEditAndSetup)
      {
        this._isEnableProductionEditAndSetup = value;
      }
      else if (ePermission == ePermission.EnableShiftTypeSetup)
      {
        this._isEnableShiftTypeSetup = value;
      }
      else if (ePermission == ePermission.EnableRolesSetup)
      {
        this._isEnableRolesSetup = value;
      }
      else if (ePermission == ePermission.EnableStationChanged)
      {
        this._isEnableStationChanged = value;
      }
      else if (ePermission == ePermission.EnableMaxSamplesChanged)
      {
        this._isEnableMaxSamplesChanged = value;
      }
      else if (ePermission == ePermission.EnableConsumptionsPage)
      {
        this._isEnableConsumptionsPage = value;
      }
      else if (ePermission == ePermission.EnableExportExcelPage)
      {
        this._isEnableExportExcelPage = value;
      }
      else if (ePermission == ePermission.EnableSettingsPage)
      {
        this._isEnableSettingsPage = value;
      }
    }
    public bool GetPermission(ePermission ePermission)
    {
      bool result = false;
      if (ePermission == ePermission.EnableProductionEditAndSetup)
      {
        result = this._isEnableProductionEditAndSetup;
      }
      else if (ePermission == ePermission.EnableShiftTypeSetup)
      {
        result = this._isEnableShiftTypeSetup;
      }
      else if (ePermission == ePermission.EnableRolesSetup)
      {
        result = this._isEnableRolesSetup;
      }
      else if (ePermission == ePermission.EnableStationChanged)
      {
        result = this._isEnableStationChanged;
      }
      else if (ePermission == ePermission.EnableMaxSamplesChanged)
      {
        result = this._isEnableMaxSamplesChanged;
      }
      else if (ePermission == ePermission.EnableConsumptionsPage)
      {
        result = this._isEnableConsumptionsPage;
      }
      else if (ePermission == ePermission.EnableExportExcelPage)
      {
        result = this._isEnableExportExcelPage;
      }
      else if (ePermission == ePermission.EnableSettingsPage)
      {
        result = this._isEnableSettingsPage;
      }
      return result;
    }

     

    
  }
}
