using System;

namespace cuota_moderadora
{
    class cuota
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Consulta Tarifa de cuota moderadora según su salario" + "\n");


            Console.WriteLine("ingrese el valor de su salario");
            double salario = double.Parse(Console.ReadLine());
            double smmlv = 877803;
            
            if (salario < (smmlv*2))
            {
                Console.WriteLine("La tarifa correspondiente a su pago es la tarifa A"+ "\n"+"el valor de la cuota moderadora es de : $ 3.400 COP");
                
            }
            else if (salario >= (smmlv*2) && salario < (smmlv*5))
            {
                Console.WriteLine("La tarifa correspondiente a su pago es la tarifa B" + "\n" + "el valor de la cuota moderadora es de : $ 13.500 COP");
            }
            else if (salario >= (smmlv*5))
            {
                Console.WriteLine("La tarifa correspondiente a su pago es la tarifa C" + "\n" + "el valor de la cuota moderadora es de : $ 35.600 COP");
            }
            else if (salario < 1)
            {
                Console.WriteLine("El valor introducido no es válido");
            }

            Console.ReadKey();
        }
    }
}
