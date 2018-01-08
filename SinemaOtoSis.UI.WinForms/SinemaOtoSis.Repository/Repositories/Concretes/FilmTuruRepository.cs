using SinemaOtoSis.Core.Databases.RepositoryBase.Concrete;
using SinemaOtoSis.DAL.Entities;
using SinemaOtoSis.Repository.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtoSis.Repository.Repositories.Concretes
{
    public class FilmTuruRepository: RepositoryBase<FilmTuru, SinemaEntities1>, IFilmTuruRepository
    {
        public FilmTuruRepository(DbContext context) : base(context)
        {

        }
    }
}
