using System;
using System.Collections.Generic;
using System.Linq;
class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict){
       var newMyDict = myDict.OrderBy(i => i.Key);
        foreach (var item in newMyDict)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}