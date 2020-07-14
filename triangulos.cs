using System;

namespace triangulos
{
    class triangulos
    {
        static void Main(string[] args)
        {
            //Triangulo 1 - Datos Y y Z
            /*Console.WriteLine("ingrese dato para y");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese dato para z");
            double z = double.Parse(Console.ReadLine());*/

            double y = 2, z = 3;
            double t = Math.Sqrt((Math.Pow(y,2))+(Math.Pow(z,2)));

            double cr = Math.Atan((z / y));
            double c = cr * (180 / Math.PI);

            double ar = Math.PI - (Math.PI / 2) - cr;
            double a = ar * (180 / Math.PI);

            Console.WriteLine("lado t " + t);
            Console.WriteLine("ángulo c " +c);
            Console.WriteLine("ángulo a " + a);

            Console.ReadKey();


            //Triangulo 2 - Datos t y a
            /*Console.WriteLine("ingrese dato para t");
            double t = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese dato para a");
            double a = double.Parse(Console.ReadLine());*/

            /*double a = 33.69;
            double t = 3.61;

            double ar = a * (Math.PI / 180);
            double cr = Math.PI - (Math.PI / 2) - ar;
            double c = cr * (180 / Math.PI);

            double y = Math.Sin(ar) * t;
            double z = Math.Cos(ar) * t;

            Console.WriteLine("lado y: " + y);
            Console.WriteLine("lado z: " + z);
            Console.WriteLine("ángulo c: " + c);

            Console.ReadKey();*/


            //Triangulo 3 - Datos c y z
            /*Console.WriteLine("ingrese dato para c");
            double t = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese dato para z");
            double z = double.Parse(Console.ReadLine());*/

            /*double z = 3;
            double c = 56.31;
            double cr = c * (Math.PI/180);

            double ar = Math.PI - (Math.PI / 2) - cr;
            double a = ar * (180 / Math.PI);

            double t = z / Math.Sin(cr);
            double y = z / Math.Tan(cr);

            Console.WriteLine("ángulo a: " + a);
            Console.WriteLine("lado t: " + t);
            Console.WriteLine("lado y: " + y);

            Console.ReadKey();*/
        }
    }
}
