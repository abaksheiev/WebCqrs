﻿using Microsoft.AspNetCore.Mvc;
using WebCqrs.Domain.Aggregates.PostAggregate;

namespace WebCqrs.Api.Controllers.v2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController()]
    public class PostsController : Controller
    {
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }
    }
}
