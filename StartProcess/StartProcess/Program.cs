using System;
using System.Diagnostics;

namespace StartProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start("Notepad.exe");

            System.IO.File.WriteAllText(@"C:\TEMP\cSharpTestIO\notepadexercise.txt","hello from the notepad exercise");
            //Process.Start(@"C:\TEMP\cSharpTestIO\notepadexercise.txt");

            Process[] notepads = Process.GetProcessesByName("notepad");
            foreach (var process in notepads)
            {
                process.Kill();
            }
        }
    }
}
