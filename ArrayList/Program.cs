using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // ArrayList demo
        ArrayList list = new ArrayList();
        list.Add(1);
        list.Add("abc");

        Console.WriteLine("\nArrayList: ");
        foreach (object i in list)
        {
            Console.Write(i + " - ");
        }

        // HashTable demo
        Hashtable hshtb = new Hashtable();
        // Each element has key and value, key can not be duplicate
        hshtb.Add(1, "abc");
        hshtb.Add(5, 2332);
        hshtb.Add(0, "fdif");
        hshtb.Add(4, "xji");

        Console.WriteLine("\n\nHashtable: ");
        foreach (DictionaryEntry i in hshtb)
        {
            Console.WriteLine(i.Key + " : " + i.Value);
        }

        // SortedList demo
        SortedList srtLst = new SortedList();
        srtLst.Add(1, "abc");
        srtLst.Add(5, 2332);
        srtLst.Add(0, "fdif");
        srtLst.Add(4, "xji");

        Console.WriteLine("\n\nSorted List: ");
        foreach (DictionaryEntry i in srtLst)
        {
            Console.WriteLine(i.Key + " : " + i.Value);
        }
        Console.WriteLine($"\nValue of Key '1' is {0}", srtLst[1]);
    }
}