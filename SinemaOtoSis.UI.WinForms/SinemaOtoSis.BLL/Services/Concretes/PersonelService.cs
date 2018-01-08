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
    public class PersonelService : IPersonelService
    {
        private readonly IPersonelRepository _personelRepository;

        public PersonelService(IPersonelRepository personelRepository)
        {
            _personelRepository = personelRepository;
        }


        public ResultModel<Personel> PersonelDelete(Personel model)
        {
            int id = model.PersonelID;
            _personelRepository.Delete(id);
            return new ResultModel<Personel>
            {
                Errors = null,
                IsValid = true,
                Message = "Silme Başarılı"
            };
        }

        public ResultModel<Personel> PersonelSave(Personel model)
        {
            PersonelValidator validator = new PersonelValidator();
            ValidationResult result = validator.Validate(model);
            if (result.IsValid)
            {
                _personelRepository.Add(model);
                return new ResultModel<Personel>
                {
                    Errors = null,
                    IsValid = true,
                    Message = "Kayıt Başarılı"

                };
            }
            return new ResultModel<Personel>
            {
                Errors = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsValid = false,
                Message = "Kayıt Başarısız"
            };
        }

        public ResultModel<Personel> PersonelUpdate(Personel model)
        {
            PersonelValidator validator = new PersonelValidator();
            ValidationResult result = validator.Validate(model);
            if (result.IsValid)
            {
                _personelRepository.Update(model, model.PersonelID);
                return new ResultModel<Personel>
                {
                    Errors = null,
                    IsValid = true,
                    Message = "Update Başarılı"

                };
            }
            return new ResultModel<Personel>
            {
                Errors = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsValid = false,
                Message = "Update Başarısız"
            };
        }
    }
}
