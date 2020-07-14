using System;

namespace tríangulodoble
{
    class triangulodoble
    {
        static void Main(string[] args)
        {
            //triángulo 1
            /*
            Console.WriteLine("ingrese b°,Z y Y");
            double b = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double ar = Math.Atan(y / z);
            double a = ar * (180 / Math.PI);
            double ab = a + b;
            double abr = ab * (Math.PI / 180);
            double x = Math.Tan(abr) * z - y;

            Console.WriteLine(" x = " + x);

            Console.ReadKey();*/

            //Triángulo 2
            /*
            Console.WriteLine("ingrese d°, b° y y");
            double d = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double dr = d * (Math.PI / 180);
            double br = b * (Math.PI / 180);

            double ar = Math.PI - (Math.PI / 2) - dr - br;
            double a = ar * (180 / Math.PI);

            double z = y / Math.Tan(ar);

            Console.WriteLine(" Z = " + z);

            Console.ReadKey();
            */

            //Triángulo 3
            /*
            Console.WriteLine("ingrese w, d° y x");
            double w = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double dr = d * (Math.PI/180);
            double y = Math.Cos(dr) * w - x;

            Console.WriteLine(" y = " + y);

            Console.ReadKey();
            */

            //Triángulo 4

            /*
            Console.WriteLine("ingrese w, t y c°");
            double w = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double cr = c * (Math.PI / 180);
            double z = Math.Sin(cr) * t;
            double y = Math.Sqrt(t * t - z * z);
            double x = Math.Sqrt(w * w - z * z) - y;

            Console.WriteLine(" X = " + x);

            Console.ReadKey();
            */



        }
    }
}
