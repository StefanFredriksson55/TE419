using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstract
{
    class Säljare : Anställd
    {
        public override double beräknaLön()
        {
            return 12;
        }

        public override string Namn
        {
            get
            {
                return base._namn;
            }
            set
            {

            }
        }
    }
}
