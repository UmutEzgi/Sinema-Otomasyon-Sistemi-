using FluentValidation;
using SinemaOtoSis.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtoSis.BLL.Services.Validations
{
    class PersonelValidator: AbstractValidator<Personel>
    {
        public PersonelValidator()
        {
            RuleFor(x => x.Ad).NotEmpty().WithMessage("Personel Adı Boş Geçilemez");
            RuleFor(x => x.Soyad).NotEmpty().WithMessage("Personel Soyadı Boş Geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
            RuleFor(x => x.CinsiyetID).NotEmpty().WithMessage("Cinsiyetini Seçiniz!");
            RuleFor(x => x.Adres).NotEmpty().WithMessage("Adres Bilgisini Giriniz");
            RuleFor(x => x.Telefon).NotEmpty().WithMessage("Telefon Bilgisi olmadan kayıt alınamaz");
            RuleFor(x => x.UnvanID).NotEmpty().WithMessage("Personele ait Unvanı belirleyiniz");

        }
    }
}
