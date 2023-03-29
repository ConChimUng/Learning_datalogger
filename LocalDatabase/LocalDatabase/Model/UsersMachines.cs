using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model
{
//  CREATE TABLE "UsersMachines" (
//	"id"	INTEGER,
//	"user_id"	INTEGER,
//	"machine_id"	INTEGER,
//	"createdAt"	TEXT,
//	"updatedAt"	TEXT,
//	"createdBy"	INTEGER,
//	"updatedBy"	INTEGER,
//	PRIMARY KEY("id" AUTOINCREMENT)
//);
  public class UsersMachines:Entity
  {
    #region Models

    public string name { get; set; }
    public int user_id { get; set; }
    public int machine_id { get; set; }
    #endregion
    #region Methods
    private static UsersMachines Clone(UsersMachines src)
    {
      UsersMachines dst = new UsersMachines()
      {
        id = src.id,
        createdAt = src.createdAt,
        updatedAt = src.updatedAt,
        createdBy = src.createdBy,
        updatedBy = src.updatedBy,
        //--------------------       
        name = src.name,
        user_id = src.user_id,
        machine_id = src.machine_id,
      };
      return dst;
    }

    public static List<UsersMachines> LoadAll(SQLiteConnection db)
    {
      List<UsersMachines> data = new List<UsersMachines>();
      try
      {
        data = db.Table<UsersMachines>().Where(v => v.id > 0).ToList();
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, UsersMachines src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, UsersMachines src)
    {
      return (db.Update(src));
    }

    public static int Delete(SQLiteConnection db, UsersMachines src)
    {
      return (db.Delete(src));
    }
    #endregion
  }
}
