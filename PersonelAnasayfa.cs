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
    public partial class PersonelAnasayfa : Form
    {
        public PersonelAnasayfa()
        {
            InitializeComponent();
        }

        private void PersonelAnasayfa_Load(object sender, EventArgs e)
        {

        }

        private void btn_Uyeİslem_Click(object sender, EventArgs e)
        {
            Uyeİslemleri uyeİslemleri = new Uyeİslemleri();
            uyeİslemleri.Show();
            this.Hide();

        }

        private void prsCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_üyeler_Click(object sender, EventArgs e)
        {
            Üyeler uyeler = new Üyeler();
            uyeler.Show();
            this.Hide();
        }

   

        private void btn_kitaplar_Click(object sender, EventArgs e)
        {
            Kitaplar kitaplar = new Kitaplar();
            kitaplar.Show();
            this.Hide();
        }

        private void btn_Sepet_Click(object sender, EventArgs e)
        {
            Sepetİslem sepetİslem = new Sepetİslem();
            sepetİslem.ShowDialog();
        }

        private void btn_emanetTakip_Click(object sender, EventArgs e)
        {
            EmanetVer emanetVer = new EmanetVer();
            emanetVer.Show();

        }

        private void Emanet_Click(object sender, EventArgs e)
        {
            Emanet emanet = new Emanet();
            emanet.ShowDialog();
        }
    }
}
