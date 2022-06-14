using KutuphaneYonetimSistemi.Model.Entities;
using KutuphaneYonetimSistemi.Model.Manuel.Sinif;
using KutuphaneYonetimSistemi.Model.Manuel.VeriTabaniİslemleri;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYonetimSistemi
{
    public partial class Login : Form
    {
        KutuphaneYonetimiEntities db = new KutuphaneYonetimiEntities();
        Temelİslem temelİslem = new Temelİslem();

        public Login()
        {
            InitializeComponent();
            Load += Login_Load;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.BeniHatirla)
            {
                if (!string.IsNullOrEmpty(Properties.Settings.Default.KullaniciAdi))
                {
                    txt_KullaniciAdi.Text = Properties.Settings.Default.KullaniciAdi;
                    txt_Parola.Text = Properties.Settings.Default.Sifre;
                    checkBox_BeniHatırla.Checked = Properties.Settings.Default.BeniHatirla;


                }
            }
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {

            tbl_Personel prs = db.tbl_Personel.Where(p => p.KullaniciAdi == txt_KullaniciAdi.Text && p.Sifre == txt_Parola.Text).FirstOrDefault();
            // Personel tablosundaki bilgilerin girilen bilgilerle aynı olup olmadığını kontrol eden kod.
               

                if (prs.Yetkisi == 1)
                {
                    //Bilgiler doğruysa giriş yapılır

                    BeniHatirla();
                    YoneticiAnasayfa personelAnasayfa = new YoneticiAnasayfa();
                    personelAnasayfa.ShowDialog();
                    this.Hide();


                }
                if (prs.Yetkisi == 2)
                {
                    BeniHatirla();
                    PersonelAnasayfa personel = new PersonelAnasayfa();
                    personel.ShowDialog();
                    this.Hide();
                }
                //else
                //{
                //    MessageBox.Show("Hatali giris", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

            }



        private void BeniHatirla()     // Beni Hatırla. Propertisten faydalandım.
        {
            if (checkBox_BeniHatırla.Checked)
            //Giriş başarılı ise bilgileri kaydet.
            {
                Properties.Settings.Default.KullaniciAdi = txt_KullaniciAdi.Text;
                Properties.Settings.Default.Sifre = txt_Parola.Text;
                Properties.Settings.Default.BeniHatirla = true;
                Properties.Settings.Default.Save();


            }
            else
            // Giriş başarılı değilse bilgileri kaydetme
            {
                Properties.Settings.Default.KullaniciAdi = txt_KullaniciAdi.Text;
                Properties.Settings.Default.Sifre = txt_Parola.Text;
                Properties.Settings.Default.BeniHatirla = false;
                Properties.Settings.Default.Save();

            }
        }


        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //Şifremi unuttum butonunu kullanmak için öncelikle sisteme kayıt olmak gerekir. 
                //Sistemde böyle bir kullanıcının olup olmadığını kontrol ettim

                tbl_Personel personel = db.tbl_Personel.AsNoTracking().FirstOrDefault(p => p.Email == txt_KullaniciAdi.Text ||
                p.KullaniciAdi == txt_KullaniciAdi.Text);
                if (personel != null)
                {
                    //Böyle bir kullanıcı varsa maile şifresi gönderildi.
                    ArrayList mailler = new ArrayList();
                    mailler.Add(personel.Email);
                    temelİslem.SendMail(mailler, personel.Sifre.ToString(), "Sifre");
                    MessageBox.Show("Mail gönderildi", "Basarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                // Sistemde öyle bir kullanıcı yoksa kullanıcı bulunamadı hatası verilir.
                {
                    MessageBox.Show("Sistemde böyle bir kullanıcı bulunamadı", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            //Baika bir hata varsa bu bloka düşer
            {

                MessageBox.Show("Hata", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }
    }
}

        
    
    

