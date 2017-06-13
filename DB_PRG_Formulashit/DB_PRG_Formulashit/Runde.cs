using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_PRG_Formulashit
{
    class Runde
    {
        private int _rundenID;

        public int rundenID
        {
            get { return _rundenID; }
            set { _rundenID = value; }
        }

        private int _fahrerID;

        public int fahrerID
        {
            get { return _fahrerID; }
            set { _fahrerID = value; }
        }

        private int _followPoints;

        public int followPoints
        {
            get { return _followPoints; }
            set { _followPoints = value; }
        }

        private int _leaderPoints;

        public int leaderPoints
        {
            get { return _leaderPoints; }
            set { _leaderPoints = value; }
        }

    }
}
