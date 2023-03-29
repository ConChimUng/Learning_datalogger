using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model
{
//  CREATE TABLE "Protocols" (
//	"id"	INTEGER,
//	"name"	INTEGER,
//	"description"	INTEGER,
//	"createdAt"	TEXT,
//	"updatedAt"	TEXT,
//	"createdBy"	INTEGER,
//	"updatedBy"	INTEGER,
//	PRIMARY KEY("id" AUTOINCREMENT)
//);
  public class Protocols:Entity
  {
    #region Models

    public string name { get; set; }
    public string description { get; set; }
    #endregion
    #region Methods
    private static Protocols Clone(Protocols src)
    {
      Protocols dst = new Protocols()
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

    public static List<Protocols> LoadAll(SQLiteConnection db)
    {
      List<Protocols> data = new List<Protocols>();
      try
      {
        data = db.Table<Protocols>().Where(v => v.id > 0).ToList();
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, Protocols src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, Protocols src)
    {
      return (db.Update(src));
    }
    public static int Delete(SQLiteConnection db, Protocols src)
    {
      return (db.Delete(src));
    }
    #endregion

  }
}
