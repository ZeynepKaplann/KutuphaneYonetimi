namespace KutuphaneYonetimSistemi
{
    partial class TeslimAlmaİslemleri
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
            this.button_Cikis = new System.Windows.Forms.Button();
            this.dgvEmanetler = new System.Windows.Forms.DataGridView();
            this.EmanetKitapAra = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.UyeAdi = new System.Windows.Forms.TextBox();
            this.ÜyeSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kitapİd = new System.Windows.Forms.TextBox();
            this.kitapAdi = new System.Windows.Forms.TextBox();
            this.btn_TeslimAl = new System.Windows.Forms.Button();
            this.KitapVerilis = new System.Windows.Forms.TextBox();
            this.KitapTeslimEtme = new System.Windows.Forms.TextBox();
            this.KitapAlis = new System.Windows.Forms.TextBox();
            this.Ceza = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmanetler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_Cikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1291, 75);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(484, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "TESLİM ALMA İŞLEMLERİ";
            // 
            // button_Cikis
            // 
            this.button_Cikis.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cikis.Image = global::KutuphaneYonetimSistemi.Properties.Resources.Cıkısss;
            this.button_Cikis.Location = new System.Drawing.Point(1193, 0);
            this.button_Cikis.Name = "button_Cikis";
            this.button_Cikis.Size = new System.Drawing.Size(98, 75);
            this.button_Cikis.TabIndex = 0;
            this.button_Cikis.UseVisualStyleBackColor = true;
            this.button_Cikis.Click += new System.EventHandler(this.button_Cikis_Click);
            // 
            // dgvEmanetler
            // 
            this.dgvEmanetler.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmanetler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmanetler.Location = new System.Drawing.Point(273, 141);
            this.dgvEmanetler.Name = "dgvEmanetler";
            this.dgvEmanetler.RowHeadersWidth = 51;
            this.dgvEmanetler.RowTemplate.Height = 24;
            this.dgvEmanetler.Size = new System.Drawing.Size(687, 182);
            this.dgvEmanetler.TabIndex = 1;
            this.dgvEmanetler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmanetler_CellContentClick);
            // 
            // EmanetKitapAra
            // 
            this.EmanetKitapAra.Location = new System.Drawing.Point(530, 113);
            this.EmanetKitapAra.Name = "EmanetKitapAra";
            this.EmanetKitapAra.Size = new System.Drawing.Size(169, 22);
            this.EmanetKitapAra.TabIndex = 2;
            this.EmanetKitapAra.TextChanged += new System.EventHandler(this.EmanetKitapAra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(311, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitapİd";
            // 
            // UyeAdi
            // 
            this.UyeAdi.Location = new System.Drawing.Point(398, 432);
            this.UyeAdi.Name = "UyeAdi";
            this.UyeAdi.Size = new System.Drawing.Size(100, 22);
            this.UyeAdi.TabIndex = 4;
            // 
            // ÜyeSoyadi
            // 
            this.ÜyeSoyadi.Location = new System.Drawing.Point(830, 435);
            this.ÜyeSoyadi.Name = "ÜyeSoyadi";
            this.ÜyeSoyadi.Size = new System.Drawing.Size(100, 22);
            this.ÜyeSoyadi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(714, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kitap Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(311, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Üye Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(706, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Üye Soyadı";
            // 
            // kitapİd
            // 
            this.kitapİd.Location = new System.Drawing.Point(398, 378);
            this.kitapİd.Name = "kitapİd";
            this.kitapİd.Size = new System.Drawing.Size(100, 22);
            this.kitapİd.TabIndex = 9;
            this.kitapİd.TextChanged += new System.EventHandler(this.kitapİd_TextChanged);
            // 
            // kitapAdi
            // 
            this.kitapAdi.Location = new System.Drawing.Point(830, 373);
            this.kitapAdi.Name = "kitapAdi";
            this.kitapAdi.Size = new System.Drawing.Size(100, 22);
            this.kitapAdi.TabIndex = 10;
            // 
            // btn_TeslimAl
            // 
            this.btn_TeslimAl.BackColor = System.Drawing.Color.Teal;
            this.btn_TeslimAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TeslimAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_TeslimAl.Location = new System.Drawing.Point(530, 632);
            this.btn_TeslimAl.Name = "btn_TeslimAl";
            this.btn_TeslimAl.Size = new System.Drawing.Size(190, 60);
            this.btn_TeslimAl.TabIndex = 11;
            this.btn_TeslimAl.Text = "TESLİM AL";
            this.btn_TeslimAl.UseVisualStyleBackColor = false;
            this.btn_TeslimAl.Click += new System.EventHandler(this.btn_TeslimAl_Click);
            // 
            // KitapVerilis
            // 
            this.KitapVerilis.Location = new System.Drawing.Point(398, 488);
            this.KitapVerilis.Name = "KitapVerilis";
            this.KitapVerilis.Size = new System.Drawing.Size(100, 22);
            this.KitapVerilis.TabIndex = 12;
            // 
            // KitapTeslimEtme
            // 
            this.KitapTeslimEtme.Location = new System.Drawing.Point(398, 545);
            this.KitapTeslimEtme.Name = "KitapTeslimEtme";
            this.KitapTeslimEtme.Size = new System.Drawing.Size(100, 22);
            this.KitapTeslimEtme.TabIndex = 13;
            // 
            // KitapAlis
            // 
            this.KitapAlis.Location = new System.Drawing.Point(830, 488);
            this.KitapAlis.Name = "KitapAlis";
            this.KitapAlis.Size = new System.Drawing.Size(100, 22);
            this.KitapAlis.TabIndex = 14;
            // 
            // Ceza
            // 
            this.Ceza.Location = new System.Drawing.Point(830, 545);
            this.Ceza.Name = "Ceza";
            this.Ceza.Size = new System.Drawing.Size(100, 22);
            this.Ceza.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(470, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "ARA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(217, 492);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kitabın verildiği tarih";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(215, 549);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Üyenin Getiriği Tarih";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(747, 545);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ceza";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(665, 492);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(661, 491);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "Kitabın Alış Tarihi";
            // 
            // TeslimAlmaİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1291, 794);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Ceza);
            this.Controls.Add(this.KitapAlis);
            this.Controls.Add(this.KitapTeslimEtme);
            this.Controls.Add(this.KitapVerilis);
            this.Controls.Add(this.btn_TeslimAl);
            this.Controls.Add(this.kitapAdi);
            this.Controls.Add(this.kitapİd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ÜyeSoyadi);
            this.Controls.Add(this.UyeAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmanetKitapAra);
            this.Controls.Add(this.dgvEmanetler);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeslimAlmaİslemleri";
            this.Load += new System.EventHandler(this.TeslimAlmaİslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmanetler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmanetler;
        private System.Windows.Forms.TextBox EmanetKitapAra;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UyeAdi;
        private System.Windows.Forms.TextBox ÜyeSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kitapİd;
        private System.Windows.Forms.TextBox kitapAdi;
        private System.Windows.Forms.Button btn_TeslimAl;
        private System.Windows.Forms.TextBox KitapVerilis;
        private System.Windows.Forms.TextBox KitapTeslimEtme;
        private System.Windows.Forms.TextBox KitapAlis;
        private System.Windows.Forms.TextBox Ceza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}