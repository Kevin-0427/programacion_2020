using System;

namespace tarifacc
{
    class tarifa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tarifas para servicios de caja de compensación" + "\n");

            
                Console.WriteLine("ingrese el valor de su salario");
                double salario = double.Parse(Console.ReadLine());
                double smmlv = 877803;

                if(salario < (smmlv*2))
                {
                    Console.WriteLine("La tarifa correspondiente a su pago es la tarifa A");
                }else if(salario >= (smmlv*2) && salario < (smmlv*4))
                {
                    Console.WriteLine("La tarifa correspondiente a su pago es la tarifa B");
                }else if(salario >= (smmlv*4))
                {
                    Console.WriteLine("La tarifa correspondiente a su pago es la tarifa C");
                }
                else if(salario < 1)
                {
                    Console.WriteLine("El valor introducido no es válido");
                }
                
                Console.ReadKey();

             

            /*
            Console.WriteLine("digite la opción que corresponde a su salario" + "\n" + "1. Menos de 2 SMMLV" + "\n" + "2. de 2 SMMLV a menos de 4 SMMLV" + "\n" + "1. 4 o Más SMMLV");
            int sal = Convert.ToInt32(Console.ReadLine());

            if(sal == 1)
            {
                Console.WriteLine("La tarifa correspondiente a su pago es la tarifa A");
            }else if(sal == 2)
            {
                Console.WriteLine("La tarifa correspondiente a su pago es la tarifa B");
            }else if (sal == 3)
            {
                Console.WriteLine("La tarifa correspondiente a su pago es la tarifa C");
            }

            Console.ReadKey();
            */
        }
    }
}
