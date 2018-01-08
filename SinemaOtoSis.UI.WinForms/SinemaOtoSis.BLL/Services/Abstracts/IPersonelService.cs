using SinemaOtoSis.BLL.Dtos;
using SinemaOtoSis.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtoSis.BLL.Services.Abstracts
{
    public interface IPersonelService
    {
        ResultModel<Personel> PersonelUpdate(Personel model);
        ResultModel<Personel> PersonelSave(Personel model);
        ResultModel<Personel> PersonelDelete(Personel model);

        
    }
}
