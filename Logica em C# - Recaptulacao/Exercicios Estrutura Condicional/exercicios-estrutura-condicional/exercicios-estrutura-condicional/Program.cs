using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
            int num = int.Parse(Console.ReadLine());
            if (num <= 0)
                Console.WriteLine("Número negativo");
            else
                Console.WriteLine("Número positivo");

            //Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
            int num1 = int.Parse(Console.ReadLine());
            if (num1 % 2 == 0)
                Console.WriteLine("Número par");
            else
                Console.WriteLine("Número impar");

            //Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.
            int valA = int.Parse(Console.ReadLine());
            int valB = int.Parse(Console.ReadLine());
            if (valA % valB == 0 || valB % valA == 0)
                Console.WriteLine("São multiplos");
            else
                Console.WriteLine("Não são multiplos");

            //Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
            string[] times = Console.ReadLine().Split(' ');
            int entry = int.Parse(times[0]);
            int exit = int.Parse(times[1]);
            int duration = 0;
            if (entry < exit)
                duration = exit - entry;
            else
                duration = 24 - entry + exit;

            Console.WriteLine($"O jogo durou {duration} hora(s)");

            // Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.A seguir, calcule e mostre o valor da conta a pagar.
            string[] values = Console.ReadLine().Split(' ');
            int cod = int.Parse(values[0]);
            int qtde = int.Parse(values[1]);
            double pay = 0;

            if (cod == 1)
                pay = qtde * 4.0;
            else if (cod == 2)
                pay = qtde * 4.50;
            else if (cod == 3)
                pay = qtde * 5.0;
            else if (cod == 4)
                pay = qtde * 2.0;
            else if (cod == 5)
                pay = qtde * 1.50;

            Console.WriteLine($"Total: R$ {pay.ToString("F2")}");

            //Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos([0, 25], (25,50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
            double val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (val < 0.0 || val > 100.0)
                Console.WriteLine("Fora do intervalo!");
            else if (val <= 25.0)
                Console.WriteLine("Intervalo: [0 - 25]");
            else if (val <= 50.0)
                Console.WriteLine("Intervalo: [25 - 50]");
            else if (val <= 75.0)
                Console.WriteLine("Intervalo: [50 - 75]");
            else
                Console.WriteLine("Intervalo: [75 - 100]");

            //Leia 2 valores com uma casa decimal(x e y), que devem representar as coordenadas
            //de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
            //ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0).
            //Se o ponto estiver na origem, escreva a mensagem “Origem”.
            //Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
            //situação.
            Console.WriteLine("Digite o valor de X:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de Y:");
            double y = double.Parse(Console.ReadLine());

            if (x == 0.0 && y == 0.0)
                Console.WriteLine($"X: {x}, Y: {y} - Origem");
            else if (x == 0.0)
                Console.WriteLine($"X: {x}, Y: {y} - Eixo Y");
            else if (y == 0.0)
                Console.WriteLine($"X: {x}, Y: {y} - Eixo X");
            else if (x > 0.0 && y > 0.0)
                Console.WriteLine($"X: {x}, Y: {y} - Q1");
            else if (x < 0.0 && y >= 0.0)
                Console.WriteLine($"X: {x}, Y: {y} - Q2");
            else if (x < 0.0 && y < 0.0)
                Console.WriteLine($"X: {x}, Y: {y} - Q3");
            else
                Console.WriteLine($"X: {x}, Y: {y} - Q4");

            //Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
            //que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
            //qualquer desvio.A moeda deste país é o Rombus, cujo símbolo é o R$.
            //Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
            //mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
            //Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8 % apenas sobre R$ 1000.00, pois a faixa de
            //salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda.No exemplo fornecido(abaixo), a taxa é
            //de 8 % sobre R$ 1000.00 + 18 % sobre R$ 2.00, o que resulta em R$ 80.36 no total.O valor deve ser impresso com
            //duas casas decimais.
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = 0.0;

            if (salario > 4500.0)
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            else if (salario > 3000.0)
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            else if (salario > 2000.0)
                imposto = (salario - 2000.0) * 0.08;

            if (imposto == 0.0)
                Console.WriteLine("Isento");
            else
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}