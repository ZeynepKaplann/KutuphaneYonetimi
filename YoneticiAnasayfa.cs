using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYonetimSistemi
{
    public partial class YoneticiAnasayfa : Form
    {
        public YoneticiAnasayfa()
        {
            InitializeComponent();
        }

        private void YoneticiAnasayfa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            Application.Exit();
        }

        private void btn_Kitapİslem_Click(object sender, EventArgs e)
        {
            Kitapİslemleri kitapİslemleri = new Kitapİslemleri();
            kitapİslemleri.Show();
            this.Hide();

        }

        private void btn_Personeller_Click(object sender, EventArgs e)
        {
            Personeller personeller = new Personeller();
            personeller.Show();
        }

        private void btnUyeler_Click(object sender, EventArgs e)
        {
            Üyeler uyeler = new Üyeler();
            uyeler.Show();
        }

        private void btn_Kitap_Click(object sender, EventArgs e)
        {
            Kitaplar kitaplar = new Kitaplar();
            kitaplar.Show();
            this.Hide();
        }

        private void button_ist_Click(object sender, EventArgs e)
        {
            İstatistik istatistik = new İstatistik();
            istatistik.Show();
        }
    }
}
