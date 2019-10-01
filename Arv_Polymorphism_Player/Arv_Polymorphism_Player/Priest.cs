using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arv_Polymorphism_Player
{
    class Priest : Player
    {
        int _mana;

        //public Priest(string username, int mana) : base(username)
        //{
        //    this._userName = username;
        //    this._mana = mana;
        //    MessageBox.Show("Nu skapades en Priest");

        //}
        public Priest(string username, int mana, int playTime) : base(playTime)
        {
            this._userName = username;
            this._mana = mana;
            MessageBox.Show("Nu skapades en Priest");
        }
    }
}
