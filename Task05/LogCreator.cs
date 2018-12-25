using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class LogCreator
    {
        StreamWriter log = null;
        FileStream fileStream = null;
        
        string trackingDir;
        

        public void CreateLog(string logDir, string backupDir)
        {
            if (!Directory.Exists(backupDir))
            {
                logDir = Path.Combine(backupDir, "log.txt");
                Directory.CreateDirectory(backupDir);
                File.Create(logDir).Close();
            }
        }

        public void WriteLog(string textLog, string logDir, string backupDir)
        {
            if (!Directory.Exists(backupDir))
            {
                CreateLog(logDir, backupDir);               
            }
            else
            {
                fileStream = new FileStream($"C:\\Backuper\\log.txt", FileMode.Append);
                log = new StreamWriter(fileStream);
                log.WriteLine(textLog);
                log.Close();
                fileStream.Close();
            }
        }

    }
}
