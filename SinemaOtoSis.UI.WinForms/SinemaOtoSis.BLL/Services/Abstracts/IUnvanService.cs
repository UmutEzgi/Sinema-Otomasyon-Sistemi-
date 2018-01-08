using SinemaOtoSis.BLL.Dtos;
using SinemaOtoSis.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtoSis.BLL.Services.Abstracts
{
    public interface IUnvanService
    {
        ResultModel<Unvan> UnvanSave(Unvan model);
        ResultModel<Unvan> UnvanUpdate(Unvan model);
        ResultModel<Unvan> UnvanDelete(Unvan model);
    }
}
