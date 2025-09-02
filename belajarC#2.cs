using System;
using System.Runtime.InteropServices;
namespace tugas;
class Program
{
    static void Main(string[] args)
    {
        int[] arrayA = new int [5];
        int[] arrayB = new int [5];
        int[] arrayC = new int [5];
        for (int i = 0; i <= 4; i++)
        {
            Console.WriteLine($"Masukkan nilai untuk arrayA{i}: ");
            arrayA[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i <= 4; i++)
        {
            Console.WriteLine($"Masukkan nilai untuk arrayB{i}: ");
            arrayB[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("\nHasil arrayC: ");
        for (int i = 0;i <= 4; i++)
        {
            arrayC[i] = arrayA[i] + arrayB[i];
            Console.Write("{0}", arrayC[i]);
        }
    }
}