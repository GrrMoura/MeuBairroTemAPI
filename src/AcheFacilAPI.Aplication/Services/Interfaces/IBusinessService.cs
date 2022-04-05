using AcheFacilAPi.Domain.Models;

namespace AcheFacilAPI.Aplication.Services
{
    public interface IBusinessService
    {
        Task Add(Business? user);
        Task Update(Business? user);
        Task Remove(Guid? BusinessId);
    }
}
