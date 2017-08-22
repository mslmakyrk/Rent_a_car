namespace WindowsFormsApp9
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_mus = new System.Windows.Forms.Button();
            this.btn_arac = new System.Windows.Forms.Button();
            this.btn_kirala = new System.Windows.Forms.Button();
            this.btn_calisan = new System.Windows.Forms.Button();
            this.btn_teslim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad-Soyad : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 96);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(53, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rol : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tc Kimlik : ";
            // 
            // btn_mus
            // 
            this.btn_mus.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_mus.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mus.Location = new System.Drawing.Point(33, 102);
            this.btn_mus.Name = "btn_mus";
            this.btn_mus.Size = new System.Drawing.Size(145, 38);
            this.btn_mus.TabIndex = 4;
            this.btn_mus.Text = "Müşteriler";
            this.btn_mus.UseVisualStyleBackColor = false;
            this.btn_mus.Click += new System.EventHandler(this.btn_mus_Click);
            // 
            // btn_arac
            // 
            this.btn_arac.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_arac.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_arac.Location = new System.Drawing.Point(33, 140);
            this.btn_arac.Name = "btn_arac";
            this.btn_arac.Size = new System.Drawing.Size(145, 38);
            this.btn_arac.TabIndex = 5;
            this.btn_arac.Text = "Araçlar";
            this.btn_arac.UseVisualStyleBackColor = false;
            this.btn_arac.Click += new System.EventHandler(this.btn_arac_Click);
            // 
            // btn_kirala
            // 
            this.btn_kirala.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_kirala.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kirala.Location = new System.Drawing.Point(33, 178);
            this.btn_kirala.Name = "btn_kirala";
            this.btn_kirala.Size = new System.Drawing.Size(145, 38);
            this.btn_kirala.TabIndex = 6;
            this.btn_kirala.Text = "Kiralama Yap";
            this.btn_kirala.UseVisualStyleBackColor = false;
            this.btn_kirala.Click += new System.EventHandler(this.btn_kirala_Click);
            // 
            // btn_calisan
            // 
            this.btn_calisan.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_calisan.Enabled = false;
            this.btn_calisan.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_calisan.Location = new System.Drawing.Point(33, 216);
            this.btn_calisan.Name = "btn_calisan";
            this.btn_calisan.Size = new System.Drawing.Size(145, 38);
            this.btn_calisan.TabIndex = 7;
            this.btn_calisan.Text = "Çalışanlar";
            this.btn_calisan.UseVisualStyleBackColor = false;
            this.btn_calisan.Click += new System.EventHandler(this.btn_calisan_Click);
            // 
            // btn_teslim
            // 
            this.btn_teslim.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_teslim.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_teslim.Location = new System.Drawing.Point(33, 254);
            this.btn_teslim.Name = "btn_teslim";
            this.btn_teslim.Size = new System.Drawing.Size(145, 38);
            this.btn_teslim.TabIndex = 8;
            this.btn_teslim.Text = "Araç Teslim Al";
            this.btn_teslim.UseVisualStyleBackColor = false;
            this.btn_teslim.Click += new System.EventHandler(this.btn_teslim_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(327, 306);
            this.Controls.Add(this.btn_teslim);
            this.Controls.Add(this.btn_calisan);
            this.Controls.Add(this.btn_kirala);
            this.Controls.Add(this.btn_arac);
            this.Controls.Add(this.btn_mus);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Rent a Car";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_mus;
        private System.Windows.Forms.Button btn_arac;
        private System.Windows.Forms.Button btn_kirala;
        private System.Windows.Forms.Button btn_calisan;
        private System.Windows.Forms.Button btn_teslim;
    }
}