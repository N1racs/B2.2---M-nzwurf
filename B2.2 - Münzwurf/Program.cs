using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2._2___Münzwurf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            #region
            int head = 0;
            int tail = 0;
            int coinThrows = 0;
            string howManyThrows = "Wie oft soll die Münze geworfen werden?";
            string wrongOutput = "ungültige eingabe.\n bitte versuche es nocheinmal!";
            bool output = false;
            #endregion

            Console.WriteLine(howManyThrows);
            Console.Write("> ");
            string input = Console.ReadLine();
            output = int.TryParse(input, out coinThrows);

            while (!output || coinThrows < 1)
            {
                Console.WriteLine(wrongOutput);
                Console.Write("> ");
                input = Console.ReadLine();
                output = int.TryParse(input, out coinThrows);
            }

            for (int i = 0; i < coinThrows; i++)
            { 
                int allThrows = random.Next(0,2);

                if (allThrows == 0)
                {
                    Console.WriteLine("Wurf " + (i + 1) + ": " + "Kopf");
                    head++;
                }
                else
                {
                    Console.WriteLine("Wurf " + (i + 1) + ": " + "Zahl");
                    tail++;
                }
            }

            Console.WriteLine("\nVerteilung: ");

            double headThrows = (double) head / coinThrows * 100;
            double tailThrows = (double) tail / coinThrows * 100;

            Console.WriteLine("Kopf: " + head + " - " + headThrows + "%");
            Console.WriteLine("Zahl: " + tail + " - " + tailThrows + "%");

        }
    }
}
