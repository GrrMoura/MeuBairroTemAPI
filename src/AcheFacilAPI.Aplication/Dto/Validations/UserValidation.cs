using AcheFacilAPi.Domain.Models;
using FluentValidation;

namespace AcheFacilAPI.Aplication.Dto.Validations
{
   
        public class UserValidation : AbstractValidator<User>
        {
            public UserValidation()
            {
                RuleFor(e => e.Name)
                     .NotEmpty().WithMessage("O {PropertyName} precisa ser preenchido")
                     .Length(2, 30).WithMessage("O {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

                RuleFor(e => e.Email)
                     .Length(5, 50).WithMessage("O {PropertyName} precisa ter no máximo {PropertyValue} caracteres");

               

            }
        }
    
}
