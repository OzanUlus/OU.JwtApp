using MediatR;

namespace OU.JwtApp.Back.Core.Application.Features.CQRS.Commands
{
    public class CraeteCategoryCommandRequest : IRequest
    {
        public string? Definition { get; set; }
    }
}
