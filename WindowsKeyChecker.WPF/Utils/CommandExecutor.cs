using System;
using System.Diagnostics;

namespace WindowsKeyChecker.WPF.Utils
{
    public static class CommandExecutor
    {
        public static string RunCommand(string arguments)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "cscript.exe";
                process.StartInfo.Arguments = $"//Nologo C:\\Windows\\System32\\slmgr.vbs {arguments}";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                return !string.IsNullOrEmpty(output) ? output : error;
            }
            catch (Exception ex)
            {
                return $"Error ejecutando el comando: {ex.Message}";
            }
        }
    }
}
