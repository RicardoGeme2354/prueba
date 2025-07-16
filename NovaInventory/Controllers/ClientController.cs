using Microsoft.AspNetCore.Mvc;
using NovaInventory.Services.IServices;

namespace NovaInventory.Controllers
{
    [Route("api/[Controller]")]
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet("find-all-clients")]
        public async Task<IActionResult> FindAllUsers()
        {
            var AllUSers = await _clientService.ObtainAllClients();

            if (AllUSers == null || !AllUSers.Any())
            {
                return NotFound("No se encontraron clientes!");
            }

            return Ok(AllUSers);
        }

        [HttpPost("add-user/{UserName}")]
        public async Task<IActionResult> AddUser(string UserName)
        {
            await _clientService.AddClient(UserName);

            return Ok();
        }

        [HttpDelete("delete-user/{Username}")]
        public async Task<IActionResult> DeleteUser(string Username)
        {
            var FindUser = await _clientService.GetClientByName(Username);

            if (FindUser == null)
            {
                return NotFound("No se encontro el usuario!");
            }

            await _clientService.RemoveClient(FindUser);
            return Ok();
        }

        [HttpPatch("update-user/{Username}/{StateId}")]
        public async Task<IActionResult> UpdateUserState(string Username, int StateId)
        {
            var FindClient = await _clientService.GetClientByName(Username);

            if (FindClient == null)
            {
                return NotFound("No se encontro el usuario!");
            }

            await _clientService.UpdateClientStatus(FindClient, StateId);

            return Ok();
        }
    }
}