using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Other
{
  internal class DateTimeProvider : INowSetter
  {
    public DateTime Now
    {
      get { return DateTime.Now; }
    }


    void INowSetter.SetDate(DateTime v)
    {

    }
  }

  public interface INowSetter
  {
    void SetDate(DateTime v);
  }


  public class DateTimeSetter
  {
    public DateTimeSetter()
    {
      DateTimeProvider d = new DateTimeProvider();

      (d as INowSetter).SetDate
    }
  } 
}

