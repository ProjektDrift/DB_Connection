using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_PRG_Formulashit
{
    class Phase
    {
        private int _phaseID;

        public int phaseID
        {
            get { return _phaseID; }
            set { _phaseID = value; }
        }

        private int _rennenID;

        public int rennenID
        {
            get { return _rennenID; }
            set { _rennenID = value; }
        }

        private string _bezeichnung;

        public string bezeichnung
        {
            get { return _bezeichnung; }
            set { _bezeichnung = value; }
        }

    }
}
