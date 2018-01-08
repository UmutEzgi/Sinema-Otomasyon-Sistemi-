
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
    public class SeansRepository : RepositoryBase<Seans, SinemaEntities1>, ISeansRepository
    {
        public SeansRepository(DbContext context) : base(context)
        {
        }
    }
}
