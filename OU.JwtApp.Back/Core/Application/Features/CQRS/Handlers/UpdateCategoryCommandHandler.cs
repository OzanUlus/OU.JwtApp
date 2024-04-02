using MediatR;
using OU.JwtApp.Back.Core.Application.Features.CQRS.Commands;
using OU.JwtApp.Back.Core.Application.Interfaces;
using OU.JwtApp.Back.Core.Domain;

namespace OU.JwtApp.Back.Core.Application.Features.CQRS.Handlers
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandrequest>
    {
        private readonly IRepository<Category> _categoryRepository;

        public UpdateCategoryCommandHandler(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Unit> Handle(UpdateCategoryCommandrequest request, CancellationToken cancellationToken)
        {
            var updatedCategory = await _categoryRepository.GetByIdAsync(request.Id);
            if (updatedCategory != null) 
            {
                updatedCategory.Definition = request.Definition;

                await _categoryRepository.UpdateAsync(updatedCategory);
            }
            return Unit.Value;
        }
    }
}
