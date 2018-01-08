using Ninject;
using SinemaOtoSis.DAL.Entities;
using SinemaOtoSis.Repository.Repositories.Abstracts;
using SinemaOtoSis.UI.WinForms.DependencyResolver;
using SinemaOtoSis.UI.WinForms.frmYonetici;
using System;
using System.Collections;
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
    public partial class frmLogin : Form
    {
        private readonly IPersonelRepository _personelRepo;

        Dictionary<string, int> login = new Dictionary<string, int>();
        public frmLogin()
        {
            var container = NinjectDependencyContainer.RegisterDependency(new StandardKernel());
            _personelRepo = container.Get<IPersonelRepository>();
            InitializeComponent();
        }
        public IPersonelRepository Gosterimrepo
        {
            get
            {
                return _personelRepo;
            }
        }
        public bool EpostaVarmi(string yazilandeger)
        {
            foreach (var item in login)
            {
                if (yazilandeger == item.Key)
                    return true;
            }
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if((txtEposta.text == "" && txtSifre.text== "") || txtSifre.text =="" || txtEposta.text =="")
            {
                MessageBox.Show("Lüften boş alan bırakmayınız");
            }
            else if(EpostaVarmi(txtEposta.text))
            {
                foreach (var item in login)
                {
                    if (txtEposta.text == item.Key)
                    {
                        if (txtSifre.text == login[txtEposta.text].ToString())
                        {
                            personeller.ForEach(p =>
                            {
                                if (p.Sifre == login[txtEposta.text].ToString())
                                {
                                    if (p.UnvanID == 2)
                                    {
                                        //this.Hide();
                                        frmYoneticiPaneli frm = new frmYoneticiPaneli(p.PersonelID);
                                        frm.ShowDialog();
                                        
                                        
                                        //Yöneticipaneli
                                    }
                                    else 
                                    {
                                        //this.Hide();
                                        frmBiletSatisIslemleri frm = new frmBiletSatisIslemleri(p.PersonelID);
                                        frm.ShowDialog();
                                        //Gişe İşlemleri paneli
                                    }
                                    
                                }

                            });
                        }
                        else
                        {
                            MessageBox.Show("Girdiğiniz parola yanlış!");
                        }

                    }

                }
            }
            else if(EpostaVarmi(txtEposta.text)==false)
            {
                MessageBox.Show("Girdiğiniz E-posta yanlış!");
            }
            
            
        }

        List<Personel> personeller = new List<Personel>();
        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            IEnumerable<Personel> personeller = 
                _personelRepo.GetList();
            foreach (var item in personeller)
            {
                login.Add(item.Email, Convert.ToInt32(item.Sifre));
            }
            
        }


        private void txtEposta_Enter(object sender, EventArgs e)
        {
            txtEposta.text = "";
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            txtSifre.text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
