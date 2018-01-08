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

namespace SinemaOtoSis.UI.WinForms.frmYonetici
{
    public partial class frmFilmTuru : Form
    {
        private readonly IFilmTuruService _filmturservice;
        private readonly IFilmTuruRepository _filmturrepo;
        public frmFilmTuru()
        {
            var container = NinjectDependencyContainer.RegisterDependency(new StandardKernel());
            _filmturservice = container.Get<IFilmTuruService>();
            _filmturrepo = container.Get<IFilmTuruRepository>();
            InitializeComponent();
        }

        private void frmFilmTuru_Load(object sender, EventArgs e)
        {
           
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            FilmTuru model = new FilmTuru
            {
                FilmTurAd = txtFilmTurAdi.Text,
            };
            var result = _filmturservice.FilmTuruSave(model);
            lblResult.Text = result.IsValid ? result.Message : string.Join("\n", result.Errors);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
