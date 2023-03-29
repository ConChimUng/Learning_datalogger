using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase
{
  public static class Helpers
  {
    public static string ToyyyyMMddHHmmss(this DateTime dateTime)
    {
      return $"{dateTime.ToString("yyyy")}/{dateTime.ToString("MM")}/{dateTime.ToString("dd")} {dateTime.ToString("HH")}:{dateTime.ToString("mm")}:{dateTime.ToString("ss")}";
    }

    public static bool ToBool(this int src)
    {
      return (src != 0);
    }
  }
}
