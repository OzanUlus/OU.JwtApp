using MediatR;
using OU.JwtApp.Back.Core.Application.Dto;

namespace OU.JwtApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetAllCategoriesQueyRequest : IRequest<List<CategoryListDto>>
    {
    }
}
