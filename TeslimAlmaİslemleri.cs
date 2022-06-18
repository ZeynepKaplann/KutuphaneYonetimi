using KutuphaneYonetimSistemi.Model.Entities;
using KutuphaneYonetimSistemi.Model.Generic;
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
    public partial class TeslimAlmaİslemleri : Form
    {
        KutuphaneYonetimiEntities db = new KutuphaneYonetimiEntities();
        public TeslimAlmaİslemleri()
        {
            InitializeComponent();
            EmanetleriListele();
        }

        private void EmanetleriListele()
        {
            // Emanet Verilen kitapları listeleme
            var EmanetleriListele = db.tbl_Kitaplar.Where(k => k.Durumu == "O")
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

            dgvEmanetler.DataSource = EmanetleriListele.ToList();
        }

        private void kitapİd_TextChanged(object sender, EventArgs e)
        {
            Generic<tbl_KitapEmanet> db = new Generic<tbl_KitapEmanet>();

            int id = int.Parse(kitapİd.Text);
            tbl_KitapEmanet kitapEmanet = db.Find(x => x.KitapId == id);
            if (kitapEmanet != null)
            {
                //Kitap id'ye göre kitabın bilgilerini getirme
               kitapAdi.Text = kitapEmanet.tbl_Kitaplar.KitapAdi;
               UyeAdi.Text = kitapEmanet.tbl_Uyeler.UyeAdi;
               ÜyeSoyadi.Text = kitapEmanet.tbl_Uyeler.UyeSoyadi;
               KitapVerilis.Text = kitapEmanet.KitapVerilisTarih.ToString();
               KitapAlis.Text = kitapEmanet.KitapAlisTarih.ToString();
               KitapTeslimEtme.Text = DateTime.Now.ToString();


                // Kitap Teslim: Üyenin kitabı getirdiği gün   KitapAlis: 20 günlük süre 
               int Gun = (Convert.ToDateTime(KitapTeslimEtme.Text) - Convert.ToDateTime(KitapAlis.Text)).Days;
                if (Gun > 0)
                {
                    Ceza.Text = (Gun * 1).ToString(); //Her gün için 1 tl ceza
                }
                else
                {
                    Ceza.Text = "0";  //Ceza yoksa 0 tl
                }
                kitapİd.Text = kitapEmanet.Id.ToString();
                
            }
         


            
        }

        private void TeslimAlmaİslemleri_Load(object sender, EventArgs e)
        {

        }

        private void EmanetKitapAra_TextChanged(object sender, EventArgs e)
        {

            var ara = from x in db.tbl_Kitaplar select x;
            if (EmanetKitapAra.Text != null)
            {
                dgvEmanetler.DataSource = ara.Where(x => x.KitapAdi.Contains(EmanetKitapAra.Text)).ToList();
            }
        }

        private void btn_TeslimAl_Click(object sender, EventArgs e)
        {
            //Teslim alma işlemleri
            Generic<tbl_KitapEmanet> db = new Generic<tbl_KitapEmanet>();
            tbl_KitapEmanet kitapEmanet = db.GetById(int.Parse(kitapİd.Text));
            kitapEmanet.KitapTeslim = Convert.ToDateTime(KitapTeslimEtme.Text);
            kitapEmanet.Durum = false;
            kitapEmanet.tbl_Kitaplar.Durumu = "A";
            db.Update(kitapEmanet);
            MessageBox.Show("Emanet kitap alındı");


            if (int.Parse(Ceza.Text) > 0)
            {
                //Eğer ceza varsa ceza tablosuna düşer
                Generic<tbl_Ceza> ceza = new Generic<tbl_Ceza>();
                tbl_Ceza cezalar = new tbl_Ceza();
                cezalar.GunSayisi= (Convert.ToDateTime(KitapTeslimEtme.Text) - Convert.ToDateTime(KitapAlis.Text)).Days;
                cezalar.KitapId = kitapEmanet.Id;
                cezalar.CezaUcret = decimal.Parse(Ceza.Text);
                cezalar.KitapId = kitapEmanet.KitapId;
                cezalar.UyeId = kitapEmanet.KitapId;
                ceza.Add(cezalar);

            }
            


        }

        private void dgvEmanetler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Cikis_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
