using System;
using System.Collections;
using System.Diagnostics;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace TaskManagement.Models
{
    class Functions
    {

        #region Variables
        // Variables
        public  string appName, prevvalue;
        public  Stack applnames;
        public Hashtable applhash;
        public  DateTime applfocustime;
        public  string appltitle;
        public  TimeSpan applfocusinterval;
        // Variables of Machine
        public string MachineName;
        public string Osversion;
        public string UserDomainName;
        public string UserName;
        public string Version;
        public string MachineHash;
        //Variables of MachineReporting
        public string ApplicationName;
        public string ProcessName;
        public int TotalSeconds;
        public string GUID;
        public Functions()
        {
            applhash = new Hashtable();
            applnames = new Stack();
            applhash = new Hashtable();
        }
        #endregion

        #region GetMachineHash
      



        // Get MachineHash
        public string fingerPrint = string.Empty;
     

        public string GetFingerPrint()
        {
            try
            {
                if (string.IsNullOrEmpty(fingerPrint))
                {
                    fingerPrint = GetHash(GetCPUID() + GetHDDUID());
                }
                return fingerPrint;
            }
            catch (Exception ex)
            {
                return "Error GetFingerPrint" + ex.ToString();
            }
        }

        private  string GetHash(string s)
        {
            MD5 sec = new MD5CryptoServiceProvider();
            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] bt = enc.GetBytes(s);
            return GetHexString(sec.ComputeHash(bt));
        }

        private  string GetHexString(byte[] bt)
        {
            string s = string.Empty;
            for (int i = 0; i < bt.Length; i++)
            {
                byte b = bt[i];
                int n, n1, n2;
                n = (int)b;
                n1 = n & 15;
                n2 = (n >> 4) & 15;
                if (n2 > 9)
                    s += ((char)(n2 - 10 + (int)'A')).ToString();
                else
                    s += n2.ToString();
                if (n1 > 9)
                    s += ((char)(n1 - 10 + (int)'A')).ToString();
                else
                    s += n1.ToString();
                if ((i + 1) != bt.Length && (i + 1) % 2 == 0) s += "-";
            }
            return s;
        }

        private  string GetCPUID()
        {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                if (cpuInfo == "")
                {
                    //Get only the first CPU's ID
                    cpuInfo = mo.Properties["processorID"].Value.ToString();
                    break;
                }
            }
            return cpuInfo;
        }

        private  string GetHDDUID()
        {
            var logicalDiskId = "C:";
            var deviceId = string.Empty;

            var query = "ASSOCIATORS OF {Win32_LogicalDisk.DeviceID='" + logicalDiskId + "'} WHERE AssocClass = Win32_LogicalDiskToPartition";
            var queryResults = new ManagementObjectSearcher(query);
            var partitions = queryResults.Get();

            foreach (var partition in partitions)
            {
                query = "ASSOCIATORS OF {Win32_DiskPartition.DeviceID='" + partition["DeviceID"] + "'} WHERE AssocClass = Win32_DiskDriveToDiskPartition";
                queryResults = new ManagementObjectSearcher(query);
                var drives = queryResults.Get();

                foreach (var drive in drives)
                    deviceId = drive["DeviceID"].ToString();
            }
            return deviceId;
        }


        #endregion

        #region Windows API Functions Declarations
        //This Function is used to get Active Window Title...
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        public static extern int GetWindowText(IntPtr hwnd, string lpString, int cch);

        //This Function is used to get Handle for Active Window...
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern IntPtr GetForegroundWindow();

        //This Function is used to get Active process ID...
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern Int32 GetWindowThreadProcessId(IntPtr hWnd, out Int32 lpdwProcessId);
        #endregion

        #region User-defined Functions
        public  Int32 GetWindowProcessID(IntPtr hwnd)
        {
            //This Function is used to get Active process ID...
            Int32 pid;
            GetWindowThreadProcessId(hwnd, out pid);
            return pid;
        }
        public   IntPtr getforegroundWindow()
        {
            //This method is used to get Handle for Active Window using GetForegroundWindow() method present in user32.dll
            return GetForegroundWindow();
        }
        public  string ActiveApplTitle()
        {
            //This method is used to get active application's title using GetWindowText() method present in user32.dll
            IntPtr hwnd = getforegroundWindow();
            if (hwnd.Equals(IntPtr.Zero)) return "";
            string lpText = new string((char)0, 100);
            int intLength = GetWindowText(hwnd, lpText, lpText.Length);
            if ((intLength <= 0) || (intLength > lpText.Length)) return "unknown";
            return lpText.Trim();
        }
        #endregion

        #region GetActivityData
        public void SaveInHASH()
        {
            try
            {
                bool isNewAppl = false;
                IntPtr hwnd = getforegroundWindow();
                Int32 pid = GetWindowProcessID(hwnd);
                Process p = Process.GetProcessById(pid);
                appName = p.ProcessName;
                appltitle = ActiveApplTitle().Trim().Replace("\0", "");
                if (!applnames.Contains(appltitle + "$$$!!!" + appName))
                {
                    applnames.Push(appltitle + "$$$!!!" + appName);
                    applhash.Add(appltitle + "$$$!!!" + appName, 0);
                    isNewAppl = true;
                }
                if (prevvalue != (appltitle + "$$$!!!" + appName))
                {
                    IDictionaryEnumerator en = applhash.GetEnumerator();
                    applfocusinterval = DateTime.Now.Subtract(applfocustime);
                    while (en.MoveNext())
                    {
                        if (en.Key.ToString() == prevvalue)
                        {
                            double prevseconds = Convert.ToDouble(en.Value);
                            applhash.Remove(prevvalue);
                            applhash.Add(prevvalue, (applfocusinterval.TotalSeconds + prevseconds));
                            break;
                        }
                    }
                    prevvalue = appltitle + "$$$!!!" + appName;
                    applfocustime = DateTime.Now;
                }
                if (isNewAppl)
                    applfocustime = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ":" + ex.StackTrace);
            }
        }

        //public string SaveandShowDetails()
        //{


        //    try
        //    {


        //        IDictionaryEnumerator en = applhash.GetEnumerator();

        //        while (en.MoveNext())

        //            if (!en.Value.ToString().Trim().StartsWith("0"))
        //            {

        //                  processname = en.Key.ToString().Trim().Substring(0, en.Key.ToString().Trim().LastIndexOf("$$$!!!")).Trim();
        //                processname = processname.Replace("\0", "");


        //                applname = en.Key.ToString().Trim().Substring(en.Key.ToString().Trim().LastIndexOf("$$$!!!") + 6).Trim();

        //                  time = Convert.ToInt32((Convert.ToDouble(en.Value)));


        //            }
        //        return "Ok";
        //    }




        //    catch (Exception ex)
        //    {
        //        return ex.Message;
        //    }

        //}



        public bool TestFocusedChanged()
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

        #endregion

        #region GetMachineData 
        public void GetMachineData()
        {
             
       //Get machine data from environment

             MachineName = Environment.MachineName;
            Osversion = Environment.MachineName;
            UserDomainName = Environment.UserDomainName;
            UserName = Environment.UserName;
            Version = Environment.Version.ToString();
            MachineHash = GetFingerPrint();
           

        }
        #endregion
    }

}
