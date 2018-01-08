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
    public partial class frmUnvanEkle : Form
    {
        private readonly IUnvanRepository _unvanRepo;
        private readonly IUnvanService _unvanService;
        public frmUnvanEkle()
        {
            var container = NinjectDependencyContainer.RegisterDependency(new StandardKernel());
            _unvanService = container.Get<IUnvanService>();
            _unvanRepo = container.Get<IUnvanRepository>();
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Unvan model = new Unvan
            {
                UnvanAD = txtUnvan.Text,
            };
            var result = _unvanService.UnvanSave(model);
            lblResult.Text = result.IsValid ? result.Message : string.Join("\n", result.Errors);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
