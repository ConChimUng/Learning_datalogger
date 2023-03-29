using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model
{
//  CREATE TABLE "Users" (
//	"id"	INTEGER,
//	"username"	TEXT,
//	"password"	TEXT,
//	"email"	TEXT,
//	"department_id"	INTEGER,
//	"role_id"	INTEGER,
//	"enable"	INTEGER,
//	"createdAt"	TEXT,
//	"updatedAt"	INTEGER,
//	"createdBy"	INTEGER,
//	"updatedBy"	INTEGER,
//	PRIMARY KEY("id" AUTOINCREMENT)
//);
  public class Users:Entity
  {
    #region Models

    public string username { get; set; }
    public string password { get; set; }
    public string email { get; set; }
    public int department_id { get; set; }
    public int station_id { get; set; }
    public int role_id { get; set; }
    public bool enable { get; set; }

    #endregion
    #region Methods
    private static Users Clone(Users src)
    {
      Users dst = new Users()
      {
        id = src.id,
        createdAt = src.createdAt,
        updatedAt = src.updatedAt,
        createdBy = src.createdBy,
        updatedBy = src.updatedBy,
        //--------------------       
        username = src.username,
        password = src.password,
        email = src.email,
        department_id = src.department_id,
        role_id = src.role_id,
        enable = src.enable,
      };
      return dst;
    }

    public static List<Users> LoadAll(SQLiteConnection db)
    {
      List<Users> data = new List<Users>();
      try
      {
        data = db.Table<Users>().Where(v => v.id > 0).ToList();
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, Users src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, Users src)
    {
      return (db.Update(src));
    }

    public static int Delete(SQLiteConnection db, Users src)
    {
      return (db.Delete(src));
    }
    #endregion
  }
}
