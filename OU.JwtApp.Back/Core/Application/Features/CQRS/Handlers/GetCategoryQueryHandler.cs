using AutoMapper;
using MediatR;
using OU.JwtApp.Back.Core.Application.Dto;
using OU.JwtApp.Back.Core.Application.Features.CQRS.Queries;
using OU.JwtApp.Back.Core.Application.Interfaces;
using OU.JwtApp.Back.Core.Domain;

namespace OU.JwtApp.Back.Core.Application.Features.CQRS.Handlers
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQueryRequest, List<CategoryListDto>>
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;

        public GetCategoryQueryHandler(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<CategoryListDto>> Handle(GetCategoryQueryRequest request, CancellationToken cancellationToken)
        {
          var data =  await _repository.GetByFilterAsync(c => c.Id == request.Id);
            return _mapper.Map<List<CategoryListDto>>(data);
        }
    }
}
