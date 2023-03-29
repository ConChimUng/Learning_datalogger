using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase.Extra
{
  public class SeriesColors
  {
    public int id { get; set; }
    public Color BackColor { get; set; }
    public Color ForeColor { get; set; }

    public int production_id { get; set; }
    public SeriesColors(int id, Color backColor, Color foreColor, int production_id)
    {
      this.id = id;
      this.BackColor = backColor;
      this.ForeColor = foreColor;
      this.production_id = production_id;
    }
}
}
