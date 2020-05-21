using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement.Models.Reporting
{
    class ReportingModel
    {

		public static string appName, prevvalue;
		public static Stack applnames;
		public static Hashtable applhash;
		public static DateTime applfocustime;
		public static string appltitle;
		public static Form1 form1;
		public static string tempstr;
		public TimeSpan applfocusinterval;
		public DateTime logintime;
		private string SaveandShowDetails()
		{
			//This is used to save contents of hashtable in a xml file....

			try
			{
				TestFocusedChanged();

				IDictionaryEnumerator en = applhash.GetEnumerator();

				while (en.MoveNext())

					if (!en.Value.ToString().Trim().StartsWith("0"))
					{

						string processname = en.Key.ToString().Trim().Substring(0, en.Key.ToString().Trim().LastIndexOf("$$$!!!")).Trim();
						processname = processname.Replace("\0", "");


						string applname = en.Key.ToString().Trim().Substring(en.Key.ToString().Trim().LastIndexOf("$$$!!!") + 6).Trim();

						Convert.ToInt32((Convert.ToDouble(en.Value)));

						//SqlConnection conDatabase = new SqlConnection(@"Data Source=WINDOWS-SVB0N4R\JONEL;Initial Catalog=KeyLogger;Integrated Security=True");
						try
						{
							//SqlCommand cmd = conDatabase.CreateCommand();
							//cmd.CommandType = CommandType.StoredProcedure;
							//cmd.CommandText = "insertLogs";
							//cmd.Parameters.AddWithValue("@ApplDetails_Application_Info_ProcessName", processname);
							//cmd.Parameters.AddWithValue("@ApplDetails_Application_Info_ApplicationName", applname);
							//cmd.Parameters.AddWithValue("@ApplDetails_Application_Info_TotalSeconds", en.Value);






							//conDatabase.Open();
							//cmd.ExecuteNonQuery();
							//conDatabase.Close();
						}
						catch (Exception ex)
						{
							return ex.Message;
						}
					}
				return "Ok";
			}




			catch (Exception ex)
			{
				return ex.Message;
			}
		}

		private bool TestFocusedChanged()
		{
			//This is used to handle hashtable,if its length is 1.It means number of active applications is only one....
			try
			{
				if (applhash.Count == 1)
				{
					IDictionaryEnumerator en = applhash.GetEnumerator();
					applfocusinterval = DateTime.Now.Subtract(applfocustime);

					while (en.MoveNext())
					{
						if (en.Key.ToString() == appltitle + "$$$!!!" + appName)
						{
							applhash.Remove(appltitle + "$$$!!!" + appName);
							applhash.Add(appltitle + "$$$!!!" + appName, applfocusinterval.TotalSeconds);
							break;
						}
					}
				}
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}
