using System;
class U1
{
    static void Main(string[] args)
    {
        bool[] x = { true, true, false, false };
        bool[] y = { true, false, true, false };
        Console.WriteLine("| x | y | x dan y |");
        for (int i = 0; i < 4; i++)
        {
            bool result = x[i] & y[i];
            Console.WriteLine($"| {Convert.ToInt32(x[i])} | {Convert.ToInt32(y[i])} | {Convert.ToInt32(result)}");
        }
    }
}