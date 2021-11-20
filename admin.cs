using System;
using System.Diagnostics;

namespace admin_center
{
    public class Admin : Commands
    {
        public void CleanShadows()
        {
            string commmand_str = " /c vssadmin delete shadows /all /quiet & pause";
            try
            {
                Process.Start("cmd.exe", commmand_str);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Run(string command)
        {
            try
            {
                Process.Start(command);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}