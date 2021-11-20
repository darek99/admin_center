using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace admin_center
{
    public class AdminCenter : AdminCenterBase
    {
        public static void CleanShadows()
        {
            string commmand_str = " /c vssadmin delete shadows /all /quiet & pause";
            try
            {
                Process.Start("cmd.exe", commmand_str);
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        public static void RunCommand(string command)
        {
            try
            {
                Process.Start(command);
            }
            catch (Exception e) { _ = MessageBox.Show(e.Message); }
        }
    }
}