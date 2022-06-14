namespace KutuphaneYonetimSistemi
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelBaslık = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.label_kAdı = new System.Windows.Forms.Label();
            this.label_Parola = new System.Windows.Forms.Label();
            this.txt_Parola = new System.Windows.Forms.TextBox();
            this.checkBox_BeniHatırla = new System.Windows.Forms.CheckBox();
            this.linkLabelSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.btn_GirisYap = new System.Windows.Forms.Button();
            this.GırısFoto = new System.Windows.Forms.PictureBox();
            this.panelBaslık.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GırısFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBaslık
            // 
            this.panelBaslık.BackColor = System.Drawing.Color.Teal;
            this.panelBaslık.Controls.Add(this.label2);
            this.panelBaslık.Controls.Add(this.btn_cikis);
            this.panelBaslık.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBaslık.Location = new System.Drawing.Point(0, 0);
            this.panelBaslık.Name = "panelBaslık";
            this.panelBaslık.Size = new System.Drawing.Size(842, 57);
            this.panelBaslık.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(263, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "KÜTÜPHANE YÖNETİM SİSTEMİ";
            // 
            // btn_cikis
            // 
            this.btn_cikis.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikis.Image = ((System.Drawing.Image)(resources.GetObject("btn_cikis.Image")));
            this.btn_cikis.Location = new System.Drawing.Point(746, 0);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(96, 57);
            this.btn_cikis.TabIndex = 0;
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(419, 348);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(174, 22);
            this.txt_KullaniciAdi.TabIndex = 1;
            // 
            // label_kAdı
            // 
            this.label_kAdı.AutoSize = true;
            this.label_kAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kAdı.Location = new System.Drawing.Point(217, 348);
            this.label_kAdı.Name = "label_kAdı";
            this.label_kAdı.Size = new System.Drawing.Size(184, 24);
            this.label_kAdı.TabIndex = 3;
            this.label_kAdı.Text = "KullanıcıAdı/Email:";
            // 
            // label_Parola
            // 
            this.label_Parola.AutoSize = true;
            this.label_Parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Parola.Location = new System.Drawing.Point(320, 393);
            this.label_Parola.Name = "label_Parola";
            this.label_Parola.Size = new System.Drawing.Size(81, 25);
            this.label_Parola.TabIndex = 4;
            this.label_Parola.Text = "Parola:";
            // 
            // txt_Parola
            // 
            this.txt_Parola.Location = new System.Drawing.Point(419, 397);
            this.txt_Parola.Name = "txt_Parola";
            this.txt_Parola.Size = new System.Drawing.Size(174, 22);
            this.txt_Parola.TabIndex = 5;
            // 
            // checkBox_BeniHatırla
            // 
            this.checkBox_BeniHatırla.AutoSize = true;
            this.checkBox_BeniHatırla.Location = new System.Drawing.Point(361, 456);
            this.checkBox_BeniHatırla.Name = "checkBox_BeniHatırla";
            this.checkBox_BeniHatırla.Size = new System.Drawing.Size(103, 21);
            this.checkBox_BeniHatırla.TabIndex = 6;
            this.checkBox_BeniHatırla.Text = "Beni Hatırla";
            this.checkBox_BeniHatırla.UseVisualStyleBackColor = true;
            // 
            // linkLabelSifremiUnuttum
            // 
            this.linkLabelSifremiUnuttum.AutoSize = true;
            this.linkLabelSifremiUnuttum.Location = new System.Drawing.Point(358, 490);
            this.linkLabelSifremiUnuttum.Name = "linkLabelSifremiUnuttum";
            this.linkLabelSifremiUnuttum.Size = new System.Drawing.Size(108, 17);
            this.linkLabelSifremiUnuttum.TabIndex = 7;
            this.linkLabelSifremiUnuttum.TabStop = true;
            this.linkLabelSifremiUnuttum.Text = "Şifremi Unuttum";
            this.linkLabelSifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSifremiUnuttum_LinkClicked);
            // 
            // btn_GirisYap
            // 
            this.btn_GirisYap.BackColor = System.Drawing.Color.Teal;
            this.btn_GirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GirisYap.Location = new System.Drawing.Point(309, 548);
            this.btn_GirisYap.Name = "btn_GirisYap";
            this.btn_GirisYap.Size = new System.Drawing.Size(219, 76);
            this.btn_GirisYap.TabIndex = 8;
            this.btn_GirisYap.Text = "GİRİŞ";
            this.btn_GirisYap.UseVisualStyleBackColor = false;
            this.btn_GirisYap.Click += new System.EventHandler(this.btn_GirisYap_Click);
            // 
            // GırısFoto
            // 
            this.GırısFoto.Image = ((System.Drawing.Image)(resources.GetObject("GırısFoto.Image")));
            this.GırısFoto.Location = new System.Drawing.Point(197, 87);
            this.GırısFoto.Name = "GırısFoto";
            this.GırısFoto.Size = new System.Drawing.Size(434, 184);
            this.GırısFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GırısFoto.TabIndex = 2;
            this.GırısFoto.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(842, 734);
            this.Controls.Add(this.btn_GirisYap);
            this.Controls.Add(this.linkLabelSifremiUnuttum);
            this.Controls.Add(this.checkBox_BeniHatırla);
            this.Controls.Add(this.txt_Parola);
            this.Controls.Add(this.label_Parola);
            this.Controls.Add(this.label_kAdı);
            this.Controls.Add(this.GırısFoto);
            this.Controls.Add(this.txt_KullaniciAdi);
            this.Controls.Add(this.panelBaslık);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load_1);
            this.panelBaslık.ResumeLayout(false);
            this.panelBaslık.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GırısFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBaslık;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.TextBox txt_KullaniciAdi;
        private System.Windows.Forms.PictureBox GırısFoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_kAdı;
        private System.Windows.Forms.Label label_Parola;
        private System.Windows.Forms.TextBox txt_Parola;
        private System.Windows.Forms.CheckBox checkBox_BeniHatırla;
        private System.Windows.Forms.LinkLabel linkLabelSifremiUnuttum;
        private System.Windows.Forms.Button btn_GirisYap;
    }
}

