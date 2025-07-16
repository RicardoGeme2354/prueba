using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovaInventory.Services.IServices;

namespace NovaInventory.Controllers
{
    [Route("api/[Controller]")]
    public class UserController : Controller
    {
        private readonly IClientService _clientService;

        public UserController(IClientService clientService) 
        {
            _clientService = clientService;
        }

        [HttpGet("find-all-users")]
        public async Task<IActionResult> FindAllUsers()
        {
            var response = await _clientService.ObtainAllClients();

            return Ok();
        }
    }
}