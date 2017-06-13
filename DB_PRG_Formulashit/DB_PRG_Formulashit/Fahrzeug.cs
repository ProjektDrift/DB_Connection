using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_PRG_Formulashit
{
    class Fahrzeug
    {
        private int _fahrzeugID;

        public int fahrzeugID
        {
            get { return _fahrzeugID; }
            set { _fahrzeugID = value; }
        }

        private int _herstellerID;

        public int herstellerID
        {
            get { return _herstellerID; }
            set { _herstellerID = value; }
        }

        private string _modell;

        public string modell
        {
            get { return _modell; }
            set { _modell = value; }
        }

        private int _ps;

        public int ps
        {
            get { return _ps; }
            set { _ps = value; }
        }

        private int _dm;

        public int dm
        {
            get { return _dm; }
            set { _dm = value; }
        }

    }
}
