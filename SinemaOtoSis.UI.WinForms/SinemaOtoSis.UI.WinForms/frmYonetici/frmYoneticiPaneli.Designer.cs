namespace SinemaOtoSis.UI.WinForms.frmYonetici
{
    partial class frmYoneticiPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYoneticiPaneli));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnPersonelKayit = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnFilmKayit = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnGosterimKayit = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnGiseIslemleri = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnPersonelKayit
            // 
            this.btnPersonelKayit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPersonelKayit.color = System.Drawing.Color.DarkSlateGray;
            this.btnPersonelKayit.colorActive = System.Drawing.Color.Teal;
            this.btnPersonelKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelKayit.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnPersonelKayit.ForeColor = System.Drawing.Color.White;
            this.btnPersonelKayit.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelKayit.Image")));
            this.btnPersonelKayit.ImagePosition = 18;
            this.btnPersonelKayit.ImageZoom = 50;
            this.btnPersonelKayit.LabelPosition = 38;
            this.btnPersonelKayit.LabelText = "Personel Kayıt";
            this.btnPersonelKayit.Location = new System.Drawing.Point(86, 114);
            this.btnPersonelKayit.Margin = new System.Windows.Forms.Padding(6);
            this.btnPersonelKayit.Name = "btnPersonelKayit";
            this.btnPersonelKayit.Size = new System.Drawing.Size(182, 169);
            this.btnPersonelKayit.TabIndex = 0;
            this.btnPersonelKayit.Click += new System.EventHandler(this.btnPersonelKayit_Click);
            // 
            // btnFilmKayit
            // 
            this.btnFilmKayit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFilmKayit.color = System.Drawing.Color.DarkSlateGray;
            this.btnFilmKayit.colorActive = System.Drawing.Color.Teal;
            this.btnFilmKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilmKayit.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnFilmKayit.ForeColor = System.Drawing.Color.White;
            this.btnFilmKayit.Image = ((System.Drawing.Image)(resources.GetObject("btnFilmKayit.Image")));
            this.btnFilmKayit.ImagePosition = 18;
            this.btnFilmKayit.ImageZoom = 50;
            this.btnFilmKayit.LabelPosition = 38;
            this.btnFilmKayit.LabelText = "Film Kayıt";
            this.btnFilmKayit.Location = new System.Drawing.Point(337, 114);
            this.btnFilmKayit.Margin = new System.Windows.Forms.Padding(6);
            this.btnFilmKayit.Name = "btnFilmKayit";
            this.btnFilmKayit.Size = new System.Drawing.Size(182, 169);
            this.btnFilmKayit.TabIndex = 1;
            this.btnFilmKayit.Click += new System.EventHandler(this.btnFilmKayit_Click);
            // 
            // btnGosterimKayit
            // 
            this.btnGosterimKayit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGosterimKayit.color = System.Drawing.Color.DarkSlateGray;
            this.btnGosterimKayit.colorActive = System.Drawing.Color.Teal;
            this.btnGosterimKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGosterimKayit.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnGosterimKayit.ForeColor = System.Drawing.Color.White;
            this.btnGosterimKayit.Image = ((System.Drawing.Image)(resources.GetObject("btnGosterimKayit.Image")));
            this.btnGosterimKayit.ImagePosition = 18;
            this.btnGosterimKayit.ImageZoom = 50;
            this.btnGosterimKayit.LabelPosition = 38;
            this.btnGosterimKayit.LabelText = "Gösterim Kayıt";
            this.btnGosterimKayit.Location = new System.Drawing.Point(587, 114);
            this.btnGosterimKayit.Margin = new System.Windows.Forms.Padding(6);
            this.btnGosterimKayit.Name = "btnGosterimKayit";
            this.btnGosterimKayit.Size = new System.Drawing.Size(182, 169);
            this.btnGosterimKayit.TabIndex = 2;
            this.btnGosterimKayit.Click += new System.EventHandler(this.btnGosterimKayit_Click);
            // 
            // btnGiseIslemleri
            // 
            this.btnGiseIslemleri.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGiseIslemleri.BackColor = System.Drawing.Color.Gray;
            this.btnGiseIslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiseIslemleri.BorderRadius = 0;
            this.btnGiseIslemleri.ButtonText = "  Gişe İşlemleri";
            this.btnGiseIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiseIslemleri.DisabledColor = System.Drawing.Color.Gray;
            this.btnGiseIslemleri.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGiseIslemleri.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGiseIslemleri.Iconimage")));
            this.btnGiseIslemleri.Iconimage_right = null;
            this.btnGiseIslemleri.Iconimage_right_Selected = null;
            this.btnGiseIslemleri.Iconimage_Selected = null;
            this.btnGiseIslemleri.IconMarginLeft = 0;
            this.btnGiseIslemleri.IconMarginRight = 0;
            this.btnGiseIslemleri.IconRightVisible = true;
            this.btnGiseIslemleri.IconRightZoom = 0D;
            this.btnGiseIslemleri.IconVisible = true;
            this.btnGiseIslemleri.IconZoom = 90D;
            this.btnGiseIslemleri.IsTab = false;
            this.btnGiseIslemleri.Location = new System.Drawing.Point(651, 364);
            this.btnGiseIslemleri.Name = "btnGiseIslemleri";
            this.btnGiseIslemleri.Normalcolor = System.Drawing.Color.Gray;
            this.btnGiseIslemleri.OnHovercolor = System.Drawing.Color.Silver;
            this.btnGiseIslemleri.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGiseIslemleri.selected = false;
            this.btnGiseIslemleri.Size = new System.Drawing.Size(193, 48);
            this.btnGiseIslemleri.TabIndex = 3;
            this.btnGiseIslemleri.Text = "  Gişe İşlemleri";
            this.btnGiseIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiseIslemleri.Textcolor = System.Drawing.Color.Black;
            this.btnGiseIslemleri.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiseIslemleri.Click += new System.EventHandler(this.btnGiseIslemleri_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(247, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönetici Kayıt İşlemleri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(821, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmYoneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(865, 434);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiseIslemleri);
            this.Controls.Add(this.btnGosterimKayit);
            this.Controls.Add(this.btnFilmKayit);
            this.Controls.Add(this.btnPersonelKayit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmYoneticiPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmYoneticiPaneli";
            this.Load += new System.EventHandler(this.frmYoneticiPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnGiseIslemleri;
        private Bunifu.Framework.UI.BunifuTileButton btnGosterimKayit;
        private Bunifu.Framework.UI.BunifuTileButton btnFilmKayit;
        private Bunifu.Framework.UI.BunifuTileButton btnPersonelKayit;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
    }
}