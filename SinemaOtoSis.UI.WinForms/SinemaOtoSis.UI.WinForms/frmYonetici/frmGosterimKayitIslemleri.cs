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
    public partial class frmGosterimKayitIslemleri : Form
    {

        private readonly IGosterimService _gosterimservice;
        private readonly IGosterimRepository _gosterimrepo;
        private readonly ISeansRepository _seansRepo;
        private readonly ISalonRepository _salonRepo;
        private readonly IFilmRepository _filmRepo;
        private readonly IBiletSatisRepository _biletRepo;
        private readonly IKoltukRepository _koltukRepo;
        //BiletSatisSErvisi
        //private readonly IPersonelRepository _persoRepo;
        //private readonly IOdemeSekliRepository _odemeskliRepo;
        //private readonly ISeyirciRepository _seyirciRepo;
        //private readonly IKoltukRepository _koltukRepo;

        int SecilenGosterimId;
        int SclnGstrimFilmId;
        int SclnGstrimSalonId;
        int SclnGstrimSeansId;
        public frmGosterimKayitIslemleri()
        {
            var container = NinjectDependencyContainer.RegisterDependency(new StandardKernel());
            _gosterimservice = container.Get<IGosterimService>();
            _gosterimrepo = container.Get<IGosterimRepository>();
            _seansRepo = container.Get<ISeansRepository>();
            _salonRepo = container.Get<ISalonRepository>();
            _filmRepo = container.Get<IFilmRepository>();
            _biletRepo = container.Get<IBiletSatisRepository>();
            _koltukRepo = container.Get<IKoltukRepository>();
            //_persoRepo = container.Get<IPersonelRepository>();
            //_seyirciRepo = container.Get<ISeyirciRepository>();
            //_odemeskliRepo = container.Get<IOdemeSekliRepository>();
            InitializeComponent();
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            #region ModelOlustur
            Gosterim model = new Gosterim
            {

                GosterimTarih = dtpGosterimTarih.Value.Date,
                FilmID = (cbVizyonFimler.SelectedItem as Film).FilmID,
                SalonID = (cbSalonlar.SelectedItem as Salon).SalonID,
                SeansID = (cbSeanslar.SelectedItem as Seans).SeansID,
       
            };

            var result = _gosterimservice.GosterimSave(model);
            lblResult.Text = result.IsValid ? result.Message : string.Join("\n", result.Errors);

            IEnumerable<Koltuk> koltuklist = _koltukRepo.GetList();
            foreach (var item in koltuklist)
            {
               
                BiletSatis bilet = new BiletSatis
                {
                    BiletTurID = 1,
                    GosterimID = model.GosterimID,
                    PersonelID = 1,
                    SeyirciID = 1,
                    OdemeSekliID = 1,
                    BiletFiyat = 20,
                    Satıldı = false,
                    KoltukID = item.KoltukID,
                };
                 _biletRepo.Add(bilet);
            
            }

            
            
            
            #endregion

            #region PersonelleriYukle
            lvGosterimler.Items.Clear();
            GosterimleriYukle();
            #endregion
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {

            #region ModelOlustur
            Gosterim model = new Gosterim
            {

                GosterimTarih = dtpGosterimTarih.Value.Date,
                FilmID = (cbVizyonFimler.SelectedItem as Film).FilmID,
                SalonID = (cbSalonlar.SelectedItem as Salon).SalonID,
                SeansID = (cbSeanslar.SelectedItem as Seans).SeansID,
                GosterimID = SecilenGosterimId,

            };

            var result = _gosterimservice.GosterimUpdate(model);
            lblResult.Text = result.IsValid ? result.Message : string.Join("\n", result.Errors);

            #endregion

            #region PersonelleriYukle
            lvGosterimler.Items.Clear();
            GosterimleriYukle();
            #endregion
            //Burada özellikle önemli olan bir tane bile koltuk satılmış olan gösterimi değiştirmeye
            //kalkan kullanıcıya uyarı vermek.
            //Validasyon tarafında irdelenecek
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            #region GosterimIdGonder
            Gosterim model = new Gosterim
            {
                GosterimID = SecilenGosterimId,
            };
            var result = _gosterimservice.GosterimDelete(model);
            lblResult.Text = result.IsValid ? result.Message : string.Join("\n", result.Errors);

            lvGosterimler.Items.Clear();
            #endregion

            #region PersonelleriYukle
            GosterimleriYukle();
            #endregion

            //Burada özellikle önemli olan bir tane bile koltuk satılmış olan gösterimi silmeye
            //kalkan kullanıcıya uyarı vermek.
            //Validasyon tarafında irdelenecek.
        }



        private void grpbxYeniKayit_Enter(object sender, EventArgs e)
        {
            btnGosterimGuncelle.Enabled = true;
            btnGosterimKaydet.Enabled = true;
            btnGosterimSil.Enabled = false;
        }



        private void txtSalonaGore_TextChanged(object sender, EventArgs e)
        {
            GosterimleriYukle();
        }

        private void frmGosterimKayıtİslemleri_Load(object sender, EventArgs e)
        {
            SalonlariDoldur();
            SeanslariDoldur();
            FilmleriDoldur();
            GosterimleriYukle();
        }

        private void GosterimleriYukle()
        {
            if (rdbtnAktifGosterimler.Checked)
            {

                var model = _gosterimrepo.GetByFilter(x => x.Film.FilmAd.Contains(txtFilmeGore.Text) && x.Salon.SalonAD.Contains(txtSalonaGore.Text) && x.Seans.SeansAD.Contains(txtSeansaGore.Text) && x.GosterimTarih >= DateTime.Now);
                lvGosterimler.Items.Clear();
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

                    lvGosterimler.Items.Add(li);
                }
            }
            else if (rdbtnTumGosterimler.Checked)
            {
                var model = _gosterimrepo.GetByFilter(x => x.Film.FilmAd.Contains(txtFilmeGore.Text) && x.Salon.SalonAD.Contains(txtSalonaGore.Text) && x.Seans.SeansAD.Contains(txtSeansaGore.Text));
                lvGosterimler.Items.Clear();
                foreach(var item in model)
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

                    lvGosterimler.Items.Add(li);
                }
            }
        }

        private void FilmleriDoldur()
        {
            cbVizyonFimler.DataSource = _filmRepo.GetList(x => x.Vizyonda == true);
            cbVizyonFimler.ValueMember = "FilmID";
            cbVizyonFimler.DisplayMember = "FilmAD";

        }

        private void SeanslariDoldur()
        {
            cbSeanslar.DataSource = _seansRepo.GetList();
            cbSeanslar.ValueMember = "SeansID";
            cbSeanslar.DisplayMember = "SeansAD";
        }

        private void SalonlariDoldur()
        {
            cbSalonlar.DataSource = _salonRepo.GetList();
            cbSalonlar.ValueMember = "SalonID";
            cbSalonlar.DisplayMember = "SalonAd";
        }

        private void txtFilmeGore_TextChanged(object sender, EventArgs e)
        {
            GosterimleriYukle();
        }

        private void txtSeansaGore_TextChanged(object sender, EventArgs e)
        {
            GosterimleriYukle();
        }

        private void rdbtnAktifGosterimler_CheckedChanged(object sender, EventArgs e)
        {
            GosterimleriYukle();
        }

        private void rdbtnTumGosterimler_CheckedChanged(object sender, EventArgs e)
        {
            GosterimleriYukle();
        }

        private void lvGosterimler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGosterimler.SelectedItems.Count > 0)
            {
                SecilenGosterimId = Convert.ToInt32(lvGosterimler.SelectedItems[0].SubItems[0].Text);
                dtpGosterimTarih.Text = lvGosterimler.SelectedItems[0].SubItems[1].Text;
                SclnGstrimFilmId = Convert.ToInt32(lvGosterimler.SelectedItems[0].SubItems[2].Text);
                cbVizyonFimler.Text = lvGosterimler.SelectedItems[0].SubItems[3].Text.ToString();
                SclnGstrimSalonId = Convert.ToInt32(lvGosterimler.SelectedItems[0].SubItems[4].Text);
                cbSalonlar.Text = lvGosterimler.SelectedItems[0].SubItems[5].Text.ToString();
                SclnGstrimSeansId = Convert.ToInt32(lvGosterimler.SelectedItems[0].SubItems[6].Text);
                cbSeanslar.Text = lvGosterimler.SelectedItems[0].SubItems[7].Text.ToString();


            }
            btnGosterimGuncelle.Enabled = false;
            btnGosterimKaydet.Enabled = false;
            btnGosterimSil.Enabled = true;

        }

        private void btnYeniFilmEkle_Click(object sender, EventArgs e)
        {
            frmFilmKayitİslemleri frm = new frmFilmKayitİslemleri();
            frm.ShowDialog();
        }
    }
}
