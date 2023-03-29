using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model
{
//  CREATE TABLE "DeviceMemories" (
//	"id"	INTEGER,
//	"memory_type"	TEXT,
//	"address"	INTEGER,
//	"wordlen"	INTEGER,
//	"parameter_id"	INTEGER,
//	"createdAt"	TEXT,
//	"updatedAt"	TEXT,
//	"createdBy"	INTEGER,
//	"updatedBy"	INTEGER,
//	PRIMARY KEY("id" AUTOINCREMENT)
//);
  public class DeviceMemories:Entity
  {
    #region Models

    public string memory_type { get; set; }
    public int wordlen { get; set; }
    public int address { get; set; }
    public int parameter_id { get; set; }



    #endregion
    #region Methods
    private static DeviceMemories Clone(DeviceMemories src)
    {
      DeviceMemories dst = new DeviceMemories()
      {
        id = src.id,
        createdAt = src.createdAt,
        updatedAt = src.updatedAt,
        createdBy = src.createdBy,
        updatedBy = src.updatedBy,

        //--------------------       
        memory_type = src.memory_type,
        wordlen = src.wordlen,
        parameter_id = src.parameter_id,
      };
      return dst;
    }

    public static List<DeviceMemories> LoadAll(SQLiteConnection db)
    {
      List<DeviceMemories> data = new List<DeviceMemories>();
      try
      {
        data = db.Table<DeviceMemories>().Where(v => v.id > 0).ToList();
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, DeviceMemories src)
    {
     return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, DeviceMemories src)
    {
      return (db.Update(src));
    }
    public static int Delete(SQLiteConnection db, DeviceMemories src)
    {
      return (db.Delete(src));
    }
    #endregion
  }
}
