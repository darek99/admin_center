using System;
using System.Diagnostics;
using System.Windows.Forms;



namespace admin_center
{
    public class AdminCenter
    {
        public const string CLEANMGR = "CLEANMGR.exe";
        public const string EVENTVWR = "EVENTVWR.MSC";
        public const string TASKSCHD = "TASKSCHD.MSC";
        public const string MSCONFIG = "MSCONFIG.EXE";
        public const string WBADMIN = "WBADMIN.MSC";
        public const string APPWIZ = "APPWIZ.CPL";
        public const string UPDATE = "https://drive.google.com/drive/folders/1-RFHxjVz8aULLFbp4CYP1VcgUGM6Pc0p?usp=sharing";
        public const string UPDATE2 = "https://app.box.com/s/oxfhptwr9lqx6nop5y1e852etkr1z3pg";
        public AdminCenter()
        {
        }

        public static void RunCommand(string command)
        {
            try
            {
                Process.Start(command);
            }
            catch (Exception e) { _ = MessageBox.Show(e.Message); }
        }

        public static void CleanShadows()
        {
            string commmand_str = " /c vssadmin delete shadows /all /quiet & pause";
            try
            {
                Process.Start("cmd.exe", commmand_str);
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
    }
}
