﻿using System;
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
        Dictionary<string,Articolo> articoli;
        public Form1()
        {
            InitializeComponent();
            articoli = new Dictionary<string, Articolo>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
