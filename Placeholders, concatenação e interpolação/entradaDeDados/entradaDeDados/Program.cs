using System;
using System.Globalization;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine($"My name is {name}");

            string phrase = Console.ReadLine();
            string[] vet = phrase.Split(" ");
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            for ( int i = 0; i < vet.Length; i++) 
            {
                Console.WriteLine(vet[i]);
            }

            //Exercício de fixação

            //Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa.
            int v1 = 10;
            int v2 = 30;
            int sum = v1 + v2;
            Console.WriteLine($"A soma dos valores {v1} + {v2} é = {sum}");

            //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos.
            Console.WriteLine("Digite o raio do circulo:");
            double radius = double.Parse(Console.ReadLine());
            double exponent = 2;
            double pi = 3.14159;
            double area = pi * Math.Pow(radius, exponent);
            double numFormatted = double.Parse(area.ToString("F4"));
            Console.WriteLine($"A area do circulo é {numFormatted}");

            //Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
            int w = 5;
            int x = 6;
            int y = 7;
            int z = 8;
            int diferenca = w * x - y * z;
            Console.WriteLine(diferenca);

            //Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
            int number = int.Parse(Console.ReadLine());
            int hoursWorked = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            double valueRecive = hoursWorked * salary;
            Console.WriteLine($"Número do funcionário: {number}");
            Console.WriteLine($"Salário a receber: R${valueRecive}");

            //Fazer um programa para executar uma interação com o usuário, lendo os valores digitados e mostrar os dados na tela:
            Console.WriteLine("Digite sua profissão:");
            string profession = Console.ReadLine();

            Console.WriteLine("Há quantos anos está nessa profissão:");
            int timeProfession = int.Parse(Console.ReadLine());

            Console.WriteLine("Quanto é o seu salário: ");
            double wage = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o seu nome, altura e idade:");
            string[] info = Console.ReadLine().Split(" ");


            Console.WriteLine($"Sua profissão é {profession} você trabalha há {timeProfession} anos e recebe um salário de {wage}");
            for (int i = 0; i < info.Length; i++)
            {
                Console.WriteLine(info[i]);
            }

            //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.
            Console.WriteLine("Digite o codigo da peça, o número de peças e o valor:");
            int codPc1 = int.Parse(Console.ReadLine());
            int numPc1 = int.Parse(Console.ReadLine());
            float valPc1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o codigo da peça, o número de peças e o valor:");
            int codPc2 = int.Parse(Console.ReadLine());
            int numPc2 = int.Parse(Console.ReadLine());
            float valPc2 = float.Parse(Console.ReadLine());

            double amountPay = numPc1 * valPc1 + numPc2 * valPc2;
            Console.WriteLine($"O valor a ser pago é de: R${amountPay.ToString("F2")}");

            //Fazer um programa que leia três valores com ponto flutuante de dupla precisão: val1, val2 e val3. Em seguida, calcule e mostre:
            //a) a área do triângulo retângulo que tem val1 por base e val3 por altura.
            //b) a área do círculo de raio val3. (pi = 3.14159)
            //c) a área do trapézio que tem val1 e val2 por bases e val3 por altura.
            //d) a área do quadrado que tem lado val2.
            //e) a área do retângulo que tem lados val1 e val2.

            string[] values = Console.ReadLine().Split(' ');
            double val1 = double.Parse(values[0], CultureInfo.InvariantCulture);
            double val2 = double.Parse(values[1], CultureInfo.InvariantCulture);
            double val3 = double.Parse(values[2], CultureInfo.InvariantCulture);

            double triangle = val1 * val3 / 2;
            double circle = pi * Math.Pow(val3, 2);
            double trapeze = (val1 + val2) * val3 / 2;
            double square = Math.Pow(val2, 2);
            double rectangle = val1 * val2;

            Console.WriteLine($"Triangulo: {triangle.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Circulo: {circle.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Trapezio: {trapeze.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quadrado: {square.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Retanglo: {rectangle.ToString("F3", CultureInfo.InvariantCulture)}");
        }

    }
}