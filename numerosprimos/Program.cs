using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace GENERAR_N_NÚMEROS_PRIMOS
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, RESI, K, SW, CAN, X;
            string linea;
            Console.Write("CUANTOS NÚMEROS: "); linea = Console.ReadLine();
            CAN = int.Parse(linea);
            NUM = 1; X = 0;
            while ((X < CAN))
            {
                K = 2; SW = 0;
                while (((K < NUM) & (SW == 0))) {
                    RESI = NUM % K;
                    if ((RESI == 0))
                    {
                        SW = 1;
                    }
                    else
                    {
                        K = K + 1;
                    }
                }
                if ((SW == 0))
                {
                    Console.Write(NUM + " ");
                    X = X + 1;
                }
                NUM = NUM + 1;
            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}