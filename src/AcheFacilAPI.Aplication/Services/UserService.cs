using AcheFacilAPi.Domain.Models;
using AcheFacilAPi.Domain.Repositories;
using AcheFacilAPI.Aplication.NotificationsErrors;
using AcheFacilAPI.Aplication.Services.Interfaces;

namespace AcheFacilAPI.Aplication.Services
{
    internal class UserService :BaseService, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IBusinessService _businessService;

        public UserService(IUserRepository userRepository,
                           IBusinessService businessService,
                           INotifier notifier) : base(notifier)
        {
            _userRepository = userRepository;
            _businessService = businessService;
        }

        public async Task Add(User? user)
        {
            if (!RunValidation(new UserValidation(), user)
             && (!RunValidation(new AdressValidation(), user?.Address))) ;

            if (await ExistingEmployer(user) == true) return;

            await _userRepository.Add(user);
        }

        public async Task Update(User? user)
        {
            if (!RunValidation(new UserValidation(), user)) return;

            await _userRepository.Update(user);


        }

        public async Task Remove(Guid? userId)
        {
            var user = await _userRepository.GetUserAddressJob(userId);

            if (user.Jobs.Any())
            {
                Notify("O Empregador possui Vaga cadastrada ");

                foreach (var job in user.Jobs)
                {
                    await _businessService.Remove(job.Id);// vê onde pego o job id
                }
            }

            user.Active = false;
            await _userRepository.Update(user);
        }

        private async Task<bool> ExistingEmployer(User user)
        {
            var currentEmployer = await _userRepository.Search(e => e.Email == user.Email && e.Id == user.Id);

            if (!currentEmployer.Any()) return false;

            Notify("Já Existe um Empregador com esse e-mail cadastrado");
            return true;
        }

        public void Dispose()
        {
            _userRepository?.Dispose();
        }

    
}
}
