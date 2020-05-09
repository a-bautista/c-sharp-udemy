using System;

namespace _19_AdvancedClassParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopThrouhArray(new string[4] {"S.Korea","United States", "Mexico", "Canada"});
            Console.WriteLine();
            LoopThrouhArray("Alejandro", "Orlando", "Yesenia");
        }

        public static void LoopThrouhArray(params string[] names) // PARAMS allow us to define an input array of any length
        {
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
