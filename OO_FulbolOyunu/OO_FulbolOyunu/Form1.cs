using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_FulbolOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adi = txtboxAdı.Text;
            byte formatNo = Convert.ToByte(NumNo.Value);
            string takimi = txtboxTakim.Text;

            Oyunucu o = new Oyunucu(adi,formatNo,takimi);
            LstBoxOyuncular.Items.Add(o);
        }

        private void LstBoxOyuncular_SelectedIndexChanged(object sender, EventArgs e)

        {
            Oyunucu o = (Oyunucu)LstBoxOyuncular.SelectedItem;
            MessageBox.Show(o.Bilgiver());
        }

    }
}
