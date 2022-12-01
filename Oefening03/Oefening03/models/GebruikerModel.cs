using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening03.models
{
    class GebruikerModel
    {
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        private int LeeftijdP;

        public int Leeftijd
        {
            get { return LeeftijdP; }
            set
            { 
                LeeftijdP = Convert.ToInt32(value); 
            }
        }
        public GebruikerModel(string voornaam, string naam, string leeftijd)
        {
            Voornaam = voornaam;
            Naam = naam;
            leeftijd = leeftijd;
        }
    }
}
