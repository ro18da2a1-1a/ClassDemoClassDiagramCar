using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoClassDiagramCar.model
{
    class Hjul
    {
        // attribut
        private String _sæson;

        // property
        public String Sæson {
            get { return _sæson; }
            set { _sæson = value; } 
        }

        // Konstruktør
        public Hjul(String sæson)
        {
            _sæson = sæson;
        }

        // ToString
        public override string ToString()
        {
            return $"Hjul: sæson={_sæson}";
        }
    }
}
