using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using System.Data.Entity;
using SinemaOtoSis.DAL.Entities;
using SinemaOtoSis.BLL.Services.Abstracts;
using SinemaOtoSis.BLL.Services.Concretes;
using SinemaOtoSis.Repository.Repositories.Abstracts;
using SinemaOtoSis.Repository.Repositories.Concretes;

namespace SinemaOtoSis.UI.WinForms.DependencyResolver
{
    public static class NinjectDependencyContainer
    {
        public static IKernel RegisterDependency(IKernel kernel)
        {
            kernel.Bind<DbContext>().To<SinemaEntities1>();
            kernel.Bind<IFilmRepository>().To<FilmRepository>();
            kernel.Bind<IFilmServices>().To<FilmServices>();
            kernel.Bind<IFilmTuruRepository>().To<FilmTuruRepository>();
            kernel.Bind<IFilmTuruService>().To<FilmTuruService>();
            kernel.Bind<IPersonelRepository>().To<PersonelRepository>();
            kernel.Bind<IPersonelService>().To<PersonelService>();
            kernel.Bind<IUnvanRepository>().To<UnvanRepository>();
            kernel.Bind<IUnvanService>().To<UnvanService>();
            kernel.Bind<ICinsiyetRepository>().To<CinsiyetRepository>();
            kernel.Bind<IGosterimRepository>().To<GosterimRepository>();
            kernel.Bind<IGosterimService>().To<GosterimService>();
            kernel.Bind<ISalonRepository>().To<SalonRepository>();
            kernel.Bind<ISalonService>().To<SalonService>();
            kernel.Bind<ISeansRepository>().To<SeansRepository>();
            kernel.Bind<ISeansService>().To<SeansService>();
            kernel.Bind<IOdemeSekliRepository>().To<OdemeSekliRepository>();
            kernel.Bind<IKoltukRepository>().To<KoltukRepository>();
            kernel.Bind<IKoltukService>().To<KoltukService>();
            kernel.Bind<IBiletSatisRepository>().To<BiletSatisRepository>();
            kernel.Bind<IBiletSatisService>().To<BiletSatisService>();


            return kernel;
        }
    }
}
