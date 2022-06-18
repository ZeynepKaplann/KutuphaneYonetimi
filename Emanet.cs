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
    public partial class Emanet : Form
    {
        KutuphaneYonetimiEntities db = new KutuphaneYonetimiEntities();
        public Emanet()
        {
            InitializeComponent();
            kitaplariListele();
            uyeleriListele();
        }

        private void uyeleriListele()
        {
            //Üyeleri Listeler

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

            dataGridView_Uyeler.DataSource = uyeleriListele.ToList();
        }

        private void kitaplariListele()
        {
            //Kitapları Listeler


            var kitaplariListele = db.tbl_Kitaplar.Where(k => k.Durumu == "A")
                          .Select(s => new
                          {
                              İd = s.Id,
                              Ad = s.KitapAdi,
                              kategori = s.tbl_Kategori.KategoriAdi,
                              yazar = s.tbl_Yazar.YazarAdi + " " + s.tbl_Yazar.YazarSoyadi,
                              yayınevi = s.tbl_YayınEvi.YayınEviAdi,
                              sayfaSayısı = s.SayfaSayısı,
                              basımYılı = s.BasımYılı,
                              adet = s.Adet,
                              aciklama = s.Aciklama,
                              KitapDurum = s.Durumu

                          });

            dataGridView_Kitap.DataSource = kitaplariListele.ToList();
        }

        private void Ara_TextChanged(object sender, EventArgs e)
        {
            // Kitap Arama
            var ara = from x in db.tbl_Kitaplar select x;
            if (Ara.Text != null )
            {
                dataGridView_Kitap.DataSource = ara.Where(x => x.KitapAdi.Contains(Ara.Text)).ToList();
                
            }
            
        }

       


        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UyeAra_TextChanged(object sender, EventArgs e)
        {
            //Üye Arama

            var ara = from x in db.tbl_Uyeler select x;
            if (UyeAra.Text != null)
            {
                dataGridView_Uyeler.DataSource = ara.Where(x => x.UyeAdi.Contains(UyeAra.Text)).ToList();
            }

        }

        private void EmanetUyeİd_TextChanged(object sender, EventArgs e)
        {
            //Üye İdye göre üye seçme
            var ara = from x in db.tbl_Uyeler select x;
            if (EmanetUyeİd.Text != null)
            {
                dataGridView_Uyeler.DataSource = ara.Where(x => x.UyeAdi.Contains(EmanetUyeİd.Text)).ToList();
            }
        }

        private void btn_EmanetVer_Click(object sender, EventArgs e)
        {
            // Emanet verme işlemleri
            for (int i = 0; i < listView_Kitap.Items.Count; i++)
            {
                int id = int.Parse(EmanetUyeİd.Text);
                
                    
                tbl_KitapEmanet kitapEmanet = new tbl_KitapEmanet();
                kitapEmanet.KitapVerilisTarih = DateTime.Now;
                kitapEmanet.KitapAlisTarih = DateTime.Parse(listView_Kitap.Items[i].SubItems[2].Text);
                kitapEmanet.UyeId = int.Parse(EmanetUyeİd.Text);
                kitapEmanet.KitapId = int.Parse(listView_Kitap.Items[i].SubItems[0].Text);
                kitapEmanet.Durum = true;
                
                db.tbl_KitapEmanet.Add(kitapEmanet);
                
                db.SaveChanges();
                DurumuGüncelle(kitapEmanet.KitapId);
                MessageBox.Show("Kitap emanet verildi");
              
            }



        }

        private void DurumuGüncelle(int? kitapId)
        {
            // Emanet verilen kitabın durumunu güncelleme
            tbl_Kitaplar kitaplar = db.tbl_Kitaplar.Find(kitapId);
            kitaplar.Durumu = "O";
            db.SaveChanges();

            
        }

        private void EmanetKitapİd_TextChanged_1(object sender, EventArgs e)
        {
            //Kitabın id'sine göre arama
            int kitapid = int.Parse(EmanetKitapİd.Text);
            tbl_Kitaplar kitaplar = db.tbl_Kitaplar.AsNoTracking().Where(k => k.Durumu == "A" && k.Id == kitapid).FirstOrDefault();
            if(kitaplar != null)
            {
                txt_KitapAdi.Text = kitaplar.KitapAdi;
            }

        }

        private void kitapEkle_Click(object sender, EventArgs e)
        {
            //Sepete ekelenen kitap
            string[] kitap = { EmanetKitapİd.Text, txt_KitapAdi.Text, DateTime.Today.AddDays(20).ToString() };
            listView_Kitap.Items.Add(new ListViewItem(kitap));

        }

        private void Emanet_Load(object sender, EventArgs e)
        {

        }

 
    }


}

