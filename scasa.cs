using System;

namespace simulacro
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Bienvenido!");
            Console.WriteLine("Ganas si tienes 100 puntos o más o si sacas un 12 seguido de un 10." + "\n"
                                + "pierdes si despues del tercer tiro sacas un numero impar o si te retiras antes de los 100 puntos");

            Random r = new Random();

            int dado = r.Next(1, 13);
            int total = 0;
            total += dado;
            String continuar = "";
            int tiro = 1;
            int n = 0;
            Console.WriteLine("primer dado = " + dado);
            Console.WriteLine("puntaje acumulado: " + total);

            Console.WriteLine("desea lanzar de nuevo el dado? (s/n)" + continuar);
            continuar = Console.ReadLine();

            int ndado = 0;
            while (continuar.Equals("s"))
            {
                
                ndado = r.Next(1, 12);
                total += ndado;
                Console.WriteLine("nuevo dado = " + ndado);

                if (dado == 12 && ndado == 10) Console.WriteLine("ganaste! obtuviste un 12 seguido de un 10");
                
                if(ndado == 12)
                {
                    n++;
                }
                if(n == 1 && ndado == 10) Console.WriteLine("ganaste! obtuviste un 12 seguido de un 10");

                if (tiro < 3 && total < 100)
                {
                    Console.WriteLine("puntaje acumulado: " + total);
                    tiro++;
                    Console.WriteLine("desea lanzar de nuevo el dado? (s/n)" + continuar);
                    continuar = Console.ReadLine();
                }
                else if (tiro >= 3 && total < 100)
                {
                    Console.WriteLine("puntaje acumulado: " + total);
                    tiro++;

                    if (ndado % 2 != 0)
                    {
                        Console.WriteLine("ha sido eliminado");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("puntaje acumulado: " + total);
                        Console.WriteLine("desea lanzar de nuevo el dado? (s/n)" + continuar);
                        continuar = Console.ReadLine();
                    }
                }
                else if (total == 100)
                {
                    Console.WriteLine("Ganaste!");
                    break;
                }




            }

            Console.WriteLine("su puntaje final fue: " + total);



        }
    }
}
