using Microsoft.AspNetCore.Mvc;
using server.Interfaces;
using server.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PawpalsController : ControllerBase
    {
        private readonly IPawpalsService _pawpalsService;
        public PawpalsController(IPawpalsService pawpalsService) => _pawpalsService = pawpalsService;

        [HttpPost]
        [SwaggerResponse(200, "OK", typeof(Pawpal))]
        public async Task<IActionResult> CreatePawpal(CreatePawpalRequest createPawpalRequest)
        {
            Pawpal pawpal = await _pawpalsService.CreatePawpal(createPawpalRequest);
            return Ok(pawpal);
        }
    }
}
