using FluentValidation;
using SinemaOtoSis.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtoSis.BLL.Services.Validations
{
    public class BiletSatisValidator: AbstractValidator<BiletSatis>
    {
        public BiletSatisValidator()
        {
            RuleFor(x => x.GosterimID).NotEmpty().WithMessage("Gosterimi belirtilmeyen biletsatış oluşturulamaz.");
            //devam.....
        }

        public static implicit operator BiletSatisValidator(GosterimValidator v)
        {
            throw new NotImplementedException();
        }
    }
}
