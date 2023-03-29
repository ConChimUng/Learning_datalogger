using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model
{
//  CREATE TABLE "Factories" (
//	"id"	INTEGER NOT NULL,
//	"name"	TEXT,
//	"serial"	TEXT,
//	"location"	TEXT,
//	"parent_id"	INTEGER,
//	"createdAt"	TEXT,
//	"updatedAt"	TEXT,
//	"createdBy"	INTEGER,
//	"updatedBy"	INTEGER,
//	PRIMARY KEY("id" AUTOINCREMENT)
//);
  public class Factories:Entity
  {
    #region Models

    public string name { get; set; }
    public string serial { get; set; }
    public string location { get; set; }
    public int parent_id { get; set; }
    #endregion
    #region Methods
    private static Factories Clone(Factories src)
    {
      Factories dst = new Factories()
      {
        id = src.id,
        createdAt = src.createdAt,
        updatedAt = src.updatedAt,
        createdBy = src.createdBy,
        updatedBy = src.updatedBy,
        //--------------------       
        name = src.name,
        serial = src.serial,
        location = src.location,
        parent_id = src.parent_id,
      };
      return dst;
    }

    public static List<Factories> LoadAll(SQLiteConnection db)
    {
      List<Factories> data = new List<Factories>();
      try
      {
        data = db.Table<Factories>().Where(v => v.id > 0).ToList();
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, Factories src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, Factories src)
    {
      return (db.Update(src));
    }

    public static int Delete(SQLiteConnection db, Factories src)
    {
      return (db.Delete(src));
    }
    #endregion
  }
}
