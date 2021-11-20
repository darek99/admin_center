using System;
using System.Diagnostics;

namespace admin_center
{
    public class Admin : Commands
    {
        public Process ExecuteCmdCommand(string command)
        {
            try
            {
                return Process.Start("cmd.exe", command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Process Runcommand(string command)
        {
            try
            {
                return Process.Start(command);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}