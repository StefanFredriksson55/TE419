using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Poly2
{
    class Djur
    {        
        public Djur()
        {            
        }

        public virtual void sort()
        {
            MessageBox.Show("Jag är ett djur");
        }
    }
}
