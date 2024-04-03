using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OU.JwtApp.Back.Core.Application.Features.CQRS.Commands;
using OU.JwtApp.Back.Core.Application.Features.CQRS.Queries;


namespace OU.JwtApp.Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
           var result = await _mediator.Send(new GetAllCategoriesQueyRequest());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) 
        {
           var result = await _mediator.Send(new GetCategoryQueryRequest(id));
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CraeteCategoryCommandRequest request) 
        {
            var result = await _mediator.Send(request);
            return Created("", result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCategoryCommandrequest request) 
        {
          await _mediator.Send(request);
            return NoContent();
        }

        [HttpDelete("id")]
        public async Task<IActionResult> Delete(int id) 
        {
            await _mediator.Send(new DeleteCategoryCommandRequest(id));
            return Ok();
        }
    }
}
