using SinemaOtoSis.BLL.Dtos;
using SinemaOtoSis.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtoSis.BLL.Services.Abstracts
{
    public interface IKoltukService
    {
        ResultModel<Koltuk> KoltukDelete(Koltuk model);

        ResultModel<Koltuk> KoltukUpdate(Koltuk model);
        ResultModel<Koltuk> KoltukSave(Koltuk model);
    }
}
