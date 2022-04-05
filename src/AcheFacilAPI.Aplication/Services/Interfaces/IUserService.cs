using AcheFacilAPi.Domain.Models;

namespace AcheFacilAPI.Aplication.Services.Interfaces
{
    public interface IUserService:IDisposable
    {
        Task Add(User? user);
        Task Update(User? user);
        Task Remove(Guid? userId);
    }
}
