using System;
using System.Globalization;

namespace Myapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double v = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (v >= 0)
            {
                double raiz = Math.Sqrt(v);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                v = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número negativo");

            //Exercícios de fixação

            //Escreva um programa que repita a leitura de uma senha até que ela seja válida.Para cada leitura de senha
            //incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
            //impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.
            //Console.Write("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.Write("Senha inválida, tente novamente: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido!");

            //Escreva um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no sistema
            //cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            //menos uma de duas coordenadas for NULA(nesta situação sem escrever mensagem alguma).
            string[] values = Console.ReadLine().Split(" ");
            int x = int.Parse(values[0]);
            int y = int.Parse(values[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                    Console.WriteLine("primeiro");
                else if (x < 0 && y > 0)
                    Console.WriteLine("segundo");
                else if (x < 0 && y < 0)
                    Console.WriteLine("terceiro");
                else
                    Console.WriteLine("Quarto");

                values = Console.ReadLine().Split(" ");
                x = int.Parse(values[0]);
                y = int.Parse(values[1]);
            }

            //Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            //um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            //4.Fim). Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até
            //que seja válido). O programa será encerrado quando o código informado for o número 4.Deve ser escrito a
            //mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            //exemplo.

            Console.WriteLine("1 - Álcool, 2 - Gasolina, 3 - Diesel");
            Console.WriteLine("Digite o tipo de combustível: ");
            int cod = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (cod != 4)
            {
                if (cod == 1)
                    alcool += 1;
                else if (cod == 2)
                    gasolina += 1;
                else if (cod == 3)
                    diesel += 1;
                cod = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Muito obrigado!");
            Console.WriteLine($"Álcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");

        }
    }
}