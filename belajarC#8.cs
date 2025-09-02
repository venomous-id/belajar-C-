using System;
class P4
{
    static void Main(string[] args)
    {
        string merk, warna;
        int CC;
        Console.WriteLine("merk motor yang ingin di beli= ");
        merk = Convert.ToString(Console.ReadLine());
        Console.WriteLine("warna motor yang ingin dibeli= ");
        warna = Convert.ToString(Console.ReadLine());
        Console.WriteLine("CC motor yang ingin dibeli");
        CC = Convert.ToInt32(Console.ReadLine());
        if (merk == "honda" & warna == "biru" &  CC == 110)
        {
            Console.WriteLine("jadi beli");
        }
        else
        {
            Console.WriteLine("cancel");
        }
    }
}