using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arv_Polymorphism_Player
{
    class Player
    {
        protected string _userName;
        protected int playTime;

        public Player(string username)
        {
            this._userName = username;
            MessageBox.Show("Nu skapades en player");
        }
        public Player(int playTime)
        {
            MessageBox.Show("Nu körst lilla tomma jag");
        }

        public override string ToString()
        {
            return "Hej";
        }
    }
}
