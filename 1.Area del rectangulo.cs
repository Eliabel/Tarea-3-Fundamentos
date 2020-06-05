using System;

namespace Area_del_rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, a, r;
            Console.WriteLine("###############################CALCULOD EL AREA DE UN RECTANGULO#############################");
            Console.WriteLine("Escribe la base del rectangulo: "); b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe la altura del rectangulo: "); a = Convert.ToInt32(Console.ReadLine());
            r = (b * a);
            Console.WriteLine("El area del rectangulo es: "+r); 

        }
    }
}
