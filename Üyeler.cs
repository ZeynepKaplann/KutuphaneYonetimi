using KutuphaneYonetimSistemi.Model.Entities;
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
    public partial class Üyeler : Form
    {
        KutuphaneEntities db = new KutuphaneEntities();


        public Üyeler()
        {
            InitializeComponent();
            UyeleriListele();
        }

        private void UyeleriListele()
        {
            //Üyeleri Listeleme
            var uyeleriListele = db.tbl_Uyeler.Where(u => u.Durum == true || u.Durum==false)
                                   .Select(s => new
                                   {
                                       İd = s.İd,
                                       Ad = s.ÜyeAdi,
                                       Soyad = s.ÜyeSoyadi,
                                       Mail = s.Email,
                                       Tel = s.Telefon,
                                       Cins = s.Cinsiyet,
                                       UyeDurum = s.Durum

                                   });

            UyelerDTV.DataSource = uyeleriListele.ToList();
        }

        private void Üyeler_Load(object sender, EventArgs e)
        {
            UyeleriListele();

        }

        private void btn_uyelerCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUyeAdSoyad_TextChanged(object sender, EventArgs e)
        {
            //İsme göre üye arama
            var ara = from x in db.tbl_Uyeler select x;
            if (txtUyeAdSoyad.Text!=null)
            {
                UyelerDTV.DataSource = ara.Where(x => x.ÜyeAdi.Contains(txtUyeAdSoyad.Text)).ToList();
            }
        }

        private void UyelerDTV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
