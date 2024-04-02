using MediatR;
using OU.JwtApp.Back.Core.Application.Features.CQRS.Commands;
using OU.JwtApp.Back.Core.Application.Interfaces;
using OU.JwtApp.Back.Core.Domain;

namespace OU.JwtApp.Back.Core.Application.Features.CQRS.Handlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CraeteCategoryCommandRequest>
    {
        private readonly IRepository<Category> _categoryRepository;

        public CreateCategoryCommandHandler(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Unit> Handle(CraeteCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            await _categoryRepository.CreateAsync(new Category 
            {
              Definition = request.Definition,
            });
            return Unit.Value;
        }
    }
}
