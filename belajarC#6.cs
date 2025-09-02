using System;
namespace tugas;
class program
{
    static void Main(string[] args)
    {
        string [] ketua = ["Fatih", "Ahmad", "Annas", "Mumtaz"];
        string pilihan;
        Console.WriteLine("Petunjuk memilih ketua");
        Console.WriteLine("Ketik pilih untuk memilih ketua");
        Console.WriteLine("Ketik skip jika tidak memilih kandidat");
        Console.WriteLine("Jangan golput atau tidak memilih sama sekali");
        for(int i = 0; i <= 3;  i++)
        {
            Console.Write($"Pilih ketua {ketua[i]}: ");
            pilihan = Console.ReadLine();
            if ( pilihan == "pilih")
            {
                if (ketua[i] == ketua[0])
                    goto Fatih;
                if (ketua[i] == ketua[1])
                    goto Ahmad;
                if (ketua[i] == ketua[2])
                    goto Annas;
                if (ketua[i] == ketua[3])
                    goto Mumtaz;
            }
            if (i == 3 && pilihan != "pilih")
            {
                goto invalid;
            }
        }
    Fatih:
        Console.WriteLine($"Selamat anda sudah memilih untuk {ketua[0]}");
        Console.WriteLine("Fatih adalah tipe pemimpin yang visioner dan karismatik. Dirinya terkenal karena pekerja keras dan mampu mampu memotivasi anggota kelompok");
        return;
    Ahmad:
        Console.WriteLine($"Selamat anda sudah memilih untuk {ketua[1]} ");
        Console.WriteLine("Ahmad adalah tipe pemimpin yang tegas dan pragmatis. Sebelumnya dirinya terkenal selalu menjadi seorang koordinator dalam acara acara besar.");
        return;
    Annas:
        Console.WriteLine($"Selamat anda sudah memilih untuk {ketua[2]} ");
        Console.WriteLine("Annas adalah tipe pemimpin yang inspiratif dan peduli terhadap sesama anggota. dirinya selalu aktif dalam kegiatan sosial dan pernah memimpin program kemasyarakatan.");
        return;
    Mumtaz:
        Console.WriteLine($"Selamat anda sudah memilih untuk {ketua[3]}");
        Console.WriteLine("Mumtaz adalah tipe pemimpin yang analitis dan fokus pada hasil. Dirinya terkenal karena selalu tepat waktu pada segala kegiatannya dan sering aktif dalam keorganisasian sebagai sekretaris atau bendahara");
        return;
    invalid:
        Console.WriteLine("Jangan golput atau tidak memilih sama sekali");
    }
}