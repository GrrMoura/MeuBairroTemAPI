using AcheFacilAPi.Domain.Models;
using FluentValidation;

namespace AcheFacilAPI.Aplication.Dto.Validations
{
    public class BusinessValidation:AbstractValidator<Business>
    {
        public BusinessValidation()
        {
            RuleFor(e => e.Name)
                     .NotEmpty().WithMessage("O {PropertyName} precisa ser preenchido")
                     .Length(2, 50).WithMessage("O {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(e => e.Profession)
                 .Length(2, 50).WithMessage("O {PropertyName} precisa ter no máximo {PropertyValue} caracteres");
        }
    }
}
