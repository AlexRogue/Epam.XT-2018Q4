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
            string textlog = $"{currentTime}\n{e.FullPath}\n{e.ChangeType}\n";
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
            string textlog = $"{currentTime}\n{e.FullPath}\n{e.ChangeType}\n";
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
            string textlog = $"{currentTime}\n{e.FullPath}\n{e.ChangeType}\n";
            fireCount++;
            BeginInvoke(new Action(() =>
            richTextBox1.AppendText(textlog + "\n")
            ));
            logCreator.WriteLog(textlog, logDir, backupDir);
        }

        private void OnRenamed(object sender, FileSystemEventArgs e)
        {
            string currentTime = DateTime.Now.ToString("yyyy/MM/dd HH-mm-ss");
            string textlog = $"{currentTime}\n{e.FullPath}\nRenamed\n";
            BeginInvoke(new Action(() =>
            {
                richTextBox1.AppendText(textlog);
                logCreator.WriteLog(textlog, logDir, backupDir);
                BackupFile(e.FullPath, $"{backupDir}{currentTime}\\", e.Name);
            }));  
        }

        private void BackupFile (string sourcefn, string destinfn, string backupingfile)
        {

            //var fileName = backupingfile.Substring(backupingfile.LastIndexOf('\\') + 1).Replace(".txt", string.Empty);
            //var additionOfFileName = backupingfile.Substring(backupingfile.IndexOf('\\'));


            string pathtofile = ($"{destinfn}{backupingfile.Replace(".txt", "")}");
            if (!Directory.Exists(pathtofile))
            {
                Directory.CreateDirectory(pathtofile);
            }
            File.Copy(sourcefn, $"{destinfn}{backupingfile}", true);
            richTextBox1.AppendText($"{destinfn}{backupingfile}");
            logCreator.WriteLog($"{destinfn}{backupingfile}\n", logDir, backupDir);
            richTextBox1.AppendText($"\n");
        }

        private void RecoverFiles()
        {
            StreamReader readlog = new StreamReader(logDir);
            StringBuilder strLog = new StringBuilder();
            DateTime remainnigdatetime = DateTime.Now;  
            while (!readlog.EndOfStream)
            {
                strLog.Append(readlog.ReadLine());
            }
            readlog.Close();
            string result = strLog.ToString();
            List<string> listlog = new List<string>(result.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries));
            for(int i = 0; (remainnigdatetime < dateTimePicker1.Value | i < listlog.Count); i++)  //until <= control datetime
            {
                if (listlog[i].StartsWith("2"))
                {
                    remainnigdatetime = DateTime.ParseExact(listlog[i], "yyyy-MM-dd-HH-mm-ss", System.Globalization.CultureInfo.InvariantCulture);
                }
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
            MessageBox.Show($"{recoverdate}", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
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
