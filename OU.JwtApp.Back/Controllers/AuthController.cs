using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OU.JwtApp.Back.Core.Application.Features.CQRS.Commands;

namespace OU.JwtApp.Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterUserCommandrequest request) 
        {
          await _mediator.Send(request);
            return Created("", request);
        }
    }
}
