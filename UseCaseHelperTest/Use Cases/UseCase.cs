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
        private string actor1;
        private string actor2;
        private string actor3;
        private bool actornaam1;
        private bool actornaam2;
        private bool actornaam3;
        private bool select;
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

        public bool Select
        {
            get
            {
                return select;
            }

            set
            {
                select = value;
            }
        }

        public bool Actornaam1
        {
            get
            {
                return actornaam1;
            }

            set
            {
                actornaam1 = value;
            }
        }

        public bool Actornaam2
        {
            get
            {
                return actornaam2;
            }

            set
            {
                actornaam2 = value;
            }
        }

        public bool Actornaam3
        {
            get
            {
                return actornaam3;
            }

            set
            {
                actornaam3 = value;
            }
        }

        public string Actor1
        {
            get
            {
                return actor1;
            }

            set
            {
                actor1 = value;
            }
        }

        public string Actor2
        {
            get
            {
                return actor2;
            }

            set
            {
                actor2 = value;
            }
        }

        public string Actor3
        {
            get
            {
                return actor3;
            }

            set
            {
                actor3 = value;
            }
        }

        public UseCase(string naam)
        {
            this.naam = naam; 
        }
        public UseCase(UseCase Case)
        {
      
        }
    }
}
