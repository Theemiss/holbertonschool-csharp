using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0,j = 1;
            while(i < 9){
                Console.Write($"{i}{j}");
                if (i == 8 && j == 9){
                    Console.WriteLine("");
                    j++;
                    i++;

                }
                else
                {
                    Console.Write(", ");
                }
                if(j < 9){
                    j++;
                }
                else
                {
                    i++;
                    j = i +1;
                }

            }
        }
    }
}
