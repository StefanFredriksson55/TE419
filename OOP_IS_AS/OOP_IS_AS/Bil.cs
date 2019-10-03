using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_IS_AS
{
    class Bil : Fordon
    {
        int _antalDörrar;
        public Bil(int antalDörrar, string regnr):base(regnr)
        {
            this._antalDörrar = antalDörrar;        }

        public void gasa()
        {
            MessageBox.Show("Bruumm brummm");
        }
        public override string ToString()
        {
            string s = "Regnr: " + this._regNr +
                       " antaldörar: " + this._antalDörrar;
            return s;
        }
    }
}
