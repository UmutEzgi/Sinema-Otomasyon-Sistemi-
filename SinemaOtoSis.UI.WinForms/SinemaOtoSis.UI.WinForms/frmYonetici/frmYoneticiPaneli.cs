using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtoSis.UI.WinForms.frmYonetici
{
    public partial class frmYoneticiPaneli : Form
    {
        public frmYoneticiPaneli()
        {
            InitializeComponent();
        }
        int PrsnlId;
        public frmYoneticiPaneli(int PersonelId)
        {
            PrsnlId = PersonelId;
            InitializeComponent();
        }

        private void frmYoneticiPaneli_Load(object sender, EventArgs e)
        {

        }

        private void btnGosterimKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGosterimKayitIslemleri frm = new frmGosterimKayitIslemleri();
            frm.ShowDialog();
        }

        private void btnFilmKayit_Click(object sender, EventArgs e)
        {
            
            frmFilmKayitİslemleri frm = new frmFilmKayitİslemleri();
            frm.ShowDialog();
        }

        private void btnPersonelKayit_Click(object sender, EventArgs e)
        {
            
            frmPersonelKayitFormu frm = new frmPersonelKayitFormu();
            frm.ShowDialog();
        }

        private void btnGiseIslemleri_Click(object sender, EventArgs e)
        {
            
            frmBiletSatisIslemleri frm = new frmBiletSatisIslemleri(PrsnlId);
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
