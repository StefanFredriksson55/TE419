using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstract
{
    abstract class Anställd
    {
        protected string _namn;
        abstract public double beräknaLön();
        abstract public string Namn{get; set;}
    }
}






