using MediatR;
using OU.JwtApp.Back.Core.Application.Dto;

namespace OU.JwtApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetCategoryQueryRequest : IRequest<CategoryListDto>
    {
        public int Id { get; set; }

        public GetCategoryQueryRequest(int ıd)
        {
            Id = ıd;
        }
    }
}
