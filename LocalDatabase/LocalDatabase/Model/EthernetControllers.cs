using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model
{
//  CREATE TABLE "EthernetControllers" (
//	"id"	INTEGER,
//	"name"	TEXT,
//	"serial"	TEXT,
//	"ipaddress"	TEXT,
//	"port"	INTEGER,
//	"intervalRead"	INTEGER,
//	"direction"	INTEGER,
//	"protocol_id"	INTEGER,
//	"station_id"	INTEGER,
//	"machine_id"	INTEGER,
//	"enable"	INTEGER,
//	"createdAt"	TEXT,
//	"updatedAt"	TEXT,
//	"createdBy"	INTEGER,
//	"updatedBy"	INTEGER,
//	PRIMARY KEY("id" AUTOINCREMENT)
//);
  public class EthernetControllers:Entity
  {
    #region Models

    public string name { get; set; }
    public string serial { get; set; }
    public string ipaddress { get; set; }
    public int port { get; set; }
    public int intervalRead { get; set; }
    public int direction { get; set; }
    public int protocol_id { get; set; }
    public int station_id { get; set; }
    public int machine_id { get; set; }
    public bool enable { get; set; }


    #endregion
    #region Methods
    private static EthernetControllers Clone(EthernetControllers src)
    {
      EthernetControllers dst = new EthernetControllers()
      {
        id = src.id,
        createdAt = src.createdAt,
        updatedAt = src.updatedAt,
        createdBy = src.createdBy,
        updatedBy = src.updatedBy,
        //--------------------       
        name = src.name,
        serial = src.serial,
        ipaddress = src.ipaddress,
        port = src.port,
        intervalRead = src.intervalRead,
        direction = src.direction,
          
        protocol_id = src.protocol_id, 
        station_id = src.station_id,
        machine_id = src.machine_id,
        enable = src.enable,

      };
      return dst;
    }

    public static List<EthernetControllers> LoadAll(SQLiteConnection db)
    {
      List<EthernetControllers> data = new List<EthernetControllers>();
      try
      {
        data = db.Table<EthernetControllers>().Where(v => v.id > 0).ToList();
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, EthernetControllers src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, EthernetControllers src)
    {
      return (db.Update(src));
    }

    public static int Delete(SQLiteConnection db, EthernetControllers src)
    {
      return (db.Delete(src));
    }
    #endregion
  }
}
