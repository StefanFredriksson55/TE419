using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_IS_AS
{
    public partial class Form1 : Form
    {
        List<Fordon> fordonsLista = new List<Fordon>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fordonsLista.Add(new Bil(5, "BIL123"));
            fordonsLista.Add(new Släp(2000, "SLÄ567"));
            listaFordon();
        }

        private void listaFordon()
        {
            listBox1.Items.Clear();
            foreach(Fordon f in fordonsLista)
            {
                listBox1.Items.Add(f);
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fordon f = (Fordon)listBox1.SelectedItem;
            Fordon f = listBox1.SelectedItem as Fordon;
            MessageBox.Show(f.ToString());
            
            

            if (f is Bil)
            {
                Bil b = f as Bil;
                b.gasa();
            }
            else if (f is Släp)
            {

            }
           

        }
    }
}
