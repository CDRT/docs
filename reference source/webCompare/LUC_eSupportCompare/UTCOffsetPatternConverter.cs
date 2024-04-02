using log4net.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUC_eSupportCompare
{
    public class UTCOffsetPatternConverter : PatternConverter
    {
        override protected void Convert(System.IO.TextWriter writer, object state)
        {
            TimeSpan delta;
            try
            {
                System.TimeZone TimeZoneInfo = System.TimeZone.CurrentTimeZone;
                delta = TimeZoneInfo.GetUtcOffset(DateTime.Now);
            }
            catch
            {
                delta = (System.TimeSpan.Zero);
            }
            writer.Write(delta.TotalMinutes.ToString());
        }
    }
}
