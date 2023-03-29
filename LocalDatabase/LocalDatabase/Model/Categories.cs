using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model
{
  public class Categories: Entity
  {
//    CREATE TABLE "Categories" (
//	"id"	INTEGER,
//	"name"	TEXT,
//	"description"	TEXT,
//	"created"	TEXT,
//	"updated"	TEXT,
//	PRIMARY KEY("id" AUTOINCREMENT)
//);
    #region Models
    
    public string name { get; set; }
    public string description { get; set; }
    #endregion
    #region Methods
    private static Categories Clone(Categories src)
    {
      Categories dst = new Categories()
      {
        id = src.id,
        createdAt = src.createdAt,
        updatedAt = src.updatedAt,
        createdBy = src.createdBy,
        updatedBy = src.updatedBy,
        //--------------------       
        name = src.name,
        description = src.description,
      };
      return dst;
    }

    public static List<Categories> LoadAll(SQLiteConnection db)
    {
      List<Categories> data = new List<Categories>();
      try
      {
        data = db.Table<Categories>().Where(v => v.id > 0).ToList();
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, Categories src)
    {
     return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, Categories src)
    {
      return (db.Update(src));
    }

    public static int Delete(SQLiteConnection db, Categories src)
    {
      return (db.Delete(src));
    }
    #endregion

  }



}
