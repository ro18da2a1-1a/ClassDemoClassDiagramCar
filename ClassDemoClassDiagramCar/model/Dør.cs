using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoClassDiagramCar.model
{
    class Dør
    {
        // attribut
        private bool _isOpen;

        // property
        public bool IsOpen
        {
            get { return _isOpen; }
            set { _isOpen = value; }
        }

        // Konstruktør
        public Dør()
        {
            _isOpen = false;
        }

        // ToString
        public override string ToString()
        {
            return $"Dør: isOpen={_isOpen}";
        }
    }
}
