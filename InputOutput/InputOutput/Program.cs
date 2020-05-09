using System;
using System.IO;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Write 
            Directory.CreateDirectory(@"C:\TEMP\cSharpTestIO");
            string file = @"C:\TEMP\test.txt";

            StreamWriter sw = new StreamWriter(file); // this overwrites the lines
            // StreamWriter sw = new StreamWriter(file, new); // this appends the next lines
            sw.WriteLine("Orlando");
            sw.WriteLine("Ramos");
            sw.Close();
            #endregion

            #region Read
            System.IO.StreamReader sr = new System.IO.StreamReader(file);
            Console.WriteLine(sr.ReadToEnd());
            Console.WriteLine("File has been read in its entirety.");
            sr.Close();

            #endregion
        }
    }
}
