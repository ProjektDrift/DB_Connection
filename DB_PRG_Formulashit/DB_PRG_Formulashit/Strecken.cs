using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_PRG_Formulashit
{
    class Strecken
    {
        private int _streckenID;

        public int streckenID
        {
            get { return _streckenID; }
            set { _streckenID = value; }
        }

        private int _landID;

        public int landID
        {
            get { return _landID; }
            set { _landID = value; }
        }

        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private double _länge;

        public double länge
        {
            get { return _länge; }
            set { _länge = value; }
        }

        private string _ort;

        public string ort
        {
            get { return _ort; }
            set { _ort = value; }
        }

    }
}
