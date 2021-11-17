using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riemann
{
    class Riemann
    {
        private double a, b, n;

        public double A 
        { 
            get
            {
                return this.a;
            }
            set 
            {
                this.a = value;
            }
        }

        public double B
        {
            get
            {
                return this.b;
            }
            set
            {
                this.b = value;
            }
        }

        public double N
        {
            get
            {
                return this.n;
            }
            set
            {
                this.n = value;
            }
        }

        public double Delta_x
        {
            get
            {
                return (this.b - this.a) / this.n;
            }
        }
        
        private double parabol_denklemi(double x)
        {
            return x * x;
        }

        public string Calculate()
        {
            double alt_toplam = 0;
            double ust_toplam = 0;

            //Console.WriteLine("Delta_x: " + delta_x);

            for (double i = 0; i < n; i++)
                alt_toplam += this.Delta_x * this.parabol_denklemi(this.a + (i * this.Delta_x));

            //Console.WriteLine("Alt Toplam: " + alt_toplam);

            for (int i = 1; i <= n; i++)
                ust_toplam += this.Delta_x * this.parabol_denklemi(a + (i * this.Delta_x));

            //Console.WriteLine("Üst Toplam: " + ust_toplam);

            return "Alt Toplam: " + alt_toplam + "\nÜst Toplam: " + ust_toplam;
        }
    }
}
