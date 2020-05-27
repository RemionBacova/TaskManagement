using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection.PortableExecutable;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.Models;


namespace TaskManagement
{
    public partial class Form1 : Form
    {
        ThreadManager manager;

        public Form1()
        {
            InitializeComponent();
            this.manager = new ThreadManager();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //NotifyIcon
            ShowIcon = false;
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipText = "Application start running";
            notifyIcon1.BalloonTipTitle = " TASK MANAGEMENT | SITEL";
            notifyIcon1.ShowBalloonTip(100);
            this.Hide();
            //ButtonColor
           
            this.manager.ThreadManagerStart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            
            this.manager.ThreadManagetStop();
        }

        private void label8_Click(object sender, EventArgs e)
        {

            this.manager.Dispose();
            this.Close();
            this.Dispose();
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Double clicl to get windows in normal state
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
            this.Show();
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Crimson;
            button2.BackColor = Color.LightSkyBlue;
            button1.Text = "Running";
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.LightSkyBlue;
            button2.BackColor = Color.Crimson;
            button1.Text = "Start";
        }
    }
}

