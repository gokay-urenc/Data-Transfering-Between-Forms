﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlar_Arasi_Veri_Tasima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ikinci_form = new Form2();
            //  ikinci_form.ekleme_yapılacak_liste = this.listBox1; // 1. Yol
            ikinci_form.birinci_form = this; // 2. Yol
            ikinci_form.Show();
        }
    }
}