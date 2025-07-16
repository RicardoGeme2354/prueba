using NovaInventory.Repositories.IRepositories;
using NovaInventory.Data;
using NovaInventory.Models.Entities;
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
                .Where(client => client.stateId == 3)
                .ToListAsync();
        }

        public async Task AddClient(Client newClient)
        {

            await _context.Clients.AddAsync(newClient);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteClient(Client client)
        {
            client.stateId = 5;
            _context.Clients.Update(client);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateStatusUser(Client client, int statusId)
        {
            client.stateId = statusId;
            _context.Clients.Update(client);
            await _context.SaveChangesAsync();
        }

        public async Task<Client?> GetClientByName(string ClientName)
        {
            return await _context.Clients
                .FirstOrDefaultAsync(client => client.clientName == ClientName);
        }
    }
}