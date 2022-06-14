namespace KutuphaneYonetimSistemi
{
    partial class Üyeler
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
            this.btn_uyelerCikis = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUyeAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UyelerDTV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UyelerDTV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_uyelerCikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 74);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(487, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÜYELER";
            // 
            // btn_uyelerCikis
            // 
            this.btn_uyelerCikis.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_uyelerCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uyelerCikis.Image = global::KutuphaneYonetimSistemi.Properties.Resources.Cıkısss;
            this.btn_uyelerCikis.Location = new System.Drawing.Point(1020, 0);
            this.btn_uyelerCikis.Name = "btn_uyelerCikis";
            this.btn_uyelerCikis.Size = new System.Drawing.Size(96, 74);
            this.btn_uyelerCikis.TabIndex = 0;
            this.btn_uyelerCikis.UseVisualStyleBackColor = true;
            this.btn_uyelerCikis.Click += new System.EventHandler(this.btn_uyelerCikis_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.txtUyeAdSoyad);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(246, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 91);
            this.panel2.TabIndex = 2;
            // 
            // txtUyeAdSoyad
            // 
            this.txtUyeAdSoyad.Location = new System.Drawing.Point(217, 29);
            this.txtUyeAdSoyad.Multiline = true;
            this.txtUyeAdSoyad.Name = "txtUyeAdSoyad";
            this.txtUyeAdSoyad.Size = new System.Drawing.Size(158, 25);
            this.txtUyeAdSoyad.TabIndex = 1;
            this.txtUyeAdSoyad.TextChanged += new System.EventHandler(this.txtUyeAdSoyad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(84, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Üye Adı ";
            // 
            // UyelerDTV
            // 
            this.UyelerDTV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UyelerDTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UyelerDTV.Location = new System.Drawing.Point(84, 249);
            this.UyelerDTV.Name = "UyelerDTV";
            this.UyelerDTV.RowHeadersWidth = 51;
            this.UyelerDTV.RowTemplate.Height = 24;
            this.UyelerDTV.Size = new System.Drawing.Size(1020, 417);
            this.UyelerDTV.TabIndex = 4;
            this.UyelerDTV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UyelerDTV_CellContentClick);
            // 
            // Üyeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 778);
            this.Controls.Add(this.UyelerDTV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Üyeler";
            this.Text = "Üyeler";
            this.Load += new System.EventHandler(this.Üyeler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UyelerDTV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_uyelerCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUyeAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView UyelerDTV;
    }
}