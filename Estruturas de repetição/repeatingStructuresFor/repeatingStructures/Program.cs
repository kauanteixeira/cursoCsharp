using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números inteiros você vai digitar?");
            int qtde = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < qtde; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine($"Soma: {sum}");

            ////Leia um valor inteiro X(1 <= X <= 1000).Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
            ////X, se for o caso.
            Console.WriteLine("Digite um valor inteiro");
            int val = int.Parse(Console.ReadLine());
            for (int x = 0; x <= val; x++)
            {
                if (x % 2 != 0)
                {
                    Console.WriteLine(x);
                }
            }

            //Leia um valor inteiro N.Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            //Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
            //essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
            //Console.WriteLine("Digite um valor inteiro");
            int n = int.Parse(Console.ReadLine());
            int cont_in = 0;
            int cont_out = 0;

            for (int i = 0; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                    cont_in += 1;
                else
                    cont_out += 1;
            }
            Console.WriteLine($"{cont_in} in");
            Console.WriteLine($"{cont_out} out");

            //Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            //de 3 valores reais, cada um deles com uma casa decimal.Apresente a média ponderada para cada um destes
            //conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            //peso 5
            Console.WriteLine("Digite a quantidade de testes: ");
            int qtdeTestes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdeTestes; i++)
            {
                Console.WriteLine($"Digite a nota {i}: ");
                string[] valores = Console.ReadLine().Split(" ");
                double v1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double v2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double v3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double media = (v1 * 2 + v2 * 3 + v3 * 5) / (2 + 3 + 5);
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }

            //Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            //segundo.Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
            int nd = int.Parse(Console.ReadLine());

            for (int i = 0; i <= nd; i++)
            {
                string[] v = Console.ReadLine().Split(" ");
                double a = double.Parse(v[0]);
                double b = double.Parse(v[1]);

                if (b == 0)
                    Console.WriteLine("Divisao impossivel");
                else
                {
                    double d = a / b;
                    Console.WriteLine(d.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

            //Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N - 1) * (N - 2) * (N - 3) * ... *1.
            //Lembrando que, por definição, fatorial de 0 é 1.
            int n1 = int.Parse(Console.ReadLine());
            int fat = 1;

            for (int i = 1; i <= n1; i++)
                fat *= i;

            Console.WriteLine(fat);
            Console.ReadLine();

            //Ler um número inteiro N e calcular todos os seus divisores.
            int valIn = int.Parse(Console.ReadLine());

            for (int i = 0; i <= valIn; i++)
            {
                if (valIn % i == 0)
                    Console.WriteLine(i);
            }

            //Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
            //começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
            //exemplo.
            int nInt = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nInt; i++)
            {
                int q = (int)Math.Pow(i, 2);
                int c = (int)Math.Pow(i, 3);
                Console.WriteLine($"{i} {q} {c}");
            }

        }
    }
}