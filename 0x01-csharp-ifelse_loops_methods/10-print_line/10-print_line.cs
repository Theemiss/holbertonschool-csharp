using System;

class Line 
{
    public static void PrintLine(int length){
        if (length <= 0){
            Console.WriteLine("");
        }
        else
        {
            string val = "";
            int i;
            for (i = 0; i<=length;i++)
            {
                val += "_";
            }
            
            Console.WriteLine(val);
        }
    }
}