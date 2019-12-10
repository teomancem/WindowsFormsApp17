using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Normal norm = new Normal();
            norm.İsim = "Teoman";
            Firma firm = new Firma();
            firm.CalisanEkle(norm);
            MessageBox.Show("Calisan adi:" + firm.Kullanicilar);

        }
    }
}
