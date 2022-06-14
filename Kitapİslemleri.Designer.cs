namespace KutuphaneYonetimSistemi
{
    partial class Kitapİslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.kitapİslemCikis = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbDurum = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Temizleme = new System.Windows.Forms.Button();
            this.btn_KitapSil = new System.Windows.Forms.Button();
            this.btn_KitapGuncelle = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.cbbYazar = new System.Windows.Forms.ComboBox();
            this.cbbYayinevi = new System.Windows.Forms.ComboBox();
            this.cbb_Kategori = new System.Windows.Forms.ComboBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.labelAciklama = new System.Windows.Forms.Label();
            this.txtBasimYili = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelSayfaSayisi = new System.Windows.Forms.Label();
            this.labelYazar = new System.Windows.Forms.Label();
            this.labelYayinevi = new System.Windows.Forms.Label();
            this.labelKategori = new System.Windows.Forms.Label();
            this.labelKitapAd = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.KitapİslemDTV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KitapİslemDTV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.kitapİslemCikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(507, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "KİTAP İŞLEMLERİ";
            // 
            // kitapİslemCikis
            // 
            this.kitapİslemCikis.BackColor = System.Drawing.Color.Teal;
            this.kitapİslemCikis.Dock = System.Windows.Forms.DockStyle.Right;
            this.kitapİslemCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapİslemCikis.Image = global::KutuphaneYonetimSistemi.Properties.Resources.Cıkısss;
            this.kitapİslemCikis.Location = new System.Drawing.Point(1160, 0);
            this.kitapİslemCikis.Name = "kitapİslemCikis";
            this.kitapİslemCikis.Size = new System.Drawing.Size(93, 70);
            this.kitapİslemCikis.TabIndex = 0;
            this.kitapİslemCikis.UseVisualStyleBackColor = false;
            this.kitapİslemCikis.Click += new System.EventHandler(this.kitapİslemCikis_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.cbbDurum);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_Temizleme);
            this.panel2.Controls.Add(this.btn_KitapSil);
            this.panel2.Controls.Add(this.btn_KitapGuncelle);
            this.panel2.Controls.Add(this.btnKitapEkle);
            this.panel2.Controls.Add(this.txtAciklama);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.txtAdet);
            this.panel2.Controls.Add(this.txtSayfaSayisi);
            this.panel2.Controls.Add(this.cbbYazar);
            this.panel2.Controls.Add(this.cbbYayinevi);
            this.panel2.Controls.Add(this.cbb_Kategori);
            this.panel2.Controls.Add(this.txtKitapAdi);
            this.panel2.Controls.Add(this.labelAciklama);
            this.panel2.Controls.Add(this.txtBasimYili);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.labelSayfaSayisi);
            this.panel2.Controls.Add(this.labelYazar);
            this.panel2.Controls.Add(this.labelYayinevi);
            this.panel2.Controls.Add(this.labelKategori);
            this.panel2.Controls.Add(this.labelKitapAd);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(788, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 716);
            this.panel2.TabIndex = 2;
            // 
            // cbbDurum
            // 
            this.cbbDurum.FormattingEnabled = true;
            this.cbbDurum.Items.AddRange(new object[] {
            "A",
            "P"});
            this.cbbDurum.Location = new System.Drawing.Point(171, 401);
            this.cbbDurum.Name = "cbbDurum";
            this.cbbDurum.Size = new System.Drawing.Size(216, 24);
            this.cbbDurum.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(84, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Durum";
            // 
            // btn_Temizleme
            // 
            this.btn_Temizleme.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Temizleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Temizleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Temizleme.Location = new System.Drawing.Point(145, 628);
            this.btn_Temizleme.Name = "btn_Temizleme";
            this.btn_Temizleme.Size = new System.Drawing.Size(162, 66);
            this.btn_Temizleme.TabIndex = 22;
            this.btn_Temizleme.Text = "TEMİZLE";
            this.btn_Temizleme.UseVisualStyleBackColor = false;
            this.btn_Temizleme.Click += new System.EventHandler(this.btn_Temizleme_Click);
            // 
            // btn_KitapSil
            // 
            this.btn_KitapSil.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_KitapSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KitapSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KitapSil.Location = new System.Drawing.Point(317, 543);
            this.btn_KitapSil.Name = "btn_KitapSil";
            this.btn_KitapSil.Size = new System.Drawing.Size(117, 66);
            this.btn_KitapSil.TabIndex = 20;
            this.btn_KitapSil.Text = "SİL";
            this.btn_KitapSil.UseVisualStyleBackColor = false;
            this.btn_KitapSil.Click += new System.EventHandler(this.btn_KitapSil_Click);
            // 
            // btn_KitapGuncelle
            // 
            this.btn_KitapGuncelle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_KitapGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KitapGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KitapGuncelle.Location = new System.Drawing.Point(165, 544);
            this.btn_KitapGuncelle.Name = "btn_KitapGuncelle";
            this.btn_KitapGuncelle.Size = new System.Drawing.Size(127, 65);
            this.btn_KitapGuncelle.TabIndex = 19;
            this.btn_KitapGuncelle.Text = "GÜNCELLE";
            this.btn_KitapGuncelle.UseVisualStyleBackColor = false;
            this.btn_KitapGuncelle.Click += new System.EventHandler(this.btn_KitapGuncelle_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnKitapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapEkle.Location = new System.Drawing.Point(24, 544);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(122, 65);
            this.btnKitapEkle.TabIndex = 18;
            this.btnKitapEkle.Text = "EKLE";
            this.btnKitapEkle.UseVisualStyleBackColor = false;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(171, 440);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(216, 86);
            this.txtAciklama.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(171, 364);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(216, 22);
            this.textBox5.TabIndex = 16;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(171, 327);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(216, 22);
            this.txtAdet.TabIndex = 15;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(171, 290);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(216, 22);
            this.txtSayfaSayisi.TabIndex = 0;
            // 
            // cbbYazar
            // 
            this.cbbYazar.FormattingEnabled = true;
            this.cbbYazar.Location = new System.Drawing.Point(171, 249);
            this.cbbYazar.Name = "cbbYazar";
            this.cbbYazar.Size = new System.Drawing.Size(216, 24);
            this.cbbYazar.TabIndex = 14;
            // 
            // cbbYayinevi
            // 
            this.cbbYayinevi.FormattingEnabled = true;
            this.cbbYayinevi.Location = new System.Drawing.Point(171, 212);
            this.cbbYayinevi.Name = "cbbYayinevi";
            this.cbbYayinevi.Size = new System.Drawing.Size(216, 24);
            this.cbbYayinevi.TabIndex = 13;
            // 
            // cbb_Kategori
            // 
            this.cbb_Kategori.FormattingEnabled = true;
            this.cbb_Kategori.Location = new System.Drawing.Point(171, 173);
            this.cbb_Kategori.Name = "cbb_Kategori";
            this.cbb_Kategori.Size = new System.Drawing.Size(216, 24);
            this.cbb_Kategori.TabIndex = 12;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(171, 136);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(216, 22);
            this.txtKitapAdi.TabIndex = 11;
            this.txtKitapAdi.TextChanged += new System.EventHandler(this.txtKitapAdi_TextChanged);
            // 
            // labelAciklama
            // 
            this.labelAciklama.AutoSize = true;
            this.labelAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAciklama.Location = new System.Drawing.Point(65, 465);
            this.labelAciklama.Name = "labelAciklama";
            this.labelAciklama.Size = new System.Drawing.Size(94, 24);
            this.labelAciklama.TabIndex = 9;
            this.labelAciklama.Text = "Açıklama";
            // 
            // txtBasimYili
            // 
            this.txtBasimYili.AutoSize = true;
            this.txtBasimYili.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBasimYili.Location = new System.Drawing.Point(59, 364);
            this.txtBasimYili.Name = "txtBasimYili";
            this.txtBasimYili.Size = new System.Drawing.Size(100, 24);
            this.txtBasimYili.TabIndex = 8;
            this.txtBasimYili.Text = "Basım Yılı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(106, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "Adet";
            // 
            // labelSayfaSayisi
            // 
            this.labelSayfaSayisi.AutoSize = true;
            this.labelSayfaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSayfaSayisi.Location = new System.Drawing.Point(39, 288);
            this.labelSayfaSayisi.Name = "labelSayfaSayisi";
            this.labelSayfaSayisi.Size = new System.Drawing.Size(120, 24);
            this.labelSayfaSayisi.TabIndex = 6;
            this.labelSayfaSayisi.Text = "Sayfa Sayısı";
            // 
            // labelYazar
            // 
            this.labelYazar.AutoSize = true;
            this.labelYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYazar.Location = new System.Drawing.Point(97, 247);
            this.labelYazar.Name = "labelYazar";
            this.labelYazar.Size = new System.Drawing.Size(62, 24);
            this.labelYazar.TabIndex = 5;
            this.labelYazar.Text = "Yazar";
            // 
            // labelYayinevi
            // 
            this.labelYayinevi.AutoSize = true;
            this.labelYayinevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYayinevi.Location = new System.Drawing.Point(71, 212);
            this.labelYayinevi.Name = "labelYayinevi";
            this.labelYayinevi.Size = new System.Drawing.Size(88, 24);
            this.labelYayinevi.TabIndex = 4;
            this.labelYayinevi.Text = "Yayınevi";
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKategori.Location = new System.Drawing.Point(72, 173);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(87, 24);
            this.labelKategori.TabIndex = 3;
            this.labelKategori.Text = "Kategori";
            // 
            // labelKitapAd
            // 
            this.labelKitapAd.AutoSize = true;
            this.labelKitapAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKitapAd.Location = new System.Drawing.Point(66, 134);
            this.labelKitapAd.Name = "labelKitapAd";
            this.labelKitapAd.Size = new System.Drawing.Size(93, 24);
            this.labelKitapAd.TabIndex = 2;
            this.labelKitapAd.Text = "Kitap Adı";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(33, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 55);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(128, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kitap Bilgileri";
            // 
            // KitapİslemDTV
            // 
            this.KitapİslemDTV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KitapİslemDTV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KitapİslemDTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KitapİslemDTV.Location = new System.Drawing.Point(59, 91);
            this.KitapİslemDTV.Name = "KitapİslemDTV";
            this.KitapİslemDTV.RowHeadersWidth = 51;
            this.KitapİslemDTV.RowTemplate.Height = 24;
            this.KitapİslemDTV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KitapİslemDTV.Size = new System.Drawing.Size(685, 526);
            this.KitapİslemDTV.TabIndex = 3;
            this.KitapİslemDTV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KitapİslemDTV_CellContentClick);
            this.KitapİslemDTV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KitapİslemDTV_CellDoubleClick);
            // 
            // Kitapİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1253, 823);
            this.Controls.Add(this.KitapİslemDTV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kitapİslemleri";
            this.Text = "Kitapİslemleri";
            this.Load += new System.EventHandler(this.Kitapİslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KitapİslemDTV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kitapİslemCikis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelAciklama;
        private System.Windows.Forms.Label txtBasimYili;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelSayfaSayisi;
        private System.Windows.Forms.Label labelYazar;
        private System.Windows.Forms.Label labelYayinevi;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.Label labelKitapAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Temizleme;
        private System.Windows.Forms.Button btn_KitapSil;
        private System.Windows.Forms.Button btn_KitapGuncelle;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.ComboBox cbbYazar;
        private System.Windows.Forms.ComboBox cbbYayinevi;
        private System.Windows.Forms.ComboBox cbb_Kategori;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.ComboBox cbbDurum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView KitapİslemDTV;
    }
}