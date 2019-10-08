using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Poly2
{
    class Hund : Djur
    {        
        public Hund()
        {

        }

        public override void sort()
        {
            MessageBox.Show("Jag är en hund");
        }

    }
}
