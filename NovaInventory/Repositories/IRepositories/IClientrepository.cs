using NovaInventory.Models.Entities;

namespace NovaInventory.Repositories.IRepositories
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>?> GetAllClients();
        Task<Client?> GetClientByName(string ClientName);
        Task AddClient(Client client);
        Task DeleteClient(Client client);
        Task UpdateStatusUser(Client client, int StateId);
    }
}