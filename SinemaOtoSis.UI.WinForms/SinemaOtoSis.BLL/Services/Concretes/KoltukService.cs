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
    public class KoltukService : IKoltukService
    {
        private readonly IKoltukRepository _koltukRepository;

        public KoltukService(IKoltukRepository koltukRepository)
        {
            _koltukRepository = koltukRepository;
        }
        public ResultModel<Koltuk> KoltukDelete(Koltuk model)
        {
            int id = model.KoltukID;
            _koltukRepository.Delete(id);
            return new ResultModel<Koltuk>
            {
                Errors = null,
                IsValid = true,
                Message = "Silme Başarılı"
            };
        }

        public ResultModel<Koltuk> KoltukSave(Koltuk model)
        {
            KoltukValidator validator = new KoltukValidator();
            ValidationResult result = validator.Validate(model);
            if (result.IsValid)
            {
                _koltukRepository.Add(model);
                return new ResultModel<Koltuk>
                {
                    Errors = null,
                    IsValid = true,
                    Message = "Kayıt Başarılı"

                };
            }
            return new ResultModel<Koltuk>
            {
                Errors = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsValid = false,
                Message = "Kayıt Başarısız"
            };
        }

        public ResultModel<Koltuk> KoltukUpdate(Koltuk model)
        {
            KoltukValidator validator = new KoltukValidator();
            ValidationResult result = validator.Validate(model);
            if (result.IsValid)
            {
                _koltukRepository.Update(model, model.KoltukID);
                return new ResultModel<Koltuk>
                {
                    Errors = null,
                    IsValid = true,
                    Message = "Update Başarılı"

                };
            }
            return new ResultModel<Koltuk>
            {
                Errors = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsValid = false,
                Message = "Update Başarısız"
            };
        }
    }
}
