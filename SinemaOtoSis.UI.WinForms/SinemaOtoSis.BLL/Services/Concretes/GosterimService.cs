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
    public class GosterimService : IGosterimService
    {
        private readonly IGosterimRepository _gosterimRepository;

        public GosterimService(IGosterimRepository gosterimRepository)
        {
            _gosterimRepository = gosterimRepository;
        }
        public ResultModel<Gosterim> GosterimDelete(Gosterim model)
        {
            int id = model.GosterimID;
            _gosterimRepository.Delete(id);
            return new ResultModel<Gosterim>
            {
                Errors = null,
                IsValid = true,
                Message = "Silme Başarılı"
            };
        }

        public ResultModel<Gosterim> GosterimSave(Gosterim model)
        {
            GosterimValidator validator = new GosterimValidator();
            ValidationResult result = validator.Validate(model);
            if (result.IsValid)
            {
                _gosterimRepository.Add(model);
                return new ResultModel<Gosterim>
                {
                    Errors = null,
                    IsValid = true,
                    Message = "Kayıt Başarılı"

                };
            }
            return new ResultModel<Gosterim>
            {
                Errors = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsValid = false,
                Message = "Kayıt Başarısız"
            };
        }

        public ResultModel<Gosterim> GosterimUpdate(Gosterim model)
        {
            GosterimValidator validator = new GosterimValidator();
            ValidationResult result = validator.Validate(model);
            if (result.IsValid)
            {
                _gosterimRepository.Update(model, model.GosterimID);
                return new ResultModel<Gosterim>
                {
                    Errors = null,
                    IsValid = true,
                    Message = "Update Başarılı"

                };
            }
            return new ResultModel<Gosterim>
            {
                Errors = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsValid = false,
                Message = "Update Başarısız"
            };
        }
    }
}
