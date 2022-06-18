using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.Model.Manuel.VeriTabaniİslemleri
{
    abstract class TemelVeritabani
    {
        //Sql bağlantısı için gerekli komutlar
        public SqlCommand komut;
        public SqlDataAdapter adaptor;
        public DataTable tablo;
        public SqlConnection baglanti;
        public string veriYolu;

        public TemelVeritabani()
        {
            //Sql yolu
            veriYolu = "Data Source=DESKTOP-L2IUGM8\\SQLEXPRESS05;Initial Catalog=Kutuphane;" + "Integrated Security=true;";
        }
        public void Baglan()
        {
            //Bağlantının açık olup olmadığını kontrol etmek için bir kontrol yaptım. Bağlantı kapalıysa bağlantı açılacak.
            baglanti = new SqlConnection(veriYolu);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();

            }
        }

        //veritabanından yapılavak ekle sil güncelle vs gibi işlemler için tanımladım

        abstract public void Ekle(object obj);
        abstract public void Sil(object obj);
        abstract public void Guncelle(object obj);
        abstract public DataTable Listele(object obj);
        abstract public DataTable Listele();

    }


}




