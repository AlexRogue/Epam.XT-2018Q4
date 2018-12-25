using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class FileWatcher : Form
    {
        FileSystemWatcher fileSystemWatcher;
        LogCreator logCreator = new LogCreator();
        private int fireCount = 0;
        private string logDir = "C:\\Backuper\\log.txt";
        private string backupDir = "C:\\Backuper\\";
        private string recoverdate;
        DateTime recoveryTime;

        public FileWatcher()
        {
            InitializeComponent();
            fileSystemWatcher = new FileSystemWatcher();

            logCreator.CreateLog(logDir, backupDir);
            
            fileSystemWatcher.Filter = "*.txt";

            if (radioButton1.Checked == true)
            {
                fileSystemWatcher.IncludeSubdirectories = true;
            }
            else
            {
                fileSystemWatcher.IncludeSubdirectories = false;
            }
            fileSystemWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite | NotifyFilters.Size 
                | NotifyFilters.Attributes | NotifyFilters.DirectoryName | NotifyFilters.LastAccess | NotifyFilters.CreationTime;
            fileSystemWatcher.Changed += new FileSystemEventHandler(OnChanged);         
            fileSystemWatcher.Created += new FileSystemEventHandler(OnCreated);
            fileSystemWatcher.Deleted += new FileSystemEventHandler(OnDeleted);
            fileSystemWatcher.Renamed += new RenamedEventHandler(OnRenamed);            
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            fireCount++;
            string currentTime = DateTime.Now.ToString("yyyy/MM/dd HH-mm-ss");
            string textlog = $"{Environment.NewLine}{currentTime}{Environment.NewLine}{e.FullPath}{Environment.NewLine}{e.ChangeType}";
            BeginInvoke(new Action(() => {
                richTextBox1.AppendText(textlog);
                logCreator.WriteLog(textlog, logDir, backupDir);
                BackupFile(e.FullPath, $"{backupDir}{currentTime}\\", e.Name);
            }
          ));  
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            string currentTime = DateTime.Now.ToString("yyyy/MM/dd HH-mm-ss");
            string textlog = $"{Environment.NewLine}{currentTime}{Environment.NewLine}{e.FullPath}{Environment.NewLine}{e.ChangeType}";
            fireCount++;
            if (fireCount == 1)
            {
                BeginInvoke(new Action(() => {
                    richTextBox1.AppendText(textlog);
                    logCreator.WriteLog(textlog, logDir, backupDir);
                    BackupFile(e.FullPath, $"{backupDir}{currentTime}\\", e.Name);
                }
            ));
            }
            else
            {
                fireCount = 0;
            }
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            string currentTime = DateTime.Now.ToString("yyyy/MM/dd HH-mm-ss");
            string textlog = $"{Environment.NewLine}{currentTime}{Environment.NewLine}{e.FullPath}{Environment.NewLine}{e.ChangeType}";
            fireCount++;
            BeginInvoke(new Action(() =>
            richTextBox1.AppendText(textlog + "\n")
            ));
            logCreator.WriteLog(textlog, logDir, backupDir);
        }

        private void OnRenamed(object sender, FileSystemEventArgs e)
        {
            string currentTime = DateTime.Now.ToString("yyyy/MM/dd HH-mm-ss");
            string textlog = $"{Environment.NewLine}{currentTime}{Environment.NewLine}{e.FullPath}{Environment.NewLine}Renamed";
            BeginInvoke(new Action(() =>
            {
                richTextBox1.AppendText(textlog);
                logCreator.WriteLog(textlog, logDir, backupDir);
                BackupFile(e.FullPath, $"{backupDir}{currentTime}\\", e.Name);
            }));  
        }

        private void BackupFile (string sourcefn, string destinfn, string backupingfile)
        {
            object obj = new object();
            var fileName = backupingfile.Substring(backupingfile.LastIndexOf('\\') + 1);
            var additionOfFileName = backupingfile.Replace(fileName, string.Empty);
            string pathtofile = $"{destinfn}{additionOfFileName}";
            if (!Directory.Exists(pathtofile))
            {
                Directory.CreateDirectory(pathtofile);
            }
            lock (obj)
            {
                File.Copy(sourcefn, $"{pathtofile + fileName}", true);
            }
            richTextBox1.AppendText($"\n{pathtofile}{fileName}");
            logCreator.WriteLog($"{pathtofile}{fileName}\n", logDir, backupDir);
            richTextBox1.AppendText($"\n");
        }

        private void RecoverFiles()
        {
            DirectoryInfo directory = new DirectoryInfo(fileSystemWatcher.Path);
            foreach (var file in directory.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo subDirectory in directory.GetDirectories())
            {
                subDirectory.Delete(true);
            }
            List<string> listlog = new List<string>();
            StringBuilder strLog = new StringBuilder();
            DateTime remainnigdatetime = DateTime.Now;
            using (StreamReader readlog = new StreamReader(logDir))
            {
                while (!readlog.EndOfStream)
                {
                    if (readlog.ReadLine() != "")
                    {
                        listlog.Add(readlog.ReadLine());
                    }
                    //strLog.Append(readlog.ReadLine());
                }
            }
            //var t = strLog.ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            

            for (DateTime d = DateTime.Parse(listlog[0]); d < recoveryTime ; d = d.AddSeconds(1))  //until <= control datetime
            {
                //if (listlog[i].StartsWith("2"))
                //{
                //    remainnigdatetime = DateTime.ParseExact(listlog[i], "yyyy-MM-dd-HH-mm-ss", System.Globalization.CultureInfo.InvariantCulture);
                //}
            }
        }


        private void startToWatch_Click(object sender, EventArgs e)
        {
            try
            {
                string path = textBox1.Text;
                fileSystemWatcher.Path = path;
                fileSystemWatcher.EnableRaisingEvents = true;
                richTextBox1.AppendText($"Path set {path}\n");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Wrong path", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void buttonRetrive_Click(object sender, EventArgs e)
        {
           string folderIdToRetrive =  dateTimePicker1.Text;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            recoveryTime = dateTimePicker1.Value;
            RecoverFiles();
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                RecoverButton.Visible = false;
                dateTimePicker1.Visible = false;
                BackupButton.Visible = true;
                fileSystemWatcher.IncludeSubdirectories = true;
                richTextBox1.AppendText("Pasring continued\n");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                RecoverButton.Visible = true;
                dateTimePicker1.Visible = true;
                BackupButton.Visible = false;
                fileSystemWatcher.IncludeSubdirectories = false;
                richTextBox1.AppendText("Pasring paused\n");
            }                
        }

        
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
