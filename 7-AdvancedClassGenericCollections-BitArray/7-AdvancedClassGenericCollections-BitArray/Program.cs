using System;
using System.Collections;
using System.Collections.Generic;

namespace _7_AdvancedClassGenericCollections_BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] boolArray = new bool[4];
            boolArray[0] = false;
            boolArray[1] = false;
            boolArray[2] = false;
            boolArray[3] = true;

            BitArray firstArray = new BitArray(4);
            BitArray secondArray = new BitArray(boolArray);

            // setting value
            firstArray.Set(0, true);
            firstArray.Set(1, true);
            firstArray.Set(2, true);
            firstArray.Set(3, false);

            Console.WriteLine("Values modified for the first array:");
            foreach (var item in firstArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Values for the second array:");
            foreach (var item in secondArray)
            {
                Console.WriteLine(item);
            }

            // AND - OR - NOT
            BitArray resultAND = new BitArray(4);
            resultAND = firstArray.And(secondArray);
            Console.WriteLine("Display results of the AND:\n");
            foreach (var item in resultAND)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Results in the first array:");
            foreach (var item in firstArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Results in the second array:");
            foreach (var item in secondArray)
            {
                Console.WriteLine(item);
            }


            BitArray resultOR = new BitArray(4);
            resultOR = firstArray.Or(secondArray);
            Console.WriteLine("Display results of the OR:\n");
            foreach (var item in resultOR)
            {
                Console.WriteLine(item);
            }

        }
    }
}
