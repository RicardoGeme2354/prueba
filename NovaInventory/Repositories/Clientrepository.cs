using NovaInventory.Repositories.IRepositories;
using NovaInventory.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using NovaInventory.Models.Entities;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace NovaInventory.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly NovaInventoryDbContext _context;

        public ClientRepository(NovaInventoryDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Client>?> GetAllClients()
        {
            return await _context.Clients
                .ToListAsync();
        }

        public async Task AddClient(Client newClient)
        {

            await _context.Clients.AddAsync(newClient);
        }

        Task DeleteClient(Client client)
        {
            client.StatusId = 5; // representa el id de usuario bloqueado
        }

        Task UpdateStatusUser(Client client, StatusId statusId)
        {
            
        }
    }
}