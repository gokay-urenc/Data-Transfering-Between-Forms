using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // public ListBox ekleme_yapılacak_liste; // 1. Yol
        public Form1 birinci_form; // 2. Yol

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            // ekleme_yapılacak_liste.Items.Add(metin); // 1. Yol
            birinci_form.listBox1.Items.Add(metin); // 2. Yol
        }
    }
}
// 2. Yolda ilk formun listBox1 nesnesinin modifiers özelliğini public yaptık.