using FluentValidation;
using SinemaOtoSis.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtoSis.BLL.Services.Validations
{
    class SeansValidator: AbstractValidator<Seans>
    {
        public SeansValidator()
        {
            RuleFor(x => x.SeansAD).NotEmpty().WithMessage("Seans adını girmek zorundasınız");
            // Daha kurallar eklenecek. Belli bir standart yakalanana kadar.
            //Ardından bütün ekleme silme işlemlerinde aynı standartlar kullanılcak.
            //Takviyeler gerektiğinde yapılacak.



        }
    }
}
