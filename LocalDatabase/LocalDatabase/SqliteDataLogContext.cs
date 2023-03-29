using LocalDatabase.Model.Datalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LocalDatabase.Model;

namespace LocalDatabase
{
  public class SqliteDataLogContext : SqliteContext
  {
    public delegate void SendStatus(object sender, string status);
    public event SendStatus OnSendStatus;

    /// <summary>
    /// data_log
    /// </summary>
    private List<data_log> _data_log = null;
    public List<data_log> Data_logs
    {
      get
      {
        if (this._data_log == null)
        {
          this._data_log = data_log.LoadAll(this._db);
        }
        return this._data_log;
      }
      set { this._data_log = value; }
    }

    
    /// <summary>
    /// Tares
    /// </summary>
    private List<tare> _tare = null;
    public List<tare> Tares
    {
      get
      {
        if (this._tare == null)
        {
          this._tare = tare.LoadAll(this._db);
        }
        return this._tare;
      }
      set { this._tare = value; }
    }

    /// <summary>
    /// Tares
    /// </summary>
    private List<sample> _samples = null;
    public List<sample> Samples
    {
      get
      {
        if (this._samples == null)
        {
          this._samples = sample.LoadAll(this._db);
        }
        return this._samples;
      }
      set { this._samples = value; }
    }



    public SqliteDataLogContext(string datasource, string password = "") : base(datasource, password)
    {
      if (File.Exists(datasource) == false)
      {
        base.Setup(datasource, password);
        this._db.CreateTable<data_log>();
        this._db.CreateTable<tare>();
        this._db.CreateTable<sample>();
      }
      else
      {
        base.Setup(datasource, password);
      }
     
    }

   

    public int Update(object data)
    {
      int row_updated = 0;
      if (this._db != null)
      {
        if (data is Model.Datalog.data_log) row_updated = (Model.Datalog.data_log.Update(this._db, (data_log)data));
        else if (data is Model.Datalog.tare) row_updated = (Model.Datalog.tare.Update(this._db, (tare)data));
        else if (data is Model.Datalog.sample) row_updated = (Model.Datalog.sample.Update(this._db, (sample)data));
      }
      return row_updated;
    }

    public int Insert(object data)
    {
      int row_inserted = 0;
      if (this._db != null)
      {
        if (data is Model.Datalog.data_log)
        {
          row_inserted = Model.Datalog.data_log.Insert(this._db, (data_log)data);
          this.Data_logs.Add((data_log)data);
        }
        else if (data is Model.Datalog.tare)
        {
          row_inserted = Model.Datalog.tare.Insert(this._db, (tare)data);
          this.Tares.Add((tare)data);
        }
        else if (data is Model.Datalog.sample)
        {
          row_inserted = Model.Datalog.sample.Insert(this._db, (sample)data);
          this.Samples.Add((sample)data);
        }
      }
      return row_inserted;

    }
    
  }
}
