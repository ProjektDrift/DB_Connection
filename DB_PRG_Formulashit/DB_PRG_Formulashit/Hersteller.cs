using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_PRG_Formulashit
{
    class Hersteller
    {
        private int _herstellerID;

        public int herstellerID
        {
            get { return _herstellerID; }
            set { _herstellerID = value; }
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
        
    }
}
