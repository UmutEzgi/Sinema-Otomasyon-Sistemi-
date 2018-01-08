using SinemaOtoSis.BLL.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinemaOtoSis.BLL.Dtos;
using SinemaOtoSis.DAL.Entities;
using SinemaOtoSis.Repository.Repositories.Abstracts;
using SinemaOtoSis.BLL.Services.Validations;
using FluentValidation.Results;

namespace SinemaOtoSis.BLL.Services.Concretes
{
    public class UnvanService : IUnvanService
    {
        private readonly IUnvanRepository _unvanRepository;

        public UnvanService(IUnvanRepository unvanRepository)
        {
            _unvanRepository = unvanRepository;
        }
        public ResultModel<Unvan> UnvanDelete(Unvan model)
        {
            int id = model.UnvanID;
            _unvanRepository.Delete(id);
            return new ResultModel<Unvan>
            {
                Errors = null,
                IsValid = true,
                Message = "Silme Başarılı"
            };
        }

        public ResultModel<Unvan> UnvanSave(Unvan model)
        {
            UnvanValidator validator = new UnvanValidator();
            ValidationResult result = validator.Validate(model);
            if (result.IsValid)
            {
                _unvanRepository.Add(model);
                return new ResultModel<Unvan>
                {
                    Errors = null,
                    IsValid = true,
                    Message = "Kayıt Başarılı"

                };
            }
            return new ResultModel<Unvan>
            {
                Errors = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsValid = false,
                Message = "Kayıt Başarısız"
            };
        }

        public ResultModel<Unvan> UnvanUpdate(Unvan model)
        {
            UnvanValidator validator = new UnvanValidator();
            ValidationResult result = validator.Validate(model);
            if (result.IsValid)
            {
                _unvanRepository.Update(model, model.UnvanID);
                return new ResultModel<Unvan>
                {
                    Errors = null,
                    IsValid = true,
                    Message = "Update Başarılı"

                };
            }
            return new ResultModel<Unvan>
            {
                Errors = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsValid = false,
                Message = "Update Başarısız"
            };
        }
    }
}
