using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.Models;
using TaskManagement.Models.MachineID;
using TaskManagement.Models.Reporting;
using WebApiTaskManagement.Models;

namespace TaskManagement
{
    public partial class Form1 : Form
    {
        Machines p;
        ReportingModel q; 

        public Form1()
        {
            InitializeComponent();
            p = new Machines();
            q = new ReportingModel();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            GetMachineData();
            timer1.Start();
        }


        private async void GetMachineData()
        {
            #region code

            p.MachineName = Environment.MachineName;
            p.Osversion = Environment.MachineName;
            p.UserDomainName = Environment.UserDomainName;
            p.UserName = Environment.UserName;
            p.Version = Environment.Version.ToString();
            p.MachineHash = MachineIdModel.GetFingerPrint();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5001/index.html");
                var mashi = JsonConvert.SerializeObject(p);
                var content = new StringContent(mashi, Encoding.UTF8, "application/json");
                var result = await client.PostAsync("api/Machines", content);
            }
            #endregion

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            q.SaveandShowDetails();
        }
    }
}

