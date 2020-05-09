using System;
using System.IO;

namespace FileCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw;
            string language = string.Empty;
            int count = Enum.GetNames(typeof(Language)).Length;

            for (int i = 0; i < count; i++)
            {
                language = Enum.GetValues(typeof(Language)).GetValue(i).ToString();
                Console.WriteLine(language);
                Directory.CreateDirectory(@"C:\Temp\Languages");
                Directory.CreateDirectory(@"C:\Temp\Languages\" + language);
                sw = new StreamWriter(@"C:\Temp\Languages\" + language + "\\log.txt");
                sw.WriteLine("File no " + i + "created on "+ DateTime.Now);
                sw.Close();
            }
        }
    }

    enum Language
    {
        Arabic,
        Armenian,
        Chinese,
        Dutch,
        English,
        German,
        Japanese,
        Korean,
        Spanish,
        Vietnamese
    }
}
