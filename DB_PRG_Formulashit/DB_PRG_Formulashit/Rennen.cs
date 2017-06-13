using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_PRG_Formulashit
{
    class Rennen
    {
        private int _rennenID;

        public int rennenID
        {
            get { return _rennenID; }
            set { _rennenID = value; }
        }

        private int _streckenID;

        public int streckenID
        {
            get { return _streckenID; }
            set { _streckenID = value; }
        }

        private int _gewinnerID;

        public int gewinnerID
        {
            get { return _gewinnerID; }
            set { _gewinnerID = value; }
        }

    }
}
