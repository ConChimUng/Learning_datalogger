using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//CREATE TABLE "Commands" (
//	"id"	INTEGER,
//	"name"	TEXT,
//	"description"	TEXT,
//	"createdAt"	TEXT,
//	"updatedAt"	TEXT,
//	"createdBy"	INTEGER,
//	"updatedBy"	INTEGER,
//  PRIMARY KEY("id" AUTOINCREMENT)
//);
namespace LocalDatabase.Model
{
  public class Commands: Entity
  {
    #region Models

    public string name { get; set; }
    public string description { get; set; }
    #endregion
    #region Methods
    private static Commands Clone(Commands src)
    {
      Commands dst = new Commands()
      {
        createdAt = src.createdAt,
        updatedAt = src.updatedAt,
        createdBy = src.createdBy,
        updatedBy = src.updatedBy,

        //--------------------
        id = src.id,
        name = src.name,
        description = src.description,
      };
      return dst;
    }

    public static List<Commands> LoadAll(SQLiteConnection db)
    {
      List<Commands> data = new List<Commands>();
      try
      {
        data = db.Table<Commands>().Where(v => v.id > 0).ToList();
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, Commands src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, Commands src)
    {
      return (db.Update(src));
    }

    public static int Delete(SQLiteConnection db, Commands src)
    {
      return (db.Delete(src));
    }
    #endregion
  }
}
