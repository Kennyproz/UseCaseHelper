using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Cases
{
    public class UseCase
    {
        private string naam;
        private string samenvatting;
        private string aannamen;
        private string beschrijving;
        private string uitzondering;
        private string resultaat;
        private int x;
        private int y;

        public string Naam
        {
            get
            {
                return naam;
            }

            set
            {
                naam = value;
            }
        }

        public string Samenvatting
        {
            get
            {
                return samenvatting;
            }

            set
            {
                samenvatting = value;
            }
        }

        public string Aannamen
        {
            get
            {
                return aannamen;
            }

            set
            {
                aannamen = value;
            }
        }

        public string Beschrijving
        {
            get
            {
                return beschrijving;
            }

            set
            {
                beschrijving = value;
            }
        }

        public string Uitzondering
        {
            get
            {
                return uitzondering;
            }

            set
            {
                uitzondering = value;
            }
        }

        public string Resultaat
        {
            get
            {
                return resultaat;
            }

            set
            {
                resultaat = value;
            }
        }

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public UseCase(string naam)
        {
            this.naam = naam; 
        }
        public UseCase(UseCase Case)
        {
            Case.naam = naam;
            Case.samenvatting = samenvatting;
            Case.aannamen = aannamen;
            Case.beschrijving = beschrijving;
            Case.uitzondering = uitzondering;
            Case.resultaat = resultaat;
        }
    }
}
