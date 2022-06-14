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
            var ara = from x in db.tbl_Kitaplar select x;
            if (Ara.Text != null)
            {
                dataGridView_Kitap.DataSource = ara.Where(x => x.KitapAdi.Contains(Ara.Text)).ToList();
            }
        }

        private void EmanetKitapİd_TextChanged(object sender, EventArgs e)
        {
            int KitapId = int.Parse(EmanetKitapİd.Text);
            tbl_Kitaplar kitaplar = db.tbl_Kitaplar.AsNoTracking().Where(k => k.Durumu == "A" && k.Id == KitapId).FirstOrDefault();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kitaplar = { EmanetKitapİd.Text, DateTime.Today.AddDays(20).ToString() };
            listView_Kitap.Items.Add(new ListViewItem(kitaplar));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

    


        private void listView_Kitap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Emanet_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var ara = from x in db.tbl_Uyeler select x;
            if (textBox2.Text != null)
            {
                dataGridView_Uyeler.DataSource = ara.Where(x => x.UyeAdi.Contains(textBox2.Text)).ToList();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            tbl_Uyeler uyeler = db.tbl_Uyeler.AsNoTracking().FirstOrDefault(k => (k.Id == id) && k.Durum == true);
        }

     

        private void button3_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < listView_Kitap.Items.Count; i++)

            {
                int id = int.Parse(textBox1.Text);
                tbl_KitapEmanet kitapEmanet = new tbl_KitapEmanet();
                kitapEmanet.KitapVerilisTarih = DateTime.Now;
                kitapEmanet.KitapAlisTarih = DateTime.Parse(listView_Kitap.Items[i].SubItems[1].Text);
                kitapEmanet.UyeId = int.Parse(textBox1.Text);
                kitapEmanet.KitapId = int.Parse(listView_Kitap.Items[i].SubItems[0].Text);
                kitapEmanet.Durum = true;
                db.tbl_KitapEmanet.Add(kitapEmanet);
                
                db.SaveChanges();
                
                

            }
        }

        

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            var ara = from x in db.tbl_Uyeler select x;
            if (textBox1.Text != null)
            {
                dataGridView_Uyeler.DataSource = ara.Where(x => x.UyeAdi.Contains(textBox1.Text)).ToList();
            }


        }
                 
        }
    }

