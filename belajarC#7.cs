using System;
namespace tugas;
class program
{
    static void Main(string[] args)
    {
        int i;
        bool prima = true;
        for (i = 1; i <= 100; i++)
        {
            if (i % 2 != 0)
            {
                continue;
            }
            if (i > 1)
            {
                for (int n = 2; n <= Math.Sqrt(i); n++)
                {
                    if (i % n == 0)
                    {
                        prima = false;
                        break;
                    }
                }
                if (prima == true)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}