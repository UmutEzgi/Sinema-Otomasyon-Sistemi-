using FluentValidation;
using SinemaOtoSis.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtoSis.BLL.Services.Validations
{
    public class KoltukValidator: AbstractValidator<Koltuk>
    {
        public KoltukValidator()
        {
            RuleFor(x => x.KoltukAD).NotEmpty().WithMessage("Koltuk adi boş geçilemez");
            //devam...
        }
    }
}
