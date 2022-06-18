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
    public partial class Kitaplar : Form
    {
        KutuphaneYonetimiEntities db = new KutuphaneYonetimiEntities();
        public Kitaplar()
        {
            InitializeComponent();
            KitaplarıListele();
        }

        private void KitaplarıListele()
        {
            //Kitapları Listeleme
            var kitaplariListele = db.tbl_Kitaplar.Where(k => k.Durumu == "A" || k.Durumu=="P" || k.Durumu=="O")
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

            dtvKitapListesi.DataSource = kitaplariListele.ToList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Kitaplar_Load(object sender, EventArgs e)
        {
            KitaplarıListele();

        }

        private void txt_KitapArama_TextChanged(object sender, EventArgs e)
        {
            //Kitap Adına göre arama
            var ara = from x in db.tbl_Kitaplar select x;
            if (txt_KitapArama.Text != null)
            {
                dtvKitapListesi.DataSource = ara.Where(x => x.KitapAdi.Contains(txt_KitapArama.Text)).ToList();
            }
        }
    }
    }

