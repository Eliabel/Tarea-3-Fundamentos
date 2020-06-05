using System;

namespace Calculo_de_precio_final
{
    class Program
    {
        static void Main(string[] args)
        {
            double p, itbi, pf;
            Console.WriteLine("###############################CALCULO DE PRECIO FINAL##########################");
            Console.WriteLine("Escribe el precio del producto sin ITBI: "); p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el porciento de ITBI aplicable(COLOCAR EN DECIMAL): "); itbi = Convert.ToDouble(Console.ReadLine());
            pf=((p*itbi)+p);
            Console.WriteLine("El precio final es: "+pf);



        }
    }
}
