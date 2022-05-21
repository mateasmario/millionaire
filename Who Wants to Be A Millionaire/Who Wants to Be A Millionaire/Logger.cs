using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Who_Wants_to_Be_A_Millionaire
{
    internal static class Logger
    {
        private static StreamWriter log;
        private static String fileName;
        private static bool available = false;

        public static void open()
        {
            fileName = DateTime.Now.ToFileTime() + ".txt";
            var file = File.Create("logs/" + fileName);
            available = true;
            file.Close();

            log = new StreamWriter("logs/" + fileName);
            log.WriteLine("Application Name: 'Who Wants To Be A Millionaire?'", true);
            log.WriteLine("Application Version: 1.01", true);
            log.WriteLine("Application Creator: Mateaș Mario-Mihai", true);
            log.WriteLine("", true);
            log.WriteLine("Log Name: " + fileName, true);
            log.WriteLine("Log Generation Date: " + DateTime.Now.ToShortDateString(), true);
            log.WriteLine("Log Generation Time: " + DateTime.Now.ToShortTimeString(), true);
            log.WriteLine("");
        }

        public static void write(String text)
        {
            if (available)
                log.WriteLine(text);
        }

        public static void writeTrace(String text)
        {
            write("<" + DateTime.Now.ToLongTimeString() + "> " + text);
        }

        public static void close()
        {
            log.Close();
        }

        public static void setStatus(bool status)
        {
            available = status;
        }
    }
}
