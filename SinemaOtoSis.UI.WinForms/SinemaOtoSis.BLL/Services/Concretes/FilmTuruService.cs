using SinemaOtoSis.BLL.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinemaOtoSis.BLL.Dtos;
using SinemaOtoSis.DAL.Entities;
using SinemaOtoSis.Repository.Repositories.Abstracts;
using SinemaOtoSis.BLL.Services.Validations;

namespace SinemaOtoSis.BLL.Services.Concretes
{
    public class FilmTuruService : IFilmTuruService
    {
        private readonly IFilmTuruRepository _filmturRepo;

        public FilmTuruService(IFilmTuruRepository filmturRepo)
        {
            _filmturRepo = filmturRepo;
        }
        public ResultModel<FilmTuru> FilmTuruSave(FilmTuru model)
        {
            var validator = new FilmTuruValidator().Validate(model);

            if (validator.IsValid)
            {
                _filmturRepo.Add(model);

                return new ResultModel<FilmTuru>
                {
                    Errors = null,
                    IsValid = true,
                    Message = "Film Türü Eklendi."
                };
            }

            return new ResultModel<FilmTuru>
            {
                Errors = validator.Errors.Select(x => x.ErrorMessage).ToList(),
                IsValid = false,
                Message = "Kayıt Gerçekleşemedi!"
            };
        }
    }
}
