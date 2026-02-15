using System;
using ReferenciaValor;

namespace Course
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Structs são tipos por valor armazenados diretamente na memória (stack), sendo mais leves e rápidos que classes. Diferente das classes, não suportam herança, mas podem possuir métodos e implementar interfaces. Ao copiar uma struct, é criada uma nova cópia independente do valor, enquanto classes compartilham a mesma referência.
            Point p;
            p.X = 5;
            p.Y = 10;
            Console.WriteLine(p);

            //Como atribuir o valor null a um struct
            Nullable<double> a = null;

            //Maneira mais simplificada
            double? b = null;
            //Métodos Nullable
            // .HasValue
            // .GetValueOrDefault
            // .Value

            //Operador de coalescência
            double? c = null;
            double d = c ?? 0.0; // - Caso c for null d terá o valor de 0.0
        }
    }
}