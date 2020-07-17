using System;

namespace deducciones_salariales
{
    class deducciones
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            
            int riesgo = 0;
            double sreal = 0;
            double deducciones = 0;
            double pension = 0;
            double arl = 0;
            double eps = 0;
            double bonif = 0;
            double sanual = 0;
            double bcoti = 0;
            double smmlv = 877803;

            Console.WriteLine("ingrese el valor de su salario");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("digite la opción que corresponde a su Tipo de Contrato" + "\n" + "1. Dependiente" + "\n" + "2. Independiente" + "\n");
            int contrato = Convert.ToInt32(Console.ReadLine());
            
            
            bcoti = salario * 0.4;
            
            if (bcoti < smmlv)
            {
                if (contrato == 2)
                { 
                    Console.WriteLine("digite el nivel de riesgo laboral de 1 a 5");
                    riesgo = Convert.ToInt32(Console.ReadLine());
                    double Parl = 0;

                    pension = smmlv * 0.16;
                    eps = smmlv * 0.125;

                
                    if (riesgo == 1)
                    {
                        Parl = 0.00522;
                        arl = smmlv * Parl;
                        deducciones = pension + eps + arl;
                        sreal = salario - deducciones;
                        sanual = sreal * 12;

                        Console.WriteLine("Su Salario real mensual es: " + sreal + "\n" + "su salario anual es: " + sanual);


                    }
                    else if (riesgo == 2)
                    {
                        Parl = 0.01044;
                        arl = smmlv * Parl;
                        deducciones = pension + eps + arl;
                        sreal = salario - deducciones;
                        sanual = sreal * 12;

                        Console.WriteLine("Su Salario real mensual es: " + sreal + "\n" + "su salario anual es: " + sanual);
                    }
                    else if (riesgo == 3)
                    {
                        Parl = 0.02436;
                        arl = smmlv * Parl;
                        deducciones = pension + eps + arl;
                        sreal = salario - deducciones;
                        sanual = sreal * 12;

                        Console.WriteLine("Su Salario real mensual es: " + sreal + "\n" + "su salario anual es: " + sanual);
                    }
                    else if (riesgo == 4)
                    {
                        Parl = 0.04350;
                        arl = smmlv * Parl;
                        deducciones = pension + eps + arl;
                        sreal = salario - deducciones;
                        sanual = sreal * 12;

                        Console.WriteLine("Su Salario real mensual es: " + sreal + "\n" + "su salario anual es: " + sanual);
                    }
                    else if (riesgo == 5)
                    {
                        Parl = 0.06960;
                        arl = smmlv * Parl;
                        deducciones = pension + eps + arl;
                        sreal = salario - deducciones;
                        sanual = sreal * 12;

                        Console.WriteLine("Su Salario real mensual es: " + sreal + "\n" + "su salario anual es: " + sanual);

                    }


                }
                else
                {
                    bonif = salario;
                    pension = smmlv * 0.04;
                    eps = smmlv * 0.04;
                    deducciones = pension + eps;
                    sreal = salario - deducciones;
                    sanual = (sreal * 12) + bonif;

                    Console.WriteLine("Su Salario real mensual es: " + sreal + "\n" + "su salario anual es: " + sanual);

                }

            }
            else if(bcoti >= 877803)
            {
                if (contrato == 2)
                {
                    Console.WriteLine("digite el nivel de riesgo laboral de 1 a 5");
                    riesgo = Convert.ToInt32(Console.ReadLine());
                    double Parl = 0;

                    pension = bcoti * 0.16;
                    eps = bcoti * 0.125;


                    if (riesgo == 1)
                    {
                        Parl = 0.00522;
                        arl = bcoti * Parl;
                        deducciones = pension + eps + arl;
                        sreal = salario - deducciones;
                        sanual = sreal * 12;

                        Console.WriteLine("Su Salario real mensual es: " + sreal + "\n" + "su salario anual es: " + sanual);


                    }
                    else if (riesgo == 2)
                    {
                        Parl = 0.01044;
                        arl = bcoti * Parl;
                        deducciones = pension + eps + arl;
                        sreal = salario - deducciones;
                        sanual = sreal * 12;

                        Console.WriteLine("Su Salario real mensual es: " + sreal + "\n" + "su salario anual es: " + sanual);
                    }
                    else if (riesgo == 3)
                    {
                        Parl = 0.02436;
                        arl = bcoti * Parl;
                        deducciones = pension + eps + arl;
                        sreal = salario - deducciones;
                        sanual = sreal * 12;

                        Console.WriteLine("Su Salario real mensual es: " + sreal + "\n" + "su salario anual es: " + sanual);
                    }
                    else if (riesgo == 4)
                    {
                        Parl = 0.04350;
                        arl = bcoti * Parl;
                        deducciones = pension + eps + arl;
                        sreal = salario - deducciones;
                        sanual = sreal * 12;

                        Console.WriteLine("Su Salario real mensual es: " + sreal + "\n" + "su salario anual es: " + sanual);
                    }
                    else if (riesgo == 5)
                    {
                        Parl = 0.06960;
                        arl = bcoti * Parl;
                        deducciones = pension + eps + arl;
                        sreal = salario - deducciones;
                        sanual = sreal * 12;

                        Console.WriteLine("Su Salario real mensual es: " + sreal + "\n" + "su salario anual es: " + sanual);

                    }


                }
                else
                {
                    bonif = salario;
                    pension = bcoti * 0.04;
                    eps = bcoti * 0.04;
                    deducciones = pension + eps;
                    sreal = salario - deducciones;
                    sanual = (sreal * 12) + bonif;

                    Console.WriteLine("Su Salario real mensual es: " + sreal + "\n" + "su salario anual es: " + sanual);

                }
            }


            Console.ReadKey();

        }
    }
}
