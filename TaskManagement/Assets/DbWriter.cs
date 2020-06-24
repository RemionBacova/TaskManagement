using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TaskManagement.Models;
namespace TaskManagement.Assets
{
    class DbWriter
    {  

        //Get Unique ID for Session
        string guid = "";
         public DbWriter ()
        {
             guid = Guid.NewGuid().ToString();
        }
        public void WriteMachine(Functions m)
        {
            //Insert Directly to DB
            SqlConnection conDatabase = new SqlConnection(@"Data Source=WINDOWS-SVB0N4R\JONEL;Initial Catalog=TaskManagement;Integrated Security=True");
            try
            {  //insert to db machine data
                SqlCommand cmd = conDatabase.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spi_tbl_Machines";
                cmd.Parameters.AddWithValue("@MachineName", m.MachineName);
                cmd.Parameters.AddWithValue("@OsVersion", m.Osversion);
                cmd.Parameters.AddWithValue("@UserDomainName", m.UserDomainName);
                cmd.Parameters.AddWithValue("@UserName", m.UserName);
                cmd.Parameters.AddWithValue("@Version", m.Version);
                cmd.Parameters.AddWithValue("@MachineHash", m.MachineHash);
                conDatabase.Open();
                cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public string processname;
        public string applname;
        public int time;

        public void WriteMachineReporting(Functions mr)
        {
            //Insert Directly to DB

            try
            {


                SqlConnection conDatabase = new SqlConnection(@"Data Source=WINDOWS-SVB0N4R\JONEL;Initial Catalog=TaskManagement;Integrated Security=True");
               

                IDictionaryEnumerator en = mr.applhash.GetEnumerator();

                while (en.MoveNext())
                {
                    if (!en.Value.ToString().Trim().StartsWith("0"))
                    {

                        processname = en.Key.ToString().Trim().Substring(0, en.Key.ToString().Trim().LastIndexOf("$$$!!!")).Trim();
                        processname = processname.Replace("\0", "");


                        applname = en.Key.ToString().Trim().Substring(en.Key.ToString().Trim().LastIndexOf("$$$!!!") + 6).Trim();

                        time = Convert.ToInt32((Convert.ToDouble(en.Value)));
            
                        SqlCommand cmi = conDatabase.CreateCommand();
                        cmi.CommandType = CommandType.StoredProcedure;
                        cmi.CommandText = "spi_tbl_MachineReporting";

                        conDatabase.Open();

                        cmi.Parameters.AddWithValue("@ProcessName", processname);
                        cmi.Parameters.AddWithValue("@ApplicationName", applname);
                        cmi.Parameters.AddWithValue("@TotalSecond", time);
                        cmi.Parameters.AddWithValue("@MachineHash", mr.fingerPrint);
                        cmi.Parameters.AddWithValue("@SessionID", guid);
                        cmi.ExecuteScalar();
                        conDatabase.Close();
                    }
                }





      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
