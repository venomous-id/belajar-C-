using System;
namespace tugas;
class Program
{
    static void Main(string[] args)
    {
        int[] bilangan = new int[100];
        int indexArray = 0;
        int jumlah = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 5 == 0 && i % 2 !=0)
            {
                bilangan[indexArray++] = i;
                jumlah += i;
            }
        }
        double ratarata = (double)jumlah / indexArray;
        Console.WriteLine($"Rata-rata deret bilangan yang habis dibagi 5 adalah {ratarata}");
    }
}