using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoClassDiagramCar.model
{
    class Bil
    {
        // attributter
        private String _model;

        private int _kørtKM;


        // Associering
        private List<Ejer> _bilEjer;
        // "property"
        public List<Ejer> BilEjer {get { return _bilEjer; }}

        // aggregering
        private Hjul[] _bilHjul;
        // "property"
        public Hjul[] BilHjul { get { return _bilHjul; } }

        // composite
        private List<Dør> _bilDøre;
        // metoder til døre
        public void TilføjDør()
        {
            _bilDøre.Add(new Dør());
        }

        public void ÅbenDør(int ix)
        {
            _bilDøre[ix].IsOpen = true;
        }

        public void LukDør(int ix)
        {
            _bilDøre[ix].IsOpen = false;
        }

        public List<Dør> HentDøre()
        {
            return _bilDøre;
        }

        // Properties
        public String Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int KørtKM
        {
            get { return _kørtKM; }
            set { _kørtKM = value; }
        }

        // Konstruktør
        public Bil(String model, int km)
        {
            _model = model;
            _kørtKM = km;

            // til associering
            _bilEjer = new List<Ejer>();

            // til aggregering
            _bilHjul = new Hjul[4];

            // til composite
            _bilDøre = new List<Dør>();

        }


        // ToString
        public override string ToString()
        {

            // todo support associering, aggregering og composite
            return $"Bil: model={_model} kørt km={_kørtKM}";
        }

        // metode
        public int DageTilNæsteVærksted()
        {
            int restkm = _kørtKM % 10000; // værksted hver 10000 km
            return restkm / 25; // 25 km / dag
        }
    }
}
