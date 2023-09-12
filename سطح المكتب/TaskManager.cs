using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace سطح_المكتب
{
    public partial class TaskManager : Form
    {
        public TaskManager()
        {
            InitializeComponent();
            listProcess();

        }

        private void TaskManager_Load(object sender, EventArgs e)
        {

        }
        private void listProcess()
        {
            Process[] p = Process.GetProcesses();
            listViewProcesses.Items.Clear();
            foreach (Process p1 in p)
            {

                listViewProcesses.Items.Add(p1.ProcessName).SubItems.Add(p1.Id.ToString());

            }
        }
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            listProcess();

        }

        private void buttonKill_Click(object sender, EventArgs e)
        {
            try
            {
                string item = listViewProcesses.SelectedItems[0].Text;
                foreach (Process p in Process.GetProcessesByName(item))
                {
                    p.Kill();
                }
                listProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonStartProcess_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Convert.ToString(textBoxProcessName.Text + ".exe"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sou_Brows_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.RestoreDirectory = true;
            if (fd.ShowDialog() == DialogResult.OK)
                textBoxSourceFile.Text = Path.GetFullPath(fd.FileName);
        }

        private void Des_Brows_Click(object sender, EventArgs e)
        {

            OpenFileDialog fd = new OpenFileDialog();
            FolderBrowserDialog df = new FolderBrowserDialog();

            if (df.ShowDialog() == DialogResult.OK)

                textBoxDestinationFile.Text = Path.GetFullPath(df.SelectedPath) + '\\';

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string sourcefile = textBoxSourceFile.Text;
                if (File.Exists(sourcefile))
                {
                    MessageBox.Show("file name is found");
                }
                else
                {
                    File.Create(sourcefile);
                    MessageBox.Show("the file create successfuly");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            try
            {
                string sourcefile = textBoxSourceFile.Text;

                string[] filename_exe = textBoxSourceFile.Text.Split('\\');
                string[] filename = filename_exe[filename_exe.Length - 1].Split('.');


                string desfile = textBoxDestinationFile.Text + filename[0] + "(1)." + filename[1];
                if (File.Exists(desfile))
                    desfile = textBoxDestinationFile.Text + filename[0] + "(1)+." + filename[1];
                if (!File.Exists(sourcefile))
                {
                    MessageBox.Show("file not found");
                }
                else
                {
                    File.Move(sourcefile, desfile);
                    MessageBox.Show("the file cut successfuly");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string sourcefile = textBoxSourceFile.Text;
                if (textBoxSourceFile.Text.Contains("/"))
                    MessageBox.Show("Uncorrect Path");
                else if (!File.Exists(sourcefile))
                    MessageBox.Show("file name is not found");
                else
                {
                    File.Delete(sourcefile);
                    MessageBox.Show("the file deleted successfuly");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            try
            {
                string sourcefile = textBoxSourceFile.Text;

                string[] filename_exe = textBoxSourceFile.Text.Split('\\');
                string[] filename = filename_exe[filename_exe.Length - 1].Split('.');


                string desfile = textBoxDestinationFile.Text + filename[0] + "(1)." + filename[1];
                if (File.Exists(desfile))
                    desfile = textBoxDestinationFile.Text + filename[0] + "(1)+." + filename[1];
                if (!File.Exists(sourcefile))

                    MessageBox.Show("file not found");

                else
                {
                    File.Copy(sourcefile, desfile);
                    MessageBox.Show("the file copied successfuly");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void listViewProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCopy_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sourcefile = textBoxSourceFile.Text;

                string[] filename_exe = textBoxSourceFile.Text.Split('\\');
                string[] filename = filename_exe[filename_exe.Length - 1].Split('.');


                string desfile = textBoxDestinationFile.Text + filename[0] + "(1)." + filename[1];
                if (File.Exists(desfile))
                    desfile = textBoxDestinationFile.Text + filename[0] + "(1)+." + filename[1];
                if (!File.Exists(sourcefile))

                    MessageBox.Show("file not found");

                else
                {
                    File.Copy(sourcefile, desfile);
                    MessageBox.Show("the file copied successfuly");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxSourceFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCut_Click_1(object sender, EventArgs e)
        {

            try
            {
                string sourcefile = textBoxSourceFile.Text;

                string[] filename_exe = textBoxSourceFile.Text.Split('\\');
                string[] filename = filename_exe[filename_exe.Length - 1].Split('.');


                string desfile = textBoxDestinationFile.Text + filename[0] + "(1)." + filename[1];
                if (File.Exists(desfile))
                    desfile = textBoxDestinationFile.Text + filename[0] + "(1)+." + filename[1];
                if (!File.Exists(sourcefile))
                {
                    MessageBox.Show("file not found");
                }
                else
                {
                    File.Move(sourcefile, desfile);
                    MessageBox.Show("the file cut successfuly");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sourcefile = textBoxSourceFile.Text;
                if (textBoxSourceFile.Text.Contains("/"))
                    MessageBox.Show("Uncorrect Path");
                else if (!File.Exists(sourcefile))
                    MessageBox.Show("file name is not found");
                else
                {
                    File.Delete(sourcefile);
                    MessageBox.Show("the file deleted successfuly");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCreate_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sourcefile = textBoxSourceFile.Text;
                if (File.Exists(sourcefile))
                {
                    MessageBox.Show("file name is found");
                }
                else
                {
                    File.Create(sourcefile);
                    MessageBox.Show("the file create successfuly");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBoxDestinationFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Des_Brows_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog fd = new OpenFileDialog();
            FolderBrowserDialog df = new FolderBrowserDialog();

            if (df.ShowDialog() == DialogResult.OK)

                textBoxDestinationFile.Text = Path.GetFullPath(df.SelectedPath) + '\\';
        }

        private void Sou_Brows_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.RestoreDirectory = true;
            if (fd.ShowDialog() == DialogResult.OK)
                textBoxSourceFile.Text = Path.GetFullPath(fd.FileName);
        }

        private void buttonKill_Click_1(object sender, EventArgs e)
        {
            try
            {
                string item = listViewProcesses.SelectedItems[0].Text;
                foreach (Process p in Process.GetProcessesByName(item))
                {
                    p.Kill();
                }
                listProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRefresh_Click_1(object sender, EventArgs e)
        {
            listProcess();

        }

        private void buttonStartProcess_Click_1(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Convert.ToString(textBoxProcessName.Text + ".exe"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
