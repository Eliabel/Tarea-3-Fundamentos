using System;

namespace Division_y_resto
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1, N2, d, r;
            Console.Write("Division y resto de dos numeros \n Escribe el primer numero: ");
            N1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escribe el siguiente numero: ");
            N2 = Convert.ToInt32(Console.ReadLine());
            d = (N1/N2);
            r = (N1 % N2);
            Console.Write("El resultado de la division es: "+ d + "\n El resto de la division es: "+r);
            // ELIABEL ROSARIO DE LOS SANTOS 2019-8146   04/06/2020
        }
    }
}
