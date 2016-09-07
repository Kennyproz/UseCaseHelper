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

        public UseCase(string naam, string samenvatting, string aannamen, string beschrijving, string uitzondering, string resultaat)
        {
            this.naam = naam;
            this.samenvatting = samenvatting;
            this.aannamen = aannamen;
            this.beschrijving = beschrijving;
            this.uitzondering = uitzondering;
            this.resultaat = resultaat;
        }
        public UseCase(string naam)
        {
            this.naam = naam;
            
        }
    }
}
