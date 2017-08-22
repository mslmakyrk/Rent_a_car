namespace WindowsFormsApp9
{
    partial class teslim_al
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teslim_al));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbox_plaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbox_arac = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_kirabiris = new System.Windows.Forms.Label();
            this.label_ucret = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_kontrol = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_onay = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbox_plaka);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbox_arac);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(23, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 133);
            this.groupBox2.TabIndex = 95;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aracı Seciniz";
            // 
            // tbox_plaka
            // 
            this.tbox_plaka.Location = new System.Drawing.Point(138, 32);
            this.tbox_plaka.Name = "tbox_plaka";
            this.tbox_plaka.Size = new System.Drawing.Size(121, 20);
            this.tbox_plaka.TabIndex = 0;
            this.tbox_plaka.TextChanged += new System.EventHandler(this.tbox_plaka_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plaka :";
            // 
            // cmbox_arac
            // 
            this.cmbox_arac.FormattingEnabled = true;
            this.cmbox_arac.Location = new System.Drawing.Point(138, 67);
            this.cmbox_arac.Name = "cmbox_arac";
            this.cmbox_arac.Size = new System.Drawing.Size(121, 21);
            this.cmbox_arac.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Arac :";
            // 
            // label_kirabiris
            // 
            this.label_kirabiris.AutoSize = true;
            this.label_kirabiris.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_kirabiris.Location = new System.Drawing.Point(75, 215);
            this.label_kirabiris.Name = "label_kirabiris";
            this.label_kirabiris.Size = new System.Drawing.Size(137, 16);
            this.label_kirabiris.TabIndex = 96;
            this.label_kirabiris.Text = "Kiralama Bitiş Tarihi :";
            // 
            // label_ucret
            // 
            this.label_ucret.AutoSize = true;
            this.label_ucret.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_ucret.Location = new System.Drawing.Point(166, 245);
            this.label_ucret.Name = "label_ucret";
            this.label_ucret.Size = new System.Drawing.Size(46, 16);
            this.label_ucret.TabIndex = 97;
            this.label_ucret.Text = "Ücret :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 98;
            // 
            // btn_kontrol
            // 
            this.btn_kontrol.Location = new System.Drawing.Point(358, 208);
            this.btn_kontrol.Name = "btn_kontrol";
            this.btn_kontrol.Size = new System.Drawing.Size(79, 20);
            this.btn_kontrol.TabIndex = 2;
            this.btn_kontrol.Text = "Kontrol Et";
            this.btn_kontrol.UseVisualStyleBackColor = true;
            this.btn_kontrol.Click += new System.EventHandler(this.btn_kontrol_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(177, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(166, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 101;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 102;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(166, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 103;
            // 
            // btn_onay
            // 
            this.btn_onay.Location = new System.Drawing.Point(358, 241);
            this.btn_onay.Name = "btn_onay";
            this.btn_onay.Size = new System.Drawing.Size(79, 23);
            this.btn_onay.TabIndex = 3;
            this.btn_onay.Text = "Onayla";
            this.btn_onay.UseVisualStyleBackColor = true;
            this.btn_onay.Click += new System.EventHandler(this.btn_onay_Click);
            // 
            // teslim_al
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(471, 350);
            this.Controls.Add(this.btn_onay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_kontrol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_ucret);
            this.Controls.Add(this.label_kirabiris);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "teslim_al";
            this.Text = "Araç Teslim Al";
            this.Load += new System.EventHandler(this.teslim_al_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbox_plaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbox_arac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_kirabiris;
        private System.Windows.Forms.Label label_ucret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_kontrol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_onay;
    }
}