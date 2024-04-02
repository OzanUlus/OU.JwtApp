using AutoMapper;
using MediatR;
using OU.JwtApp.Back.Core.Application.Dto;
using OU.JwtApp.Back.Core.Application.Features.CQRS.Queries;
using OU.JwtApp.Back.Core.Application.Interfaces;
using OU.JwtApp.Back.Core.Domain;

namespace OU.JwtApp.Back.Core.Application.Features.CQRS.Handlers
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQueyRequest, List<CategoryListDto>>
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;

        public GetAllCategoriesQueryHandler(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<CategoryListDto>> Handle(GetAllCategoriesQueyRequest request, CancellationToken cancellationToken)
        {
            var datas = await _repository.GetAllAsync();
            return _mapper.Map<List<CategoryListDto>>(datas);
        }
    }
}
