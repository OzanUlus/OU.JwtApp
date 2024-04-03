using MediatR;
using OU.JwtApp.Back.Core.Application.Enums;
using OU.JwtApp.Back.Core.Application.Features.CQRS.Commands;
using OU.JwtApp.Back.Core.Application.Interfaces;
using OU.JwtApp.Back.Core.Domain;

namespace OU.JwtApp.Back.Core.Application.Features.CQRS.Handlers
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommandrequest>
    {
        private readonly IRepository<AppUser> _appUserRepository;

        public RegisterUserCommandHandler(IRepository<AppUser> appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }

        public async Task<Unit> Handle(RegisterUserCommandrequest request, CancellationToken cancellationToken)
        {
            await _appUserRepository.CreateAsync(new AppUser 
            {
              UserName = request.UserName,
              Password = request.Password,
              AppRoleId = (int)RoleType.Member,
            });
            return Unit.Value;
        }
    }
}
