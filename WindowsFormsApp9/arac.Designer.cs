namespace WindowsFormsApp9
{
    partial class arac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(arac));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbox_arama = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbox_ehliyet_turu = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_marka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_plaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbox_aciklama = new System.Windows.Forms.TextBox();
            this.tbox_seri = new System.Windows.Forms.TextBox();
            this.tbox_model = new System.Windows.Forms.TextBox();
            this.tbox_motorgucu = new System.Windows.Forms.TextBox();
            this.cmbox_renk = new System.Windows.Forms.ComboBox();
            this.tbox_motorhacmi = new System.Windows.Forms.TextBox();
            this.date_bakim = new System.Windows.Forms.DateTimePicker();
            this.tbox_km = new System.Windows.Forms.TextBox();
            this.cmbox_yakitturu = new System.Windows.Forms.ComboBox();
            this.tbox_fiyat = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_gncl_kaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cmbox_arama);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(0, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 86);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARAMA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(114, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "Aranacak Değer :";
            // 
            // cmbox_arama
            // 
            this.cmbox_arama.FormattingEnabled = true;
            this.cmbox_arama.Items.AddRange(new object[] {
            "Plaka",
            "Marka",
            "Seri",
            "Model",
            "Renk",
            "Motor Gücü",
            "Motor Hacmi",
            "Son Bakim Tarihi",
            "Kilometre",
            "Yakıt Türü",
            "Günlük Fiyat",
            "Ehliyet Türü"});
            this.cmbox_arama.Location = new System.Drawing.Point(228, 27);
            this.cmbox_arama.Name = "cmbox_arama";
            this.cmbox_arama.Size = new System.Drawing.Size(121, 21);
            this.cmbox_arama.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(198, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Arama Yapılacak Sütünü Seçiniz :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(328, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 22);
            this.label13.TabIndex = 58;
            this.label13.Text = "*";
            // 
            // cmbox_ehliyet_turu
            // 
            this.cmbox_ehliyet_turu.FormattingEnabled = true;
            this.cmbox_ehliyet_turu.Items.AddRange(new object[] {
            "A1",
            "A2",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.cmbox_ehliyet_turu.Location = new System.Drawing.Point(575, 272);
            this.cmbox_ehliyet_turu.Name = "cmbox_ehliyet_turu";
            this.cmbox_ehliyet_turu.Size = new System.Drawing.Size(169, 21);
            this.cmbox_ehliyet_turu.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(467, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 18);
            this.label10.TabIndex = 53;
            this.label10.Text = "Yakıt Türü :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(471, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 18);
            this.label9.TabIndex = 52;
            this.label9.Text = "Kilometre :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(418, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 18);
            this.label8.TabIndex = 51;
            this.label8.Text = "Son Bakım Tarihi : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(41, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 18);
            this.label7.TabIndex = 50;
            this.label7.Text = "Motor Hacmi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(48, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 49;
            this.label6.Text = "Motor Gücü :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(87, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 48;
            this.label5.Text = "Model :";
            // 
            // tbox_marka
            // 
            this.tbox_marka.Location = new System.Drawing.Point(153, 74);
            this.tbox_marka.MaxLength = 50;
            this.tbox_marka.Name = "tbox_marka";
            this.tbox_marka.Size = new System.Drawing.Size(169, 20);
            this.tbox_marka.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(97, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 43;
            this.label4.Text = "Renk :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(105, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Seri :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(87, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Marka :";
            // 
            // tbox_plaka
            // 
            this.tbox_plaka.Location = new System.Drawing.Point(153, 34);
            this.tbox_plaka.MaxLength = 20;
            this.tbox_plaka.Name = "tbox_plaka";
            this.tbox_plaka.Size = new System.Drawing.Size(169, 20);
            this.tbox_plaka.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(94, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "Plaka :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 410);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1116, 175);
            this.dataGridView1.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(446, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 18);
            this.label11.TabIndex = 63;
            this.label11.Text = "Günlük Fiyatı :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(475, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 18);
            this.label12.TabIndex = 64;
            this.label12.Text = "Açıklama :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(366, 276);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(187, 18);
            this.label14.TabIndex = 65;
            this.label14.Text = "Gerekli Olan Ehliyet Türü :";
            // 
            // tbox_aciklama
            // 
            this.tbox_aciklama.Location = new System.Drawing.Point(575, 193);
            this.tbox_aciklama.MaxLength = 50;
            this.tbox_aciklama.Multiline = true;
            this.tbox_aciklama.Name = "tbox_aciklama";
            this.tbox_aciklama.Size = new System.Drawing.Size(169, 60);
            this.tbox_aciklama.TabIndex = 11;
            // 
            // tbox_seri
            // 
            this.tbox_seri.Location = new System.Drawing.Point(153, 114);
            this.tbox_seri.MaxLength = 50;
            this.tbox_seri.Name = "tbox_seri";
            this.tbox_seri.Size = new System.Drawing.Size(169, 20);
            this.tbox_seri.TabIndex = 2;
            // 
            // tbox_model
            // 
            this.tbox_model.Location = new System.Drawing.Point(153, 154);
            this.tbox_model.MaxLength = 50;
            this.tbox_model.Name = "tbox_model";
            this.tbox_model.Size = new System.Drawing.Size(169, 20);
            this.tbox_model.TabIndex = 3;
            // 
            // tbox_motorgucu
            // 
            this.tbox_motorgucu.Location = new System.Drawing.Point(153, 235);
            this.tbox_motorgucu.MaxLength = 50;
            this.tbox_motorgucu.Name = "tbox_motorgucu";
            this.tbox_motorgucu.Size = new System.Drawing.Size(169, 20);
            this.tbox_motorgucu.TabIndex = 5;
            this.tbox_motorgucu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_motorgucu_KeyPress);
            // 
            // cmbox_renk
            // 
            this.cmbox_renk.FormattingEnabled = true;
            this.cmbox_renk.Items.AddRange(new object[] {
            "Beyaz",
            "Siyah",
            "Gri",
            "Mavi",
            "Kırmızı",
            "Diğer"});
            this.cmbox_renk.Location = new System.Drawing.Point(153, 194);
            this.cmbox_renk.Name = "cmbox_renk";
            this.cmbox_renk.Size = new System.Drawing.Size(169, 21);
            this.cmbox_renk.TabIndex = 4;
            // 
            // tbox_motorhacmi
            // 
            this.tbox_motorhacmi.Location = new System.Drawing.Point(153, 275);
            this.tbox_motorhacmi.MaxLength = 50;
            this.tbox_motorhacmi.Name = "tbox_motorhacmi";
            this.tbox_motorhacmi.Size = new System.Drawing.Size(169, 20);
            this.tbox_motorhacmi.TabIndex = 6;
            this.tbox_motorhacmi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_motorhacmi_KeyPress);
            // 
            // date_bakim
            // 
            this.date_bakim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_bakim.Location = new System.Drawing.Point(575, 34);
            this.date_bakim.Name = "date_bakim";
            this.date_bakim.Size = new System.Drawing.Size(169, 20);
            this.date_bakim.TabIndex = 7;
            // 
            // tbox_km
            // 
            this.tbox_km.Location = new System.Drawing.Point(575, 73);
            this.tbox_km.MaxLength = 50;
            this.tbox_km.Name = "tbox_km";
            this.tbox_km.Size = new System.Drawing.Size(169, 20);
            this.tbox_km.TabIndex = 8;
            this.tbox_km.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_km_KeyPress);
            // 
            // cmbox_yakitturu
            // 
            this.cmbox_yakitturu.FormattingEnabled = true;
            this.cmbox_yakitturu.Items.AddRange(new object[] {
            "Dizel",
            "Benzinli",
            "LPG",
            "Elektrikli"});
            this.cmbox_yakitturu.Location = new System.Drawing.Point(575, 112);
            this.cmbox_yakitturu.Name = "cmbox_yakitturu";
            this.cmbox_yakitturu.Size = new System.Drawing.Size(169, 21);
            this.cmbox_yakitturu.TabIndex = 9;
            // 
            // tbox_fiyat
            // 
            this.tbox_fiyat.Location = new System.Drawing.Point(575, 153);
            this.tbox_fiyat.MaxLength = 50;
            this.tbox_fiyat.Name = "tbox_fiyat";
            this.tbox_fiyat.Size = new System.Drawing.Size(169, 20);
            this.tbox_fiyat.TabIndex = 10;
            this.tbox_fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_fiyat_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(750, 155);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 22);
            this.label20.TabIndex = 79;
            this.label20.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(750, 71);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 22);
            this.label21.TabIndex = 80;
            this.label21.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(328, 151);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(18, 22);
            this.label22.TabIndex = 81;
            this.label22.Text = "*";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(328, 75);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(18, 22);
            this.label23.TabIndex = 82;
            this.label23.Text = "*";
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_ekle.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ekle.Location = new System.Drawing.Point(806, 35);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(144, 62);
            this.btn_ekle.TabIndex = 13;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_sil.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sil.Location = new System.Drawing.Point(806, 114);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(144, 62);
            this.btn_sil.TabIndex = 14;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_guncelle.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guncelle.Location = new System.Drawing.Point(806, 195);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(144, 62);
            this.btn_guncelle.TabIndex = 15;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_gncl_kaydet
            // 
            this.btn_gncl_kaydet.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_gncl_kaydet.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gncl_kaydet.Location = new System.Drawing.Point(806, 275);
            this.btn_gncl_kaydet.Name = "btn_gncl_kaydet";
            this.btn_gncl_kaydet.Size = new System.Drawing.Size(144, 62);
            this.btn_gncl_kaydet.TabIndex = 16;
            this.btn_gncl_kaydet.Text = "GÜNCELLEMEYİ KAYDET";
            this.btn_gncl_kaydet.UseVisualStyleBackColor = false;
            this.btn_gncl_kaydet.Visible = false;
            this.btn_gncl_kaydet.Click += new System.EventHandler(this.btn_gncl_kaydet_Click);
            // 
            // arac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1113, 584);
            this.Controls.Add(this.btn_gncl_kaydet);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tbox_fiyat);
            this.Controls.Add(this.cmbox_yakitturu);
            this.Controls.Add(this.tbox_km);
            this.Controls.Add(this.date_bakim);
            this.Controls.Add(this.tbox_motorhacmi);
            this.Controls.Add(this.cmbox_renk);
            this.Controls.Add(this.tbox_motorgucu);
            this.Controls.Add(this.tbox_model);
            this.Controls.Add(this.tbox_seri);
            this.Controls.Add(this.tbox_aciklama);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbox_ehliyet_turu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbox_marka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_plaka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "arac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araçlar";
            this.Load += new System.EventHandler(this.arac_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbox_arama;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbox_ehliyet_turu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_marka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_plaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbox_aciklama;
        private System.Windows.Forms.TextBox tbox_seri;
        private System.Windows.Forms.TextBox tbox_model;
        private System.Windows.Forms.TextBox tbox_motorgucu;
        private System.Windows.Forms.ComboBox cmbox_renk;
        private System.Windows.Forms.TextBox tbox_motorhacmi;
        private System.Windows.Forms.DateTimePicker date_bakim;
        private System.Windows.Forms.TextBox tbox_km;
        private System.Windows.Forms.ComboBox cmbox_yakitturu;
        private System.Windows.Forms.TextBox tbox_fiyat;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_gncl_kaydet;
    }
}