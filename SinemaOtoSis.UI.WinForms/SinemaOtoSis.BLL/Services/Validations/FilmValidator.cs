using FluentValidation;
using SinemaOtoSis.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtoSis.BLL.Services.Validations
{
    public class FilmValidator:AbstractValidator<Film>
    {
        public FilmValidator()
        {
            RuleFor(x => x.FilmAd).NotEmpty().WithMessage("Film adını girmek zorundasınız");
            RuleFor(x => x.FilmTurID).NotEmpty().WithMessage("Film türünü belirtmek zorundasınız");
            RuleFor(x => x.Yonetmen).NotEmpty().WithMessage("Yönetmen adını girmek zorundasınız");
            RuleFor(x => x.Oyuncular).NotEmpty().WithMessage("En az bir oyuncu adını girmek zorundasınız");
            RuleFor(x => x.VizyonCksTarih).NotEmpty().WithMessage("Vizyon çıkış tarihini belirtmek zorundasınız");
            RuleFor(x => x.VizyonGrsTarih).NotEmpty().WithMessage("Vizyon Giriş Tarihini belirtmek zorundasınız");
            
        }

        

    }
    
}
