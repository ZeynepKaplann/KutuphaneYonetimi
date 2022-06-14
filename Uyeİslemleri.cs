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
    public partial class Uyeİslemleri : Form
    {
        KutuphaneYonetimiEntities db = new KutuphaneYonetimiEntities();

        public Uyeİslemleri()
        {
            InitializeComponent();
            UyeleriListele();
        }

        private void UyeleriListele()  //Eklediğim üyeleri DataGridView'de görüntülemek için.
        {
            var uyeleriListele = db.tbl_Uyeler.Where(u => u.Durum == true )
                                    .Select(s => new
                                    {
                                        İd = s.Id,
                                        Ad = s.UyeAdi,
                                        Soyad = s.UyeSoyadi,
                                        Mail = s.Email,
                                        Tel = s.Telefon,
                                        Cins = s.Cinsiyet,
                                        UyeDurum = s.Durum

                                    }) ;
            
            UyeİslemDTV.DataSource = uyeleriListele.ToList();
        }

        private void Uyeİslemleri_Load(object sender, EventArgs e)
        {
            UyeleriListele(); // Üyeleri listelemek için
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Çıkış simgesi için.
        }

        private void UyeİslemDTV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Eklediğim üyenin bilgilerinin dolması için
            txt_UyeAdi.Text = UyeİslemDTV.CurrentRow.Cells[1].Value.ToString();
            txt_UyeSoyad.Text= UyeİslemDTV.CurrentRow.Cells[2].Value.ToString();
            txt_UyeEmail.Text = UyeİslemDTV.CurrentRow.Cells[3].Value.ToString();
            txtUyeTelefon.Text = UyeİslemDTV.CurrentRow.Cells[4].Value.ToString();
            cbb_Cinsiyet.Text = UyeİslemDTV.CurrentRow.Cells[5].Value.ToString();
            cbb_UyeDurum.Text = UyeİslemDTV.CurrentRow.Cells[6].Value.ToString();

        }
        public void Kontrol() //Textboxların içeriğini silmek için
        {
            MessageBox.Show("İşlem Başarılı");
            foreach (Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
            }
            UyeİslemDTV.DataSource = db.tbl_Uyeler.ToList();

        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
           // Üye eklemek için 
            tbl_Uyeler UyeEkle = new tbl_Uyeler();
            UyeEkle.UyeAdi = txt_UyeAdi.Text;
            UyeEkle.UyeSoyadi = txt_UyeSoyad.Text;
            UyeEkle.Email = txt_UyeEmail.Text;
            UyeEkle.Telefon = txtUyeTelefon.Text;
            UyeEkle.Cinsiyet = cbb_Cinsiyet.Text;
            UyeEkle.Durum = true;
            db.tbl_Uyeler.Add(UyeEkle);
            db.SaveChanges();
            Kontrol();


        }
        private void btn_UyeGuncelle_Click(object sender, EventArgs e)
        {
            // Güncellemek için(isme göre güncelliyorum)
           
            string ad = txt_UyeAdi.Text;
            var guncelle = db.tbl_Uyeler.Where(w => w.UyeAdi == ad).FirstOrDefault();
            guncelle.UyeAdi = txt_UyeAdi.Text;
            guncelle.UyeSoyadi = txt_UyeSoyad.Text;
            guncelle.Email = txt_UyeEmail.Text;
            guncelle.Telefon = txtUyeTelefon.Text;
            guncelle.Durum = false;
            guncelle.Cinsiyet = cbb_Cinsiyet.Text;
            db.SaveChanges();
            Kontrol();
        }

        private void btn_UyeSil_Click(object sender, EventArgs e)
        {
            //Silmek için(İsme göre siliyorum)
            string ad = UyeİslemDTV.CurrentRow.Cells[1].Value.ToString();
            var sil = db.tbl_Uyeler.Where(w => w.UyeAdi == ad).FirstOrDefault();
            db.tbl_Uyeler.Remove(sil);
            db.SaveChanges();
            Kontrol();

        }

        private void btn_UyeTemizle_Click(object sender, EventArgs e)
        {

            Temizle();
        }
        private void Temizle()    // Temizleme işlemi yapmak için.
        { 
            txt_UyeAdi.Text = "";
            txt_UyeSoyad.Text = "";
            txt_UyeEmail.Text = "";
            txtUyeTelefon.Text = "";
            cbb_Cinsiyet.Text = "";
            cbb_UyeDurum.Text = "";

        }

        private void UyeİslemDTV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
