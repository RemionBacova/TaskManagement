using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement.Models.Reporting
{
	class ReportingModel
	{

		private static string appName, prevvalue;
		private static Stack applnames;
		private static Hashtable applhash;
		private static DateTime applfocustime;
		private static string appltitle;
		private static Form1 form1;
		private static string tempstr;
		private TimeSpan applfocusinterval;
		private DateTime logintime;
		private static string processname;
		private static string applname;
		




			public string SaveandShowDetails()
			{
				

				try
				{
					TestFocusedChanged();

					IDictionaryEnumerator en = applhash.GetEnumerator();

					while (en.MoveNext())

						if (!en.Value.ToString().Trim().StartsWith("0"))
						{

							processname = en.Key.ToString().Trim().Substring(0, en.Key.ToString().Trim().LastIndexOf("$$$!!!")).Trim();
							processname = processname.Replace("\0", "");


							applname = en.Key.ToString().Trim().Substring(en.Key.ToString().Trim().LastIndexOf("$$$!!!") + 6).Trim();

							Convert.ToInt32((Convert.ToDouble(en.Value)));


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
