using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model
{
  public class Departments:Entity
  {
    //    CREATE TABLE "Departments" (
    //	"id"	INTEGER,
    //	"name"	TEXT,
    //	"description"	INTEGER,
    //	"createdAt"	TEXT,
    //	"updatedAt"	TEXT,
    //	"createdBy"	INTEGER,
    //	"updatedBy"	INTEGER,
    //	PRIMARY KEY("id" AUTOINCREMENT)
    //);
    #region Models

    public string name { get; set; }
    public string description { get; set; }
    #endregion
    #region Methods
    private static Departments Clone(Departments src)
    {
      Departments dst = new Departments()
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

    public static List<Departments> LoadAll(SQLiteConnection db)
    {
      List<Departments> data = new List<Departments>();
      try
      {
        data = db.Table<Departments>().Where(v => v.id > 0).ToList();
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, Departments src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, Departments src)
    {
     return (db.Update(src));
    }

    public static int Delete(SQLiteConnection db, Departments src)
    {
      return (db.Delete(src));
    }
    #endregion
  }
}
