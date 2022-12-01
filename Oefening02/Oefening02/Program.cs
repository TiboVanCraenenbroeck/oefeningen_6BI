using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* De gebruiker kan 3 getallen tussen 1 en 10 ingeven. Nadien krijgt de gebruiker de soms van de 3 getallen te zien.
             * Er zitten 3 fouten in het programma:
             * Fout 1: 
             * Fout 2:
             * Fout 3: 
             */
            int[] getallen = new int[3];
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Kies een getal tussen 1 en 10: ");
                int getal = Console.ReadLine();
                if(getal < 0 || getal > 10)
                {
                    Console.WriteLine("Het getal moet tussen 1 en 10 zijn!");
                    i--;
                }
                else
                {
                    getallen[i] = getal;
                }
            }
            Console.WriteLine(getallen.Sum());
            Console.ReadLine();
        }
    }
}
