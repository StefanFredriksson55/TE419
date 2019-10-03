using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_IS_AS
{
    class Släp : Fordon 
    {
        int _maxVikt;
        public Släp(int maxvikt, string regnr) : base(regnr)
        {

            this._maxVikt = maxvikt;
        }

        //public override string ToString()
        //{
        //    string s = "Regnr: " + this._regNr +
        //               " maxvikt: " + this._maxVikt;
        //    return s;
        //}
    }
}
