using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektoNuskaitymasIsKonsoles
{
    internal class Preke
    {
        private string pavadinimas;
        private string aprasymas;
        private double kaina;
        private long id;

        public Preke(string pavadinimas, string aprasymas, double kaina, long id)
        {
            this.pavadinimas = pavadinimas;
            this.aprasymas = aprasymas;
            this.kaina = kaina;
            this.id = id;
        }

        public Preke()
        {
        }

        public string Pavadinimas 
        { 
            get 
            { 
                return pavadinimas; 
            }
            set
            {
                this.pavadinimas = value;   
            }
        }

        public string Aprasymas
        {
            get
            {
                return aprasymas;
            }
            set { aprasymas = value; }
        }

        public long Id
        {
            get
            {
                return id;  
            }
            set
            {
                id = value;
            }
        }

        public double Kaina
        {
            get { return kaina; }
            set { kaina = value; }
        }


    }
}
