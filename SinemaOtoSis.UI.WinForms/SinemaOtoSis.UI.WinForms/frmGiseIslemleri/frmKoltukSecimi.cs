using Ninject;
using SinemaOtoSis.DAL.Entities;
using SinemaOtoSis.Repository.Repositories.Abstracts;
using SinemaOtoSis.UI.WinForms.DependencyResolver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtoSis.UI.WinForms
{
    public partial
        class frmKoltukSecimi : Form
    {
        private readonly IBiletSatisRepository _biletRepo;
        private readonly IGosterimRepository _gosterimrepo;
        private readonly IPersonelRepository _persnelRepo;
        private readonly ISeyirciRepository _seyirciRepo;
        public frmKoltukSecimi()
        {
            InitializeComponent();
        }
        List<string> koltuklar = new List<string>();
        List<string> secilikoltuklar = new List<string>();
        IQueryable<BiletSatis> Biletler;
        Gosterim secilengstrm = new Gosterim();


        public IGosterimRepository Gosterimrepo
        {
            get
            {
                return _gosterimrepo;
            }
        }
        int PrsnlId;
        public frmKoltukSecimi(Gosterim gstrm, int PersonelId)
        {
            var container = NinjectDependencyContainer.RegisterDependency(new StandardKernel());
            _biletRepo = container.Get<IBiletSatisRepository>();
            _gosterimrepo = container.Get<IGosterimRepository>();
            _persnelRepo = container.Get<IPersonelRepository>();
            _seyirciRepo = container.Get<ISeyirciRepository>();
            Biletler = _biletRepo.GetByFilter(x => x.GosterimID == gstrm.GosterimID);
            foreach (var item in Biletler)
            {
                if (item.Satıldı == true)
                {
                    koltuklar.Add(item.Koltuk.KoltukAD);
                }
            }
            secilengstrm = gstrm;
            PrsnlId = PersonelId;
            InitializeComponent();
        }
        public void KoltuklariBoya()
        {
            if (koltuklar.Count() != 0)
            {
                foreach (var item in koltuklar)
                {
                    Button btn = new Button();
                    btn = (Button)Controls[item];
                    btn.BackColor = Color.Red;

                }
            }
        }
        public void BosKoltukSayisi()
        {
            int Count = 0;
            foreach (Control c in this.Controls)
            {
                if (c.BackColor == Color.Gray)
                {
                    Count++;
                }
            }

            lblBosKoltuk.Text = Count.ToString();
        }

        private void frmKoltukSecimi_Load(object sender, EventArgs e)
        {
            txtGosterimBilgileri.Text = secilengstrm.Film.FilmAd + " / ";
            txtGosterimBilgileri.Text += "Salon: ";
            txtGosterimBilgileri.Text += secilengstrm.Salon.SalonAD + " / ";
            txtGosterimBilgileri.Text += "Seans: ";
            txtGosterimBilgileri.Text += secilengstrm.Seans.SeansAD + " / ";
            

            KoltuklariBoya();
            BosKoltukSayisi();
            Personel prs = _persnelRepo.GetFindById(PrsnlId);
            lblPersonelBilgisi.Text = prs.Ad + " " + prs.Soyad;
            dtpKayitTarih.Text = secilengstrm.GosterimTarih.ToShortDateString();

        }

        private void A3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.BackColor == Color.Gray)
            {
                btn.BackColor = Color.Green;
                secilikoltuklar.Add(btn.Name);
                
                
            }
            else if (btn.BackColor == Color.Green)
            {
                btn.BackColor = Color.Gray;
                secilikoltuklar.Remove(btn.Name);
            }
            lbKoltuklar.DataSource = koltuklar.ToList();
            
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBilet_Click(object sender, EventArgs e)
        {
            if (lbKoltuklar.Items.Count != 0)
            {
                if (string.IsNullOrEmpty(txtSeyirciAd.Text) && string.IsNullOrEmpty(txtSeyirciSoyad.Text) && string.IsNullOrEmpty(mtxtTelefon.Text))
                {
                    MessageBox.Show(" Gerekli alanları doldurmalısınız ! ");
                    txtSeyirciAd.Focus();
                }
                else
                {

                    BosKoltukSayisi();
                    Seyirci model = new Seyirci
                    {
                        SeyirciAd = txtSeyirciAd.Text,
                        SeyirciSoyad= txtSeyirciSoyad.Text,
                        SeyirciTelefon=mtxtTelefon.Text,
                        SeyirciAdres=txtAdres.Text

                    };
                    _seyirciRepo.Add(model);


                    
                    

                }
            }
        }
    }
}
