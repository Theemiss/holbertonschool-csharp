using System;
using System.Collections.Generic;

class Dictionary
{
   public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key){
       try
       {
           myDict.Remove(key);
       }
       catch (System.Exception)
       {
            return(myDict);
       }
       return myDict;
   }
}