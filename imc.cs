using System;

namespace IMC
{
    class imc
    {
        static void Main(string[] args)
        {
            float altura, peso, imc;

            Console.WriteLine("Por favor ingrese altura en cm");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese peso en kg");
            peso = float.Parse(Console.ReadLine());

            imc = (peso / ((altura/100) * (altura/100)));

            Console.WriteLine("Su indice de masa corporal (IMC) es: " +imc );
            if (imc < 18.5)
            {
                Console.WriteLine("usted se encuentra bajo de peso");
            }
            else if (imc >= 18.5 && imc < 25)
            { 
                Console.WriteLine("Usted presenta un peso normal");            
            }
            else if(imc >= 25 && imc < 30)
            {
                Console.WriteLine("usted presenta sobrepeso");
            }
            else if (imc > 30)
            {
                Console.WriteLine("usted presenta obesidad");
            }

            Console.ReadKey();
        }
    }
}
