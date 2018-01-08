using FluentValidation;
using SinemaOtoSis.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtoSis.BLL.Services.Validations
{
    public class SalonValidator: AbstractValidator<Salon>
    {
        public SalonValidator()
        {
            RuleFor(x => x.SalonAD).NotEmpty().WithMessage("Salon adını girmek zorundasınız");
        }
    }
}
