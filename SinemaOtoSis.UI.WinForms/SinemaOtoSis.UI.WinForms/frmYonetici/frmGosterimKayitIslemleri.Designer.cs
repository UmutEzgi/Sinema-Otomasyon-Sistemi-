namespace SinemaOtoSis.UI.WinForms
{
    partial class frmGosterimKayitIslemleri
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
            this.grpbxYeniGosterimKayit = new System.Windows.Forms.GroupBox();
            this.cbSeanslar = new System.Windows.Forms.ComboBox();
            this.cbSalonlar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYeniFilmEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpGosterimTarih = new System.Windows.Forms.DateTimePicker();
            this.cbVizyonFimler = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSalonaGore = new System.Windows.Forms.TextBox();
            this.btnGosterimKaydet = new System.Windows.Forms.Button();
            this.btnGosterimGuncelle = new System.Windows.Forms.Button();
            this.btnGosterimSil = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.rdbtnAktifGosterimler = new System.Windows.Forms.RadioButton();
            this.rdbtnTumGosterimler = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtFilmeGore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lvGosterimler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSeansaGore = new System.Windows.Forms.TextBox();
            this.grpbxYeniGosterimKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxYeniGosterimKayit
            // 
            this.grpbxYeniGosterimKayit.Controls.Add(this.cbSeanslar);
            this.grpbxYeniGosterimKayit.Controls.Add(this.cbSalonlar);
            this.grpbxYeniGosterimKayit.Controls.Add(this.label1);
            this.grpbxYeniGosterimKayit.Controls.Add(this.btnYeniFilmEkle);
            this.grpbxYeniGosterimKayit.Controls.Add(this.label3);
            this.grpbxYeniGosterimKayit.Controls.Add(this.label4);
            this.grpbxYeniGosterimKayit.Controls.Add(this.label2);
            this.grpbxYeniGosterimKayit.Controls.Add(this.dtpGosterimTarih);
            this.grpbxYeniGosterimKayit.Controls.Add(this.cbVizyonFimler);
            this.grpbxYeniGosterimKayit.Location = new System.Drawing.Point(40, 167);
            this.grpbxYeniGosterimKayit.Name = "grpbxYeniGosterimKayit";
            this.grpbxYeniGosterimKayit.Size = new System.Drawing.Size(346, 214);
            this.grpbxYeniGosterimKayit.TabIndex = 110;
            this.grpbxYeniGosterimKayit.TabStop = false;
            this.grpbxYeniGosterimKayit.Text = "Yeni Gösterim Kaydı";
            this.grpbxYeniGosterimKayit.Enter += new System.EventHandler(this.grpbxYeniKayit_Enter);
            // 
            // cbSeanslar
            // 
            this.cbSeanslar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeanslar.DropDownWidth = 120;
            this.cbSeanslar.FormattingEnabled = true;
            this.cbSeanslar.Location = new System.Drawing.Point(109, 152);
            this.cbSeanslar.Name = "cbSeanslar";
            this.cbSeanslar.Size = new System.Drawing.Size(149, 21);
            this.cbSeanslar.TabIndex = 92;
            // 
            // cbSalonlar
            // 
            this.cbSalonlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalonlar.DropDownWidth = 120;
            this.cbSalonlar.FormattingEnabled = true;
            this.cbSalonlar.Location = new System.Drawing.Point(109, 121);
            this.cbSalonlar.Name = "cbSalonlar";
            this.cbSalonlar.Size = new System.Drawing.Size(149, 21);
            this.cbSalonlar.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "Vizyondaki Filmler";
            // 
            // btnYeniFilmEkle
            // 
            this.btnYeniFilmEkle.BackColor = System.Drawing.Color.DarkCyan;
            this.btnYeniFilmEkle.Location = new System.Drawing.Point(109, 56);
            this.btnYeniFilmEkle.Name = "btnYeniFilmEkle";
            this.btnYeniFilmEkle.Size = new System.Drawing.Size(214, 23);
            this.btnYeniFilmEkle.TabIndex = 89;
            this.btnYeniFilmEkle.Text = "Yeni Film Ekle";
            this.btnYeniFilmEkle.UseVisualStyleBackColor = false;
            this.btnYeniFilmEkle.Click += new System.EventHandler(this.btnYeniFilmEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Seanslar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Gösterim Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Salonlar";
            // 
            // dtpGosterimTarih
            // 
            this.dtpGosterimTarih.Location = new System.Drawing.Point(109, 85);
            this.dtpGosterimTarih.Name = "dtpGosterimTarih";
            this.dtpGosterimTarih.Size = new System.Drawing.Size(214, 20);
            this.dtpGosterimTarih.TabIndex = 86;
            // 
            // cbVizyonFimler
            // 
            this.cbVizyonFimler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVizyonFimler.DropDownWidth = 120;
            this.cbVizyonFimler.FormattingEnabled = true;
            this.cbVizyonFimler.Location = new System.Drawing.Point(109, 29);
            this.cbVizyonFimler.Name = "cbVizyonFimler";
            this.cbVizyonFimler.Size = new System.Drawing.Size(214, 21);
            this.cbVizyonFimler.TabIndex = 80;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(698, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 109;
            this.label13.Text = "Seansa Göre Arama";
            // 
            // txtSalonaGore
            // 
            this.txtSalonaGore.Location = new System.Drawing.Point(545, 124);
            this.txtSalonaGore.Name = "txtSalonaGore";
            this.txtSalonaGore.Size = new System.Drawing.Size(134, 20);
            this.txtSalonaGore.TabIndex = 108;
            this.txtSalonaGore.TextChanged += new System.EventHandler(this.txtSalonaGore_TextChanged);
            // 
            // btnGosterimKaydet
            // 
            this.btnGosterimKaydet.BackColor = System.Drawing.Color.Teal;
            this.btnGosterimKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGosterimKaydet.Enabled = false;
            this.btnGosterimKaydet.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnGosterimKaydet.FlatAppearance.CheckedBackColor = System.Drawing.Color.Tomato;
            this.btnGosterimKaydet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnGosterimKaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnGosterimKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGosterimKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGosterimKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGosterimKaydet.Location = new System.Drawing.Point(39, 403);
            this.btnGosterimKaydet.Name = "btnGosterimKaydet";
            this.btnGosterimKaydet.Size = new System.Drawing.Size(94, 31);
            this.btnGosterimKaydet.TabIndex = 98;
            this.btnGosterimKaydet.Text = "Kaydet";
            this.btnGosterimKaydet.UseVisualStyleBackColor = false;
            this.btnGosterimKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGosterimGuncelle
            // 
            this.btnGosterimGuncelle.BackColor = System.Drawing.Color.Teal;
            this.btnGosterimGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGosterimGuncelle.Enabled = false;
            this.btnGosterimGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnGosterimGuncelle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Tomato;
            this.btnGosterimGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnGosterimGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnGosterimGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGosterimGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGosterimGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGosterimGuncelle.Location = new System.Drawing.Point(143, 404);
            this.btnGosterimGuncelle.Name = "btnGosterimGuncelle";
            this.btnGosterimGuncelle.Size = new System.Drawing.Size(91, 31);
            this.btnGosterimGuncelle.TabIndex = 99;
            this.btnGosterimGuncelle.Text = "Guncelle";
            this.btnGosterimGuncelle.UseVisualStyleBackColor = false;
            this.btnGosterimGuncelle.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnGosterimSil
            // 
            this.btnGosterimSil.BackColor = System.Drawing.Color.Teal;
            this.btnGosterimSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGosterimSil.Enabled = false;
            this.btnGosterimSil.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnGosterimSil.FlatAppearance.CheckedBackColor = System.Drawing.Color.Tomato;
            this.btnGosterimSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnGosterimSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnGosterimSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGosterimSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGosterimSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGosterimSil.Location = new System.Drawing.Point(244, 403);
            this.btnGosterimSil.Name = "btnGosterimSil";
            this.btnGosterimSil.Size = new System.Drawing.Size(85, 31);
            this.btnGosterimSil.TabIndex = 100;
            this.btnGosterimSil.Text = "Sil";
            this.btnGosterimSil.UseVisualStyleBackColor = false;
            this.btnGosterimSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(542, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 107;
            this.label11.Text = "Salona Göre Arama";
            // 
            // rdbtnAktifGosterimler
            // 
            this.rdbtnAktifGosterimler.AutoSize = true;
            this.rdbtnAktifGosterimler.Location = new System.Drawing.Point(958, 124);
            this.rdbtnAktifGosterimler.Name = "rdbtnAktifGosterimler";
            this.rdbtnAktifGosterimler.Size = new System.Drawing.Size(101, 17);
            this.rdbtnAktifGosterimler.TabIndex = 106;
            this.rdbtnAktifGosterimler.Text = "Aktif Gösterimler";
            this.rdbtnAktifGosterimler.UseVisualStyleBackColor = true;
            this.rdbtnAktifGosterimler.CheckedChanged += new System.EventHandler(this.rdbtnAktifGosterimler_CheckedChanged);
            // 
            // rdbtnTumGosterimler
            // 
            this.rdbtnTumGosterimler.AutoSize = true;
            this.rdbtnTumGosterimler.Checked = true;
            this.rdbtnTumGosterimler.Location = new System.Drawing.Point(845, 124);
            this.rdbtnTumGosterimler.Name = "rdbtnTumGosterimler";
            this.rdbtnTumGosterimler.Size = new System.Drawing.Size(108, 17);
            this.rdbtnTumGosterimler.TabIndex = 105;
            this.rdbtnTumGosterimler.TabStop = true;
            this.rdbtnTumGosterimler.Text = "Bütün Gösterimler";
            this.rdbtnTumGosterimler.UseVisualStyleBackColor = true;
            this.rdbtnTumGosterimler.CheckedChanged += new System.EventHandler(this.rdbtnTumGosterimler_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblResult.Location = new System.Drawing.Point(35, 448);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(18, 20);
            this.lblResult.TabIndex = 104;
            this.lblResult.Text = "\'\'\'";
            // 
            // txtFilmeGore
            // 
            this.txtFilmeGore.Location = new System.Drawing.Point(392, 124);
            this.txtFilmeGore.Name = "txtFilmeGore";
            this.txtFilmeGore.Size = new System.Drawing.Size(134, 20);
            this.txtFilmeGore.TabIndex = 103;
            this.txtFilmeGore.TextChanged += new System.EventHandler(this.txtFilmeGore_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 102;
            this.label5.Text = "Filme Göre Arama";
            // 
            // lvGosterimler
            // 
            this.lvGosterimler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvGosterimler.FullRowSelect = true;
            this.lvGosterimler.Location = new System.Drawing.Point(406, 166);
            this.lvGosterimler.Name = "lvGosterimler";
            this.lvGosterimler.Size = new System.Drawing.Size(677, 269);
            this.lvGosterimler.TabIndex = 101;
            this.lvGosterimler.UseCompatibleStateImageBehavior = false;
            this.lvGosterimler.View = System.Windows.Forms.View.Details;
            this.lvGosterimler.SelectedIndexChanged += new System.EventHandler(this.lvGosterimler_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "GosterimID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gosterim Tarihi";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "FilmID";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Film Adı";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SalonID";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Salon Adı";
            this.columnHeader6.Width = 123;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "SeansID";
            this.columnHeader7.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "SeansAD";
            this.columnHeader8.Width = 113;
            // 
            // txtSeansaGore
            // 
            this.txtSeansaGore.Location = new System.Drawing.Point(701, 124);
            this.txtSeansaGore.Name = "txtSeansaGore";
            this.txtSeansaGore.Size = new System.Drawing.Size(134, 20);
            this.txtSeansaGore.TabIndex = 111;
            this.txtSeansaGore.TextChanged += new System.EventHandler(this.txtSeansaGore_TextChanged);
            // 
            // frmGosterimKayitIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 539);
            this.Controls.Add(this.txtSeansaGore);
            this.Controls.Add(this.grpbxYeniGosterimKayit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSalonaGore);
            this.Controls.Add(this.btnGosterimKaydet);
            this.Controls.Add(this.btnGosterimGuncelle);
            this.Controls.Add(this.btnGosterimSil);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rdbtnAktifGosterimler);
            this.Controls.Add(this.rdbtnTumGosterimler);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtFilmeGore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvGosterimler);
            this.Name = "frmGosterimKayitIslemleri";
            this.Text = "frmGosterimKayıtİslemleri";
            this.Load += new System.EventHandler(this.frmGosterimKayıtİslemleri_Load);
            this.grpbxYeniGosterimKayit.ResumeLayout(false);
            this.grpbxYeniGosterimKayit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpbxYeniGosterimKayit;
        private System.Windows.Forms.Button btnYeniFilmEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpGosterimTarih;
        private System.Windows.Forms.ComboBox cbVizyonFimler;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSalonaGore;
        private System.Windows.Forms.Button btnGosterimKaydet;
        private System.Windows.Forms.Button btnGosterimGuncelle;
        private System.Windows.Forms.Button btnGosterimSil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdbtnAktifGosterimler;
        private System.Windows.Forms.RadioButton rdbtnTumGosterimler;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtFilmeGore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvGosterimler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSeanslar;
        private System.Windows.Forms.ComboBox cbSalonlar;
        private System.Windows.Forms.TextBox txtSeansaGore;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}