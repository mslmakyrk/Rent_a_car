namespace WindowsFormsApp9
{
    partial class musteri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musteri));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_tc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_ad = new System.Windows.Forms.TextBox();
            this.txb_mail = new System.Windows.Forms.TextBox();
            this.txb_is_tel = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_dogumyeri = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_adres = new System.Windows.Forms.TextBox();
            this.cmb_ehliyet_turu = new System.Windows.Forms.ComboBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.txb_ceptel = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txb_ehliyet_trh = new System.Windows.Forms.DateTimePicker();
            this.txb_dogum = new System.Windows.Forms.DateTimePicker();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_gncl_kaydet = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbox_arama = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1154, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_ekle.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ekle.Location = new System.Drawing.Point(753, 23);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(144, 62);
            this.btn_ekle.TabIndex = 11;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            this.btn_ekle.MouseEnter += new System.EventHandler(this.btn_ekle_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tc Kimlik No :";
            // 
            // txb_tc
            // 
            this.txb_tc.Location = new System.Drawing.Point(151, 37);
            this.txb_tc.MaxLength = 11;
            this.txb_tc.Name = "txb_tc";
            this.txb_tc.Size = new System.Drawing.Size(169, 20);
            this.txb_tc.TabIndex = 1;
            this.txb_tc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_tc_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(35, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doğum Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(53, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "İş Telefonu :";
            // 
            // txb_ad
            // 
            this.txb_ad.Location = new System.Drawing.Point(151, 78);
            this.txb_ad.MaxLength = 50;
            this.txb_ad.Name = "txb_ad";
            this.txb_ad.Size = new System.Drawing.Size(169, 20);
            this.txb_ad.TabIndex = 2;
            // 
            // txb_mail
            // 
            this.txb_mail.Location = new System.Drawing.Point(540, 38);
            this.txb_mail.MaxLength = 100;
            this.txb_mail.Name = "txb_mail";
            this.txb_mail.Size = new System.Drawing.Size(159, 20);
            this.txb_mail.TabIndex = 7;
            // 
            // txb_is_tel
            // 
            this.txb_is_tel.Location = new System.Drawing.Point(151, 201);
            this.txb_is_tel.Mask = "(9999) 000-0000";
            this.txb_is_tel.Name = "txb_is_tel";
            this.txb_is_tel.Size = new System.Drawing.Size(169, 20);
            this.txb_is_tel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(47, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Doğum Yeri :";
            // 
            // cmb_dogumyeri
            // 
            this.cmb_dogumyeri.FormattingEnabled = true;
            this.cmb_dogumyeri.Items.AddRange(new object[] {
            "ADANA",
            "ADIYAMAN",
            "AFYONKARAHİSAR",
            "AĞRI",
            "AKSARAY",
            "AMASYA",
            "ANKARA",
            "ANTALYA",
            "ARDAHAN",
            "ARTVİN",
            "AYDIN",
            "BALIKESİR",
            "BARTIN",
            "BATMAN",
            "BAYBURT",
            "BİLECİK",
            "BİNGÖL",
            "BİTLİS",
            "BOLU",
            "BURDUR",
            "BURSA",
            "ÇANAKKALE",
            "ÇANKIRI",
            "ÇORUM",
            "DENİZLİ",
            "DİYARBAKIR",
            "DÜZCE",
            "EDİRNE",
            "ELAZIĞ",
            "ERZİNCAN",
            "ERZURUM",
            "ESKİŞEHİR",
            "GAZİANTEP",
            "GİRESUN",
            "GÜMÜŞHANE",
            "HAKKARİ",
            "HATAY",
            "IĞDIR",
            "ISPARTA",
            "İSTANBUL",
            "İZMİR",
            "KAHRAMANMARAŞ",
            "KARABÜK",
            "KARAMAN",
            "KARS",
            "KASTAMONU",
            "KAYSERİ",
            "KIRIKKALE",
            "KIRKLARELİ",
            "KIRŞEHİR",
            "KİLİS",
            "KOCAELİ",
            "KONYA",
            "KÜTAHYA",
            "MALATYA",
            "MANİSA",
            "MARDİN",
            "MERSİN",
            "MUĞLA",
            "MUŞ",
            "NEVŞEHİR",
            "NİĞDE",
            "ORDU",
            "OSMANİYE",
            "RİZE",
            "SAKARYA",
            "SAMSUN",
            "SİİRT",
            "SİNOP",
            "SİVAS",
            "ŞANLI URFA",
            "ŞIRNAK",
            "TEKİRDAĞ",
            "TOKAT",
            "TRABZON",
            "TUNCELİ",
            "UŞAK",
            "VAN",
            "YALOVA",
            "YOZGAT",
            "ZONGULDAK"});
            this.cmb_dogumyeri.Location = new System.Drawing.Point(151, 161);
            this.cmb_dogumyeri.Name = "cmb_dogumyeri";
            this.cmb_dogumyeri.Size = new System.Drawing.Size(169, 21);
            this.cmb_dogumyeri.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(39, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cep Telefonu :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(488, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Mail :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(478, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Adres :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(436, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ehliyet Türü :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(399, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ehliyet Alış Tarihi :";
            // 
            // txb_adres
            // 
            this.txb_adres.Location = new System.Drawing.Point(540, 83);
            this.txb_adres.MaxLength = 200;
            this.txb_adres.Multiline = true;
            this.txb_adres.Name = "txb_adres";
            this.txb_adres.Size = new System.Drawing.Size(159, 63);
            this.txb_adres.TabIndex = 8;
            // 
            // cmb_ehliyet_turu
            // 
            this.cmb_ehliyet_turu.FormattingEnabled = true;
            this.cmb_ehliyet_turu.Items.AddRange(new object[] {
            "A1",
            "A2",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.cmb_ehliyet_turu.Location = new System.Drawing.Point(540, 161);
            this.cmb_ehliyet_turu.Name = "cmb_ehliyet_turu";
            this.cmb_ehliyet_turu.Size = new System.Drawing.Size(159, 21);
            this.cmb_ehliyet_turu.TabIndex = 9;
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_sil.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sil.Location = new System.Drawing.Point(753, 97);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(144, 62);
            this.btn_sil.TabIndex = 12;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // txb_ceptel
            // 
            this.txb_ceptel.Location = new System.Drawing.Point(151, 242);
            this.txb_ceptel.Mask = "(9999) 000-0000";
            this.txb_ceptel.Name = "txb_ceptel";
            this.txb_ceptel.Size = new System.Drawing.Size(169, 20);
            this.txb_ceptel.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(326, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 22);
            this.label11.TabIndex = 28;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(705, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 22);
            this.label12.TabIndex = 29;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(326, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 22);
            this.label13.TabIndex = 30;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(326, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 22);
            this.label14.TabIndex = 31;
            this.label14.Text = "*";
            // 
            // txb_ehliyet_trh
            // 
            this.txb_ehliyet_trh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txb_ehliyet_trh.Location = new System.Drawing.Point(540, 198);
            this.txb_ehliyet_trh.Name = "txb_ehliyet_trh";
            this.txb_ehliyet_trh.Size = new System.Drawing.Size(159, 20);
            this.txb_ehliyet_trh.TabIndex = 10;
            // 
            // txb_dogum
            // 
            this.txb_dogum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txb_dogum.Location = new System.Drawing.Point(151, 117);
            this.txb_dogum.Name = "txb_dogum";
            this.txb_dogum.Size = new System.Drawing.Size(169, 20);
            this.txb_dogum.TabIndex = 3;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_guncelle.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guncelle.Location = new System.Drawing.Point(753, 171);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(144, 62);
            this.btn_guncelle.TabIndex = 13;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_gncl_kaydet
            // 
            this.btn_gncl_kaydet.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_gncl_kaydet.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gncl_kaydet.Location = new System.Drawing.Point(753, 245);
            this.btn_gncl_kaydet.Name = "btn_gncl_kaydet";
            this.btn_gncl_kaydet.Size = new System.Drawing.Size(144, 62);
            this.btn_gncl_kaydet.TabIndex = 14;
            this.btn_gncl_kaydet.Text = "GÜNCELLEMEYİ KAYDET";
            this.btn_gncl_kaydet.UseVisualStyleBackColor = false;
            this.btn_gncl_kaydet.Visible = false;
            this.btn_gncl_kaydet.Click += new System.EventHandler(this.btn_gncl_kaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cmbox_arama);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(32, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 86);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARAMA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
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
            "Tc Kimlik",
            "Ad-Soyad",
            "Doğum Tarihi",
            "Doğum Yeri",
            "İş Telefonu",
            "Cep Telefonu",
            "Mail",
            "Adres",
            "Ehliyet Türü",
            "Ehliyet Alış Tarihi"});
            this.cmbox_arama.Location = new System.Drawing.Point(228, 27);
            this.cmbox_arama.Name = "cmbox_arama";
            this.cmbox_arama.Size = new System.Drawing.Size(121, 21);
            this.cmbox_arama.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(198, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Arama Yapılacak Sütünü Seciniz :";
            // 
            // musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1153, 517);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_gncl_kaydet);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.txb_dogum);
            this.Controls.Add(this.txb_ehliyet_trh);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txb_ceptel);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.cmb_ehliyet_turu);
            this.Controls.Add(this.txb_adres);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_dogumyeri);
            this.Controls.Add(this.txb_is_tel);
            this.Controls.Add(this.txb_mail);
            this.Controls.Add(this.txb_ad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_tc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "musteri";
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.musteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_tc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_ad;
        private System.Windows.Forms.TextBox txb_mail;
        private System.Windows.Forms.MaskedTextBox txb_is_tel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_dogumyeri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_adres;
        private System.Windows.Forms.ComboBox cmb_ehliyet_turu;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.MaskedTextBox txb_ceptel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker txb_ehliyet_trh;
        private System.Windows.Forms.DateTimePicker txb_dogum;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_gncl_kaydet;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbox_arama;
        private System.Windows.Forms.Label label15;
    }
}