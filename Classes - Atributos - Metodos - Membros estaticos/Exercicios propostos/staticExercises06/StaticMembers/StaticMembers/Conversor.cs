using System;

namespace StaticMembers
{
    public class Conversor
    {
        public static double Iof = 6.0;
        public static double DolarReal(double cotacao, double quantia)
        {
            return quantia * cotacao * (1 + Iof / 100);
        }
    }
}