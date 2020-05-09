using System;
using System.Reflection;
using System.Globalization;

namespace AssemblyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assemblyObject = Assembly.GetEntryAssembly();
            AssemblyName assemblyName = assemblyObject.GetName();

            Console.WriteLine(assemblyName.FullName);

            CultureInfo cultureInfo = new CultureInfo("de-DE");
            assemblyName.CultureInfo = cultureInfo;
            Console.WriteLine(assemblyName.CultureInfo.DisplayName);
            Console.WriteLine(assemblyName.CultureInfo.NativeName);
            Console.WriteLine(assemblyName.CultureInfo.NumberFormat.CurrencySymbol);

            assemblyName.Version = new Version(1,2,0,0);
            Console.WriteLine(assemblyName.Version);
        }

    }
}
