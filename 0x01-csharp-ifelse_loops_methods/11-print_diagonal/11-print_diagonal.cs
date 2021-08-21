using System;
class Line
{
    public static void PrintDiagonal(int length){
     
            for(int i=0 ; i< length;i++)
            {
                Console.Write(new String(' ',i));
                Console.Write("\\\n");
            }

        
        Console.Write("\n");


    }


}
