using System;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArrayOne = new int[3][];
            jaggedArrayOne[0] = new int[5] { 0, 1, 2, 3, 4 };
            jaggedArrayOne[1] = new int[2] { 10, 20};
            jaggedArrayOne[2] = new int[3] { 1, 3, 5 };

            int[][] jaggedArrayTwo =
            {
                new int[] {0,1,2,3},
                new int[] {10,20,30,40,50}
            };

            for (int i = 0; i < jaggedArrayTwo.Length; i++)
            {
                Console.WriteLine("Now accessing array number "+i);
                for (int j = 0; j < jaggedArrayTwo[i].Length; j++)
                {
                    Console.WriteLine(jaggedArrayTwo[i][j]);
                }
            }
            Console.WriteLine();
        }
    }
}
