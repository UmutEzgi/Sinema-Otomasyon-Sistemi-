using Ninject;
using SinemaOtoSis.BLL.Services.Abstracts;
using SinemaOtoSis.DAL.Entities;
using SinemaOtoSis.Repository.Repositories.Abstracts;
using SinemaOtoSis.UI.WinForms.DependencyResolver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtoSis.UI.WinForms
{
    public partial class frmBiletSatisIslemleri : Form
    {
        private readonly IGosterimService _gosterimservice;
        private readonly IGosterimRepository _gosterimrepo;
        private readonly ISeansRepository _seansRepo;
        private readonly ISalonRepository _salonRepo;
        private readonly IFilmRepository _filmRepo;
        private readonly IBiletSatisRepository _biletRepo;
        private readonly IKoltukRepository _koltukRepo;
        
        public frmBiletSatisIslemleri()
        {
            InitializeComponent();
        }
        int PrsnlId;

        public frmBiletSatisIslemleri(int PersonelId)
        {
            var container = NinjectDependencyContainer.RegisterDependency(new StandardKernel());
            _gosterimservice = container.Get<IGosterimService>();
            _gosterimrepo = container.Get<IGosterimRepository>();
            _seansRepo = container.Get<ISeansRepository>();
            _salonRepo = container.Get<ISalonRepository>();
            _filmRepo = container.Get<IFilmRepository>();
            _biletRepo = container.Get<IBiletSatisRepository>();
            _koltukRepo = container.Get<IKoltukRepository>();
            PrsnlId = PersonelId;
            InitializeComponent();
        }



        int SecilenGosterimId;
        public void GosterimleriListeleKriterlereGore()
        {

            var model = _gosterimrepo.GetByFilter(x => x.Film.FilmAd.Contains(txtVizyonFilmler.Text) && x.Salon.SalonAD.Contains(txtSalonlar.Text) && x.Seans.SeansAD.Contains(txtSeanslar.Text) && x.GosterimTarih == dtpGosterimTarihi.Value.Date);
            lvAktifGosterimler.Items.Clear();
            foreach (var item in model)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.GosterimID.ToString();
                li.SubItems.Add(item.GosterimTarih.ToString());
                li.SubItems.Add(_filmRepo.GetFindById((int)item.FilmID).FilmID.ToString());
                li.SubItems.Add(_filmRepo.GetFindById((int)item.FilmID).FilmAd.ToString());
                li.SubItems.Add(_salonRepo.GetFindById((int)item.SalonID).SalonID.ToString());
                li.SubItems.Add(_salonRepo.GetFindById((int)item.SalonID).SalonAD.ToString());
                li.SubItems.Add(_seansRepo.GetFindById((int)item.SeansID).SeansID.ToString());
                li.SubItems.Add(_seansRepo.GetFindById((int)item.SeansID).SeansAD.ToString());


                li.Tag = item;

                lvAktifGosterimler.Items.Add(li);

            }
        }
        public void FilmleriDoldur()
        {
            var model = _gosterimrepo.GetByFilter(x=> x.GosterimTarih == dtpGosterimTarihi.Value.Date).Select(x => new 
            {
                Id = x.FilmID,
                Ad = x.Film.FilmAd
            }).ToList();
            List<VizyonFilm> cmbList = new List<VizyonFilm>();
            model.ForEach(item =>
            {

                if (cmbList.Where(x => x.AD == item.Ad).FirstOrDefault() == null)
                {
                    VizyonFilm f = new VizyonFilm();
                    f.AD = item.Ad;
                    f.ID = item.Id;
                    cmbList.Add(f);
                }
            });
            cbVizyondakiFimler.DataSource = cmbList;
            cbVizyondakiFimler.ValueMember = "ID";
            cbVizyondakiFimler.DisplayMember = "AD";
            
            



        }
        public void SalonlariDoldur()
        {
            var model = _gosterimrepo.GetByFilter(x => x.GosterimTarih == dtpGosterimTarihi.Value.Date && x.Film.FilmAd == txtVizyonFilmler.Text).Select(x => new
            {
                Id = x.SalonID,
                Ad = x.Salon.SalonAD
            }).ToList();
            List<AktifSalon> cmblist = new List<AktifSalon>();
            model.ForEach(item =>
            {
                if(cmblist.Where(x=> x.AD==item.Ad).FirstOrDefault()==null)
                {
                    AktifSalon s = new AktifSalon();
                    s.AD = item.Ad;
                    s.ID = item.Id;
                    cmblist.Add(s);
                }
                
                
                
            });
            cbSalonlari.DataSource = cmblist;
            cbSalonlari.ValueMember = "ID";
            cbSalonlari.DisplayMember = "AD";
        }
        public void SeanslariDoldur()
        {
            var model = _gosterimrepo.GetList(x => x.GosterimTarih == dtpGosterimTarihi.Value.Date && x.Film.FilmAd == txtVizyonFilmler.Text&& x.Salon.SalonAD==txtSalonlar.Text).Select(x => new
            {
                Id = x.SeansID,
                Ad = x.Seans.SeansAD
            }).ToList();
            List<AktifSeans> cmblist = new List<AktifSeans>();
            model.ForEach(item =>
            {
                if (cmblist.Where(x => x.AD == item.Ad).FirstOrDefault() == null)
                {
                    AktifSeans se = new AktifSeans();
                    se.AD = item.Ad;
                    se.ID = item.Id;
                    cmblist.Add(se);
                }



            });
            cbSeanslari.DataSource = cmblist;
            cbSeanslari.ValueMember = "ID";
            cbSeanslari.DisplayMember = "AD";
        }

        private void frmBiletSatisİslemleri_Load(object sender, EventArgs e)
        {
            
            GosterimleriListeleKriterlereGore();
            dtpGosterimTarihi.MinDate = DateTime.Now;
        }

        private void dtpGosterimTarihi_ValueChanged(object sender, EventArgs e)
        {

            txtGosterimTarihini.Text = string.Format("{0: dd/MM/yy}", dtpGosterimTarihi.Value.Date);
        }

        private void txtVizyonFilmler_TextChanged(object sender, EventArgs e)
        {

            SalonlariDoldur();
            txtSalonlar.Text = "";
            GosterimleriListeleKriterlereGore();
        }

        private void txtSalonlar_TextChanged(object sender, EventArgs e)
        {
            SeanslariDoldur();
            txtSeanslar.Text = "";
            GosterimleriListeleKriterlereGore();
        }

        private void txtSeanslar_TextChanged(object sender, EventArgs e)
        {
            
            GosterimleriListeleKriterlereGore();
        }

        private void cbVizyondakiFimler_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVizyonFilmler.Text = (cbVizyondakiFimler.SelectedItem as VizyonFilm).AD;
        }

        private void cbSeanslari_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSeanslar.Text = (cbSeanslari.SelectedItem as AktifSeans).AD;
            
             
            
        }

        private void cbSalonlari_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSalonlar.Text = (cbSalonlari.SelectedItem as AktifSalon).AD;
        }

        private void txtGosterimTarihini_TextChanged(object sender, EventArgs e)
        {
            
            FilmleriDoldur();
            txtVizyonFilmler.Text = "";
            GosterimleriListeleKriterlereGore();
        }

        private void btnKoltuklaraGit_Click(object sender, EventArgs e)
        {
            Gosterim model = _gosterimrepo.GetFindById(SecilenGosterimId);
           
            frmKoltukSecimi frm = new frmKoltukSecimi(model, PrsnlId);

            frm.ShowDialog();
        }

        private void lvAktifGosterimler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvAktifGosterimler.SelectedItems.Count>0)
            {
                txtGosterimTarihini.Text = lvAktifGosterimler.Items[0].SubItems[1].Text;
                txtVizyonFilmler.Text = lvAktifGosterimler.Items[0].SubItems[3].Text;
                txtSalonlar.Text = lvAktifGosterimler.Items[0].SubItems[5].Text;
                txtSeanslar.Text = lvAktifGosterimler.Items[0].SubItems[7].Text;
                SecilenGosterimId = Convert.ToInt32(lvAktifGosterimler.Items[0].SubItems[0].Text);

                btnKoltuklaraGit.Enabled = true;

            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        
    }

    public class VizyonFilm
    {
        public int ID { get; set; }
        public string AD { get; set; }
    }

    public class AktifSalon
    {
        public int ID { get; set; }
        public string AD { get; set; }
    }
    public class AktifSeans
    {
        public int ID { get; set; }
        public string AD { get; set; }
    }

}
