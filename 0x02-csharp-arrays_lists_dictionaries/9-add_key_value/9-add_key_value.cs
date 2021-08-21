using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {

        try
        {
            myDict.Add(key, value);
        }
        catch (ArgumentException)
        {
            myDict[key] = value;
        }
        return myDict;
    }
}