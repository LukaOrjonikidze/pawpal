﻿using Microsoft.AspNetCore.Mvc;
using server.Interfaces;
using server.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PawbondPostsController : ControllerBase
    {
        private readonly IPawbondPostsService _pawbondPostsService;
        public PawbondPostsController(IPawbondPostsService pawbondPostsService) => _pawbondPostsService = pawbondPostsService;

        [HttpGet]
        [SwaggerResponse(200, "OK", typeof(List<PawbondPost>))]
        public async Task<IActionResult> GetPawbondPosts()
        {
            List<PawbondPost> pawbondPosts = await _pawbondPostsService.GetPawbondPosts();
            return Ok(pawbondPosts);
        }

        [HttpPost]
        [SwaggerResponse(200, "OK", typeof(PawbondPost))]
        public async Task<IActionResult> AddPawbondPost(AddPawbondPostRequest addPawbondPostRequest)
        {
            PawbondPost pawbondPost = await _pawbondPostsService.AddPawbondPost(addPawbondPostRequest);
            return Ok(pawbondPost);
        }

        [HttpDelete]
        [Route("{pawbondPostId:int}")]
        [SwaggerResponse(200, "OK", typeof(PawbondPost))]
        public async Task<IActionResult> DeletePawbondPost([FromRoute] int pawbondPostId)
        {
            PawbondPost? pawbondPost = await _pawbondPostsService.DeletePawbondPost(pawbondPostId);
            return Ok(pawbondPost);
        }
    }
}
