using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOGSM
{
    public class Enquete
    {
        // class constructor
        public Enquete(Int16 aantal)
        {
            for (Int16 i = 0; i < aantal; i++)
                _vragen.Add(new Vraag());
        }

        // in vragen worden alle Vraag object bijgehouden
        private List<Vraag> _vragen = new List<Vraag>();
        public List<Vraag> Vragen
        {
            get { return _vragen; }
            set { _vragen = value; }
        }

        // het aantal deelnemers wordt hierin bijgehouden
        private Int16 _aantalDeelnemers;
        public Int16 AantalDeelnemers
        {
            get { return _aantalDeelnemers; }
            set { _aantalDeelnemers = value; }
        }

        // resultatenVerwerkt telt het aantal keer dat een antwoord verwerkt geweest is
        private Int16 resultatenVerwerkt = 0;

        // verwerkt een array van antwoorden en geeft het antwoord door aan het bijhorende Vraag object
        // returnt false als 1 vd vragen false returnt, dient om de enquete stop te zetten
        public Boolean VerwerkResultaat(String[] antwoorden)
        {
            Boolean succes = true;
            Int16 i = 0;
            foreach (String antwoord in antwoorden)
            {
                if (!_vragen[i].Verwerk(antwoord.ToUpper()))
                    succes = false;
                i++;                
            }

            resultatenVerwerkt++;

            // als het aantal verwerkte resultaten gelijk is aan het aantal deelnemers wordt er false gereturnd om de enquete te stoppen
            if (resultatenVerwerkt >= _aantalDeelnemers)
                return false;
            else
                return succes;
        }
    }
}
