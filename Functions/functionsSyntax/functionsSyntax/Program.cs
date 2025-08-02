using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 valores inteiros:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);

            Console.WriteLine($"O maior número digitado é: {resultado}");
        }
        static int Maior(int x, int y, int z)
        {
            int m = 0;
                m = x;
                m = x;
            if (x > y && x > z)
            else if (y > z)
                m = y;
            else
                m = z;
            return m;
        }
    }
}