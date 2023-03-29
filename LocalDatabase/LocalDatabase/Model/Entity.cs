using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Model
{
  public class Entity
  {
    [PrimaryKey, AutoIncrement]
    public int id { get; set; }
    public string createdAt { get; set; }
    public string updatedAt { get; set; }
    public int createdBy { get; set; }
    public int updatedBy { get; set; }


    public enum eAction
    {
      Donothing,
      Update,
      Createnew,
      Delete
    }
  }
}
