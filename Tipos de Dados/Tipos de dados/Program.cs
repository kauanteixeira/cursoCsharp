using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n1 = 255;
            int n2 = 223235;
            long n3 = 12323432454L;
            float n4 = 4.5f; // Sempre que um valor for float deve-se colocar um f no final 
            double n5 = 4.5;

            char genero = 'M';
            char unicode = '\u0041';
            string nome = "Maria";

            // Tipo boleano verdadeiro e falso

            bool completo = true;

            // Object é um tipo universal ele aceita qualquer valor

            object nome1 = "Kauan";
            object n6 = 45.9f;

            // Como saber os valores minímos e máximos que um tipo de dado pode ter

            int n7 = int.MinValue;
            int n8 = int.MaxValue;  


            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);

            Console.WriteLine(genero);
            Console.WriteLine(unicode);
            Console.WriteLine(nome);
            Console.WriteLine(nome1);

            Console.WriteLine(completo);

            Console.WriteLine(n7);
            Console.WriteLine(n8);
        }
    }
}