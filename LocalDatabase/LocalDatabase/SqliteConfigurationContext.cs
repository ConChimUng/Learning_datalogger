using LocalDatabase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase
{
  public class SqliteConfigurationContext : SqliteContext
  {
    public delegate void SendStatus(object sender, string status);
    public event SendStatus OnSendStatus;
    public SqliteConfigurationContext(string datasource, string password = "") : base(datasource, password)
    {
      base.Setup(datasource, password);
    }
    public int Update(object data)
    {
      int row_updated = 0;
      if (this._db != null)
      {
        if (data is Model.Categories) row_updated = (Model.Categories.Update(this._db, (Categories)data));
        else if (data is Model.Commands) row_updated = (Model.Commands.Update(this._db, (Commands)data));
        else if (data is Model.Departments) row_updated = (Model.Departments.Update(this._db, (Departments)data));
        else if (data is Model.DeviceMemories) row_updated = (Model.DeviceMemories.Update(this._db, (DeviceMemories)data));
        else if (data is Model.EquipmentLogs) row_updated = (Model.EquipmentLogs.Update(this._db, (EquipmentLogs)data));
        else if (data is Model.Equipments) row_updated = (Model.Equipments.Update(this._db, (Equipments)data));
        else if (data is Model.EthernetControllers) row_updated = (Model.EthernetControllers.Update(this._db, (EthernetControllers)data));
        else if (data is Model.Factories) row_updated = (Model.Factories.Update(this._db, (Factories)data));
        else if (data is Model.Factories) row_updated = (Model.Factories.Update(this._db, (Factories)data));
        else if (data is Model.ParameterLogs) row_updated = (Model.ParameterLogs.Update(this._db, (ParameterLogs)data));
        else if (data is Model.Parameters) row_updated = (Model.Parameters.Update(this._db, (Parameters)data));
        else if (data is Model.Protocols) row_updated = (Model.Protocols.Update(this._db, (Protocols)data));
        else if (data is Model.Roles) row_updated = (Model.Roles.Update(this._db, (Roles)data));
        else if (data is Model.Samplings) row_updated = (Model.Samplings.Update(this._db, (Samplings)data));
        else if (data is Model.SerialControllers) row_updated = (Model.SerialControllers.Update(this._db, (SerialControllers)data));
        else if (data is Model.Stations) row_updated = (Model.Stations.Update(this._db, (Stations)data));
        else if (data is Model.StationSettings) row_updated = (Model.StationSettings.Update(this._db, (StationSettings)data));
        else if (data is Model.Users) row_updated = (Model.Users.Update(this._db, (Users)data));
        else if (data is Model.UsersMachines) row_updated = (Model.UsersMachines.Update(this._db, (UsersMachines)data));
        else if (data is Model.UsersStations) row_updated = (Model.UsersStations.Update(this._db, (UsersStations)data));
        else if (data is Model.Productions) row_updated = (Model.Productions.Update(this._db, (Productions)data));
        else if (data is Model.ShiftTypes) row_updated = (Model.ShiftTypes.Update(this._db, (ShiftTypes)data));
        else if (data is Model.Shifts) row_updated = (Model.Shifts.Update(this._db, (Shifts)data));
        else if (data is Model.ProductionChangedLoggings) row_updated = (Model.ProductionChangedLoggings.Update(this._db, (ProductionChangedLoggings)data));
      }
      return row_updated;
    }

    public int Insert(object data)
    {
      int row_inserted = 0;
      if (this._db != null)
      {
        if (data is Model.Categories)
        {
          row_inserted = Model.Categories.Insert(this._db, (Categories)data);
          Categories.Add((Categories)data);
        }
        else if (data is Model.Commands)
        {
          row_inserted = Model.Commands.Insert(this._db, (Commands)data);
          Commands.Add((Commands)data);
        }
        else if (data is Model.Departments)
        {
          row_inserted = Model.Departments.Insert(this._db, (Departments)data);
          Departments.Add((Departments)data);
        }
        else if (data is Model.DeviceMemories)
        {
          row_inserted = Model.DeviceMemories.Insert(this._db, (DeviceMemories)data);
          DeviceMemories.Add((DeviceMemories)data);
        }
        else if (data is Model.EquipmentLogs)
        {
          row_inserted = Model.EquipmentLogs.Insert(this._db, (EquipmentLogs)data);
          this.EquipmentLogs.Add((EquipmentLogs)data);
        }
        else if (data is Model.EthernetControllers)
        {
          row_inserted = Model.EthernetControllers.Insert(this._db, (EthernetControllers)data);
          EthernetControllers.Add((EthernetControllers)data);
        }
        else if (data is Model.Factories)
        {
          row_inserted = Model.Factories.Insert(this._db, (Factories)data);
          this.Factories.Add((Factories)data);
        }
        else if (data is Model.Machines)
        {
          row_inserted = Model.Machines.Insert(this._db, (Machines)data);
          this.Machines.Add((Machines)data);
        }
        else if (data is Model.ParameterLogs)
        {
          row_inserted = Model.ParameterLogs.Insert(this._db, (ParameterLogs)data);
          ParameterLogs.Add((ParameterLogs)data);
        }
        else if (data is Model.Parameters)
        {
          row_inserted = Model.Parameters.Insert(this._db, (Parameters)data);
          Parameters.Add((Parameters)data);
        }
        else if (data is Model.Protocols)
        {
          row_inserted = Model.Protocols.Insert(this._db, (Protocols)data);
          Protocols.Add((Protocols)data);
        }
        else if (data is Model.Roles)
        {
          row_inserted = Model.Roles.Insert(this._db, (Roles)data);
          Roles.Add((Roles)data);
        }
        else if (data is Model.Samplings)
        {
          row_inserted = Model.Samplings.Insert(this._db, (Samplings)data);
          Samplings.Add((Samplings)data);
        }
        else if (data is Model.SerialControllers)
        {
          row_inserted = Model.SerialControllers.Insert(this._db, (SerialControllers)data);
          SerialControllers.Add((SerialControllers)data);
        }
        else if (data is Model.Stations)
        {
          row_inserted = Model.Stations.Insert(this._db, (Stations)data);
          Stations.Add((Stations)data);
        }
        else if (data is Model.StationSettings)
        {
          row_inserted = Model.StationSettings.Insert(this._db, (StationSettings)data);
          StationSettings.Add((StationSettings)data);
        }
        else if (data is Model.Users)
        {
          row_inserted = Model.Users.Insert(this._db, (Users)data);
          this.Users.Add((Users)data);
        }
        else if (data is Model.UsersMachines)
        {
          row_inserted = Model.UsersMachines.Insert(this._db, (UsersMachines)data);
          this.UsersMachines.Add((UsersMachines)data);
        }
        else if (data is Model.UsersStations)
        {
          row_inserted = Model.UsersStations.Insert(this._db, (UsersStations)data);
          this.UsersStations.Add((UsersStations)data);
        }
        else if (data is Model.Productions)
        {
          row_inserted = Model.Productions.Insert(this._db, (Productions)data);
          this.Productions.Add((Productions)data);
        }
        else if (data is Model.ProductionChangedLoggings)
        {
          row_inserted = Model.ProductionChangedLoggings.Insert(this._db, (ProductionChangedLoggings)data);
          this.ProductionChangedLoggings.Add((ProductionChangedLoggings)data);
        }
        //Productions
      }
      return row_inserted;

    }

    public int Delete(object data)
    {
      int row_deleted = 0;
      if (this._db != null)
      {
        if (data is Model.Categories)
        {
          row_deleted = Model.Categories.Delete(this._db, (Categories)data);
          Categories.Add((Categories)data);
        }
        else if (data is Model.Commands)
        {
          row_deleted = Model.Commands.Delete(this._db, (Commands)data);
          Commands.Add((Commands)data);
        }
        else if (data is Model.Departments)
        {
          row_deleted = Model.Departments.Delete(this._db, (Departments)data);
          Departments.Add((Departments)data);
        }
        else if (data is Model.DeviceMemories)
        {
          row_deleted = Model.DeviceMemories.Delete(this._db, (DeviceMemories)data);
          DeviceMemories.Add((DeviceMemories)data);
        }
        else if (data is Model.EquipmentLogs)
        {
          row_deleted = Model.EquipmentLogs.Delete(this._db, (EquipmentLogs)data);
          this.EquipmentLogs.Add((EquipmentLogs)data);
        }
        else if (data is Model.EthernetControllers)
        {
          row_deleted = Model.EthernetControllers.Delete(this._db, (EthernetControllers)data);
          EthernetControllers.Add((EthernetControllers)data);
        }
        else if (data is Model.Factories)
        {
          row_deleted = Model.Factories.Delete(this._db, (Factories)data);
          this.Factories.Add((Factories)data);
        }
        else if (data is Model.Machines)
        {
          row_deleted = Model.Machines.Delete(this._db, (Machines)data);
          this.Machines.Add((Machines)data);
        }
        else if (data is Model.ParameterLogs)
        {
          row_deleted = Model.ParameterLogs.Delete(this._db, (ParameterLogs)data);
          ParameterLogs.Add((ParameterLogs)data);
        }
        else if (data is Model.Parameters)
        {
          row_deleted = Model.Parameters.Delete(this._db, (Parameters)data);
          Parameters.Add((Parameters)data);
        }
        else if (data is Model.Protocols)
        {
          row_deleted = Model.Protocols.Delete(this._db, (Protocols)data);
          Protocols.Add((Protocols)data);
        }
        else if (data is Model.Roles)
        {
          row_deleted = Model.Roles.Delete(this._db, (Roles)data);
          Roles.Add((Roles)data);
        }
        else if (data is Model.Samplings)
        {
          row_deleted = Model.Samplings.Delete(this._db, (Samplings)data);
          Samplings.Add((Samplings)data);
        }
        else if (data is Model.SerialControllers)
        {
          row_deleted = Model.SerialControllers.Delete(this._db, (SerialControllers)data);
          SerialControllers.Add((SerialControllers)data);
        }
        else if (data is Model.Stations)
        {
          row_deleted = Model.Stations.Delete(this._db, (Stations)data);
          Stations.Add((Stations)data);
        }
        else if (data is Model.StationSettings)
        {
          row_deleted = Model.StationSettings.Delete(this._db, (StationSettings)data);
          StationSettings.Add((StationSettings)data);
        }
        else if (data is Model.Users)
        {
          row_deleted = Model.Users.Delete(this._db, (Users)data);
          this.Users.Add((Users)data);
        }
        else if (data is Model.UsersMachines)
        {
          row_deleted = Model.UsersMachines.Delete(this._db, (UsersMachines)data);
          this.UsersMachines.Add((UsersMachines)data);
        }
        else if (data is Model.UsersStations)
        {
          row_deleted = Model.UsersStations.Delete(this._db, (UsersStations)data);
          this.UsersStations.Add((UsersStations)data);
        }
        else if (data is Model.Productions)
        {
          row_deleted = Model.Productions.Delete(this._db, (Productions)data);
          this.Productions.Add((Productions)data);
        }
        else if (data is Model.ProductionChangedLoggings)
        {
          row_deleted = Model.ProductionChangedLoggings.Delete(this._db, (ProductionChangedLoggings)data);
          this.ProductionChangedLoggings.Add((ProductionChangedLoggings)data);
        }
        //Productions
      }
      return row_deleted;

    }
    /// <summary>
    /// Categories
    /// </summary>
    private List<Categories> _Categorie = null;
    public List<Categories> Categories
    {
      get
      {
        if (this._Categorie == null)
        {
          this._Categorie = Model.Categories.LoadAll(this._db);
        }
        return this._Categorie;
      }
      set { this._Categorie = value; }
    }

    /// <summary>
    /// Commands
    /// </summary>
    private List<Commands> _Commands = null;
    public List<Commands> Commands
    {
      get
      {
        if (this._Commands == null)
        {
          this._Commands = Model.Commands.LoadAll(this._db);
        }
        return this._Commands;
      }
      set { this._Commands = value; }
    }

    /// <summary>
    /// Departments
    /// </summary>
    private List<Departments> _Departments = null;
    public List<Departments> Departments
    {
      get
      {
        if (this._Departments == null)
        {
          this._Departments = Model.Departments.LoadAll(this._db);
        }
        return this._Departments;
      }
      set { this._Departments = value; }
    }


    /// <summary>
    /// Departments
    /// </summary>
    private List<ProductionChangedLoggings> _ProductionChangedLogging = null;
    public List<ProductionChangedLoggings> ProductionChangedLoggings
    {
      get
      {
        if (this._ProductionChangedLogging == null)
        {
          this._ProductionChangedLogging = Model.ProductionChangedLoggings.LoadAll(this._db);
        }
        return this._ProductionChangedLogging;
      }
      set { this._ProductionChangedLogging = value; }
    }




    /// <summary>
    /// Departments
    /// </summary>
    private List<DeviceMemories> _DeviceMemories = null;
    public List<DeviceMemories> DeviceMemories
    {
      get
      {
        if (this._DeviceMemories == null)
        {
          this._DeviceMemories = Model.DeviceMemories.LoadAll(this._db);
        }
        return this._DeviceMemories;
      }
      set { this._DeviceMemories = value; }
    }
    /// <summary>
    /// Departments
    /// </summary>
    private List<EquipmentLogs> _EquipmentLogs = null;
    public List<EquipmentLogs> EquipmentLogs
    {
      get
      {
        if (this._EquipmentLogs == null)
        {
          this._EquipmentLogs = Model.EquipmentLogs.LoadAll(this._db);
        }
        return this._EquipmentLogs;
      }
      set { this._EquipmentLogs = value; }
    }

    /// <summary>
    /// Equipments
    /// </summary>
    private List<Equipments> _Equipments = null;
    public List<Equipments> Equipments
    {
      get
      {
        if (this._Equipments == null)
        {
          this._Equipments = Model.Equipments.LoadAll(this._db);
        }
        return this._Equipments;
      }
      set { this._Equipments = value; }
    }

    /// <summary>
    /// EthernetControllers
    /// </summary>
    private List<EthernetControllers> _EthernetControllers = null;
    public List<EthernetControllers> EthernetControllers
    {
      get
      {
        if (this._EthernetControllers == null)
        {
          this._EthernetControllers = Model.EthernetControllers.LoadAll(this._db);
        }
        return this._EthernetControllers;
      }
      set { this._EthernetControllers = value; }
    }

    /// <summary>
    /// Factories
    /// </summary>
    private List<Model.Factories> _Factories = null;
    public List<Model.Factories> Factories
    {
      get
      {
        if (this._Factories == null)
        {
          this._Factories = Model.Factories.LoadAll(this._db);
        }
        return this._Factories;
      }
      set { this._Factories = value; }
    }
    
    /// <summary>
    /// _ParameterLogs
    /// </summary>
    private List<ParameterLogs> _ParameterLogs = null;
    public List<ParameterLogs> ParameterLogs
    {
      get
      {
        if (this._ParameterLogs == null)
        {
          this._ParameterLogs = Model.ParameterLogs.LoadAll(this._db);
        }
        return this._ParameterLogs;
      }
      set { this._ParameterLogs = value; }
    }

    /// <summary>
    /// _ParameterLogs
    /// </summary>
    private List<Machines> _Machines = null;
    public List<Machines> Machines
    {
      get
      {
        if (this._Machines == null)
        {
          this._Machines = Model.Machines.LoadAll(this._db);
        }
        return this._Machines;
      }
      set { this._Machines = value; }
    }


    /// <summary>
    /// Parameters
    /// </summary>
    private List<Parameters> _Parameters = null;
    public List<Parameters> Parameters
    {
      get
      {
        if (this._Parameters == null)
        {
          this._Parameters = Model.Parameters.LoadAll(this._db);
        }
        return this._Parameters;
      }
      set { this._Parameters = value; }
    }


    /// <summary>
    /// Protocols
    /// </summary>
    private List<Protocols> _Protocols = null;
    public List<Protocols> Protocols
    {
      get
      {
        if (this._Protocols == null)
        {
          this._Protocols = Model.Protocols.LoadAll(this._db);
        }
        return this._Protocols;
      }
      set { this._Protocols = value; }
    }
    /// <summary>
    /// Roles
    /// </summary>
    private List<Roles> _Roles = null;
    public List<Roles> Roles
    {
      get
      {
        if (this._Roles == null)
        {
          this._Roles = Model.Roles.LoadAll(this._db);
        }
        return this._Roles;
      }
      set { this._Roles = value; }
    }

    /// <summary>
    /// Samplings
    /// </summary>
    private List<Samplings> _Samplings = null;
    public List<Samplings> Samplings
    {
      get
      {
        if (this._Samplings == null)
        {
          this._Samplings = Model.Samplings.LoadAll(this._db);
        }
        return this._Samplings;
      }
      set { this._Samplings = value; }
    }

    /// <summary>
    /// SerialControllers
    /// </summary>
    private List<SerialControllers> _SerialControllers = null;
    public List<SerialControllers> SerialControllers
    {
      get
      {
        if (this._SerialControllers == null)
        {
          this._SerialControllers = Model.SerialControllers.LoadAll(this._db);
        }
        return this._SerialControllers;
      }
      set { this._SerialControllers = value; }
    }
    /// <summary>
    /// Stations
    /// </summary>
    private List<Stations> _Stations = null;
    public List<Stations> Stations
    {
      get
      {
        if (this._Stations == null)
        {
          this._Stations = Model.Stations.LoadAll(this._db);
        }
        return this._Stations;
      }
      set { this._Stations = value; }
    }
    /// <summary>
    /// StationSettings
    /// </summary>
    private List<StationSettings> _StationSettings = null;
    public List<StationSettings> StationSettings
    {
      get
      {
        if (this._StationSettings == null)
        {
          this._StationSettings = Model.StationSettings.LoadAll(this._db);
        }
        return this._StationSettings;
      }
      set { this._StationSettings = value; }
    }

    /// <summary>
    /// Users
    /// </summary>
    private List<Users> _Users = null;
    public List<Users> Users
    {
      get
      {
        if (this._Users == null)
        {
          this.Users = Model.Users.LoadAll(this._db);
        }
        return this._Users;
      }
      set { this._Users = value; }
    }

    /// <summary>
    /// UsersMachines
    /// </summary>
    private List<UsersMachines> _UsersMachines = null;
    public List<UsersMachines> UsersMachines
    {
      get
      {
        if (this._UsersMachines == null)
        {
          this._UsersMachines = Model.UsersMachines.LoadAll(this._db);
        }
        return this._UsersMachines;
      }
      set { this._UsersMachines = value; }
    }
    /// <summary>
    /// UsersStations
    /// </summary>
    private List<UsersStations> _UsersStations = null;
    public List<UsersStations> UsersStations
    {
      get
      {
        if (this._UsersStations == null)
        {
          this._UsersStations = Model.UsersStations.LoadAll(this._db);
        }
        return this._UsersStations;
      }
      set { this._UsersStations = value; }
    }

    /// <summary>
    /// UsersStations
    /// </summary>
    private List<Productions> _Productions = null;
    public List<Productions> Productions
    {
      get
      {
        if (this._Productions == null)
        {
          this._Productions = Model.Productions.LoadAll(this._db);
        }
        return this._Productions;
      }
      set { this._Productions = value; }
    }


    /// <summary>
    /// Shifts
    /// </summary>
    private List<Shifts> _Shifts = null;
    public List<Shifts> Shifts
    {
      get
      {
        if (this._Shifts == null)
        {
          this._Shifts = Model.Shifts.LoadAll(this._db);
        }
        return this._Shifts;
      }
      set { this._Shifts = value; }
    }


    /// <summary>
    /// Shifts
    /// </summary>
    private List<ShiftTypes> _ShiftTypes = null;
    public List<ShiftTypes> ShiftTypes
    {
      get
      {
        if (this._ShiftTypes == null)
        {
          this._ShiftTypes = Model.ShiftTypes.LoadAll(this._db);
        }
        return this._ShiftTypes;
      }
      set { this._ShiftTypes = value; }
    }


  }
}
