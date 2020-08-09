using System;
using System.Collections;
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

namespace ImageSorter
{
    public partial class Form1 : Form
    {

        public static string SearchDirectory { get; set; }
        public static string StoreDirectory { get; set; }
        Hashtable DirAndDate = new Hashtable();
        public static int SortedItemCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            var directory = new FolderBrowserDialog();
            directory.ShowDialog();
            SearchDirectory = directory.SelectedPath + @"\";
            FindTextbox.Text = SearchDirectory;
        }

        private void StoreButton_Click(object sender, EventArgs e)
        {
            var directory = new FolderBrowserDialog();
            directory.ShowDialog();
            StoreDirectory = directory.SelectedPath + @"\";
            StoreTextbox.Text = StoreDirectory;
        }
        
        private void SortButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(SearchDirectory) && !String.IsNullOrEmpty(StoreDirectory))
            {
                try
                {
                    DirAndDate.Clear();
                    SortedItemCount = 0;
                    Thread thread = new Thread(() =>
                    {
                        FindFiles();
                        Mover();
                        MessageBox.Show(String.Format("Sorted {0} / {1} items!", SortedItemCount, DirAndDate.Keys.Count), "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    });
                    thread.Start();
                }
                catch (Exception b)
                {
                    MessageBox.Show("Something went wrong. Writing to log file!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LogWriter(b.Message);
                }

            }
            else
            {
                MessageBox.Show("The two directories seem to be empty. Please navigate to a directory and try again!", "Empty directories", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void FindFiles()
        {
            string[] allfiles = System.IO.Directory.GetFileSystemEntries(SearchDirectory, "*", SearchOption.AllDirectories);
            foreach (string x in allfiles)
            {
                DateTime creation = File.GetLastWriteTime(x);
                DirAndDate.Add(x, creation.ToString("yyyy-MM-dd"));
            }
        }

        public void Mover()
        {
            foreach (string FilePath in DirAndDate.Keys)
            {
                try
                {
                    string path = StoreDirectory + DirAndDate[FilePath].ToString() + @"\";
                    if (!System.IO.Directory.Exists(path))
                    {
                        System.IO.Directory.CreateDirectory(path);
                    }
                    FileInfo File = new FileInfo(FilePath);
                    string EndPath = path + File.Name;
                    if (CopyRadioButton.Checked == true)
                    {
                        File.CopyTo(EndPath, true);
                    }
                    if (MoveRadioButton.Checked == true)
                    {
                        File.MoveTo(EndPath, true);
                    }
                    SortedItemCount += 1;
                }
                catch (Exception e)
                {
                    LogWriter("Error: " + e.Message);
                }
            }
        }

        public void LogWriter(string input)
        {

            using (StreamWriter sw = File.AppendText("log.txt"))
            {
                sw.WriteLine(input);
                sw.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CopyRadioButton.Checked = true;
        }
    }
}
