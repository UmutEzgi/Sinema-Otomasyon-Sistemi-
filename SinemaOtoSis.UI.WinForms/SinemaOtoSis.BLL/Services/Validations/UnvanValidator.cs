using FluentValidation;
using SinemaOtoSis.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtoSis.BLL.Services.Validations
{
    public class UnvanValidator: AbstractValidator<Unvan>
    {
        public UnvanValidator()
        {
            RuleFor(x => x.UnvanAD).NotEmpty().WithMessage("Unvan Adı boş geçilemez");

        }
    }
}
