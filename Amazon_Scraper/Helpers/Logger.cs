using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon_Scraper.Helpers
{
    public static class Logger
    {
        private static void WriteLog(this string logTxt)
        {
            logTxt = $"{DateTime.Now}: {logTxt}";
            Trace.WriteLine(logTxt);
        }
    }
}
