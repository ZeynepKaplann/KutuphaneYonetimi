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
        KutuphaneYonetimiEntities db = new KutuphaneYonetimiEntities();


        public Üyeler()
        {
            InitializeComponent();
            UyeleriListele();
        }

        private void UyeleriListele()
        {
            var uyeleriListele = db.tbl_Uyeler.Where(u => u.Durum == true)
                                   .Select(s => new
                                   {
                                       İd = s.Id,
                                       Ad = s.UyeAdi,
                                       Soyad = s.UyeSoyadi,
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
            var ara = from x in db.tbl_Uyeler select x;
            if (txtUyeAdSoyad.Text!=null)
            {
                UyelerDTV.DataSource = ara.Where(x => x.UyeAdi.Contains(txtUyeAdSoyad.Text)).ToList();
            }
        }

        private void UyelerDTV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
