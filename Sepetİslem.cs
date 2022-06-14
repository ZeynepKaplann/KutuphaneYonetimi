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
    public partial class Sepetİslem : Form
    {
        KutuphaneYonetimiEntities db = new KutuphaneYonetimiEntities();

           public Sepetİslem()
           {
            InitializeComponent();
            kitaplariListele();
            
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

            dgvSepetKitap.DataSource = kitaplariListele.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
               
        }

        private void dgvSepetKitap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    

        private void sepetKitap_TextChanged(object sender, EventArgs e)
        {
            var ara = from x in db.tbl_Kitaplar select x;
            if (sepetKitap.Text != null)
            {
                dgvSepetKitap.DataSource = ara.Where(x => x.KitapAdi.Contains(sepetKitap.Text)).ToList();
            }
        }

        private void Sepet_İd_TextChanged(object sender, EventArgs e)
        {
            int KitapId = int.Parse(Sepet_İd.Text);
            tbl_Kitaplar kitaplar = db.tbl_Kitaplar.AsNoTracking().Where(k => k.Durumu == "A" && k.Id == KitapId).FirstOrDefault();
            if(kitaplar != null)
            {
                sepet_Adi.Text = kitaplar.KitapAdi;
                sepet_Kategori.Text = kitaplar.tbl_Kategori.KategoriAdi;
                sepet_Yayinevi.Text = kitaplar.tbl_YayınEvi.YayınEviAdi;
                sepet_Yazar.Text = kitaplar.tbl_Yazar.YazarAdi + " " + kitaplar.tbl_Yazar.YazarSoyadi;
                sepet_Sayfa.Text = kitaplar.SayfaSayısı.ToString();
                SepetAciklama.Text = kitaplar.Aciklama;
                sepetBasim.Text = kitaplar.BasımYılı;

            }
        }

        private void btn_SepeteEkle_Click(object sender, EventArgs e)
        {
            string[] kitaplar = { Sepet_İd.Text, sepet_Adi.Text, sepet_Kategori.Text, DateTime.Today.AddDays(20).ToString() };
            listView_Kitap.Items.Add(new ListViewItem(kitaplar));
        }

        private void btn_SepetOnay_Click(object sender, EventArgs e)
        {
            EmanetVer emanetVer = new EmanetVer();
            emanetVer.Show();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sepetİslem_Load(object sender, EventArgs e)
        {

        }
    }
}
