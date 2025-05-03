using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace RestavracijaClasses
{
    public static class LoggedInUser
    {
        public static string Username { get; set; }
        public static string Ime { get; set; }
        public static string Priimek { get; set; }
        public static string IdStranke { get; set; }
        public static string IdZaposleni { get; set; }
    }
    public static class Log
    {
        private static readonly string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs", "error_log.txt");
        public static void logError(Exception ex)
        {
            string logMessage = $"{DateTime.Now}: {ex.Message}";
            WriteToFile(logMessage);
        }
        public static void WriteToFile(string logMessage)
        {
            try
            {
                string directory = Path.GetDirectoryName(logPath);
                if(!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                File.AppendAllText(logPath, logMessage + Environment.NewLine);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Napaka pri zapisovanju v dnevnik: {ex.Message}");
            }
        }
    }

}
