using SinemaOtoSis.BLL.Dtos;
using SinemaOtoSis.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtoSis.BLL.Services.Abstracts
{
    public interface ISalonService
    {
        ResultModel<Salon> SalonSave(Salon model);
        ResultModel<Salon> SalonUpdate(Salon model);
        ResultModel<Salon> SalonDelete(Salon model);
    }
}
