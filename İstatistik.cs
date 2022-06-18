using KutuphaneYonetimSistemi.Model.Manuel.VeriTabaniİslemleri;
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
    public partial class İstatistik : Form
    {
        public İstatistik()
        {
            InitializeComponent();
        }

        private void İstatistik_Load(object sender, EventArgs e)
        {

        }
        void İstatistikler()
        {
            string query = "";

            switch (cbb_Sec.SelectedIndex)
            {
                case 0:
                    query = "select ÜyeAdi+' '+ÜyeSoyadi as X, COUNT(*) as Y from tbl_KitapEmanet inner join tbl_Uyeler on tbl_Uyeler.İd = tbl_KitapEmanet.UyeId where tbl_Uyeler.Durum=1 and tbl_KitapEmanet.Durumu=1 group by ÜyeAdi+' '+ÜyeSoyadi";
                    break;
                case 1:
                    query = "select KitapAdi as X, COUNT(*) as Y from tbl_KitapEmanet inner join tbl_Kitaplar on tbl_Kitaplar.İd=tbl_KitapEmanet.KitapId group by KitapAdi";
                    break;

                default:
                    break;
            }
            foreach (var series in chart.Series)
            {
                series.Points.Clear();

            }
            foreach (DataRow row in IDatabase.DataToDataTable(query).Rows)
            {
                chart.Series["Durum"].Points.AddXY(row["X"].ToString(), row["Y"].ToString());

            }
        }

      
     

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbb_Sec_SelectedIndexChanged(object sender, EventArgs e)
        {
            İstatistikler();
        }
    }
}
