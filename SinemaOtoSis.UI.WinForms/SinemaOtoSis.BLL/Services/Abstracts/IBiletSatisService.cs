using SinemaOtoSis.BLL.Dtos;
using SinemaOtoSis.DAL.Entities;
using SinemaOtoSis.Repository.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtoSis.BLL.Services.Abstracts
{
    public interface IBiletSatisService
    {
        
        ResultModel<BiletSatis> BiletSatisSave(BiletSatis model);
        ResultModel<BiletSatis> BiletSatisUpdate(BiletSatis model);
        ResultModel<BiletSatis> BiletSatisDelete(BiletSatis model);
    }
}
