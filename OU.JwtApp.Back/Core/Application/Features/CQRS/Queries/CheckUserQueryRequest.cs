using MediatR;
using OU.JwtApp.Back.Core.Application.Dto;

namespace OU.JwtApp.Back.Core.Application.Features.CQRS.Queries
{
    public class CheckUserQueryRequest : IRequest<CheckUserResponseDto>
    {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;

    }
}
