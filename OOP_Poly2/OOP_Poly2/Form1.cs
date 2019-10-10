using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Poly2
{
   
    public partial class Form1 : Form
    {
        List<Djur> djurLista = new List<Djur>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            djurLista.Add(new Hund());
            djurLista.Add(new Katt());
            foreach(Djur d in djurLista)
            {
                
                d.sort();
                //if (d is Hund)
                //{
                //    Hund h = d as Hund;
                //    h.sort();
                //}
                //else if (d is Katt)
                //{
                //    Katt k = d as Katt;
                //    k.sort();
                //}
                //else
                //{
                //    d.sort();
                //}

            }
        }
    }
}
