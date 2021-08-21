using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string maxK = "None";
        int max = int.MinValue; ;
        foreach (KeyValuePair<string, int> item in myList)
        {
            if (max < item.Value)
            {
                max = item.Value;
                maxK = item.Key;
            }
        }
        return maxK;
    }
}

