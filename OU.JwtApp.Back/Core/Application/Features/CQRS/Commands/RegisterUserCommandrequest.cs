using MediatR;

namespace OU.JwtApp.Back.Core.Application.Features.CQRS.Commands
{
    public class RegisterUserCommandrequest : IRequest
    {
        public string? UserName { get; set;}
        public string? Password { get; set;}
    }
}
