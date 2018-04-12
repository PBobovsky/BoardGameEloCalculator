using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameEloCalculator.Helpers
{
    static class Logger
    {
        static string path = @"DBFiles/log.txt";


        public static void Log(string text)
        {
            text = text + "\n";
            try
            {
                if (!File.Exists(path))
                {
                    using (FileStream fs = File.Create(path)){}
                }
                File.AppendAllText(path, text);

            }
            catch (DirectoryNotFoundException ed)
            {
                Directory.CreateDirectory("DBFiles");
                Logger.Log("Directory not found, creating a new one");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
