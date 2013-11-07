using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOGSM
{
    public class Vraag
    {
        private Int16 ja;
        private Int16 nee;
        private Int16 neutraal;

        // verwerkt een antwoord en returnt false als het geen geldig antwoord is
        public Boolean Verwerk(String antwoord)
        {
            switch (antwoord)
            {
                case "J": ja++; break;
                case "N": nee++; break;
                case "O": neutraal++; break;
                default: return false;
            }        

            return true;                
        }

        // de huidige resultaten
        public String Resultaat()
        {
            return "- # ja: " + ja.ToString() + 
                "\n- # nee: " + nee.ToString() +
                "\n- # onverschillig: " + neutraal.ToString();
        }

        // resultaat specifiek voor het gsm gebruik
        public String GsmGebruik()
        {
            if (ja == nee)
                return "Het resultaat van de enquete is onbepaald.";
            else 
                return "Volgens de enquete is het gsm gebruik in een klaslokaal " + (ja < nee ? "niet " : "") + "toegelaten.";

        }
    }
}
