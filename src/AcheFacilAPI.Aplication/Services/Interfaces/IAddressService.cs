using AcheFacilAPi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcheFacilAPI.Aplication.Services.Interfaces
{
    public interface IAddressService
    {
        Task Add(Address? user);
        Task Update(Address? user);
        Task Remove(Guid? BusinessId);

    }
}
