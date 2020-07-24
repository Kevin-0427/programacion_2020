using System;

namespace votaciones
{
    class votaciones
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero de  votos por el partido 1");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese numero de  votos por el partido 2");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese numero de  votos en blanco");
            int blancos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese numero de  votos anulados");
            int anulados = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese numero total de la población");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese porcentaje de la población que es mayor de edad");
            double p = Convert.ToInt32(Console.ReadLine());

            double pme = n * (p / 100);
            int votantes = a + b + blancos + anulados;
            double abstencion = pme - votantes;

            bool c1 = anulados < ((a + b) * 0.3);
            bool c2 = (a + b) > blancos;
            bool c3 = abstencion < (a + b + blancos + anulados);

            Console.WriteLine("votos: " + "\n" + "partido1: " + a + "  partido2: " + b + "   blancos: " + blancos + "   anulados: " + anulados
                               + "\n"+"total habitantes: "+n+"   mayores de edad: "+p+"%" + "\n"+"poblacion mayor de edad: "+(int)pme+"\n"
                               +"total de votantes: "+votantes+"   abstencion: "+(int)abstencion);
            
            
            
            if(c3 && (c1 || c2))
            {
                Console.WriteLine("\n"+"Las votaciones fueron exitosas");
                if(a > b)
                {
                    Console.WriteLine("\n" + "Ganador de las elecciones: Partido 1");
                }
                else
                {
                    Console.WriteLine("\n" + "Ganador de las elecciones: Partido 2");
                }

            }
            else
            {
                Console.WriteLine("\n" + "Las votaciones deben repetirse");
            }


        }

    }
}
