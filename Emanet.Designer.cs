namespace KutuphaneYonetimSistemi
{
    partial class Emanet
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
            this.dataGridView_Kitap = new System.Windows.Forms.DataGridView();
            this.dataGridView_Uyeler = new System.Windows.Forms.DataGridView();
            this.Ara = new System.Windows.Forms.TextBox();
            this.UyeAra = new System.Windows.Forms.TextBox();
            this.btn_EmanetVer = new System.Windows.Forms.Button();
            this.EmanetUyeİd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView_Kitap = new System.Windows.Forms.ListView();
            this.list_kitapİd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_KitapAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_Alis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.EmanetKitapİd = new System.Windows.Forms.TextBox();
            this.kitapEkle = new System.Windows.Forms.Button();
            this.txt_KitapAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Kitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Uyeler)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Kitap
            // 
            this.dataGridView_Kitap.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Kitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Kitap.Location = new System.Drawing.Point(47, 166);
            this.dataGridView_Kitap.Name = "dataGridView_Kitap";
            this.dataGridView_Kitap.RowHeadersWidth = 51;
            this.dataGridView_Kitap.RowTemplate.Height = 24;
            this.dataGridView_Kitap.Size = new System.Drawing.Size(570, 174);
            this.dataGridView_Kitap.TabIndex = 0;
            // 
            // dataGridView_Uyeler
            // 
            this.dataGridView_Uyeler.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Uyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Uyeler.Location = new System.Drawing.Point(177, 577);
            this.dataGridView_Uyeler.Name = "dataGridView_Uyeler";
            this.dataGridView_Uyeler.RowHeadersWidth = 51;
            this.dataGridView_Uyeler.RowTemplate.Height = 24;
            this.dataGridView_Uyeler.Size = new System.Drawing.Size(929, 150);
            this.dataGridView_Uyeler.TabIndex = 2;
            // 
            // Ara
            // 
            this.Ara.Location = new System.Drawing.Point(216, 110);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(158, 22);
            this.Ara.TabIndex = 6;
            this.Ara.TextChanged += new System.EventHandler(this.Ara_TextChanged);
            // 
            // UyeAra
            // 
            this.UyeAra.Location = new System.Drawing.Point(389, 527);
            this.UyeAra.Name = "UyeAra";
            this.UyeAra.Size = new System.Drawing.Size(194, 22);
            this.UyeAra.TabIndex = 7;
            this.UyeAra.TextChanged += new System.EventHandler(this.UyeAra_TextChanged);
            // 
            // btn_EmanetVer
            // 
            this.btn_EmanetVer.BackColor = System.Drawing.Color.Teal;
            this.btn_EmanetVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EmanetVer.Location = new System.Drawing.Point(583, 746);
            this.btn_EmanetVer.Name = "btn_EmanetVer";
            this.btn_EmanetVer.Size = new System.Drawing.Size(202, 58);
            this.btn_EmanetVer.TabIndex = 11;
            this.btn_EmanetVer.Text = "Emanet Ver";
            this.btn_EmanetVer.UseVisualStyleBackColor = false;
            this.btn_EmanetVer.Click += new System.EventHandler(this.btn_EmanetVer_Click);
            // 
            // EmanetUyeİd
            // 
            this.EmanetUyeİd.Location = new System.Drawing.Point(760, 525);
            this.EmanetUyeİd.Name = "EmanetUyeİd";
            this.EmanetUyeİd.Size = new System.Drawing.Size(132, 22);
            this.EmanetUyeİd.TabIndex = 12;
            this.EmanetUyeİd.TextChanged += new System.EventHandler(this.EmanetUyeİd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(279, 529);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Üye Ara";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 78);
            this.panel1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::KutuphaneYonetimSistemi.Properties.Resources.Cıkısss;
            this.button1.Location = new System.Drawing.Point(1224, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 78);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(541, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "EMANET VER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(70, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Kitap Ara";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(667, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Üye İd";
            // 
            // listView_Kitap
            // 
            this.listView_Kitap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_kitapİd,
            this.list_KitapAdi,
            this.list_Alis});
            this.listView_Kitap.HideSelection = false;
            this.listView_Kitap.Location = new System.Drawing.Point(756, 166);
            this.listView_Kitap.Name = "listView_Kitap";
            this.listView_Kitap.Size = new System.Drawing.Size(502, 174);
            this.listView_Kitap.TabIndex = 18;
            this.listView_Kitap.UseCompatibleStateImageBehavior = false;
            this.listView_Kitap.View = System.Windows.Forms.View.Details;
            // 
            // list_kitapİd
            // 
            this.list_kitapİd.Text = "İd";
            this.list_kitapİd.Width = 133;
            // 
            // list_KitapAdi
            // 
            this.list_KitapAdi.Text = "KitapAdi";
            this.list_KitapAdi.Width = 170;
            // 
            // list_Alis
            // 
            this.list_Alis.Text = "Aliş Tarihi";
            this.list_Alis.Width = 266;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(774, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Kitap İd";
            // 
            // EmanetKitapİd
            // 
            this.EmanetKitapİd.Location = new System.Drawing.Point(866, 113);
            this.EmanetKitapİd.Name = "EmanetKitapİd";
            this.EmanetKitapİd.Size = new System.Drawing.Size(100, 22);
            this.EmanetKitapİd.TabIndex = 20;
            this.EmanetKitapİd.TextChanged += new System.EventHandler(this.EmanetKitapİd_TextChanged_1);
            // 
            // kitapEkle
            // 
            this.kitapEkle.BackColor = System.Drawing.Color.Teal;
            this.kitapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapEkle.Location = new System.Drawing.Point(1005, 107);
            this.kitapEkle.Name = "kitapEkle";
            this.kitapEkle.Size = new System.Drawing.Size(149, 37);
            this.kitapEkle.TabIndex = 21;
            this.kitapEkle.Text = "Kitap EKLE";
            this.kitapEkle.UseVisualStyleBackColor = false;
            this.kitapEkle.Click += new System.EventHandler(this.kitapEkle_Click);
            // 
            // txt_KitapAdi
            // 
            this.txt_KitapAdi.Location = new System.Drawing.Point(177, 365);
            this.txt_KitapAdi.Name = "txt_KitapAdi";
            this.txt_KitapAdi.Size = new System.Drawing.Size(130, 22);
            this.txt_KitapAdi.TabIndex = 22;

            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(75, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Kitap Adi";
            // 
            // Emanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1314, 834);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_KitapAdi);
            this.Controls.Add(this.kitapEkle);
            this.Controls.Add(this.EmanetKitapİd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView_Kitap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmanetUyeİd);
            this.Controls.Add(this.btn_EmanetVer);
            this.Controls.Add(this.UyeAra);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.dataGridView_Uyeler);
            this.Controls.Add(this.dataGridView_Kitap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Emanet";
            this.Text = "Emanet";
            this.Load += new System.EventHandler(this.Emanet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Kitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Uyeler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Kitap;
        private System.Windows.Forms.DataGridView dataGridView_Uyeler;
        private System.Windows.Forms.TextBox Ara;
        private System.Windows.Forms.TextBox UyeAra;
        private System.Windows.Forms.Button btn_EmanetVer;
        private System.Windows.Forms.TextBox EmanetUyeİd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView_Kitap;
        private System.Windows.Forms.ColumnHeader list_kitapİd;
        private System.Windows.Forms.ColumnHeader list_KitapAdi;
        private System.Windows.Forms.ColumnHeader list_Alis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmanetKitapİd;
        private System.Windows.Forms.Button kitapEkle;
        private System.Windows.Forms.TextBox txt_KitapAdi;
        private System.Windows.Forms.Label label6;
    }
}