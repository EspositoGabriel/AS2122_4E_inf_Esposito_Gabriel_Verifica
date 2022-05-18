using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_4E_inf_Esposito_Gabriel_Verifica
{
    public partial class Form1 : Form
    {
        Dictionary<string, Articolo> articoli;
        public Form1()
        {
            InitializeComponent();
            articoli = new Dictionary<string, Articolo>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (articoli.ContainsKey(txtCodice.Text))
            {
                articoli[txtCodice.Text] = new Articolo(txtCodice.Text, unitadimisura.Text, txtDescrizione.Text, txtPrezzo.Text);
            }
        else {

                articoli.Add(txtCodice.Text, new Articolo(txtCodice.Text, unitadimisura.Text, txtDescrizione.Text, txtPrezzo.Text);
        
        }

                    
                    
                    
            }
        private void btnVisualizza_Click(object sebnder ,EventArgs e)
        {

            int count = 0;
        foreach(KeyValuePair<string, Articolo>a in articoli)
            {
                lstVisualizza.Items.Add(a.ToString());
                lnlArticoliNumerati.Text =$ "Articolo  (count)";
            }
        
        }
                    

        }
    }
}
