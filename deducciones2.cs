using System;

namespace deducciones2
{
    class deducciones2
    {
        static void Main(string[] args)
        {
            double pension = 0;
            double arl = 0;
            double eps = 0;
            double bonif = 0;
            double smmlv = 877803;
            double sreal = 0;
            double sanual = 0;

            Console.WriteLine("ingrese el valor de su salario");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("digite la opción que corresponde a su Tipo de Contrato" + "\n" + "1. Dependiente" + "\n" + "2. Independiente" + "\n");
            int contrato = Convert.ToInt32(Console.ReadLine());

            double bcoti = salario * 0.4;

            if (bcoti < smmlv) bcoti = smmlv;

            switch (contrato)
            {
                case 1:
                    bonif = salario;
                    pension = bcoti * 0.04;
                    eps = bcoti * 0.04;
                    double deducciones = pension + eps;
                    sreal = salario - deducciones;
                    sanual = (sreal * 12) + bonif;

                    Console.WriteLine("Deducciones: "+deducciones + "\n" + "pensión :" + pension + "    Eps: " + eps);
                    Console.WriteLine("Su Salario real mensual es: " + sreal + "\n" + "su salario anual es: " + sanual);
                    break;

                case 2:
                    Console.WriteLine("digite el nivel de riesgo laboral de 1 a 5");
                    int riesgo = Convert.ToInt32(Console.ReadLine());

                    switch (riesgo)
                    {
                        case 1: arl = 0.00522 * bcoti;
                            break;
                        case 2: arl = 0.01044 * bcoti;
                            break;
                        case 3: arl = 0.02436 * bcoti;
                            break;
                        case 4: arl = 0.04350 * bcoti;
                            break;
                        case 5: arl = 0.06960 * bcoti;
                            break;
                    }
                    
                    pension = bcoti * 0.16;
                    eps = bcoti * 0.125;
                    double deduccionesi = pension + eps + arl;
                    sreal = salario - (pension+eps+arl);
                    sanual = sreal * 12;

                    Console.WriteLine("Deducciones: " + deduccionesi + "\n" + "pensión :" + pension + "    Eps: " + eps+"    Arl: "+arl);
                    Console.WriteLine("Su Salario real mensual es: " + sreal + "\n" + "su salario anual es: " + sanual);

                    break;
            }
        }
    }
}
