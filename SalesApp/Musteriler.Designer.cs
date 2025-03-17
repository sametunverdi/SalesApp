namespace SalesApp
{
    partial class Musteriler
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Mst2 = new System.Windows.Forms.Button();
            this.Mst1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnAra = new System.Windows.Forms.Button();
            this.MstArama = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MstVergiNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.MstMail = new System.Windows.Forms.TextBox();
            this.MstTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MstTc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MstAdres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MstSoyadi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MstFirma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(226, 432);
            this.listView1.Margin = new System.Windows.Forms.Padding(5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1054, 190);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.button1_Click);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 42;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ADI";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SOYADI";
            this.columnHeader3.Width = 104;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "FİRMA ADI";
            this.columnHeader4.Width = 143;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "MAİL";
            this.columnHeader5.Width = 118;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ADRES";
            this.columnHeader6.Width = 132;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "TELEFON";
            this.columnHeader7.Width = 122;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "T.C.";
            this.columnHeader8.Width = 130;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "VERGİ NO";
            this.columnHeader9.Width = 153;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.Mst2);
            this.panel1.Controls.Add(this.Mst1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 703);
            this.panel1.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 494);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(218, 70);
            this.button6.TabIndex = 35;
            this.button6.Text = "Çıkış";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 70);
            this.button4.TabIndex = 19;
            this.button4.Text = "Siparişler";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 70);
            this.button3.TabIndex = 18;
            this.button3.Text = "Müşteriler";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Mst2
            // 
            this.Mst2.Location = new System.Drawing.Point(0, 169);
            this.Mst2.Name = "Mst2";
            this.Mst2.Size = new System.Drawing.Size(218, 70);
            this.Mst2.TabIndex = 17;
            this.Mst2.Text = "Ürünler";
            this.Mst2.UseVisualStyleBackColor = true;
            this.Mst2.Click += new System.EventHandler(this.Mst2_Click);
            // 
            // Mst1
            // 
            this.Mst1.Location = new System.Drawing.Point(0, 22);
            this.Mst1.Name = "Mst1";
            this.Mst1.Size = new System.Drawing.Size(218, 70);
            this.Mst1.TabIndex = 16;
            this.Mst1.Text = "Müşteri Kayıt";
            this.Mst1.UseVisualStyleBackColor = true;
            this.Mst1.Click += new System.EventHandler(this.Mst1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Verileri Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(441, 283);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(172, 47);
            this.BtnGuncelle.TabIndex = 4;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(639, 283);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(172, 47);
            this.BtnSil.TabIndex = 5;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnAra
            // 
            this.BtnAra.Location = new System.Drawing.Point(747, 367);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(172, 47);
            this.BtnAra.TabIndex = 6;
            this.BtnAra.Text = "Ara";
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // MstArama
            // 
            this.MstArama.Location = new System.Drawing.Point(976, 375);
            this.MstArama.Name = "MstArama";
            this.MstArama.Size = new System.Drawing.Size(178, 32);
            this.MstArama.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(732, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 25);
            this.label13.TabIndex = 49;
            this.label13.Text = "Vergi Numarası";
            // 
            // MstVergiNo
            // 
            this.MstVergiNo.Location = new System.Drawing.Point(960, 207);
            this.MstVergiNo.Name = "MstVergiNo";
            this.MstVergiNo.Size = new System.Drawing.Size(178, 32);
            this.MstVergiNo.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(249, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 25);
            this.label12.TabIndex = 47;
            this.label12.Text = "Mail Adresi";
            // 
            // MstMail
            // 
            this.MstMail.Location = new System.Drawing.Point(477, 205);
            this.MstMail.Name = "MstMail";
            this.MstMail.Size = new System.Drawing.Size(178, 32);
            this.MstMail.TabIndex = 46;
            // 
            // MstTelefon
            // 
            this.MstTelefon.Location = new System.Drawing.Point(960, 80);
            this.MstTelefon.Mask = "(999) 000-0000";
            this.MstTelefon.Name = "MstTelefon";
            this.MstTelefon.Size = new System.Drawing.Size(178, 32);
            this.MstTelefon.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(732, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(222, 25);
            this.label11.TabIndex = 44;
            this.label11.Text = "T.C. Kimlik Numarası";
            // 
            // MstTc
            // 
            this.MstTc.Location = new System.Drawing.Point(960, 139);
            this.MstTc.Name = "MstTc";
            this.MstTc.Size = new System.Drawing.Size(178, 32);
            this.MstTc.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(732, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 25);
            this.label10.TabIndex = 42;
            this.label10.Text = "Telefon Numarası";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(732, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 41;
            this.label9.Text = "Adres";
            // 
            // MstAdres
            // 
            this.MstAdres.Location = new System.Drawing.Point(960, 30);
            this.MstAdres.Name = "MstAdres";
            this.MstAdres.Size = new System.Drawing.Size(178, 32);
            this.MstAdres.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(249, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 39;
            this.label8.Text = " Soyadı";
            // 
            // MstSoyadi
            // 
            this.MstSoyadi.Location = new System.Drawing.Point(477, 83);
            this.MstSoyadi.Name = "MstSoyadi";
            this.MstSoyadi.Size = new System.Drawing.Size(178, 32);
            this.MstSoyadi.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "Firma İsmi";
            // 
            // MstFirma
            // 
            this.MstFirma.Location = new System.Drawing.Point(477, 139);
            this.MstFirma.Name = "MstFirma";
            this.MstFirma.Size = new System.Drawing.Size(178, 32);
            this.MstFirma.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = " Adı";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(477, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 32);
            this.textBox1.TabIndex = 50;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(841, 283);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(172, 47);
            this.BtnTemizle.TabIndex = 51;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1294, 703);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.MstVergiNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.MstMail);
            this.Controls.Add(this.MstTelefon);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MstTc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MstAdres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MstSoyadi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MstFirma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MstArama);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Musteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteriler";
            this.Load += new System.EventHandler(this.Musteriler_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Mst2;
        private System.Windows.Forms.Button Mst1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.TextBox MstArama;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox MstVergiNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox MstMail;
        private System.Windows.Forms.MaskedTextBox MstTelefon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MstTc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MstAdres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MstSoyadi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MstFirma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnTemizle;
    }
}