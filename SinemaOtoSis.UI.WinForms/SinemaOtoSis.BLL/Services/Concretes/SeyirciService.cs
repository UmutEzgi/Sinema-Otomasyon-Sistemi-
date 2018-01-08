using SinemaOtoSis.BLL.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinemaOtoSis.BLL.Dtos;
using SinemaOtoSis.DAL.Entities;
using SinemaOtoSis.BLL.Services.Validations;
using FluentValidation.Results;
using SinemaOtoSis.Repository.Repositories.Abstracts;

namespace SinemaOtoSis.BLL.Services.Concretes
{
    public class SeyirciService : ISeyirciService
    {
        private readonly ISeyirciRepository _seyirciRepository;
        public SeyirciService(ISeyirciRepository seyirciRepository)
        {
            _seyirciRepository = seyirciRepository;
        }
        public ResultModel<Seyirci> SeyirciSave(Seyirci model)
        {
            SeyirciValidator validator = new SeyirciValidator();
            ValidationResult result = validator.Validate(model);
            if (result.IsValid)
            {
                _seyirciRepository.Add(model);
                return new ResultModel<Seyirci>
                {
                    Errors = null,
                    IsValid = true,
                    Message = "Kayıt Başarılı"

                };
            }
            return new ResultModel<Seyirci>
            {
                Errors = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsValid = false,
                Message = "Kayıt Başarısız"
            };
        }
    }
}
