using System;
namespace Maths
{
    class Program
    {
        static void Main()
        {
        
            Real real = new Real();
            int z = 16;
            real.Sqr(z,2);
            real.Sqrt(z);
            Console.WriteLine("");

            Complex a = new Complex(12, -6);
            Complex b = new Complex(4, 4);
            Complex c = a.Sqr(2);
            Complex d = a.Sqrt(b);

            Console.WriteLine("(" + c.Real + ", " + c.Imaginary + ")");
            Console.WriteLine("(" + d.Real + ", " + d.Imaginary + ")\n");

            Fractional frac = new Fractional();
            double v = 16.2;
            frac.Sqr(v, 2);
            frac.Sqrt(v);
            Console.ReadKey();
        }
    }


    public abstract class Method
    {   public int i { get; set; }
        public double x { get; set; }
       
        public abstract void Sqrt(double x);
        public abstract void Sqr(double x,int i);
    }

    class Real : Method
    { 
        public override void Sqrt(double x)
        {
            Console.WriteLine(Math.Sqrt(x));
        }
        
        
        public override void Sqr(double x,int i)
        {   
             Console.WriteLine(Math.Pow(x, i));
        }
    }

    class Complex : Method
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
        protected double Magnitude { get; }
        protected double Phase { get; }
        public Complex(double x, double y)
        {
            Real = x;
            Imaginary = y;
            Phase = Math.Atan2(y, x);
            Magnitude = Math.Sqrt(x * x + y * y);


        }

        
        public Complex Add(Complex b)
        {
            Complex x = new Complex(this.Real + b.Real, this.Imaginary + b.Imaginary);
            return x;
        }

        public Complex Add(int a)
        {
            Complex x = new Complex(this.Real + a, this.Imaginary);
            return x;
        }
        public Complex Sqrt(Complex b)
        {
            Complex x = new Complex(Math.Sqrt(this.Magnitude), this.Phase / 2.0);
            return x;
        }

        public Complex Sqr(int i)
        {
            double argument = i * this.Phase;
            double pow = Math.Pow(this.Magnitude, i);
            this.Real = pow * Math.Cos(argument);
            this.Imaginary = pow * Math.Sin(argument);
            Complex x = new Complex(this.Real, this.Imaginary);
            return x;
        }
        public override void Sqr(double x, int i)
        {
           
        }
        public override void Sqrt(double x)
        {
            
        }
       
        

        
    }
    class Fractional : Method
    {   
        public override void Sqrt(double x)
        {
            Console.WriteLine(Math.Sqrt(x));
        }

        public override void Sqr(double x, int i)
        {
            Console.WriteLine(Math.Pow(x, i));

        }
    }



}

