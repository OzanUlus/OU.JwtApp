using MediatR;
using OU.JwtApp.Back.Core.Application.Dto;

namespace OU.JwtApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetProductQueryRequest : IRequest<ProductlistDto>
    {
        public int Id { get; set; }

        public GetProductQueryRequest(int ıd)
        {
            Id = ıd;
        }
    }
}
