using System.Globalization;
using Vetores;

namespace Course
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double sum = 0;
            Product[] items = new Product[num];

            for (int i = 0; i < num; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                items[i] = new Product{Name = name, Price = price};

                sum += price;
            }

            double average = sum / num;
            Console.WriteLine($"Preço médio = {average.ToString("F2")}");
        }
    }
}