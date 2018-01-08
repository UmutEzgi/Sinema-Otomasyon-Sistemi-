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
    public class SeansService : ISeansService
    {
        private readonly ISeansRepository _seansRepository;

        public SeansService(ISeansRepository seansRepository)
        {
            _seansRepository = seansRepository;
        }
        public ResultModel<Seans> SalonDelete(Seans model)
        {
            int id = model.SeansID;
            _seansRepository.Delete(id);
            return new ResultModel<Seans>
            {
                Errors = null,
                IsValid = true,
                Message = "Silme Başarılı"
            };
        }

        public ResultModel<Seans> SalonSave(Seans model)
        {
            SeansValidator validator = new SeansValidator();
            ValidationResult result = validator.Validate(model);
            if (result.IsValid)
            {
                _seansRepository.Add(model);
                return new ResultModel<Seans>
                {
                    Errors = null,
                    IsValid = true,
                    Message = "Kayıt Başarılı"

                };
            }
            return new ResultModel<Seans>
            {
                Errors = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsValid = false,
                Message = "Kayıt Başarısız"
            };
        }

        public ResultModel<Seans> SalonUpdate(Seans model)
        {
            SeansValidator validator = new SeansValidator();
            ValidationResult result = validator.Validate(model);
            if (result.IsValid)
            {
                _seansRepository.Update(model, model.SeansID);
                return new ResultModel<Seans>
                {
                    Errors = null,
                    IsValid = true,
                    Message = "Update Başarılı"

                };
            }
            return new ResultModel<Seans>
            {
                Errors = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsValid = false,
                Message = "Update Başarısız"
            };
        }
    }
}
