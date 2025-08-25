using System;
using System.Globalization;

namespace CodeClass
{
    public class Retangulo
    {
        public double Altura;
        public double Largura;


        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return 2 * (Altura + Largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }

        public override string ToString()
        {
            return "AREA = " 
                + Area().ToString("F2", CultureInfo.InvariantCulture) 
                + ", PERIMETRO = " 
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture) 
                + ", DIAGONAL = " 
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture)
            ;
        }
    }
}
