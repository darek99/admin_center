using System;
using System.Diagnostics;

namespace admin_center
{
    public static class Commands
    {
        public static readonly string appwiz = "appwiz.cpl";
        public static readonly string cleanmgr = "cleanmgr.exe";
        public static readonly string cmd_run = "cmd.exe";
        public static readonly string compmgmt = "compmgmt.msc";
        public static readonly string diskmgmt = "diskmgmt.msc";
        public static readonly string eventvwr = "eventvwr.msc";
        public static readonly string firewall = "firewall.cpl";
        public static readonly string msconfig = "msconfig.exe";
        public static readonly string msinfo32 = "msinfo32.exe";
        public static readonly string taskschd = "taskschd.msc";
        public static readonly string wbadmin = "wbadmin.msc";

        public static readonly string wbadmin_delete =
            "/c wbadmin delete backup -keepversions:{0} && pause";

        public static readonly string wmic_list =
            " /c wmic useraccount get Disabled, Lockout, Name, PasswordChangeable, PasswordExpires, " +
            "PasswordRequired & pause";
    }

    public static class CommandExecute
    {
        public static Action<Exception> ExecuteException;

        public static void Execute(this string command, bool cmd = false)
        {
            try
            {
                _ = !cmd ? Process.Start(command) : Process.Start("cmd.exe", command);
            }
            catch (Exception e)
            {
                ExecuteException?.Invoke(e);
            }
        }
    }
}