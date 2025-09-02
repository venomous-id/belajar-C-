using System;

class Program
{
    static void Main(string[] args)
    {
        // Input jumlah cabang toko
        Console.Write("Masukkan jumlah cabang toko: ");
        int jumlahCabang = int.Parse(Console.ReadLine());

        // Input jumlah produk
        Console.Write("Masukkan jumlah produk: ");
        int jumlahProduk = int.Parse(Console.ReadLine());

        // Deklarasi array multidimensi untuk menyimpan data penjualan
        string[] namaCabang = new string[jumlahCabang];
        string[] namaProduk = new string[jumlahProduk];
        int[,] penjualan = new int[jumlahCabang, jumlahProduk];

        // Input nama cabang
        for (int i = 0; i < jumlahCabang; i++)
        {
            Console.Write($"Masukkan nama cabang ke-{i + 1}: ");
            namaCabang[i] = Console.ReadLine();
        }

        // Input nama produk
        for (int j = 0; j < jumlahProduk; j++)
        {
            Console.Write($"Masukkan nama produk ke-{j + 1}: ");
            namaProduk[j] = Console.ReadLine();
        }

        // Input data penjualan untuk setiap cabang dan produk
        for (int i = 0; i < jumlahCabang; i++)
        {
            Console.WriteLine($"\nMasukkan data penjualan untuk cabang {namaCabang[i]}:");
            for (int j = 0; j < jumlahProduk; j++)
            {
                Console.Write($"Penjualan produk {namaProduk[j]}: ");
                penjualan[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Menghitung total penjualan per cabang dan menampilkan kategori performa
        Console.WriteLine("\nLaporan Penjualan per Cabang:");
        for (int i = 0; i < jumlahCabang; i++)
        {
            int totalPenjualan = 0;

            Console.WriteLine($"\nCabang: {namaCabang[i]}");
            for (int j = 0; j < jumlahProduk; j++)
            {
                Console.WriteLine($"Produk {namaProduk[j]}: {penjualan[i, j]}");
                totalPenjualan += penjualan[i, j];
            }

            Console.WriteLine($"Total Penjualan: {totalPenjualan}");
            Console.WriteLine($"Kategori: {KategoriPenjualan(totalPenjualan)}");
        }
    }

    // Fungsi untuk menentukan kategori penjualan
    static string KategoriPenjualan(int totalPenjualan)
    {
        if (totalPenjualan >= 50000)
        {
            return "Sangat Tinggi";
        }
        else if (totalPenjualan >= 40000)
        {
            return "Tinggi";
        }
        else if (totalPenjualan >= 30000)
        {
            return "Sedang";
        }
        else if (totalPenjualan >= 20000)
        {
            return "Cukup";
        }
        else
        {
            return "Kurang";
        }
    }
}