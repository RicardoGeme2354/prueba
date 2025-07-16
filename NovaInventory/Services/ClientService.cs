using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<IEnumerable<Client>?> ObtainAllClients()
        {
            return await _clientRepository.GetAllClients();
        }
    }
}