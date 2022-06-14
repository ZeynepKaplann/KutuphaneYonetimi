namespace KutuphaneYonetimSistemi
{
    partial class Sepetİslem
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.sepet_Adi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SepetAciklama = new System.Windows.Forms.TextBox();
            this.sepetBasim = new System.Windows.Forms.TextBox();
            this.sepet_Sayfa = new System.Windows.Forms.TextBox();
            this.sepet_Yayinevi = new System.Windows.Forms.TextBox();
            this.sepet_Yazar = new System.Windows.Forms.TextBox();
            this.sepet_Kategori = new System.Windows.Forms.TextBox();
            this.Sepet_İd = new System.Windows.Forms.TextBox();
            this.btn_SepeteEkle = new System.Windows.Forms.Button();
            this.sepet_Aciklama = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.sepetSayfa = new System.Windows.Forms.Label();
            this.SepetYayınevi = new System.Windows.Forms.Label();
            this.SepetYazar = new System.Windows.Forms.Label();
            this.SepetKategori = new System.Windows.Forms.Label();
            this.SepetKitapİd = new System.Windows.Forms.Label();
            this.sepetKitap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSepetKitap = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_SepetOnay = new System.Windows.Forms.Button();
            this.listView_Kitap = new System.Windows.Forms.ListView();
            this.List_Kitapİd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List_KitapAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List_Kategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List_KitapAlis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepetKitap)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(441, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "SEPET İŞLEMLERİ";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::KutuphaneYonetimSistemi.Properties.Resources.Cıkısss;
            this.button1.Location = new System.Drawing.Point(994, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 70);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel.Controls.Add(this.sepet_Adi);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.SepetAciklama);
            this.panel.Controls.Add(this.sepetBasim);
            this.panel.Controls.Add(this.sepet_Sayfa);
            this.panel.Controls.Add(this.sepet_Yayinevi);
            this.panel.Controls.Add(this.sepet_Yazar);
            this.panel.Controls.Add(this.sepet_Kategori);
            this.panel.Controls.Add(this.Sepet_İd);
            this.panel.Controls.Add(this.btn_SepeteEkle);
            this.panel.Controls.Add(this.sepet_Aciklama);
            this.panel.Controls.Add(this.label);
            this.panel.Controls.Add(this.sepetSayfa);
            this.panel.Controls.Add(this.SepetYayınevi);
            this.panel.Controls.Add(this.SepetYazar);
            this.panel.Controls.Add(this.SepetKategori);
            this.panel.Controls.Add(this.SepetKitapİd);
            this.panel.Controls.Add(this.sepetKitap);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.dgvSepetKitap);
            this.panel.Location = new System.Drawing.Point(12, 88);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1079, 333);
            this.panel.TabIndex = 1;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // sepet_Adi
            // 
            this.sepet_Adi.Location = new System.Drawing.Point(937, 87);
            this.sepet_Adi.Name = "sepet_Adi";
            this.sepet_Adi.Size = new System.Drawing.Size(100, 22);
            this.sepet_Adi.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(837, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kitap Adı";
            // 
            // SepetAciklama
            // 
            this.SepetAciklama.Location = new System.Drawing.Point(942, 225);
            this.SepetAciklama.Name = "SepetAciklama";
            this.SepetAciklama.Size = new System.Drawing.Size(100, 22);
            this.SepetAciklama.TabIndex = 17;
            // 
            // sepetBasim
            // 
            this.sepetBasim.Location = new System.Drawing.Point(942, 186);
            this.sepetBasim.Name = "sepetBasim";
            this.sepetBasim.Size = new System.Drawing.Size(100, 22);
            this.sepetBasim.TabIndex = 16;
            // 
            // sepet_Sayfa
            // 
            this.sepet_Sayfa.Location = new System.Drawing.Point(942, 139);
            this.sepet_Sayfa.Name = "sepet_Sayfa";
            this.sepet_Sayfa.Size = new System.Drawing.Size(100, 22);
            this.sepet_Sayfa.TabIndex = 15;
            // 
            // sepet_Yayinevi
            // 
            this.sepet_Yayinevi.Location = new System.Drawing.Point(684, 224);
            this.sepet_Yayinevi.Name = "sepet_Yayinevi";
            this.sepet_Yayinevi.Size = new System.Drawing.Size(100, 22);
            this.sepet_Yayinevi.TabIndex = 14;
            // 
            // sepet_Yazar
            // 
            this.sepet_Yazar.Location = new System.Drawing.Point(684, 184);
            this.sepet_Yazar.Name = "sepet_Yazar";
            this.sepet_Yazar.Size = new System.Drawing.Size(100, 22);
            this.sepet_Yazar.TabIndex = 13;
            // 
            // sepet_Kategori
            // 
            this.sepet_Kategori.Location = new System.Drawing.Point(684, 138);
            this.sepet_Kategori.Name = "sepet_Kategori";
            this.sepet_Kategori.Size = new System.Drawing.Size(100, 22);
            this.sepet_Kategori.TabIndex = 12;
            // 
            // Sepet_İd
            // 
            this.Sepet_İd.Location = new System.Drawing.Point(684, 88);
            this.Sepet_İd.Name = "Sepet_İd";
            this.Sepet_İd.Size = new System.Drawing.Size(100, 22);
            this.Sepet_İd.TabIndex = 11;
            this.Sepet_İd.TextChanged += new System.EventHandler(this.Sepet_İd_TextChanged);
            // 
            // btn_SepeteEkle
            // 
            this.btn_SepeteEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SepeteEkle.Location = new System.Drawing.Point(739, 257);
            this.btn_SepeteEkle.Name = "btn_SepeteEkle";
            this.btn_SepeteEkle.Size = new System.Drawing.Size(196, 57);
            this.btn_SepeteEkle.TabIndex = 10;
            this.btn_SepeteEkle.Text = "Sepete Ekle";
            this.btn_SepeteEkle.UseVisualStyleBackColor = true;
            this.btn_SepeteEkle.Click += new System.EventHandler(this.btn_SepeteEkle_Click);
            // 
            // sepet_Aciklama
            // 
            this.sepet_Aciklama.AutoSize = true;
            this.sepet_Aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sepet_Aciklama.Location = new System.Drawing.Point(830, 225);
            this.sepet_Aciklama.Name = "sepet_Aciklama";
            this.sepet_Aciklama.Size = new System.Drawing.Size(94, 24);
            this.sepet_Aciklama.TabIndex = 9;
            this.sepet_Aciklama.Text = "Açıklama";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.Location = new System.Drawing.Point(830, 184);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 24);
            this.label.TabIndex = 8;
            this.label.Text = "Basım Yılı";
            // 
            // sepetSayfa
            // 
            this.sepetSayfa.AutoSize = true;
            this.sepetSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sepetSayfa.Location = new System.Drawing.Point(816, 138);
            this.sepetSayfa.Name = "sepetSayfa";
            this.sepetSayfa.Size = new System.Drawing.Size(120, 24);
            this.sepetSayfa.TabIndex = 7;
            this.sepetSayfa.Text = "Sayfa Sayısı";
            // 
            // SepetYayınevi
            // 
            this.SepetYayınevi.AutoSize = true;
            this.SepetYayınevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SepetYayınevi.Location = new System.Drawing.Point(590, 223);
            this.SepetYayınevi.Name = "SepetYayınevi";
            this.SepetYayınevi.Size = new System.Drawing.Size(88, 24);
            this.SepetYayınevi.TabIndex = 6;
            this.SepetYayınevi.Text = "Yayınevi";
            // 
            // SepetYazar
            // 
            this.SepetYazar.AutoSize = true;
            this.SepetYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SepetYazar.Location = new System.Drawing.Point(615, 183);
            this.SepetYazar.Name = "SepetYazar";
            this.SepetYazar.Size = new System.Drawing.Size(62, 24);
            this.SepetYazar.TabIndex = 5;
            this.SepetYazar.Text = "Yazar";
            // 
            // SepetKategori
            // 
            this.SepetKategori.AutoSize = true;
            this.SepetKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SepetKategori.Location = new System.Drawing.Point(590, 137);
            this.SepetKategori.Name = "SepetKategori";
            this.SepetKategori.Size = new System.Drawing.Size(87, 24);
            this.SepetKategori.TabIndex = 4;
            this.SepetKategori.Text = "Kategori";
            // 
            // SepetKitapİd
            // 
            this.SepetKitapİd.AutoSize = true;
            this.SepetKitapİd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SepetKitapİd.Location = new System.Drawing.Point(647, 86);
            this.SepetKitapİd.Name = "SepetKitapİd";
            this.SepetKitapİd.Size = new System.Drawing.Size(30, 25);
            this.SepetKitapİd.TabIndex = 3;
            this.SepetKitapİd.Text = "İd";
            // 
            // sepetKitap
            // 
            this.sepetKitap.Location = new System.Drawing.Point(739, 30);
            this.sepetKitap.Name = "sepetKitap";
            this.sepetKitap.Size = new System.Drawing.Size(185, 22);
            this.sepetKitap.TabIndex = 2;
            this.sepetKitap.TextChanged += new System.EventHandler(this.sepetKitap_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(686, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ARA";
            // 
            // dgvSepetKitap
            // 
            this.dgvSepetKitap.BackgroundColor = System.Drawing.Color.White;
            this.dgvSepetKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSepetKitap.Location = new System.Drawing.Point(12, 14);
            this.dgvSepetKitap.Name = "dgvSepetKitap";
            this.dgvSepetKitap.RowHeadersWidth = 51;
            this.dgvSepetKitap.RowTemplate.Height = 24;
            this.dgvSepetKitap.Size = new System.Drawing.Size(561, 300);
            this.dgvSepetKitap.TabIndex = 0;
            this.dgvSepetKitap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSepetKitap_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btn_SepetOnay);
            this.panel3.Controls.Add(this.listView_Kitap);
            this.panel3.Location = new System.Drawing.Point(13, 427);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1078, 336);
            this.panel3.TabIndex = 2;
            // 
            // btn_SepetOnay
            // 
            this.btn_SepetOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SepetOnay.Location = new System.Drawing.Point(419, 258);
            this.btn_SepetOnay.Name = "btn_SepetOnay";
            this.btn_SepetOnay.Size = new System.Drawing.Size(193, 68);
            this.btn_SepetOnay.TabIndex = 1;
            this.btn_SepetOnay.Text = "EKLE";
            this.btn_SepetOnay.UseVisualStyleBackColor = true;
            this.btn_SepetOnay.Click += new System.EventHandler(this.btn_SepetOnay_Click);
            // 
            // listView_Kitap
            // 
            this.listView_Kitap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.List_Kitapİd,
            this.List_KitapAdi,
            this.List_Kategori,
            this.List_KitapAlis});
            this.listView_Kitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView_Kitap.GridLines = true;
            this.listView_Kitap.HideSelection = false;
            this.listView_Kitap.Location = new System.Drawing.Point(11, 32);
            this.listView_Kitap.Name = "listView_Kitap";
            this.listView_Kitap.Size = new System.Drawing.Size(977, 199);
            this.listView_Kitap.TabIndex = 0;
            this.listView_Kitap.UseCompatibleStateImageBehavior = false;
            this.listView_Kitap.View = System.Windows.Forms.View.Details;
            // 
            // List_Kitapİd
            // 
            this.List_Kitapİd.Text = "İd";
            this.List_Kitapİd.Width = 97;
            // 
            // List_KitapAdi
            // 
            this.List_KitapAdi.Text = "KitapAdi";
            this.List_KitapAdi.Width = 119;
            // 
            // List_Kategori
            // 
            this.List_Kategori.Text = "Kategori";
            this.List_Kategori.Width = 124;
            // 
            // List_KitapAlis
            // 
            this.List_KitapAlis.Text = "KitapAlisTarih";
            this.List_KitapAlis.Width = 123;
            // 
            // Sepetİslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 765);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sepetİslem";
            this.Text = "Sepetİslem";
            this.Load += new System.EventHandler(this.Sepetİslem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepetKitap)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox SepetAciklama;
        private System.Windows.Forms.TextBox sepetBasim;
        private System.Windows.Forms.TextBox sepet_Sayfa;
        private System.Windows.Forms.TextBox sepet_Yayinevi;
        private System.Windows.Forms.TextBox sepet_Yazar;
        private System.Windows.Forms.TextBox sepet_Kategori;
        private System.Windows.Forms.TextBox Sepet_İd;
        private System.Windows.Forms.Button btn_SepeteEkle;
        private System.Windows.Forms.Label sepet_Aciklama;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label sepetSayfa;
        private System.Windows.Forms.Label SepetYayınevi;
        private System.Windows.Forms.Label SepetYazar;
        private System.Windows.Forms.Label SepetKategori;
        private System.Windows.Forms.Label SepetKitapİd;
        private System.Windows.Forms.TextBox sepetKitap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSepetKitap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox sepet_Adi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SepetOnay;
        private System.Windows.Forms.ListView listView_Kitap;
        private System.Windows.Forms.ColumnHeader List_Kitapİd;
        private System.Windows.Forms.ColumnHeader List_KitapAdi;
        private System.Windows.Forms.ColumnHeader List_Kategori;
        private System.Windows.Forms.ColumnHeader List_KitapAlis;
    }
}