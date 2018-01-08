namespace SinemaOtoSis.UI.WinForms
{
    partial class frmBiletSatisIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBiletSatisIslemleri));
            this.txtSeanslar = new System.Windows.Forms.TextBox();
            this.grpbxYeniGosterimKayit = new System.Windows.Forms.GroupBox();
            this.txtGosterimTarihini = new System.Windows.Forms.TextBox();
            this.txtVizyonFilmler = new System.Windows.Forms.TextBox();
            this.txtSalonlar = new System.Windows.Forms.TextBox();
            this.cbSeanslari = new System.Windows.Forms.ComboBox();
            this.cbSalonlari = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpGosterimTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbVizyondakiFimler = new System.Windows.Forms.ComboBox();
            this.btnKoltuklaraGit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lvAktifGosterimler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnExit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuThinButton2();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.aaa1 = new WindowsFormsControlLibrary1.aaa();
            this.grpbxYeniGosterimKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSeanslar
            // 
            this.txtSeanslar.Location = new System.Drawing.Point(109, 122);
            this.txtSeanslar.Name = "txtSeanslar";
            this.txtSeanslar.Size = new System.Drawing.Size(134, 20);
            this.txtSeanslar.TabIndex = 125;
            this.txtSeanslar.TextChanged += new System.EventHandler(this.txtSeanslar_TextChanged);
            // 
            // grpbxYeniGosterimKayit
            // 
            this.grpbxYeniGosterimKayit.Controls.Add(this.txtGosterimTarihini);
            this.grpbxYeniGosterimKayit.Controls.Add(this.txtVizyonFilmler);
            this.grpbxYeniGosterimKayit.Controls.Add(this.txtSalonlar);
            this.grpbxYeniGosterimKayit.Controls.Add(this.txtSeanslar);
            this.grpbxYeniGosterimKayit.Controls.Add(this.cbSeanslari);
            this.grpbxYeniGosterimKayit.Controls.Add(this.cbSalonlari);
            this.grpbxYeniGosterimKayit.Controls.Add(this.label1);
            this.grpbxYeniGosterimKayit.Controls.Add(this.label3);
            this.grpbxYeniGosterimKayit.Controls.Add(this.label4);
            this.grpbxYeniGosterimKayit.Controls.Add(this.label2);
            this.grpbxYeniGosterimKayit.Controls.Add(this.dtpGosterimTarihi);
            this.grpbxYeniGosterimKayit.Controls.Add(this.cbVizyondakiFimler);
            this.grpbxYeniGosterimKayit.Location = new System.Drawing.Point(12, 149);
            this.grpbxYeniGosterimKayit.Name = "grpbxYeniGosterimKayit";
            this.grpbxYeniGosterimKayit.Size = new System.Drawing.Size(346, 214);
            this.grpbxYeniGosterimKayit.TabIndex = 124;
            this.grpbxYeniGosterimKayit.TabStop = false;
            this.grpbxYeniGosterimKayit.Text = "Bilet Satış Ön İşlemler";
            // 
            // txtGosterimTarihini
            // 
            this.txtGosterimTarihini.Location = new System.Drawing.Point(109, 24);
            this.txtGosterimTarihini.Name = "txtGosterimTarihini";
            this.txtGosterimTarihini.Size = new System.Drawing.Size(184, 20);
            this.txtGosterimTarihini.TabIndex = 126;
            this.txtGosterimTarihini.TextChanged += new System.EventHandler(this.txtGosterimTarihini_TextChanged);
            // 
            // txtVizyonFilmler
            // 
            this.txtVizyonFilmler.Location = new System.Drawing.Point(109, 58);
            this.txtVizyonFilmler.Name = "txtVizyonFilmler";
            this.txtVizyonFilmler.Size = new System.Drawing.Size(194, 20);
            this.txtVizyonFilmler.TabIndex = 125;
            this.txtVizyonFilmler.TextChanged += new System.EventHandler(this.txtVizyonFilmler_TextChanged);
            // 
            // txtSalonlar
            // 
            this.txtSalonlar.Location = new System.Drawing.Point(109, 89);
            this.txtSalonlar.Name = "txtSalonlar";
            this.txtSalonlar.Size = new System.Drawing.Size(131, 20);
            this.txtSalonlar.TabIndex = 125;
            this.txtSalonlar.TextChanged += new System.EventHandler(this.txtSalonlar_TextChanged);
            // 
            // cbSeanslari
            // 
            this.cbSeanslari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeanslari.DropDownWidth = 120;
            this.cbSeanslari.FormattingEnabled = true;
            this.cbSeanslari.Location = new System.Drawing.Point(112, 122);
            this.cbSeanslari.Name = "cbSeanslari";
            this.cbSeanslari.Size = new System.Drawing.Size(149, 21);
            this.cbSeanslari.TabIndex = 92;
            this.cbSeanslari.SelectedIndexChanged += new System.EventHandler(this.cbSeanslari_SelectedIndexChanged);
            // 
            // cbSalonlari
            // 
            this.cbSalonlari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalonlari.DropDownWidth = 120;
            this.cbSalonlari.FormattingEnabled = true;
            this.cbSalonlari.Location = new System.Drawing.Point(109, 88);
            this.cbSalonlari.Name = "cbSalonlari";
            this.cbSalonlari.Size = new System.Drawing.Size(149, 21);
            this.cbSalonlari.TabIndex = 91;
            this.cbSalonlari.SelectedIndexChanged += new System.EventHandler(this.cbSalonlari_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "Vizyondaki Filmler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Seanslar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Gösterim Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Salonlar";
            // 
            // dtpGosterimTarihi
            // 
            this.dtpGosterimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGosterimTarihi.Location = new System.Drawing.Point(109, 24);
            this.dtpGosterimTarihi.Name = "dtpGosterimTarihi";
            this.dtpGosterimTarihi.Size = new System.Drawing.Size(214, 20);
            this.dtpGosterimTarihi.TabIndex = 86;
            this.dtpGosterimTarihi.ValueChanged += new System.EventHandler(this.dtpGosterimTarihi_ValueChanged);
            // 
            // cbVizyondakiFimler
            // 
            this.cbVizyondakiFimler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVizyondakiFimler.DropDownWidth = 120;
            this.cbVizyondakiFimler.FormattingEnabled = true;
            this.cbVizyondakiFimler.Location = new System.Drawing.Point(109, 57);
            this.cbVizyondakiFimler.Name = "cbVizyondakiFimler";
            this.cbVizyondakiFimler.Size = new System.Drawing.Size(214, 21);
            this.cbVizyondakiFimler.TabIndex = 80;
            this.cbVizyondakiFimler.SelectedIndexChanged += new System.EventHandler(this.cbVizyondakiFimler_SelectedIndexChanged);
            // 
            // btnKoltuklaraGit
            // 
            this.btnKoltuklaraGit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKoltuklaraGit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKoltuklaraGit.Enabled = false;
            this.btnKoltuklaraGit.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnKoltuklaraGit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Tomato;
            this.btnKoltuklaraGit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnKoltuklaraGit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnKoltuklaraGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKoltuklaraGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKoltuklaraGit.ForeColor = System.Drawing.Color.White;
            this.btnKoltuklaraGit.Location = new System.Drawing.Point(578, 393);
            this.btnKoltuklaraGit.Name = "btnKoltuklaraGit";
            this.btnKoltuklaraGit.Size = new System.Drawing.Size(265, 31);
            this.btnKoltuklaraGit.TabIndex = 112;
            this.btnKoltuklaraGit.Text = "Koltuklara Git";
            this.btnKoltuklaraGit.UseVisualStyleBackColor = false;
            this.btnKoltuklaraGit.Click += new System.EventHandler(this.btnKoltuklaraGit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblResult.Location = new System.Drawing.Point(-81, 437);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(18, 20);
            this.lblResult.TabIndex = 118;
            this.lblResult.Text = "\'\'\'";
            // 
            // lvAktifGosterimler
            // 
            this.lvAktifGosterimler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvAktifGosterimler.FullRowSelect = true;
            this.lvAktifGosterimler.Location = new System.Drawing.Point(380, 149);
            this.lvAktifGosterimler.Name = "lvAktifGosterimler";
            this.lvAktifGosterimler.Size = new System.Drawing.Size(463, 214);
            this.lvAktifGosterimler.TabIndex = 115;
            this.lvAktifGosterimler.UseCompatibleStateImageBehavior = false;
            this.lvAktifGosterimler.View = System.Windows.Forms.View.Details;
            this.lvAktifGosterimler.SelectedIndexChanged += new System.EventHandler(this.lvAktifGosterimler_SelectedIndexChanged);
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnExit
            // 
            this.btnExit.ActiveBorderThickness = 1;
            this.btnExit.ActiveCornerRadius = 20;
            this.btnExit.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.ActiveForecolor = System.Drawing.Color.White;
            this.btnExit.ActiveLineColor = System.Drawing.Color.Red;
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.ButtonText = " X";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnExit.IdleBorderThickness = 1;
            this.btnExit.IdleCornerRadius = 20;
            this.btnExit.IdleFillColor = System.Drawing.Color.White;
            this.btnExit.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(889, 4);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 36);
            this.btnExit.TabIndex = 125;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.ActiveBorderThickness = 1;
            this.btnMinimize.ActiveCornerRadius = 20;
            this.btnMinimize.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnMinimize.ActiveForecolor = System.Drawing.Color.White;
            this.btnMinimize.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnMinimize.BackColor = System.Drawing.SystemColors.Control;
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.ButtonText = " _";
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinimize.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnMinimize.IdleBorderThickness = 1;
            this.btnMinimize.IdleCornerRadius = 20;
            this.btnMinimize.IdleFillColor = System.Drawing.Color.White;
            this.btnMinimize.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnMinimize.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnMinimize.Location = new System.Drawing.Point(855, 4);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 36);
            this.btnMinimize.TabIndex = 126;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(740, 478);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar1.TabIndex = 127;
            // 
            // aaa1
            // 
            this.aaa1.Location = new System.Drawing.Point(0, 0);
            this.aaa1.Name = "aaa1";
            this.aaa1.Size = new System.Drawing.Size(201, 131);
            this.aaa1.TabIndex = 128;
            // 
            // frmBiletSatisIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 558);
            this.ControlBox = false;
            this.Controls.Add(this.aaa1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpbxYeniGosterimKayit);
            this.Controls.Add(this.btnKoltuklaraGit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lvAktifGosterimler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBiletSatisIslemleri";
            this.Text = "frmBiletSatisİslemleri";
            this.Load += new System.EventHandler(this.frmBiletSatisİslemleri_Load);
            this.grpbxYeniGosterimKayit.ResumeLayout(false);
            this.grpbxYeniGosterimKayit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSeanslar;
        private System.Windows.Forms.GroupBox grpbxYeniGosterimKayit;
        private System.Windows.Forms.ComboBox cbSeanslari;
        private System.Windows.Forms.ComboBox cbSalonlari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpGosterimTarihi;
        private System.Windows.Forms.ComboBox cbVizyondakiFimler;
        private System.Windows.Forms.Button btnKoltuklaraGit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ListView lvAktifGosterimler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox txtVizyonFilmler;
        private System.Windows.Forms.TextBox txtSalonlar;
        private System.Windows.Forms.TextBox txtGosterimTarihini;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnMinimize;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExit;
        private WindowsFormsControlLibrary1.aaa aaa1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}