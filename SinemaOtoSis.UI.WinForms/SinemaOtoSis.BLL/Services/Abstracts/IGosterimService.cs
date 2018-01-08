using SinemaOtoSis.BLL.Dtos;
using SinemaOtoSis.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtoSis.BLL.Services.Abstracts
{
    public interface IGosterimService
    {
        ResultModel<Gosterim> GosterimSave(Gosterim model);
        ResultModel<Gosterim> GosterimUpdate(Gosterim model);
        ResultModel<Gosterim> GosterimDelete(Gosterim model);

    }
}
