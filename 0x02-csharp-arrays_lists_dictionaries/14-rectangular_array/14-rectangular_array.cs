using System;
using System.Text;
namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[6, 5];
            array2D[2, 2] = 1;
            int j = 0;
            var Message = new StringBuilder();
            foreach (var i in array2D)
            {
                if (j == 5)
                {
                    Console.WriteLine(Message);
                    Message.Clear();
                    j = 0;
                }
                Message.Append(i);
                if (j != 4)
                    Message.Append(" ");
                j += 1;
            }

        }
    }
}
