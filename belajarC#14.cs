using System;
class P5
{
    static void Main(string[] args)
    {
        char huruf;
        Console.WriteLine("masukkan huruf a,b,c,d");
        huruf= Convert.ToChar(Console.ReadLine());
        switch (huruf)
        {
            case 'a':
                Console.WriteLine("huruf is a");
                break;
            case 'b':
                Console.WriteLine("huruf is b");
                break;
            case 'c':
                Console.WriteLine("huruf is c");
                break;
            case 'd':
                Console.WriteLine("huruf is d");
                break;
        }
        Console.ReadLine();
    }
}