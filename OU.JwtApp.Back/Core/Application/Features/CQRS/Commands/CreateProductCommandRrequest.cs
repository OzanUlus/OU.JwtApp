using MediatR;

namespace OU.JwtApp.Back.Core.Application.Features.CQRS.Commands
{
    public class CreateProductCommandRrequest : IRequest
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
