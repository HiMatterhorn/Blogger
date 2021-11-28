﻿using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;
        public PostsController(IPostService postService)
        {
            _postService = postService;
        }


        [SwaggerOperation(Summary = "Retrieves all posts")]
        [HttpGet]
        public IActionResult Get()
        {
            var posts = _postService.GetAllPosts();
            return Ok(posts);
        }

        [SwaggerOperation(Summary = "Retrieves post by unique id")]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var post = _postService.GetPostById(id);

            if (post == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(post);
            }

        }
    }
}
