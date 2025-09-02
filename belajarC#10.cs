using System;
using System.Reflection.Metadata.Ecma335;
class p7
{
    static void Main(string[] args)
    {
        int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19 };
        foreach (int angka in numbers)
        {
            Console.Write("" + angka);
        }
        Console.WriteLine();
        string[] towns = { "london", "milan", "paris", "new york" };
        foreach (string kota in towns)
        {
            Console.Write("" + kota);
        }
    }
}