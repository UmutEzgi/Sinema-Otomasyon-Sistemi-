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
    public class SalonService : ISalonService
    {
        private readonly ISalonRepository _salonRepository;

        public SalonService(ISalonRepository salonRepository)
        {
            _salonRepository = salonRepository;
        }
        public ResultModel<Salon> SalonDelete(Salon model)
        {
            int id = model.SalonID;
            _salonRepository.Delete(id);
            return new ResultModel<Salon>
            {
                Errors = null,
                IsValid = true,
                Message = "Silme Başarılı"
            };
        }

        public ResultModel<Salon> SalonSave(Salon model)
        {
            SalonValidator validator = new SalonValidator();
            ValidationResult result = validator.Validate(model);
            if (result.IsValid)
            {
                _salonRepository.Add(model);
                return new ResultModel<Salon>
                {
                    Errors = null,
                    IsValid = true,
                    Message = "Kayıt Başarılı"

                };
            }
            return new ResultModel<Salon>
            {
                Errors = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsValid = false,
                Message = "Kayıt Başarısız"
            };
        }

        public ResultModel<Salon> SalonUpdate(Salon model)
        {
            SalonValidator validator = new SalonValidator();
            ValidationResult result = validator.Validate(model);
            if (result.IsValid)
            {
                _salonRepository.Update(model, model.SalonID);
                return new ResultModel<Salon>
                {
                    Errors = null,
                    IsValid = true,
                    Message = "Update Başarılı"

                };
            }
            return new ResultModel<Salon>
            {
                Errors = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsValid = false,
                Message = "Update Başarısız"
            };
        }
    }
}
