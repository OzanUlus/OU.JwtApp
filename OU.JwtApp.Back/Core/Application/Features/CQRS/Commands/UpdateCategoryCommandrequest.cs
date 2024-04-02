using MediatR;

namespace OU.JwtApp.Back.Core.Application.Features.CQRS.Commands
{
    public class UpdateCategoryCommandrequest : IRequest
    {
        public int Id { get; set; }
        public string? Definition { get; set; }
    }
}
