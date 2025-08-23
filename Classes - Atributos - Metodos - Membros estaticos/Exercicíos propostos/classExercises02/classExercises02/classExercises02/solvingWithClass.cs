namespace solvingWithClass
{
    class Triangle
    {
        public double A;
        public double B;
        public double C;

        public double CalculaArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }

}