using NovaInventory.Repositories.IRepositories;
using NovaInventory.Services.IServices;
using NovaInventory.Models.Entities;

namespace NovaInventory.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository) 
        {
            _clientRepository = clientRepository;
        }

        public async Task AddClient(string ClientName)
        {
            Client newClient = new Client
            {
                clientName = ClientName,
                stateId = 3
            };

            await _clientRepository.AddClient(newClient);
        }

        public async Task<Client?> GetClientByName(string ClientName)
        {
            return await _clientRepository.GetClientByName(ClientName);
        }

        public async Task<IEnumerable<Client>?> ObtainAllClients()
        {
            return await _clientRepository.GetAllClients();
        }

        public async Task RemoveClient(Client client)
        {
            await _clientRepository.DeleteClient(client);
        }

        public async Task UpdateClientStatus(Client client, int StatusId)
        {
            await _clientRepository.UpdateStatusUser(client, StatusId);
        }
    }
}