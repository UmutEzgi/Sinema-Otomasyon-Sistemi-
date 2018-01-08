using Ninject;
using SinemaOtoSis.BLL.Services.Abstracts;
using SinemaOtoSis.DAL.Entities;
using SinemaOtoSis.Repository.Repositories.Abstracts;
using SinemaOtoSis.UI.WinForms.DependencyResolver;
using SinemaOtoSis.UI.WinForms.frmYonetici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtoSis.UI.WinForms
{
    public partial class frmFilmKayitİslemleri : Form
    {
        private readonly IFilmServices _filmservice;
        private readonly IFilmRepository _filmrepo;
        private readonly IFilmTuruRepository _filmturRepo;
       

        int SecilenFilmId;

        public frmFilmKayitİslemleri()
        {
            var container = NinjectDependencyContainer.RegisterDependency(new StandardKernel());
            _filmservice = container.Get<IFilmServices>();
            _filmrepo = container.Get<IFilmRepository>();
            _filmturRepo = container.Get<IFilmTuruRepository>();
            

            InitializeComponent();
        }

        public void FilmTurleriCombobox()
        {
            cbFilmTurleri.DataSource = _filmturRepo.GetList();
            cbFilmTurleri.ValueMember = "FilmTurId";
            cbFilmTurleri.DisplayMember = "FilmTurAd";
        }

        public void FilmleriGetir()
        {
            lvFilmler.Items.Clear();

            if (rdbtnVizyondakiler.Checked)
            {

                 
                var model1 = _filmrepo.GetByFilter(x => x.FilmAd.Contains(txtAdaGore.Text) && x.Yonetmen.Contains(txtYonetmenGore.Text) && x.Vizyonda == true);
                foreach (var item in model1)
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = item.FilmID.ToString();
                    li.SubItems.Add(item.FilmAd.ToString());
                    li.SubItems.Add(_filmturRepo.GetFindById((int)item.FilmTurID).FilmTurID.ToString());
                    li.SubItems.Add(_filmturRepo.GetFindById((int)item.FilmTurID).FilmTurAd);
                    li.SubItems.Add(item.Yonetmen.ToString());
                    li.SubItems.Add(item.Oyuncular.ToString());
                    li.SubItems.Add(item.VizyonGrsTarih.ToString());
                    li.SubItems.Add(item.VizyonCksTarih.ToString());
                    li.SubItems.Add(item.FilmSuresi_dk.ToString());
                    li.SubItems.Add(item.Vizyonda.ToString());
                    li.Tag = item;

                    lvFilmler.Items.Add(li);
                }
                //model1.ForEach(item =>
                //{
                //    ListViewItem li = new ListViewItem();
                //    li.Text = item.FilmID.ToString();
                //    li.SubItems.Add(item.FilmAd.ToString());
                //    li.SubItems.Add(_filmturRepo.GetFindById((int)item.FilmTurID).FilmTurID.ToString());
                //    li.SubItems.Add(_filmturRepo.GetFindById((int)item.FilmTurID).FilmTurAd);
                //    li.SubItems.Add(item.Yonetmen.ToString());
                //    li.SubItems.Add(item.Oyuncular.ToString());
                //    li.SubItems.Add(item.VizyonGrsTarih.ToString());
                //    li.SubItems.Add(item.VizyonCksTarih.ToString());
                //    li.SubItems.Add(item.FilmSuresi_dk.ToString());
                //    li.SubItems.Add(item.Vizyonda.ToString());
                //    li.Tag = item;

                //    lvFilmler.Items.Add(li);
                //});
            }

            else if (rdbtnVizyondakiler.Checked == false)
            {
                var model3 = _filmrepo.GetByFilter(x => x.FilmAd.Contains(txtAdaGore.Text) && x.Yonetmen.Contains(txtYonetmenGore.Text));
                foreach (var item in model3)
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = item.FilmID.ToString();
                    li.SubItems.Add(item.FilmAd.ToString());
                    li.SubItems.Add(_filmturRepo.GetFindById((int)item.FilmTurID).FilmTurID.ToString());
                    li.SubItems.Add(_filmturRepo.GetFindById((int)item.FilmTurID).FilmTurAd);
                    li.SubItems.Add(item.Yonetmen.ToString());
                    li.SubItems.Add(item.Oyuncular.ToString());
                    li.SubItems.Add(item.VizyonGrsTarih.ToString());
                    li.SubItems.Add(item.VizyonCksTarih.ToString());
                    li.SubItems.Add(item.FilmSuresi_dk.ToString());
                    li.SubItems.Add(item.Vizyonda.ToString());
                    li.Tag = item;

                    lvFilmler.Items.Add(li);
                }
                //model3.ForEach(item =>
                //{
                //    ListViewItem li = new ListViewItem();
                //    li.Text = item.FilmID.ToString();
                //    li.SubItems.Add(item.FilmAd.ToString());
                //    li.SubItems.Add(_filmturRepo.GetFindById((int)item.FilmTurID).FilmTurID.ToString());
                //    li.SubItems.Add(_filmturRepo.GetFindById((int)item.FilmTurID).FilmTurAd);
                //    li.SubItems.Add(item.Yonetmen.ToString());
                //    li.SubItems.Add(item.Oyuncular.ToString());
                //    li.SubItems.Add(item.VizyonGrsTarih.ToString());
                //    li.SubItems.Add(item.VizyonCksTarih.ToString());
                //    li.SubItems.Add(item.FilmSuresi_dk.ToString());
                //    li.SubItems.Add(item.Vizyonda.ToString());
                //    li.Tag = item;

                //    lvFilmler.Items.Add(li);
                //});
            }


        }
        
        private void frmFilmKayitİslemleri_Load(object sender, EventArgs e)
        {
            #region ListView
            FilmleriGetir();
            #endregion
            #region FilmTurleriCombobox
            FilmTurleriCombobox();

            #endregion
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            #region ModelOlustur
            Film model = new Film
            {
                FilmAd = txtFilmAdi.Text,
                Yonetmen = txtYonetmen.Text,
                Oyuncular = txtOyuncular.Text,
                VizyonGrsTarih = dtpVizyonGiris.Value.Date,
                VizyonCksTarih = dtpVizyonCikis.Value.Date,
                FilmSuresi_dk = Convert.ToInt32(txtFlmSure.Text),
                Vizyonda = (dtpVizyonGiris.Value.Date <= DateTime.Now && dtpVizyonCikis.Value.Date >= DateTime.Now) ? true : false,
                //Sonradan düzenlenmesi gereken bir şey..... Default olarak false, tarih koşullarına göre true false 
                FilmTurID = (cbFilmTurleri.SelectedItem as FilmTuru).FilmTurID,


            };

            var result = _filmservice.FilmSave(model);
            lblResult.Text = result.IsValid ? result.Message : string.Join("\n", result.Errors);

            #endregion

            #region FilmleriYukle
            lvFilmler.Items.Clear();
            FilmleriGetir();
            #endregion
        }
        private void grpbxYeniKayit_Enter(object sender, EventArgs e)
        {
            #region ButonKontrolleri
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = true;
            btnSil.Enabled = false;
            #endregion
        }

        private void rdbtnVizyondakiler_CheckedChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
        }

        private void lvFilmler_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region TextBoxlariDoldur
            if (lvFilmler.SelectedItems.Count > 0)
            {

                SecilenFilmId = Convert.ToInt32(lvFilmler.SelectedItems[0].SubItems[0].Text);
                txtFilmAdi.Text = lvFilmler.SelectedItems[0].SubItems[1].Text;
                cbFilmTurleri.Text = lvFilmler.SelectedItems[0].SubItems[3].Text;
                txtYonetmen.Text = lvFilmler.SelectedItems[0].SubItems[4].Text;
                txtOyuncular.Text = lvFilmler.SelectedItems[0].SubItems[5].Text;
                dtpVizyonGiris.Text = lvFilmler.SelectedItems[0].SubItems[6].Text;
                dtpVizyonCikis.Text = lvFilmler.SelectedItems[0].SubItems[7].Text;
                txtFlmSure.Text = lvFilmler.SelectedItems[0].SubItems[8].Text;
            }
            #endregion
            #region ButonKontrolleri
            btnDegistir.Enabled = false;
            btnKaydet.Enabled = false;
            btnSil.Enabled = true;
            #endregion

        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            #region ModelOlustur
            Film model = new Film
            {
                FilmAd = txtFilmAdi.Text,
                Yonetmen = txtYonetmen.Text,
                Oyuncular = txtOyuncular.Text,
                FilmSuresi_dk = Convert.ToInt32(txtFlmSure.Text),
                VizyonGrsTarih = dtpVizyonGiris.Value.Date,
                VizyonCksTarih = dtpVizyonCikis.Value.Date,
                Vizyonda = (dtpVizyonGiris.Value.Date <= DateTime.Now && dtpVizyonCikis.Value.Date >= DateTime.Now) ? true : false,
                FilmTurID = (cbFilmTurleri.SelectedItem as FilmTuru).FilmTurID,
                FilmID = SecilenFilmId,
            };
            var result = _filmservice.FilmUpdate(model);
            lblResult.Text = result.IsValid ? result.Message : string.Join("\n", result.Errors);
            #endregion

            #region FilmleriYukle
            lvFilmler.Items.Clear();
            FilmleriGetir();
            #endregion
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            #region FilmIdGonder
            Film model = new Film
            {
                FilmID = SecilenFilmId,
            };
            var result = _filmservice.FilmDelete(model);
            lblResult.Text = result.IsValid ? result.Message : string.Join("\n", result.Errors);

            lvFilmler.Items.Clear();
            #endregion

            #region FilmleriYukle
            FilmleriGetir();
            #endregion
        }

        private void rdbtnTumFilmler_CheckedChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
        }

        private void txtYonetmenGore_TextChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
        }

        private void btnYeniFilmTuru_Click(object sender, EventArgs e)
        {
            frmFilmTuru frm = new frmFilmTuru();
            frm.ShowDialog();
        }
    }
}
