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
using System.Collections;



namespace سطح_المكتب
{
    public partial class ThisPc : Form
    {
        DriveInfo[] allDrives;
        public ThisPc()
        {
            InitializeComponent();

        }

        private void ThisPc_Load(object sender, EventArgs e)
        {
            label13.Text = Environment.MachineName;
            label12.Text = Environment.UserName.ToString();
            label3.Text = Environment.CurrentDirectory;
            label10.Text = Environment.Is64BitOperatingSystem.ToString();
            label11.Text = Environment.OSVersion.ToString();
            allDrives = DriveInfo.GetDrives();
            CreateDisks();

        }
        private void CreateDisks()

        {
            foreach (DriveInfo disk in allDrives)
            {
                diskcr(disk);

            }

        }

        private void diskcr(DriveInfo disk)
        {
            try{
                int TotalSpace = (int)(((disk.TotalSize / 1024) / 1024) / 1024);
                int AvailableFreeSpace = (int)(((disk.AvailableFreeSpace / 1024) / 1024) / 1024);
                int SpaceUsage = TotalSpace - AvailableFreeSpace;


                //DiskName
                Label DiskName = new Label();
                DiskName.AutoSize = true;
                DiskName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                DiskName.Location = new System.Drawing.Point(57, 0);
                DiskName.Name = "label4";
                DiskName.Size = new System.Drawing.Size(74, 17);
                DiskName.TabIndex = 46;
                DiskName.Text = "Local Disk (" + disk.ToString() + ')'; ;

                ProgressBar pr1 = new ProgressBar();
                pr1.Location = new System.Drawing.Point(60, 20);
                pr1.Name = "progressBar1";
                pr1.Size = new System.Drawing.Size(213, 15);
                pr1.Maximum = TotalSpace;
                pr1.TabIndex = 45;
                pr1.Value = SpaceUsage;
                //pic
                PictureBox px1 = new PictureBox();
                px1.ErrorImage = سطح_المكتب.Properties.Resources.Disk_Icon;
                px1.Image = سطح_المكتب.Properties.Resources.Disk_Icon;
                px1.Location = new System.Drawing.Point(3, 6);
                px1.Name = "pictureBox1";
                px1.Size = new System.Drawing.Size(32, 32);
                px1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                px1.TabIndex = 47;
                px1.TabStop = false;
                //lbldet
                Label lbldet = new Label();
                lbldet.AutoSize = true;
                lbldet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbldet.ForeColor = System.Drawing.SystemColors.AppWorkspace;
                lbldet.Location = new System.Drawing.Point(62, 44);
                lbldet.Name = "label17";
                lbldet.Size = new System.Drawing.Size(43, 17);
                lbldet.TabIndex = 48;
                lbldet.Text = AvailableFreeSpace.ToString() + "GB  free  of " + TotalSpace.ToString() + "GB"; ;

                //panel
                Panel progpnl = new Panel();
                progpnl.Controls.Add(pr1);
                progpnl.Controls.Add(px1);
                progpnl.Controls.Add(lbldet);
                progpnl.Controls.Add(DiskName);
                progpnl.Location = new System.Drawing.Point(3, 3);
                progpnl.Name = "panel1";
                progpnl.Size = new System.Drawing.Size(280, 61);
                progpnl.TabIndex = 50;
                //progpnl.DoubleClick += new System.EventHandler(Open_Disk(progpnl));

               


                flowLayoutPanel1.Controls.Add(progpnl);
            }
            catch (Exception ex) { }
            

            


        }
       
       
        private void Open_Disk(object sender, EventHandler e)
        {
            Process.Start("explorer");
        }

       
    }
}
