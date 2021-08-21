using System;

    public class Number
    {
        public static int PrintLastDigit(int number)
        {
            int l = number % 10;
            Console.Write(l < 0 ? l * -1 : l);
            return ((l < 0) ? l * -1 : l);
        }
    }
