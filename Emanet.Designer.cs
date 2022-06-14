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
            this.listView_Kitap = new System.Windows.Forms.ListView();
            this.İd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KitapAlis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridView_Uyeler = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Ara = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.EmanetKitapİd = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Kitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Uyeler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Kitap
            // 
            this.dataGridView_Kitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Kitap.Location = new System.Drawing.Point(37, 48);
            this.dataGridView_Kitap.Name = "dataGridView_Kitap";
            this.dataGridView_Kitap.RowHeadersWidth = 51;
            this.dataGridView_Kitap.RowTemplate.Height = 24;
            this.dataGridView_Kitap.Size = new System.Drawing.Size(570, 150);
            this.dataGridView_Kitap.TabIndex = 0;
            // 
            // listView_Kitap
            // 
            this.listView_Kitap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.İd,
            this.KitapAlis});
            this.listView_Kitap.HideSelection = false;
            this.listView_Kitap.Location = new System.Drawing.Point(717, 48);
            this.listView_Kitap.Name = "listView_Kitap";
            this.listView_Kitap.Size = new System.Drawing.Size(549, 150);
            this.listView_Kitap.TabIndex = 1;
            this.listView_Kitap.UseCompatibleStateImageBehavior = false;
            this.listView_Kitap.View = System.Windows.Forms.View.Details;
            this.listView_Kitap.SelectedIndexChanged += new System.EventHandler(this.listView_Kitap_SelectedIndexChanged);
            // 
            // İd
            // 
            this.İd.Text = "İd";
            this.İd.Width = 181;
            // 
            // KitapAlis
            // 
            this.KitapAlis.Text = "Kitap Alis Tarihi";
            this.KitapAlis.Width = 227;
            // 
            // dataGridView_Uyeler
            // 
            this.dataGridView_Uyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Uyeler.Location = new System.Drawing.Point(37, 278);
            this.dataGridView_Uyeler.Name = "dataGridView_Uyeler";
            this.dataGridView_Uyeler.RowHeadersWidth = 51;
            this.dataGridView_Uyeler.RowTemplate.Height = 24;
            this.dataGridView_Uyeler.Size = new System.Drawing.Size(570, 150);
            this.dataGridView_Uyeler.TabIndex = 2;
            this.dataGridView_Uyeler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1038, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kitabı Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ara
            // 
            this.Ara.Location = new System.Drawing.Point(118, 12);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(100, 22);
            this.Ara.TabIndex = 6;
            this.Ara.TextChanged += new System.EventHandler(this.Ara_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(236, 240);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // EmanetKitapİd
            // 
            this.EmanetKitapİd.Location = new System.Drawing.Point(791, 19);
            this.EmanetKitapİd.Name = "EmanetKitapİd";
            this.EmanetKitapİd.Size = new System.Drawing.Size(100, 22);
            this.EmanetKitapİd.TabIndex = 10;
            this.EmanetKitapİd.TextChanged += new System.EventHandler(this.EmanetKitapİd_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(470, 513);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(748, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(748, 335);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 13;
            // 
            // Emanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 772);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.EmanetKitapİd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_Uyeler);
            this.Controls.Add(this.listView_Kitap);
            this.Controls.Add(this.dataGridView_Kitap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Emanet";
            this.Text = "Emanet";
            this.Load += new System.EventHandler(this.Emanet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Kitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Uyeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Kitap;
        private System.Windows.Forms.ListView listView_Kitap;
        private System.Windows.Forms.DataGridView dataGridView_Uyeler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Ara;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox EmanetKitapİd;
        private System.Windows.Forms.ColumnHeader İd;
        private System.Windows.Forms.ColumnHeader KitapAlis;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
    }
}