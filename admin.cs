using System;
using System.Diagnostics;

namespace admin_center
{
    public class Admin : Commands
    {
        public Action<Exception> ExceptionRaised;

        public void RunCommand(string command, bool cmd = false)
        {
            try
            {
                _ = !cmd ? Process.Start(command) : Process.Start("cmd.exe", command);
            }
            catch (Exception e)
            {
                ExceptionRaised(e);
            }
        }
    }
}