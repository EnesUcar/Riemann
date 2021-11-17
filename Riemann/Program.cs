using System;

namespace Riemann
{
    class Program
    {
        static void Main(string[] args)
        {
            Riemann riemann = new Riemann();
            riemann.A = 1;
            riemann.B = 5;
            riemann.N = 1000;

            Console.Write(riemann.Calculate());
            Console.Read();

        }
    }
}
