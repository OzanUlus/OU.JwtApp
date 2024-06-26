﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OU.JwtApp.Back.Core.Application.Features.CQRS.Commands;
using OU.JwtApp.Back.Core.Application.Features.CQRS.Queries;

namespace OU.JwtApp.Back.Controllers
{
    [Authorize(Roles ="Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> List() 
        {
            var result = await _mediator.Send(new GetAllProductsQueryRequest());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) 
        {
            var result = await _mediator.Send(new GetProductQueryRequest(id));

            return result == null ? NotFound() : Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) 
        {
            var result = await _mediator.Send(new DeleteProductCommandRequest(id));
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductCommandRrequest request) 
        {
           var result = await _mediator.Send(request);
            return Created("", result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateProductCommandRequest request) 
        {
           await _mediator.Send(request);
            return NoContent();
        }
    }
}
