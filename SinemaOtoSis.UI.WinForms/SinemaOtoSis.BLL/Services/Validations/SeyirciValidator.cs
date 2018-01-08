using FluentValidation;
using SinemaOtoSis.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtoSis.BLL.Services.Validations
{
    public class SeyirciValidator: AbstractValidator<Seyirci>
    {
        public SeyirciValidator()
        {
            RuleFor(x => x.SeyirciAd).NotEmpty().WithMessage("Seyirci Adı Boş geçilemez");
            RuleFor(x => x.SeyirciSoyad).NotEmpty().WithMessage("Seyirci Soyadı boş geçilemez");
            RuleFor(x => x.SeyirciTelefon).NotEmpty().WithMessage("Seyirci Soyadı boş geçilemez");
            RuleFor(x => x.SeyirciTelefon).Must(SeyirciVarmi).WithMessage("Seyirci Zaten Mevcut");

            

        }
        private bool SeyirciVarmi(string Tel)
        {
            using (SinemaEntities1 context = new SinemaEntities1())
            {

                return (!context.Seyirci.Any(x => x.SeyirciTelefon == Tel));

            }
        }

    }

}
