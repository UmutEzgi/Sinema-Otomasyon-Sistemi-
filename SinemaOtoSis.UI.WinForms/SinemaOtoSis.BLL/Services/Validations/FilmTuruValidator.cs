using FluentValidation;
using SinemaOtoSis.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtoSis.BLL.Services.Validations
{
    public class FilmTuruValidator: AbstractValidator<FilmTuru>
    {
        public FilmTuruValidator()
        {
            RuleFor(x=>x.FilmTurAd).NotEmpty().WithMessage("Film Türü adı Boş Geçilemez");
            RuleFor(x => x.FilmTurAd).Must(FilmTurVarmi).WithMessage("Bu film türü daha önce girildi");
        }

        private bool FilmTurVarmi(string FilmTuruAd)
        {
            using (SinemaEntities1 context = new SinemaEntities1())
            {
                return !context.FilmTuru.Any(x => x.FilmTurAd == FilmTuruAd);
            }
        }
    }
    
}

