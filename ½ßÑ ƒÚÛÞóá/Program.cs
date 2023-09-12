using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;


namespace سطح_المكتب
{
    class Prog
    {
        //fields
        string Path;
        string ProgName;
        string ExeName;
        string[] Nms;
        Size size;
        Point point;
        //Tool
        Panel progpnl;
        //Event
        PaintEventHandler Cen;
        EventHandler HO;
        EventHandler LE;
        EventHandler Stp;
        //ContextMenuStrip cont;
        public Prog(string Path,PaintEventHandler Cen, EventHandler HO, EventHandler LE, EventHandler Stp,ContextMenuStrip cont,bool name= true)
        {
            progpnl = new Panel();
            this.Path = Path;
            //ProgName = ProgName;
            
            string[] dirs = Path.Split('\\');
            string[] temp= dirs[dirs.Length - 1].Split('.');
            ExeName= temp[0];
            if (name)
            {
                Nms = new string[] { "_pnl", "_lbl", "_icon" };
                size = new Size(65, 51);
                point = new Point(34, 35);
                progpnl.Paint += new PaintEventHandler(Cen);
                progpnl.DoubleClick += new EventHandler(Stp);
                progpnl.ContextMenuStrip = cont;
            }
            else
            {
                Nms = new string[] { "_pn", "_lb", "_ico" };
                size = new Size(188, 37);
                point = new Point(63, 8);
                progpnl.Click+= new EventHandler(Stp);
            }
               

            //event
            
            this.HO = HO;
            this.LE = LE;
            this.Stp = Stp;


        }
        public void AddTo(object Panel)
        {

        }
       
        public void InitializeProg(Control Panel)
        {


            Icon icon = Icon.ExtractAssociatedIcon(Path);

            
            progpnl.Size = size;
            progpnl.Name = ExeName + Nms[0];
          
           
            progpnl.MouseLeave += new EventHandler(LE);
            progpnl.MouseHover += new EventHandler(HO);
            //progpnl.ContextMenuStrip = contextMenuStrip2;

           

            //
            PictureBox prog_icon = new PictureBox();
            prog_icon.BackgroundImage = icon.ToBitmap();
            prog_icon.SizeMode = PictureBoxSizeMode.AutoSize;
            prog_icon.Name = prog_icon + Nms[1];
            prog_icon.Size = new Size(32, 32);
            prog_icon.Location = new Point(3, 3);
            prog_icon.MouseLeave += new EventHandler(LE);
            prog_icon.MouseHover += new EventHandler(HO);
            prog_icon.DoubleClick += new EventHandler(Stp);



            // 
            Label prog_lbl = new Label();
            ///ForeColor = Color.White;
            prog_lbl.Name = ExeName + Nms[2];
            prog_lbl.Text = ExeName;
            prog_lbl.Width = prog_lbl.Text.Length * 7;
            prog_lbl.AutoSize = true;
            prog_lbl.ForeColor = Color.White;
          
            prog_lbl.Location =point;
            prog_lbl.MouseLeave += new EventHandler(LE);
            prog_lbl.MouseHover += new EventHandler(HO);
            prog_lbl.DoubleClick += new EventHandler(Stp);

            //
            progpnl.Controls.Add(prog_icon);
            progpnl.Controls.Add(prog_lbl);
            Panel.Controls.Add(progpnl);

            

        }

    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new DeskTop());
            

        }
    }
}
