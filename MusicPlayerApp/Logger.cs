using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp
{
    public class Logger
    {
    private readonly string logFilePath;

        public Logger(string logFilePath)
        {
            this.logFilePath = logFilePath;
        }

        public void LogError(string errorMessage)
        {
            Log($"[ERROR] {DateTime.Now:yyyy-MM-dd HH:mm:ss}: {errorMessage}");
        }

        public void LogInvalidInput(string input)
        {
            Log($"[INVALID INPUT] {DateTime.Now:yyyy-MM-dd HH:mm:ss}: {input}");
        }

        public void LogEvent(string eventMessage)
        {
            Log($"[EVENT] {DateTime.Now:yyyy-MM-dd HH:mm:ss}: {eventMessage}");
        }

        private void Log(string logMessage)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine(logMessage);
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log to console or another log)
                Console.WriteLine($"Failed to write to log file: {ex.Message}");
            }
        }
    }
}
