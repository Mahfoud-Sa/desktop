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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("not process");
            }
            else
            {

                try
                {
                    string item = textBox1.Text;
                    Process.Start(Convert.ToString(item));
                    loade1();
                }
                catch
                {
                    MessageBox.Show("error process name");
                    textBox1.Clear();
                }

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            loade1();
            
            
        }

        private void loade1()
        {
            Process[] p = Process.GetProcesses();
            listBox1.Items.Clear();
            foreach (Process p1 in p)
            {
                listBox1.Items.Add(p1.ProcessName);
            }
            //MessageBox.Show(listBox1.Items.Count.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            for (int i = 0 ; i < listBox1.Items.Count - 1; i++)
            {
                if (listBox1.Items[i].ToString().Contains(textBox1.Text))
                {
                    listBox1.SetSelected(i, true);

                }

            }
            
            string item = listBox1.SelectedItem.ToString();
            foreach (Process p in Process.GetProcessesByName(item))
            {
                p.Kill();
            }

            loade1();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
