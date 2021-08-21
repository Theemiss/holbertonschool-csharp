using System;
using System.Collections.Generic;
class List
{
    public static List<bool> DivisibleBy2(List<int> myList){
        var myList1 = new  List<bool>();
        foreach (var item in myList)
        {
            if (item % 2 == 0)
                myList1.Add(true);
            else
                myList1.Add(false);
        }
        return myList1;
    }
}