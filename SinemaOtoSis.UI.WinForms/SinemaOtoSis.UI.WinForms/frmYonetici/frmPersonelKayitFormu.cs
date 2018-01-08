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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtoSis.UI.WinForms
{
    public partial class frmPersonelKayitFormu : Form
    {
        private readonly IPersonelService _personelservice;
        private readonly IPersonelRepository _personelrepo;
        private readonly IUnvanRepository _unvanRepo;
        private readonly ICinsiyetRepository _cinsiyetRepo;


        int SecilenPesonelId;
        public frmPersonelKayitFormu()
        {
            var container = NinjectDependencyContainer.RegisterDependency(new StandardKernel());
            _personelservice = container.Get<IPersonelService>();
            _personelrepo = container.Get<IPersonelRepository>();
            _unvanRepo = container.Get<IUnvanRepository>();
            _cinsiyetRepo = container.Get<ICinsiyetRepository>();
            InitializeComponent();
        }
        public void UnvanlariDoldur(ComboBox cbAdi)
        {
            cbAdi.DataSource = _unvanRepo.GetList();
            cbAdi.ValueMember = "UnvanID";
            cbAdi.DisplayMember = "UnvanAD";
        }
        //public void PersonelGetir()
        //{
        //    var model = _personelrepo.GetList();
        //    model.ForEach(item =>
        //    {
        //        ListViewItem li = new ListViewItem();
        //        li.Text = item.PersonelID.ToString();
        //        li.SubItems.Add(item.Ad.ToString());
        //        li.SubItems.Add(item.Soyad.ToString());
        //        li.SubItems.Add(item.SicilNo.ToString());
        //        li.SubItems.Add(item.Email.ToString());
        //        li.SubItems.Add(item.Sifre.ToString());
        //        li.SubItems.Add(item.Telefon.ToString());
        //        li.SubItems.Add(item.Adres.ToString());
        //        li.SubItems.Add(item.CalismaHali.ToString());
        //        li.SubItems.Add(_unvanRepo.GetFindById((int)item.UnvanID).UnvanID.ToString());
        //        li.SubItems.Add(_unvanRepo.GetFindById((int)item.UnvanID).UnvanAD.ToString());
        //        li.SubItems.Add(_cinsiyetRepo.GetFindById((int)item.CinsiyetID).CinsiyetID.ToString());
        //        li.SubItems.Add(_cinsiyetRepo.GetFindById((int)item.CinsiyetID).CinsiyetAD.ToString());
        //        li.Tag = item;

        //        lvPersoneller.Items.Add(li);
        //    });
        //}
        public void PersonelleriGetir()
        {

            string CinsiyeteGore = "";
            string UnvanaGore = "";
            if (rdbtnAktifCalisanlar.Checked)
            {
                bool CalisiyorMu = true;

                if (txtUnvanaGore.Text != "Seçiniz")
                {
                    UnvanaGore = txtUnvanaGore.Text;
                }
                if (txtCinsiyeteGore.Text != "Seçiniz")
                {
                    CinsiyeteGore = txtCinsiyeteGore.Text;
                }

                var model = _personelrepo.GetByFilter(x => x.Unvan.UnvanAD.Contains(UnvanaGore) && x.Ad.Contains(txtPersonelAdaGore.Text) && x.SicilNo.Contains(txtSicilNoyaGore.Text) && x.Cinsiyet.CinsiyetAD.Contains(CinsiyeteGore) && x.CalismaHali == CalisiyorMu);
                lvPersoneller.Items.Clear();
                foreach(var item in model)
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = item.PersonelID.ToString();
                    li.SubItems.Add(item.Ad.ToString());
                    li.SubItems.Add(item.Soyad.ToString());
                    li.SubItems.Add(item.SicilNo.ToString());
                    li.SubItems.Add(item.Email.ToString());
                    li.SubItems.Add(item.Sifre.ToString());
                    li.SubItems.Add(item.Telefon.ToString());
                    li.SubItems.Add(item.Adres.ToString());
                    li.SubItems.Add(item.CalismaHali.ToString());
                    li.SubItems.Add(_unvanRepo.GetFindById((int)item.UnvanID).UnvanID.ToString());
                    li.SubItems.Add(_unvanRepo.GetFindById((int)item.UnvanID).UnvanAD.ToString());
                    li.SubItems.Add(_cinsiyetRepo.GetFindById((int)item.CinsiyetID).CinsiyetID.ToString());
                    li.SubItems.Add(_cinsiyetRepo.GetFindById((int)item.CinsiyetID).CinsiyetAD.ToString());
                    li.Tag = item;

                    lvPersoneller.Items.Add(li);
                }
            }
            else if(rdbtnAktifCalisanlar.Checked==false)
            {
                if (txtUnvanaGore.Text != "Seçiniz")
                {
                    UnvanaGore = txtUnvanaGore.Text;
                }
                if (txtCinsiyeteGore.Text != "Seçiniz")
                {
                    CinsiyeteGore = txtCinsiyeteGore.Text;
                }

                var model1 = _personelrepo.GetByFilter(x => x.Unvan.UnvanAD.Contains(UnvanaGore) && x.Ad.Contains(txtPersonelAdaGore.Text) && x.SicilNo.Contains(txtSicilNoyaGore.Text) && x.Cinsiyet.CinsiyetAD.Contains(CinsiyeteGore));
                lvPersoneller.Items.Clear();
                foreach (var item in model1)
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = item.PersonelID.ToString();
                    li.SubItems.Add(item.Ad.ToString());
                    li.SubItems.Add(item.Soyad.ToString());
                    li.SubItems.Add(item.SicilNo.ToString());
                    li.SubItems.Add(item.Email.ToString());
                    li.SubItems.Add(item.Sifre.ToString());
                    li.SubItems.Add(item.Telefon.ToString());
                    li.SubItems.Add(item.Adres.ToString());
                    li.SubItems.Add(item.CalismaHali.ToString());
                    li.SubItems.Add(_unvanRepo.GetFindById((int)item.UnvanID).UnvanID.ToString());
                    li.SubItems.Add(_unvanRepo.GetFindById((int)item.UnvanID).UnvanAD.ToString());
                    li.SubItems.Add(_cinsiyetRepo.GetFindById((int)item.CinsiyetID).CinsiyetID.ToString());
                    li.SubItems.Add(_cinsiyetRepo.GetFindById((int)item.CinsiyetID).CinsiyetAD.ToString());
                    li.Tag = item;

                    lvPersoneller.Items.Add(li);
                }
            } 
                
            
        }
        public void CinsiyetleriDoldur(ComboBox cbAdi)
        {
            
            cbAdi.DataSource = _cinsiyetRepo.GetList();
            cbAdi.ValueMember = "CinsiyetID";
            cbAdi.DisplayMember = "CinsiyetAD";
        }

        private void frmPersonelKayitFormu_Load(object sender, EventArgs e)
        {
            PersonelleriGetir();
            UnvanlariDoldur(cbUnvan);
            UnvanlariDoldur(cbUnvanaGore);
            CinsiyetleriDoldur(cbCinsiyeteGore);
            CinsiyetleriDoldur(cbCinsiyet);

        }

        private void cbCinsiyeteGore_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCinsiyeteGore.Text = (cbCinsiyeteGore.SelectedItem as Cinsiyet).CinsiyetAD;
            PersonelleriGetir();
        }

        private void cbUnvanaGore_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUnvanaGore.Text = (cbUnvanaGore.SelectedItem as Unvan).UnvanAD;
            PersonelleriGetir();
        }

        private void txtPersonelAdaGore_TextChanged(object sender, EventArgs e)
        {
            PersonelleriGetir();
        }

        private void txtSicilNoyaGore_TextChanged(object sender, EventArgs e)
        {
            PersonelleriGetir();
        }

        private void rdbtnAktifCalisanlar_CheckedChanged(object sender, EventArgs e)
        {
            PersonelleriGetir();
        }

        private void rdbtnButunCalisanlar_CheckedChanged(object sender, EventArgs e)
        {
            PersonelleriGetir();
        }

        private void lvPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region TextBoxlariDoldur
            if (lvPersoneller.SelectedItems.Count > 0)
            {
                SecilenPesonelId = Convert.ToInt32(lvPersoneller.SelectedItems[0].SubItems[0].Text);
                txtAdi.Text = lvPersoneller.SelectedItems[0].SubItems[1].Text.ToString();
                txtSoyadi.Text = lvPersoneller.SelectedItems[0].SubItems[2].Text.ToString();
                txtSicilNo.Text = lvPersoneller.SelectedItems[0].SubItems[3].Text.ToString();
                txtMail.Text = lvPersoneller.SelectedItems[0].SubItems[4].Text.ToString();
                txtSifre.Text = lvPersoneller.SelectedItems[0].SubItems[5].Text.ToString();
                mtxtTelefon.Text = lvPersoneller.SelectedItems[0].SubItems[6].Text.ToString();
                txtAdres.Text = lvPersoneller.SelectedItems[0].SubItems[7].Text.ToString();
                cbUnvan.Text = lvPersoneller.SelectedItems[0].SubItems[10].Text.ToString();
                cbCinsiyet.Text = lvPersoneller.SelectedItems[0].SubItems[12].Text.ToString();
                bool CalismaHali = Convert.ToBoolean(lvPersoneller.SelectedItems[0].SubItems[8].Text);
               if(CalismaHali==true)
                {

                    rdbtnCalisiyor.Checked = true;
                    rdbtnCalismiyor.Checked = false;

                }
               else
                {

                    rdbtnCalisiyor.Checked = false;
                    rdbtnCalismiyor.Checked = true;
                }
                
            }
            #endregion

            #region ButonKontrolleri
            btnPersonelGuncelle.Enabled = false;
            btnPersonelKaydet.Enabled = false;
            btnPersonelSil.Enabled = true; 
            #endregion



        }

        private void grpbxYeniPersonelKayit_Enter(object sender, EventArgs e)
        {
            #region ButonKontrolleri
            btnPersonelSil.Enabled = false;
            btnPersonelGuncelle.Enabled = true;
            btnPersonelKaydet.Enabled = true; 
            #endregion

        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            #region PersonelIdGonder
            Personel model = new Personel
            {
                PersonelID = SecilenPesonelId,
            };
            var result = _personelservice.PersonelDelete(model);
            lblResult.Text = result.IsValid ? result.Message : string.Join("\n", result.Errors);

            lvPersoneller.Items.Clear();
            #endregion

            #region PersonelleriYukle
            PersonelleriGetir();
            #endregion
        }

        private void btnPersonelKaydet_Click(object sender, EventArgs e)
        {
            #region ModelOlustur
            Personel model = new Personel
            {

                Ad = txtAdi.Text,
                Soyad = txtSoyadi.Text,
                SicilNo = txtSicilNo.Text,
                Email = txtMail.Text,
                Sifre = txtSifre.Text,
                Telefon = mtxtTelefon.Text,
                Adres = txtAdres.Text,                 
                CalismaHali = rdbtnCalisiyor.Checked ? true : false,
                UnvanID = (cbUnvan.SelectedItem as Unvan).UnvanID,
                CinsiyetID=(cbCinsiyet.SelectedItem as Cinsiyet).CinsiyetID,

            };

            var result = _personelservice.PersonelSave(model);
            lblResult.Text = result.IsValid ? result.Message : string.Join("\n", result.Errors);

            #endregion

            #region PersonelleriYukle
            lvPersoneller.Items.Clear();
            PersonelleriGetir();
            #endregion
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            Personel model = new Personel
            {

                PersonelID = SecilenPesonelId,
                Ad = txtAdi.Text,
                Soyad = txtSoyadi.Text,
                SicilNo = txtSicilNo.Text,
                Email = txtMail.Text,
                Sifre = txtSifre.Text,
                Telefon = mtxtTelefon.Text,
                Adres = txtAdres.Text,
                CalismaHali = rdbtnCalisiyor.Checked ? true : false,
                UnvanID = (cbUnvan.SelectedItem as Unvan).UnvanID,
                CinsiyetID = (cbCinsiyet.SelectedItem as Cinsiyet).CinsiyetID,

            };

            var result = _personelservice.PersonelUpdate(model);
            lblResult.Text = result.IsValid ? result.Message : string.Join("\n", result.Errors);
            #region PersonelleriYukle
            lvPersoneller.Items.Clear();
            PersonelleriGetir();
            #endregion
        }

        private void btnYeniUnvanEkle_Click(object sender, EventArgs e)
        {
            frmUnvanEkle frm = new frmUnvanEkle();
            frm.ShowDialog();
        }
    }
}
