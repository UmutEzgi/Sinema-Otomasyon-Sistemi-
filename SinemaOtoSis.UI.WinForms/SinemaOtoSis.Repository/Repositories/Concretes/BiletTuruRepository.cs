using SinemaOtoSis.Core.Databases.RepositoryBase.Concrete;
using SinemaOtoSis.DAL.Entities;
using SinemaOtoSis.Repository.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SinemaOtoSis.Repository.Repositories.Concretes
{
    public class BiletTuruRepository : RepositoryBase<BiletTuru, SinemaEntities1>, IBiletTuruRepository
    {
        public BiletTuruRepository(DbContext context) : base(context)
        {
        }
    }
}
