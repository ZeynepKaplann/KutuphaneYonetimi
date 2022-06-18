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
    public partial class Personeller : Form
    {
        KutuphaneYonetimiEntities db = new KutuphaneYonetimiEntities();
        public Personeller()
        {
            InitializeComponent();
            PersonelleriListele();
        }

        private void PersonelleriListele()
        {
            //Personelleri Listeleme
            var personelListele = db.tbl_Personel.Where(p => p.Durum == true)
                          .Select(s => new
                          {
                              İd = s.Id,
                              Ad = s.PersonelAdi,
                              Soyad = s.PersonelSoyadi,
                              Mail = s.Email,
                              Yetki=s.Yetkisi,
                              Adress=s.Adres,
                              UyeDurum = s.Durum

                          });

            PersonnelerDTV.DataSource = personelListele.ToList();

        }

     

        private void Personeller_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PersonnelerDTV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
