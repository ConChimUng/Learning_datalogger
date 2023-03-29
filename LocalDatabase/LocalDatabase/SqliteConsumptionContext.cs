using LocalDatabase.Model.Consumption;
using LocalDatabase.Model.Datalog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase
{
  public class SqliteConsumptionContext : SqliteContext
  {
    public delegate void SendStatus(object sender, string status);
    public event SendStatus OnSendStatus;
    public SqliteConsumptionContext(string datasource, string password = "") : base(datasource, password)
    {
      if (File.Exists(datasource) == false)
      {
        base.Setup(datasource, password);
        this._db.CreateTable<consumption_data>();
      }
      else
      {
        base.Setup(datasource, password);
      }

    }

    /// <summary>
    /// data_log
    /// </summary>
    private List<consumption_data> _consumption_data = null;
    public List<consumption_data> ConsumptionsGet(int station_id)
    {
      if (this._consumption_data == null)
      {
        this._consumption_data = consumption_data.LoadAll(this._db, station_id);
      }
      return this._consumption_data;
    }

    public void ConsumptionsAdd(consumption_data consumption_Data)
    {
      if (this._consumption_data != null)
      {
        this._consumption_data.Add(consumption_Data);
      }
    }


    public int Update(object data)
    {
      int row_updated = 0;
      if (this._db != null)
      {
        if (data is Model.Consumption.consumption_data) row_updated = (Model.Consumption.consumption_data.Update(this._db, (consumption_data)data));
      }
      return row_updated;
    }

    public int Insert(object data)
    {
      int row_inserted = 0;
      if (this._db != null)
      {
        if (data is Model.Consumption.consumption_data)
        {
          row_inserted = Model.Consumption.consumption_data.Insert(this._db, (consumption_data)data);
          this.ConsumptionsAdd((consumption_data)data);
        }
      }
      return row_inserted;

    }

  }
}
