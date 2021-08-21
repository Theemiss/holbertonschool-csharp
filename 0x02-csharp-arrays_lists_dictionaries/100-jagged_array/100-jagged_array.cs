using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[][]
            {
                new int[] { 0, 1, 2, 3},
                new int[] { 0, 1, 2, 3, 4, 5, 6 },
                new int[] { 0, 1 }
            };
            int i,j;
            for (i = 0; i < jaggedArray.Length;i++){
                for (j = 0; j <jaggedArray[i].Length;j++){
                    if (j != jaggedArray[i].Length - 1)
                        Console.Write($"{jaggedArray[i][j]} ");
                    else
                        Console.WriteLine($"{jaggedArray[i][j]}");
                }
            }
        }
        
    }
}
