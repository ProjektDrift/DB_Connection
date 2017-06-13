using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_PRG_Formulashit
{
    class Fahrer
    {
        private int _fahrerID;

        public int fahrerID
        {
            get { return _fahrerID; }
            set { _fahrerID = value; }
        }

        private int _landID;

        public int landID
        {
            get { return _landID; }
            set { _landID = value; }
        }

        private string _nachname;

        public string nachname
        {
            get { return _nachname; }
            set { _nachname = value; }
        }

        private string _vorname;

        public string vorname
        {
            get { return _vorname; }
            set { _vorname = value; }
        }

        private int _alter;

        public int alter
        {
            get { return _alter; }
            set { _alter = value; }
        }

    }
}
