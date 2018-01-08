using SinemaOtoSis.BLL.Services.Abstracts;
using SinemaOtoSis.Repository.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinemaOtoSis.BLL.Dtos;
using SinemaOtoSis.DAL.Entities;
using SinemaOtoSis.BLL.Services.Validations;
using FluentValidation.Results;

namespace SinemaOtoSis.BLL.Services.Concretes
{
    public class FilmServices: IFilmServices
    {
        private readonly IFilmRepository _filmRepository;

        public FilmServices(IFilmRepository filmRepository)
        {
            _filmRepository = filmRepository;
        }

        public ResultModel<Film> FilmDelete(Film model)
        {

            int id = model.FilmID;
            _filmRepository.Delete(id);
            return new ResultModel<Film>
            {
                Errors = null,
                IsValid = true,
                Message = "Silme Başarılı"
            };
            
        }

       

       

        public ResultModel<Film> FilmSave(Film model)
        {
            FilmKayitValidator validator = new FilmKayitValidator();
            ValidationResult result =validator.Validate(model);
            if (result.IsValid)
            {
                _filmRepository.Add(model);
                return new ResultModel<Film>
                {
                    Errors = null,
                    IsValid = true,
                    Message = "Kayıt Başarılı"

                };
            }
            return new ResultModel<Film>
            {
                Errors = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsValid = false,
                Message = "Kayıt Başarısız"
            };
        }

        public ResultModel<Film> FilmUpdate(Film model)
        {
            FilmValidator validator = new FilmValidator();
            ValidationResult result = validator.Validate(model);
            if (result.IsValid)
            {
                _filmRepository.Update(model, model.FilmID);
                return new ResultModel<Film>
                {
                    Errors = null,
                    IsValid = true,
                    Message = "Update Başarılı"

                };
            }
            return new ResultModel<Film>
            {
                Errors = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsValid = false,
                Message = "Update Başarısız"
            };
        }
       
    }
}
