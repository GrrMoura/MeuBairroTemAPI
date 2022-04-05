using AcheFacilAPi.Domain.Models;
using AcheFacilAPi.Domain.Repositories;
using AcheFacilAPi.Infa.Data.DbApplications;
using Microsoft.EntityFrameworkCore;

namespace AcheFacilAPi.Infa.Data.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbApplication? context) : base(context)
        {
        }

        public async Task<IEnumerable<User>> GetUserBusiness(Guid Id)
        {
            return await _db.User.AsNoTracking()
                   .Include(a => a.Business)
                   
                   .OrderBy(v => v.Name).ToListAsync();
        }
    }
}
