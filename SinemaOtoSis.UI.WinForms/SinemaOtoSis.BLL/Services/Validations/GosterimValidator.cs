using FluentValidation;
using SinemaOtoSis.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtoSis.BLL.Services.Validations
{
    public class GosterimValidator: AbstractValidator<Gosterim>
    {
        public GosterimValidator()
        {
            RuleFor(x => x.GosterimTarih).NotEmpty().WithMessage("Gösterim Tarihini Belirtmelisiniz.");
            RuleFor(x => x.SalonID).NotEmpty().WithMessage("Lütfen Gösterimin Yapılacağı Salonu Seçiniz.");
            RuleFor(x => x.SeansID).NotEmpty().WithMessage("Lütfen Gösterimin Yapılacağı Seansı Seçiniz.");
            RuleFor(x => x.FilmID).NotEmpty().WithMessage("Lütfen Gösterimi Yapılacak Filmi Belirtiniz.");
            RuleFor(x => x).Must(GosterimVarmi).WithMessage("Gosterim Zaten Mevcut!!");
        }
        public bool GosterimVarmi(Gosterim model)
        {
            using (SinemaEntities1 context = new SinemaEntities1())
            {

                return (!context.Gosterim.Any(x => x.FilmID == model.FilmID && x.SalonID == model.SalonID && x.SeansID == model.SeansID && x.GosterimTarih == model.GosterimTarih));

            }
        }
    }
}
