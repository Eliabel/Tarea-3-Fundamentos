using System;

namespace La_media
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            int[] n;
            n = new int[6];
            Console.WriteLine("###############################CALCULO DE LA MEDIA#############################");
            Console.WriteLine("Escribe 5 numeros para calcular su media: ");
            for (int i = 1; i <= 5; i++)
            {
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
            r=((n[1] + n[2] + n[3] + n[4] + n[5])/5);
            Console.WriteLine("La media de estos numeros es: " +r);

        }
    }
}
