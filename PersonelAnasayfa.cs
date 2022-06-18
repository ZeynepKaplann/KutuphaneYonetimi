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
            uyeİslemleri.ShowDialog();
            

        }

        private void prsCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_üyeler_Click(object sender, EventArgs e)
        {
            Üyeler uyeler = new Üyeler();
            uyeler.ShowDialog();
            
        }

   

        private void btn_kitaplar_Click(object sender, EventArgs e)
        {
            Kitaplar kitaplar = new Kitaplar();
            kitaplar.ShowDialog();
            
        }

       

        private void Emanet_Click(object sender, EventArgs e)
        {
            Emanet emanet = new Emanet();
            emanet.ShowDialog();
        }

        private void btn_TeslimAl_Click(object sender, EventArgs e)
        {
            TeslimAlmaİslemleri teslimAlmaİslemleri = new TeslimAlmaİslemleri();
            teslimAlmaİslemleri.ShowDialog();
        }

        private void btn_istatistik_Click(object sender, EventArgs e)
        {
            İstatistik istatistik = new İstatistik();
            istatistik.ShowDialog();
        }
    }
}
