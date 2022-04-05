using AcheFacilAPi.Domain.Models;

namespace AcheFacilAPi.Domain.Repositories
{
    public interface IUserRepository:IRepository<User>
    {
        Task<IEnumerable<User>> GetUserBusiness(Guid Id);
    }
}
