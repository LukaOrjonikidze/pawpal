using Microsoft.AspNetCore.Mvc;
using server.Enums;
using server.Interfaces;
using server.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PawbondsController : ControllerBase
    {
        private readonly IPawbondsService _pawbondsService;
        public PawbondsController(IPawbondsService pawbondsService) => _pawbondsService = pawbondsService;

        [HttpGet]
        [SwaggerResponse(200, "OK", typeof(UsersPawbonds))]
        public async Task<IActionResult> GetPawbonds(int pawpalId)
        {
            UsersPawbonds usersPawbonds = await _pawbondsService.GetPawbonds(pawpalId);
            return Ok(usersPawbonds);
        }
        [HttpPost]
        [SwaggerResponse(200, "OK", typeof(Pawbond))]
        public async Task<IActionResult> CreatePawbond(int pawbondPostId, int pawpalId)
        {
            Pawbond pawbond = await _pawbondsService.CreatePawbond(pawbondPostId, pawpalId);
            return Ok(pawbond);
        }
        [HttpGet]
        [Route("{pawbondId:int}")]
        [SwaggerResponse(200, "OK", typeof(Pawbond))]
        public async Task<IActionResult> UpdatePawbond([FromRoute] int pawbondId, [FromQuery] StatusType status)
        {
            Pawbond? pawbond = await _pawbondsService.UpdatePawbond(pawbondId, status);
            return Ok(pawbond);
        }
    }
}
