using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Masukkan tanggal lahir");
        string tanggallahir = Console.ReadLine();
        if (tanggallahir.Length != 8)
        {
            Console.WriteLine("tanggal lahir salah. transaksi dibatalkan");
            return;
        }
        Console.WriteLine("masukkan uang 5000 atau 10000");
        int uang = int.Parse(Console.ReadLine());
        if (uang == 5000)
        {
            Console.WriteLine("Selamat Datang di vending mesin UNESA");
            Console.WriteLine("menu yang tersedia: kopi,teh ,cokelat");
            Console.WriteLine("Pilih Menu:");
            string menu = Console.ReadLine();
            if (menu == "kopi" || menu == "teh" || menu == "cokelat")
            {
                Console.WriteLine("Selamat menikmati");
            }
            else
            {
                Console.WriteLine("menu tidak sesuai dengan nominal uang");
            }
        }
        else if (uang == 10000)
        {
            Console.WriteLine("Selamat Datang di vending mesin UNESA");
            Console.WriteLine("menu yang tersedia: es kopi, es teh, es cokelat");
            Console.WriteLine("Pilih Menu: ");
            string menu = Console.ReadLine();
            if (menu == "es kopi" || menu == "es teh" || menu == "es cokelat")
            {
                Console.WriteLine("Selamat menikmati");
            }
            else
            {
                Console.WriteLine("menu tidak sesuai dengan nominal uang");
            }
        }
        else
        {
            Console.WriteLine("nominal uang yang dimasukkan tidak sesuai");
        }
    }
}