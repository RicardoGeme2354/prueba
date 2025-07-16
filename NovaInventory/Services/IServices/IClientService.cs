using NovaInventory.Models.Entities;

namespace NovaInventory.Services.IServices
{
    public interface IClientService
    {
        Task<IEnumerable<Client>?> ObtainAllClients();
        Task<Client?> GetClientByName(string ClientName);
        Task AddClient(string ClientName);
        Task RemoveClient(Client client);
        Task UpdateClientStatus(Client client, int StatusId);
    }
}