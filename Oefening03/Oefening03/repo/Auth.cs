using Oefening03.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening03.repo
{
    class Auth
    {
        public bool Controle(GebruikerModel gebruiker)
        {
            if(Leeftijdscontrole(gebruiker.Leeftijd)) return true;
            if(Naamcontrole(gebruiker.Voornaam)) return true;
            if (Naamcontrole(gebruiker.Naam)) return true;
            return false;
        }
        private bool Leeftijdscontrole(int leeftijd)
        {
            // De gebruiker moet minstens 18 jaar oud zijn!
            if (leeftijd <= 18) return false;
            return true;
        }
        private bool Naamcontrole(string voornaam)
        {
            // De namen moeten minstens 2 karakters lang zijn!
            if (voornaam.Length < 2) return false;
            return true;
        }
    }
}
