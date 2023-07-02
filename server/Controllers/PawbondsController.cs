using Microsoft.AspNetCore.Mvc;
using server.Enums;
using server.Interfaces;
using server.Models;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PawbondsController : ControllerBase
    {
        private readonly IPawbondsService _pawbondsService;
        public PawbondsController(IPawbondsService pawbondsService) => _pawbondsService = pawbondsService;

        [HttpGet]
        public async Task<IActionResult> GetPawbonds(int pawpalId)
        {
            UsersPawbonds usersPawbonds = await _pawbondsService.GetPawbonds(pawpalId);
            return Ok(usersPawbonds);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePawbond(int pawbondPostId, int pawpalId)
        {
            Pawbond pawbond = await _pawbondsService.CreatePawbond(pawbondPostId, pawpalId);
            return Ok(pawbond);
        }
        [HttpGet]
        [Route("{pawbondId:int}")]
        public async Task<IActionResult> UpdatePawbond([FromRoute] int pawbondId, [FromQuery] StatusType status)
        {
            Pawbond? pawbond = await _pawbondsService.UpdatePawbond(pawbondId, status);
            return Ok(pawbond);
        }
    }
}
