using FluentValidation;
using SinemaOtoSis.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtoSis.BLL.Services.Validations
{
    class PersonelKayitValidator: PersonelValidator
    {
        public PersonelKayitValidator()
        {
            RuleFor(x => x.SicilNo).Must(SicilNoKontrol).WithMessage("Başka Bir Sicil No giriniz! Zaten Mevcut");
            RuleFor(x => x.Email).Must(EmailKontrol).WithMessage("E postanızın doğruluğundan emin olunuz!");
            RuleFor(x => x.Telefon).Must(TelefonKontrol).WithMessage("Telefon zaten mevcut!");

        }

        private bool TelefonKontrol(string tel)
        {
            using (SinemaEntities1 context = new SinemaEntities1())
            {
                return !context.Personel.Any(x => x.Telefon == tel);
            }
        }

        private bool SicilNoKontrol(string sicilno)
        {
            using (SinemaEntities1 context = new SinemaEntities1())
            {
                return !context.Personel.Any(x => x.SicilNo == sicilno);
            }
        }
        private bool EmailKontrol(string email)
        {
            using (SinemaEntities1 context = new SinemaEntities1())
            {
                return !context.Personel.Any(x => x.Email == email);
            }
        }
    }
}
