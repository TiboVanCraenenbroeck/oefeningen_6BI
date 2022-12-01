using Oefening03.models;
using Oefening03.repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Deze applicatie vraagt de voornaam, naam en de leeftijd van de gebruiker.
             * Nadien kijkt hij of de ingevoerde gegevens correct zijn (lengte voornaam en naam > 2 en leeftijd >= 18)
             */
            Console.WriteLine("Voornaam: ");
            string voornaam = Console.ReadLine();
            Console.WriteLine("Naam: ");
            string naam = Console.ReadLine();
            Console.WriteLine("Leeftijd: ");
            string leeftijd = Console.ReadLine();

            GebruikerModel gebruiker = new GebruikerModel(voornaam, naam, leeftijd);

            Auth auth = new Auth();
            bool controle = auth.Controle(gebruiker);
            Console.WriteLine($"{gebruiker.Voornaam} {gebruiker.Naam} is {gebruiker.Leeftijd}");
            if (controle) Console.WriteLine("De gebruikersgegevens zijn correct!");
            else Console.WriteLine("De gebruikersgegevens zijn niet correct!");
            Console.ReadLine();
        }
    }
}
