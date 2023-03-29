using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model
{
//  CREATE TABLE "SerialControllers" (
//	"id"	INTEGER,
//	"name"	TEXT,
//	"serial"	TEXT,
//	"comport"	TEXT,
//	"baud"	INTEGER,
//	"parity"	INTEGER,
//	"databits"	INTEGER,
//	"stopbits"	INTEGER,
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
  public class SerialControllers:Entity
  {
    #region Models

    public string name { get; set; }
    public string serial { get; set; }
    public string comport { get; set; }
    public int baud { get; set; }
    public int parity { get; set; }
    public int databits { get; set; }
    public int stopbits { get; set; }
    public int intervalRead { get; set; }
    public int direction { get; set; }
    public int protocol_id { get; set; }
    public int station_id { get; set; }
    public int machine_id { get; set; }
    public bool enable { get; set; }


    #endregion
    #region Methods
    private static SerialControllers Clone(SerialControllers src)
    {
      SerialControllers dst = new SerialControllers()
      {
        id = src.id,
        createdAt = src.createdAt,
        updatedAt = src.updatedAt,
        createdBy = src.createdBy,
        updatedBy = src.updatedBy,
        //--------------------       
        name = src.name,
        serial = src.serial,
        comport = src.comport,
        baud = src.baud,
        parity = src.parity,
        databits = src.databits,
        stopbits = src.stopbits,
        intervalRead = src.intervalRead,
        direction = src.direction,
        protocol_id = src.protocol_id,
        station_id = src.station_id,
        machine_id = src.machine_id,
        enable = src.enable,
      };
      return dst;
    }

    public static List<SerialControllers> LoadAll(SQLiteConnection db)
    {
      List<SerialControllers> data = new List<SerialControllers>();
      try
      {
        data = db.Table<SerialControllers>().Where(v => v.id > 0).ToList();
      }
      catch (Exception ex)
      {

      }
      return data;
    }
    public static int Insert(SQLiteConnection db, SerialControllers src)
    {
      return (db.Insert(src));
    }

    public static int Update(SQLiteConnection db, SerialControllers src)
    {
      return (db.Update(src));
    }
    public static int Delete(SQLiteConnection db, SerialControllers src)
    {
      return (db.Delete(src));
    }
    #endregion

  }
}
