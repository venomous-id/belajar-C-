using System;
namespace tugas;
class program
{
    static void Main(string[] args)
    {
        string[] mahasiswa = ["Yuwanda", "Lizam", "asman", "Amirul", "Farhan", "Cintya", "Luthfi", "Ramadhan", "Syahrindra", "Andi"];
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{mahasiswa[i]}");
            if (mahasiswa[i] == "Luthfi")
            {
                Console.WriteLine($"Selamat {mahasiswa[6]} karena telah menjadi mahasiswa yang berprestasi pada semester Gasal 2024");
                break;
            }
        }
    }
}