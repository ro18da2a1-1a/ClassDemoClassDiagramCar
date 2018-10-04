using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoClassDiagramCar.model
{
    class Ejer
    {
        // attribut
        private String _navn;

        // property
        public String Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        // Konstruktør
        public Ejer(String navn)
        {
            _navn = navn;
        }

        // ToString
        public override string ToString()
        {
            return $"Ejer: navn={_navn}";
        }

    }
}
