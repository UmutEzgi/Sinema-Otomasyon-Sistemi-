using SinemaOtoSis.BLL.Dtos;
using SinemaOtoSis.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtoSis.BLL.Services.Abstracts
{
    public interface ISeansService
    {
        ResultModel<Seans> SalonSave(Seans model);
        ResultModel<Seans> SalonUpdate(Seans model);
        ResultModel<Seans> SalonDelete(Seans model);
    }
}
