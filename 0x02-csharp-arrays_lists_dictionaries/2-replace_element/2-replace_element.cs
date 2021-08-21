using System;

class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n){
        int i;
        for (i=0;i < array.Length;i++){
            if (i == index)
            {
                array[i] = n;
                return (array);
            }
        }
        Console.WriteLine("Index out of range");
        return array;
    }
}
