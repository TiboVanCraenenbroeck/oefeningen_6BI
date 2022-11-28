using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Deze app vraagt willekeurige getallen aan de gebruiker.
             * Stopt pas als de gebruiker op enter drukt.
             */
            List<int> getallen = new List<int>();
            bool volgende = true;

            while (volgende)
            {
                Console.WriteLine("Willekeurig getal: ");
                string getal = Console.ReadLine();
                if(getal != "")
                {
                    volgende = false;
                }
                else
                {
                    getallen.Add(getal);
                }

            }

            Console.WriteLine("De gekozen getallen zijn:");
            foreach (int g in getallen)
            {
                Console.WriteLine(g);
            }

            Console.ReadLine();
        }
    }
}
