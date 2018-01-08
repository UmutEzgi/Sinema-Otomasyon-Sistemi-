
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
    public class SeyirciRepository : RepositoryBase<Seyirci, SinemaEntities1>, ISeyirciRepository
    {
        public SeyirciRepository(DbContext context) : base(context)
        {
        }
    }
}
