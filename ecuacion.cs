using System;

namespace ecuacion
{
    class ecuacion
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Inserte a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserte b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserte c");
            double c = double.Parse(Console.ReadLine());

            double x1 = 0, x2 = 0;
            
            double disc = Math.Pow(b, 2) - 4 * a * c;

            if(disc != 0)
            {
                if(disc < 0)
                {
                    Console.WriteLine("no es posible calcular la solución");
                }
                else
                {
                    Console.WriteLine("Existen dos posibles soluciones correctas");
                    x1 = (-b + (Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a);
                    x2 = (-b - (Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a);
                    Console.WriteLine("soluciones para la ecuación: " + "\n" + " x1 = " + x1 + "\n" + " x2 = " + x2);

                }
            }
            else
            {
                Console.WriteLine("la solución existe y es unica");
                x1 = (-b + (Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a);
                Console.WriteLine("soluciones para la ecuación: " + "\n" + " x1 = " + x1);
            }
            

            Console.ReadKey();

        }
    }
}
