using System;

namespace Notas_de_examen
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            int[] n;
            n = new int[6];
            Console.WriteLine("###############################CALIFICACIONES DE EXAMENES#############################");
            Console.WriteLine("Escribe las 5  notas sacadas en examenes: ");
            for (int i = 1; i <= 5; i++)
            {
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
            r = ((n[1] + n[2] + n[3] + n[4] + n[5]) / 5);
            if (r>=70)
            {
                Console.WriteLine("Abrobado");
            }
            else { Console.WriteLine("Reprobado");}
            
        }
    }
}
