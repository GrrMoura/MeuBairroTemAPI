using AcheFacilAPi.Domain.Models;

namespace AcheFacilAPi.Domain.Repositories
{
    public interface IBusinessRepository:IRepository<Business>
    {
        Task<IEnumerable<Business>> GetAllProficiencies();
    }
}
