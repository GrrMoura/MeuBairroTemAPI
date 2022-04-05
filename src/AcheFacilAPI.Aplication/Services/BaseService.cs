using AcheFacilAPi.Domain.Entities;
using AcheFacilAPI.Aplication.NotificationsErrors;
using FluentValidation;
using FluentValidation.Results;

namespace AcheFacilAPI.Aplication.Services
{
    internal class BaseService
    {
        private readonly INotifier _notifier;


        public BaseService(INotifier notifier)
        {
            _notifier = notifier;
        }



        protected void Notify(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notify(error.ErrorMessage);
            }
        }

        protected void Notify(string message)
        {
            _notifier.Handle(new ErrorNotification(message));
        }


        public bool RunValidation<Tv, TE>(Tv validation, TE entity) where Tv : AbstractValidator<TE> where TE : Entity
        {
            var validator = validation.Validate(entity);

            if (validator.IsValid) return true;

            Notify(validator);

            return false;
        }
    }
}
