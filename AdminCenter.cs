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

        public AdminCenter()
        {
        }

        public static void RunCommand(string command)
        {
            try
            {
                System.Diagnostics.Process.Start(command);
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
  
        public static void CleanShadows()
        {
            string commmand_str = " /c vssadmin delete shadows /all /quiet & pause";
            try
            {
                Process.Start("cmd.exe", commmand_str);
            }
            catch(Exception e) { MessageBox.Show(e.Message); }
        }
    }
}
