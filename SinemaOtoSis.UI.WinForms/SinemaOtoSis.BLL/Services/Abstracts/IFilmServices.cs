using SinemaOtoSis.BLL.Dtos;
using SinemaOtoSis.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtoSis.BLL.Services.Abstracts
{
    public interface IFilmServices
    {
        ResultModel<Film> FilmSave(Film model);
        ResultModel<Film> FilmUpdate(Film model);
        ResultModel<Film> FilmDelete(Film model);
    }
}
