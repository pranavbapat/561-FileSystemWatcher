using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _561_FileSystemWatcher
{
    public partial class MainForm : Form
    {
        //FileSystemWatcher object
        private FileSystemWatcher watcher;

        //Boolean to include or exclude sub directories
        private Boolean enableDeepWatch = false;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Initializing watcher object
            watcher = new System.IO.FileSystemWatcher();

            //Clearing all listbox items
            listBoxAllChanges.Items.Clear();
            listBoxChanged.Items.Clear();
            listBoxDeleted.Items.Clear();
            listBoxRenamed.Items.Clear();
        }
                     

        private void buttonStartWatching_Click(object sender, EventArgs e)
        {
            //Checking if the path is valid or not
            if (textBoxPath.Text == "")
            {
                //Prompt the user to enter a valid path
                DialogResult invalidPathDialogue = MessageBox.Show("Please enter a valid path!", "Invalid Path", MessageBoxButtons.RetryCancel);
            }
            else
            {
                //If path is valid, set the Path attribute to the user given path
                watcher.Path = textBoxPath.Text;

                //Adding filters to the watcher object
                watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;

                //Adding events and event handling methods depending on check box selections
                if (checkBoxChanged.Checked == true)
                    watcher.Changed += new FileSystemEventHandler(onChanged);
                if (checkBoxDeleted.Checked == true)
                    watcher.Deleted += new FileSystemEventHandler(onDeleted);
                if (checkBoxRenamed.Checked == true)
                    watcher.Renamed += new RenamedEventHandler(onRenamed);

                //If deepwatch is selected the value is set to TRUE
                watcher.IncludeSubdirectories = enableDeepWatch;

                //Allows the watcher to raise events and respond
                watcher.EnableRaisingEvents = true;
            }
        }

        private void buttonStopWatching_Click(object sender, EventArgs e)
        {
            //Confirm abort dialogue box
            DialogResult sureAbort = MessageBox.Show("Are you sure you want to stop watching?", "Abort", MessageBoxButtons.YesNo);
            if (sureAbort == DialogResult.Yes)
            {
                //Dispose watcher when aborting
                watcher.Dispose();

                //Dialogue box to ask for log creation
                DialogResult writeToFile = MessageBox.Show("Do you want to dump to log?", "Write to File", MessageBoxButtons.YesNo);
                if(writeToFile == DialogResult.Yes)
                {
                    //Creating text file and dumping all listbox data
                    string logFileName = string.Format("text-{0:yyyy-MM-dd_hh-mm-ss-tt}.txt",DateTime.Now);
                    String logFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), logFileName);
                    String initialFileData = "Log Created: " + DateTime.Today.ToString();
                    File.WriteAllText(logFilePath, initialFileData + Environment.NewLine);
                    
                    //Iterating through listbox to write to text file
                    foreach (var listBoxItem in listBoxAllChanges.Items)
                    {
                        File.AppendAllText(logFilePath, listBoxItem.ToString() + Environment.NewLine);
                    }
                    DialogResult fileWriteDone = MessageBox.Show("Log successfully created", "File Write Complete", MessageBoxButtons.OK);
                }
                    //Clearing all listbox content
                    this.Invoke((MethodInvoker)delegate
                    {
                        listBoxAllChanges.Items.Clear();
                        listBoxChanged.Items.Clear();
                        listBoxDeleted.Items.Clear();
                        listBoxRenamed.Items.Clear();
                    });
            }
        }

        //onChanged method handles file change event
        public void onChanged(Object sender, FileSystemEventArgs e)
        {
            //Setting events to false to display one single event
            watcher.EnableRaisingEvents = false;
            String message = string.Format("FILE: {0} Changed; Path: {1} ", e.Name, e.FullPath);
            Console.WriteLine(message);
            //Adding message to the appropriate listbox
            this.Invoke((MethodInvoker)delegate 
            { 
                listBoxAllChanges.Items.Add(message);
                listBoxChanged.Items.Add(message);
            });

            //Enabling raising events to true to listen for new events
            watcher.EnableRaisingEvents = true;
        }


        public void onDeleted(Object sender, FileSystemEventArgs e)
        {
            watcher.EnableRaisingEvents = false;
            String message = string.Format("FILE: {0} Deleted; Path: {1} ", e.Name, e.FullPath);
            Console.WriteLine(message);
            this.Invoke((MethodInvoker)delegate
            {
                listBoxAllChanges.Items.Add(message);
                listBoxDeleted.Items.Add(message);
            });
            watcher.EnableRaisingEvents = true;
        }

        public void onRenamed(Object sender, RenamedEventArgs e)
        {
            watcher.EnableRaisingEvents = false;
            String message = string.Format("FILE: {0} Renamed; Path: {1} ", e.Name, e.FullPath);
            Console.WriteLine(message);
            this.Invoke((MethodInvoker)delegate
            {
                listBoxAllChanges.Items.Add(message);
                listBoxRenamed.Items.Add(message);
            });
            watcher.EnableRaisingEvents = true;
        }

        //Method to set deep watch boolean depending on check box selection
        public void checkBoxSubFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSubFolder.Checked == true)
                enableDeepWatch = true;
            else
                enableDeepWatch = false;
        }
    }
}


