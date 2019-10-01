using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arv_Polymorphism_Player
{
    public partial class Form1 : Form
    {
        List<Player> playerList = new List<Player>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Player p = new Player("Stefan");
            //playerList.Add(p);
            Priest pr = new Priest("Prälle", 100, 30);
            playerList.Add(pr);
            playerList.Add(new Priest("ShadowPriest", 100, 30));
            
        }
    }
}
