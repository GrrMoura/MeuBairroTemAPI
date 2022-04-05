using AcheFacilAPi.Domain.Models;
using AcheFacilAPi.Domain.Repositories;
using AcheFacilAPi.Infa.Data.DbApplications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcheFacilAPi.Infa.Data.Data.Repositories
{
    public class BusinessRepository : Repository<Business>, IBusinessRepository
    {
        public BusinessRepository(DbApplication? db) : base(db) { }

        public async Task<IEnumerable<Business>> GetAllProficiencies()
        {

            return await _db.Business.AsNoTracking()
                   .Include(a => a.Proficiencies)

                   .OrderBy(v => v.Name).ToListAsync();

        }
    }
}
