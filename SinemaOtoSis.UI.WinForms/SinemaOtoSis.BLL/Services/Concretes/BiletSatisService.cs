

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
    public class BiletSatisService : IBiletSatisService
    {
        private readonly IBiletSatisRepository _biletsatisRepository;

        public BiletSatisService(IBiletSatisRepository biletsatisRepository)
        {
            _biletsatisRepository = biletsatisRepository;
        }
        public ResultModel<BiletSatis> BiletSatisDelete(BiletSatis model)
        {
            int id = model.BiletID;
            _biletsatisRepository.Delete(id);
            return new ResultModel<BiletSatis>
            {
                Errors = null,
                IsValid = true,
                Message = "Silme Başarılı"
            };
        }

        public ResultModel<BiletSatis> BiletSatisSave(BiletSatis model)
        {
            BiletSatisValidator validator = new BiletSatisValidator();
            ValidationResult result = validator.Validate(model);
            if (result.IsValid)
            {
                _biletsatisRepository.Add(model);
                return new ResultModel<BiletSatis>
                {
                    Errors = null,
                    IsValid = true,
                    Message = "Kayıt Başarılı"

                };
            }
            return new ResultModel<BiletSatis>
            {
                Errors = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsValid = false,
                Message = "Kayıt Başarısız"
            };
        }

        public ResultModel<BiletSatis> BiletSatisUpdate(BiletSatis model)
        {
            BiletSatisValidator validator = new BiletSatisValidator();
            ValidationResult result = validator.Validate(model);
            if (result.IsValid)
            {
                _biletsatisRepository.Update(model, model.BiletID);
                return new ResultModel<BiletSatis>
                {
                    Errors = null,
                    IsValid = true,
                    Message = "Update Başarılı"

                };
            }
            return new ResultModel<BiletSatis>
            {
                Errors = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsValid = false,
                Message = "Update Başarısız"
            };
        }
    }
}
