using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Abide");
            myDictionary.Add(2, "Bahar");
            myDictionary.Add(3, "Bayram");
            myDictionary.Add(4, "Burhan");

            myDictionary.ToList();

        }
    }
}
