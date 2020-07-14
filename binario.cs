using System;

namespace binario
{
    class binario
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese los números binarios de izquierda a derecha");

            Console.WriteLine("ingrese b4");
            int b4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese b3");
            int b3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese b2");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese b1");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese b0");
            int b0 = Convert.ToInt32(Console.ReadLine());

            double dec = (b4 * (Math.Pow(2, 4)) + b3 * (Math.Pow(2, 3)) + b2 * (Math.Pow(2, 2)) + b1 * (Math.Pow(2, 1)) + b0 * (Math.Pow(2, 0)));

            Console.WriteLine("el decimal obtenido es: " + dec);

        }
    }
}
