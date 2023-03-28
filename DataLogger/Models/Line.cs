using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogger.Models
{
  public class Line
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime dataCreate {  get; set; }
    public Factory FactoryId { get; set; }
    public ICollection<Line> Lines { get; set;}
  }
}
