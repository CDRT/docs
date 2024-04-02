using log4net.Layout.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Core;
using System.IO;

namespace LUC_eSupportCompare
{
    class NumericLevelPatternConverter : PatternLayoutConverter
    {
        private const int VERBOSE = 10000;
        private const int DEBUG = 30000;
        private const int WARN = 60000;
        private const int INFO = 40000;
        private const int ERROR = 70000;
        protected override void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            if(loggingEvent.Level.Value == WARN )
                writer.Write(2);
            else if (loggingEvent.Level.Value == DEBUG)
                writer.Write(5);
            else if (loggingEvent.Level.Value == INFO)
                writer.Write(6);
            else if (loggingEvent.Level.Value == ERROR)
                writer.Write(3);
            else if(loggingEvent.Level.Value == VERBOSE)
                writer.Write(4);
        }
    }
}
