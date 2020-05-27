using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

using TaskManagement.Models;

namespace TaskManagement.Assets
{
    

    class WSwriter
    {
        //Generate Unique Session Code
        string guid = "";
  
        public WSwriter()
        {
            guid = Guid.NewGuid().ToString();
        }
        public async void WsMachine(Functions p)
        {
            
            //GetData-Machine
            p.MachineName = Environment.MachineName;
            p.Osversion = Environment.MachineName;
            p.UserDomainName = Environment.UserDomainName;
            p.UserName = Environment.UserName;
            p.Version = Environment.Version.ToString();
            p.MachineHash = p.GetFingerPrint();

            //Post to WebService
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5001/");
                var mashi = JsonConvert.SerializeObject(p);
                var content = new StringContent(mashi, Encoding.UTF8, "application/json");
                var result = await client.PostAsync("api/Machines", content);
            }
            

        }

        //Variables of MachineReporting
        public string processname;
        public string applname;
        public int time;


        public async void WsMachineRep(Functions q)
        {
            IDictionaryEnumerator en = q.applhash.GetEnumerator();

            while (en.MoveNext())
            {
                if (!en.Value.ToString().Trim().StartsWith("0"))
                {
                    //GetData-MachineReporting
                    processname = en.Key.ToString().Trim().Substring(0, en.Key.ToString().Trim().LastIndexOf("$$$!!!")).Trim();
                    processname = processname.Replace("\0", "");


                    applname = en.Key.ToString().Trim().Substring(en.Key.ToString().Trim().LastIndexOf("$$$!!!") + 6).Trim();

                    time = Convert.ToInt32((Convert.ToDouble(en.Value)));
                    
                    q.ApplicationName = applname;
                    q.ProcessName = processname;
                    q.TotalSeconds = time;
                    q.MachineHash = q.GetFingerPrint();
                    q.GUID = guid;

                    //Post to WebService
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("https://localhost:5001/");
                        var mashi = JsonConvert.SerializeObject(q);
                        var content = new StringContent(mashi, Encoding.UTF8, "application/json");
                        var result = await client.PostAsync("api/MachinesReporting", content);
                    }
                }
            }


          




        }
    }
    }
