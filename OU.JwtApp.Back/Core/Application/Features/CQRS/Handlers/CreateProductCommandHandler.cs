using MediatR;
using OU.JwtApp.Back.Core.Application.Features.CQRS.Commands;
using OU.JwtApp.Back.Core.Application.Interfaces;
using OU.JwtApp.Back.Core.Domain;

namespace OU.JwtApp.Back.Core.Application.Features.CQRS.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRrequest>
    {
        private readonly IRepository<Product> _repository;

        public CreateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateProductCommandRrequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Product
            {
                Name = request.Name,
                CategoryId = request.CategoryId,
                Price = request.Price,
                Stock = request.Stock
            });
            return Unit.Value;
        }
    }
}
