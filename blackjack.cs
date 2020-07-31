using System;

namespace blackjack
{
    class blackjack
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola! esto es blackjack!");

            Console.WriteLine("presiona 'P' para jugar o 'S' para salir");
            String jugar = Console.ReadLine();

            if (jugar.Equals("p"))
            {
                Random r = new Random();

                int c1 = r.Next(1, 10);
                int c2 = r.Next(1, 10);

                int total = c1 + c2;

                Console.WriteLine("Carta N° 1 = " + c1 + "\n" + "Carta N° 2 = " + c2 + "\n" +"Tienes: "+total);

                Console.WriteLine("presione 'c' para continuar o 'e' para salir");
                String pedir = Console.ReadLine();

                while (total <= 21 && pedir.Equals("h")){

                    Console.WriteLine("presione 'c' para pedir carta o 'e' para salir");
                    pedir = Console.ReadLine();
                    int nc = r.Next(1, 10);
                        total = total + nc;
                        Console.WriteLine("Carta N° 1 = " + c1 + "\n" + "Carta N° 2 = " + c2 + "\n" + "Nueva carta =  " + nc
                                            + "\n" + "Tienes: " + total);

                }
                if(total == 21)
                {
                    Console.WriteLine("ganaste!  Tienes 21!!");
                }
                else {
                    Console.WriteLine("elmininado!  tienes " + total);
                }                
                
            }else{
                Console.WriteLine("Hasta luego!");
            }
            
        }
    }
}
