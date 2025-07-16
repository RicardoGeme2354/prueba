using System.Collections.Generic;
using System.Threading.Tasks;
using NovaInventory.Models.Entities;

namespace NovaInventory.Repositories.IRepositories
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>?> GetAllClients();
        Task AddClient(string ClientName);
        Task DeleteClient(string ClientName);
        Task UpdateStatusUser(string StatusId);
    }
}