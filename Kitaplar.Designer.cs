namespace KutuphaneYonetimSistemi
{
    partial class Kitaplar
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_KitapArama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtvKitapListesi = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvKitapListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 70);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::KutuphaneYonetimSistemi.Properties.Resources.Cıkısss;
            this.button1.Location = new System.Drawing.Point(1014, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 70);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(475, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "KİTAPLAR";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.txt_KitapArama);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(365, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 97);
            this.panel2.TabIndex = 2;
            // 
            // txt_KitapArama
            // 
            this.txt_KitapArama.Location = new System.Drawing.Point(143, 37);
            this.txt_KitapArama.Multiline = true;
            this.txt_KitapArama.Name = "txt_KitapArama";
            this.txt_KitapArama.Size = new System.Drawing.Size(154, 25);
            this.txt_KitapArama.TabIndex = 1;
            this.txt_KitapArama.TextChanged += new System.EventHandler(this.txt_KitapArama_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kitap Adı:";
            // 
            // dtvKitapListesi
            // 
            this.dtvKitapListesi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtvKitapListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvKitapListesi.Location = new System.Drawing.Point(35, 247);
            this.dtvKitapListesi.Name = "dtvKitapListesi";
            this.dtvKitapListesi.RowHeadersWidth = 51;
            this.dtvKitapListesi.RowTemplate.Height = 24;
            this.dtvKitapListesi.Size = new System.Drawing.Size(1031, 429);
            this.dtvKitapListesi.TabIndex = 5;
            this.dtvKitapListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Kitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 766);
            this.Controls.Add(this.dtvKitapListesi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kitaplar";
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.Kitaplar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvKitapListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_KitapArama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtvKitapListesi;
    }
}