using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            int gaji = 20000000;
            int tunjangan = 2500000;
            int masakerja = 3;
            int bonus = tunjangan * masakerja;
            int totalgaji = gaji + bonus;
            Console.WriteLine("total bonus adalah "+ bonus);
            Console.WriteLine("total gaji adalah "+ totalgaji);
        }
    }
}