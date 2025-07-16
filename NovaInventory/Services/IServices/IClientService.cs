using System.Collections.Generic;
using System.Threading.Tasks;
using NovaInventory.Models.Entities;

namespace NovaInventory.Services.IServices
{
    public interface IClientService
    {
        Task<IEnumerable<Client>?> ObtainAllClients();
    }
}