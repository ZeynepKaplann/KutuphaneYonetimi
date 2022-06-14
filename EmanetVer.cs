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
    public partial class EmanetVer : Form
    {
        KutuphaneYonetimiEntities db = new KutuphaneYonetimiEntities();
        public EmanetVer(ListView listView)
        {
            InitializeComponent();
            SepetiTasi(listView);
        }

        private void SepetiTasi(ListView listView)
        {
            for (int i = 0; i < listView.Items.Count; i++)
            {
                string[] kitap = { listView.Items[i].SubItems[0].Text, listView.Items[i].SubItems[1].Text, listView.Items[i].SubItems[2].Text, listView.Items[i].SubItems[3].Text };
                listTasinan.Items.Add(new ListViewItem(kitap));
            }
        }

        public EmanetVer()
        {
        }

        private void Emanet_UyeAra_TextChanged(object sender, EventArgs e)
        {
            var ara = from x in db.tbl_Uyeler select x;
            if (Emanet_UyeAra.Text != null)
            {
                dgv_EmanetUye.DataSource = ara.Where(x => x.UyeAdi.Contains(Emanet_UyeAra.Text)).ToList();
            }
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

            dgv_EmanetUye.DataSource = uyeleriListele.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgv_EmanetUye_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtüyeİd_TextChanged(object sender, EventArgs e)
        {
                int id =int.Parse( txtüyeİd.Text);
                tbl_Uyeler uyeler = db.tbl_Uyeler.AsNoTracking().FirstOrDefault(k => (k.Id == id) && k.Durum==true);
                if (uyeler != null)
                {
                txtÜyeAd.Text = uyeler.UyeAdi;
                txtÜyeSoyad.Text = uyeler.UyeSoyadi;
                txtÜyeEmail.Text = uyeler.Email;
                txtÜyeTelefon.Text = uyeler.Telefon;
                txtÜyeCinsiyet.Text = uyeler.Cinsiyet;


            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            UyeleriListele();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
