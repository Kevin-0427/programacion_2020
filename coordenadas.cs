using System;

namespace fp20202
{
    class coordenadas
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("por favor inserte coordenadas en x, en orden x1,x2, oprima enter luego de ingresar cada coordenada");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("por favor inserte coordenadas en y, en orden y1,y2, oprima enter luego de ingresar cada coordenada");
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            int m = (y2 - y1) / (x2 - x1);

            int b = y2 - y1 - (m * x2) + (m * x1);

            double distancia = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));

            Console.WriteLine("pendiente es: " + m);
            Console.WriteLine("el punto intercepto es: " + b);
            Console.WriteLine("la distancia entre los dos puntos es: " + distancia);

            Console.ReadKey();



        }
    }
}
