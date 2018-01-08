using FluentValidation;
using SinemaOtoSis.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtoSis.BLL.Services.Validations
{
    class FilmKayitValidator: FilmValidator
    {
        public FilmKayitValidator()
        {
            RuleFor(x => x.FilmAd).Must(FilmVarmi).WithMessage("Bu Film Zaten Kayıtlı!");
            
        }
        private bool FilmVarmi(string FilmAD)
        {
            using (SinemaEntities1 context = new SinemaEntities1())
            {
                return !context.Film.Any(x => x.FilmAd == FilmAD);
            }
        }
        

    }
}
