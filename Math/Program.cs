using System;
namespace Math
{
    class Program
    {
        static void Main()
        {
            Complex a = new Complex(3.35, 5.61);
            Complex b = new Complex(5, 6);
            Complex c = a.Add(1);
            Console.WriteLine("("+c.Real + ", " + c.Imaginary+")");
            Console.ReadKey();
        }
    }

    public class Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
        public Complex(double x, double y)
        {
            Real = x;
            Imaginary = y;
            
        }
        public Complex Add(Complex b)
        {
            Complex x =new Complex(this.Real+b.Real,this.Imaginary+b.Imaginary);
            return x;
        }

        public Complex Add (int a)
        {
            Complex x = new Complex(this.Real + a, this.Imaginary);
            return x;
        }
    }
}
