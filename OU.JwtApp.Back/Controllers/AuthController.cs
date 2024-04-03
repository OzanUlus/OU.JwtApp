using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OU.JwtApp.Back.Core.Application.Features.CQRS.Commands;
using OU.JwtApp.Back.Core.Application.Features.CQRS.Queries;
using OU.JwtApp.Back.Infrastructure.Tools;

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

        [HttpPost("[action]")]
        public async Task<IActionResult> Register(RegisterUserCommandrequest request)
        {
            await _mediator.Send(request);
            return Created("", request);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(CheckUserQueryRequest request)
        {
            var dto = await _mediator.Send(request);
            if (dto.IsExist)
            {
                return Created("", JwtTokenGenerator.GenerateToken(dto));
            }
            else 
            {
              return BadRequest("kullanıcı adı veya şifre hatalı");
            }
        }
    }
}
