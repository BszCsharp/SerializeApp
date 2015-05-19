using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jason1
{
    class Kontakt
    {
        private string firma;

        public string Firma
        {
            get { return firma; }
            set { firma = value; }
        }
        public string Nachname { get; set;  }
        public string Vorname { get; set; }
        public string Telefonnummer { get; set; }
        public String Emial { get; set; }



    }
}
