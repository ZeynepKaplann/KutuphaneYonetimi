using KutuphaneYonetimSistemi.Model.Entities;
using KutuphaneYonetimSistemi.Model.Manuel.VeriTabaniİslemleri;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneYonetimSistemi
{
    public partial class Kitapİslemleri : Form

    {
        KutuphaneYonetimiEntities db = new KutuphaneYonetimiEntities();

        public Kitapİslemleri()
        {
            
            InitializeComponent();
            YazarlariListele();
            YayinEviListele();
            KategoriListele();
            KitaplariListele();



        }

        private void KitaplariListele()
            
            
        {
            
            var kitaplariListele = db.tbl_Kitaplar.Where(k => k.Durumu == "A" )
                                   .Select(s => new
                                   {
                                       İd = s.Id,
                                       Ad = s.KitapAdi,
                                       kategori = s.tbl_Kategori.KategoriAdi,
                                       yazar = s.tbl_Yazar.YazarAdi + " " + s.tbl_Yazar.YazarSoyadi  ,
                                       yayınevi = s.tbl_YayınEvi.YayınEviAdi,
                                       sayfaSayısı = s.SayfaSayısı,
                                       basımYılı = s.BasımYılı,
                                       adet = s.Adet,
                                       aciklama = s.Aciklama,
                                       KitapDurum = s.Durumu == "A"


                                   });

            KitapİslemDTV.DataSource = kitaplariListele.ToList();

        }

        private void KategoriListele()
        {
            var kategoriler = db.tbl_Kategori.Where(x => x.Durum == true);
            cbb_Kategori.DisplayMember = "KategoriAdi";
            cbb_Kategori.ValueMember = "Id";
            cbb_Kategori.DataSource = kategoriler.ToList();

        }

        private void YayinEviListele()
        {
            var yayinEvi = db.tbl_YayınEvi.Where(y => y.Durum == true);
            cbbYayinevi.DisplayMember = "YayınEviAdi";
            cbbYayinevi.ValueMember = "Id";
            cbbYayinevi.DataSource = yayinEvi.ToList();
        }

        private void YazarlariListele()
        {
            var yazar = db.tbl_Yazar.Where(y => y.Durum == true)
                .Select(s => new
                {
                    İd = s.Id,
                    Yazar = s.YazarAdi + " " + s.YazarSoyadi


                });
            cbbYazar.DisplayMember = "Yazar";
            cbbYazar.ValueMember = "Id";
            cbbYazar.DataSource = yazar.ToList();
        }


        private void kitapİslemCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Kitapİslemleri_Load(object sender, EventArgs e)
        {
            KitaplariListele();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            

            tbl_Kitaplar kitaplar = new tbl_Kitaplar();
            kitaplar.KitapAdi = txtKitapAdi.Text;
            kitaplar.Yazar = Convert.ToInt32(cbbYazar.SelectedIndex + 1);
            int yazarid = Convert.ToInt32(cbbYazar.SelectedIndex + 1);
            kitaplar.tbl_Yazar = db.tbl_Yazar.FirstOrDefault(x => x.Id == yazarid);
            kitaplar.Kategori = (byte?)(cbb_Kategori.SelectedIndex + 1);
            byte kategoriid = (byte)(cbb_Kategori.SelectedIndex + 1);
            kitaplar.tbl_Kategori = db.tbl_Kategori.FirstOrDefault(x => x.Id == kategoriid);
            kitaplar.YayınEvi = cbbYayinevi.SelectedIndex + 1;
            int yayineviid = cbb_Kategori.SelectedIndex + 1;
            kitaplar.tbl_YayınEvi = db.tbl_YayınEvi.FirstOrDefault(x => x.Id == yayineviid);
            kitaplar.SayfaSayısı = Convert.ToInt16(txtSayfaSayisi.Text);
            kitaplar.BasımYılı = txtBasimYili.Text;
            kitaplar.Adet = Convert.ToInt16(txtAdet.Text);
            kitaplar.Durumu = "A";
            kitaplar.Aciklama = txtAciklama.Text;
           // kitaplar.YayınEvi = int.Parse(cbbYayinevi.Text);
            kitaplar.tbl_YayınEvi = db.tbl_YayınEvi.Find(int.Parse(cbbYayinevi.SelectedValue.ToString()));
            KitaplariListele();




            db.tbl_Kitaplar.Add(kitaplar);
             db.SaveChanges();
              
            
        


        }


        private void btn_KitapGuncelle_Click(object sender, EventArgs e)
        {
            string ad = txtKitapAdi.Text;
            var guncelle = db.tbl_Kitaplar.Where(w => w.KitapAdi == ad).FirstOrDefault();
            guncelle.KitapAdi = txtKitapAdi.Text;
            guncelle.SayfaSayısı = short.Parse(txtSayfaSayisi.Text);
            //guncelle.BasımYılı = txtBasimYili.Text;
            guncelle.Adet = short.Parse(txtAdet.Text);
            guncelle.tbl_Yazar= db.tbl_Yazar.Find(int.Parse(cbbYazar.SelectedValue.ToString()));
            guncelle.tbl_YayınEvi= db.tbl_YayınEvi.Find(int.Parse(cbbYayinevi.SelectedValue.ToString()));
            guncelle.tbl_Kategori= db.tbl_Kategori.Find(int.Parse(cbb_Kategori.SelectedValue.ToString()));
            db.SaveChanges();
            Kontrol();

        }

        private void btn_KitapSil_Click(object sender, EventArgs e)
        {
            string ad = KitapİslemDTV.CurrentRow.Cells[1].Value.ToString();
            var sil = db.tbl_Kitaplar.Where(w => w.KitapAdi == ad).FirstOrDefault();
            db.tbl_Kitaplar.Remove(sil);
            db.SaveChanges();
            Kontrol();
        }
        public void Kontrol() //Textboxların içeriğini silmek için
        {
            MessageBox.Show("İşlem Başarılı");
            foreach (Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
            }
            KitapİslemDTV.DataSource = db.tbl_Kitaplar.ToList();

        }
        private void Temizle()    // Temizleme işlemi yapmak için.
        {
            txtKitapAdi.Text = "";
            txtSayfaSayisi.Text = "";
            txtBasimYili.Text = "";
            txtAdet.Text = "";
            txtAciklama.Text = "";
            cbbYayinevi.Text = "";
            cbbYazar.Text = "";
            cbb_Kategori.Text = "";
            cbbDurum.Text = "";

        }

        private void btn_Temizleme_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void KitapİslemDTV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKitapAdi.Text = KitapİslemDTV.CurrentRow.Cells[1].Value.ToString();
            txtSayfaSayisi.Text = KitapİslemDTV.CurrentRow.Cells[2].Value.ToString();
            //txtBasimYili.Text = KitapİslemDTV.CurrentRow.Cells[3].Value.ToString();
            txtAdet.Text = KitapİslemDTV.CurrentRow.Cells[4].Value.ToString();
            txtAciklama.Text = KitapİslemDTV.CurrentRow.Cells[5].Value.ToString();
            cbb_Kategori.Text = KitapİslemDTV.CurrentRow.Cells[6].Value.ToString();
            cbbYazar.Text = KitapİslemDTV.CurrentRow.Cells[7].Value.ToString();
            cbbYayinevi.Text = KitapİslemDTV.CurrentRow.Cells[8].Value.ToString();
            cbbDurum.Text = KitapİslemDTV.CurrentRow.Cells[9].Value.ToString();


        }

        private void KitapİslemDTV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtKitapAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
