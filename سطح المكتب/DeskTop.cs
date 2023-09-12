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
using System.Runtime.InteropServices;
using System.IO;



namespace سطح_المكتب
{
    public partial class DeskTop : Form
    {
        //fields
        ThisPc Pc;
        Color HoverColor = Color.FromArgb(50, 255, 255, 255);
        List<string> prog_name;
        string[] ProgDir;
        Bitmap background = new Bitmap(سطح_المكتب.Properties.Resources.bg_2);
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        public DeskTop()
        {
            string[] exedir = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "*.*", SearchOption.AllDirectories);

            InitializeComponent();
            ProgDir = new string[] {  @"C:\Program Files\Mozilla Firefox\firefox.exe",
                                      @"C:\Program Files\JetBrains\PyCharm Community Edition 2020.2.1\bin\pycharm64.exe",
                                      @"C:\Program Files\CCleaner\CCleaner.exe",
                                      @"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\devenv.exe",
                                      @"C:\Program Files (x86)\Microsoft SQL Server\140\Tools\Binn\ManagementStudio\Ssms.exe",
                                      @"C:\Program Files\Adobe\Adobe Photoshop 2020\Photoshop.exe",
                                      @"C:\Program Files (x86)\Microsoft Office\root\Office16\WINWORD.EXE",
                                      @"C:\Program Files\WinRAR\WinRAR.exe",
                                      @"C:\Program Files (x86)\Microsoft Office\root\Office16\POWERPNT.EXE",
                                      @"C:\Program Files (x86)\Microsoft Office\root\Office16\MSACCESS.EXE" };
            prog_name = new List<string> { };
            GetPrgsName();
            InitializePrograms();
            InitializeStartMenuPrograms();
            explorer_lbl.Text = Environment.UserName.ToString();
            label27.Text = Environment.UserName.ToString();
            BackgroundImage = background;


        }


        private void InitializePrograms()
        {
            for (int i = 0; i < ProgDir.Length; i++)
            {
                Prog p1 = new Prog($"{ProgDir[i]}", Centeralizion, HOVER, LEAVE, Start_Pro, contextMenuStrip2);//C:\\Program Files (x86)\\Microsoft Office\root\\Office16\\POWERPNT.EXE", "PowerPoint");
                p1.InitializeProg(flowLayoutPanel9);

            }

        }
        private void InitializeStartMenuPrograms()
        {
            for (int i = 0; i < ProgDir.Length; i++)
            {
                Prog p1 = new Prog($"{ProgDir[i]}", Centeralizion, SProg_h, LEAVE, Start_Pro, contextMenuStrip2, false);//C:\\Program Files (x86)\\Microsoft Office\root\\Office16\\POWERPNT.EXE", "PowerPoint");
                p1.InitializeProg(flowLayoutPanel1);

            }

        }
        private void CreMenProg(string progname)
        {


            Icon icon = Icon.ExtractAssociatedIcon(ProgDir[1]);
            //
            Panel progpnl = new Panel();
            progpnl.Size = new Size(65, 51);
            progpnl.Name = prog_name + "_pn";
            progpnl.Paint += new PaintEventHandler(Centeralizion);
            //progpnl.BackColor = HoverColor;
            progpnl.MouseLeave += new EventHandler(LEAVE);
            progpnl.MouseHover += new EventHandler(HOVER);
            //progpnl.DoubleClick += new EventHandler(Start_Pro);

            //
            PictureBox prog_icon = new PictureBox();
            prog_icon.BackgroundImage = icon.ToBitmap();
            prog_icon.SizeMode = PictureBoxSizeMode.AutoSize;
            prog_icon.Name = prog_icon + "_ico";
            prog_icon.Size = new Size(32, 32);
            prog_icon.Location = new Point(3, 3);
            prog_icon.MouseLeave += new EventHandler(LEAVE);
            prog_icon.MouseHover += new EventHandler(HOVER);
            //prog_icon.DoubleClick += new EventHandler(Start_Pro);
            //
            progpnl.Controls.Add(prog_icon);
            //progpnl.Controls.Add(prog_lbl);

            flowLayoutPanel7.Controls.Add(progpnl);

        }

        private void GetPrgsName()
        {
            foreach (string path in ProgDir)
            {
                //string path = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                string[] temp = path.Split('\\');
                string exe = temp[temp.Length - 1].Split('.')[0];
                prog_name.Add(exe);
            }


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString("HH:mm:tt ") + "\n" + DateTime.Now.ToString("d:mmmm:yyyy");

        }


        //Buttons
        private void startmenu(object sender, EventArgs e)
        {
            Start_Menu.Visible = false;
            SeaechPnl.Visible = false;
            Hidden_Icons.Visible = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {

            Start_Menu.Visible = !Start_Menu.Visible;

        }
        private void Rstart_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 0");
        }
        private void Sleep_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Suspend, true, true);
        }
        private void Hidden_Icons_Click(object sender, EventArgs e)
        {
            Hidden_Icons.Visible = !Hidden_Icons.Visible;
        }
        private void PowePnl_Click(object sender, EventArgs e)
        {
            PowePnl.Visible = !PowePnl.Visible;

        }


        //Hover_Leave Events


        private void Resize_panel(object sender, EventArgs e)
        {
            Start_Menu.SplitterDistance = 200;

        }
        private void LEAVE(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.Transparent;
        }
        private void HOVER(object sender, EventArgs e)
        {
            if (((Control)sender) is SplitContainer)
                return;
            if (((Control)sender) is Panel)
                ((Control)sender).BackColor = HoverColor;
            else
                ((Control)sender).Parent.BackColor = HoverColor;

        }
        private void power_h(object sender, EventArgs e)
        {
            this.HOVER(sender, e);
            Start_Menu.SplitterDistance = 200;

        }






        //Other

        private void open_setting(object sender, EventArgs e)
        {
            Process.Start("Setting");

        }
        private void Start_Pro(object sender, EventArgs e)
        {

            string ClicNA = ((Control)sender).Name;
            string ContNa = ClicNA.Split('_')[0];

            Process.Start(ContNa);
        }
        private void Search_click(object sender, EventArgs e)
        {
            SeaechPnl.Visible = !SeaechPnl.Visible;
            flowLayoutPanel10.Controls.Clear();
            SearchBox.Clear();
            SearchBox.Focus();


        }
        private void Search_Enter(object sender, KeyEventArgs e)
        {
            string prog = SearchBox.Text;
            flowLayoutPanel10.Controls.Clear();
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < prog_name.Count; i++)
                {
                    if (prog_name[i].StartsWith(prog))
                    {
                        Prog p1 = new Prog($"{ProgDir[i]}", Centeralizion, HOVER, LEAVE, Start_Pro, contextMenuStrip2, false);
                        p1.InitializeProg(flowLayoutPanel10);

                    }
                }
            }

        }
        private void start_click(object sender, EventArgs e)
        {
            Start_Menu.SplitterDistance = 45;
            Start_Menu.Visible = !Start_Menu.Visible;
        }
        private void Power_Off(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 1");
        }
        private void Resta_click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 0");

        }
        private void Pict_click(object sender, EventArgs e)
        {
            Process.Start("explorer", Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
        }
        private void GID_click(object sender, EventArgs e)
        {
            Process.Start("explorer");

        }
        private void SProg_h(object sender, EventArgs e)
        {
            HOVER(sender, e);
            Start_Menu.SplitterDistance = 45;
        }
        private void Net_click(object sender, EventArgs e)
        {
            Process.Start("explorer", Environment.GetFolderPath(Environment.SpecialFolder.NetworkShortcuts));

        }
        private void ORbin(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "shell:RecycleBinFolder");


        }
        private void open_pc(object sender, EventArgs e)
        {
            Process.Start("explorer", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }
        private void Centeralizion(object sender, PaintEventArgs e)
        {
            foreach (Control c in ((Panel)sender).Controls)
            {
                c.Location = new Point((((Panel)sender).Width - c.Width) / 2, c.Location.Y);
            }
        }



        //Click Menu
        private void ChangeBG(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                background = new Bitmap(openFileDialog1.OpenFile());
                this.BackgroundImage = new Bitmap(openFileDialog1.OpenFile());
            }
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        private void Menu_Act(object sender, EventArgs e)
        {
            string ClicNA = contextMenuStrip2.SourceControl.Name;
            string ContNa = ClicNA.Split('_')[0];
            Process.Start(ContNa);
        }
        private void openFileLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ClicNA = contextMenuStrip2.SourceControl.Name;
            string ContNa = ClicNA.Split('_')[0];
            Process.Start("explorer", Path.GetFullPath(ContNa));
        }
        private void Delete(object sender, EventArgs e)
        {

            if (contextMenuStrip2.SourceControl is Panel)
                contextMenuStrip2.SourceControl.Visible = false;
            else
                contextMenuStrip2.SourceControl.Parent.Visible = false;

        }







        private void Open_Pc(object sender, EventArgs e)
        {
            Pc = new ThisPc();

            Pc.Show();
        }

        private void OpenTask(object sender, EventArgs e)
        {
            TaskManager t1 = new TaskManager();
            t1.Show();
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
