using CQRS.Template.Domain.Entities;
using MediatR;

namespace CQRS.Template.Application.Features.Users.Commands.CreateUser;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, Guid>
{
    public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        // For now, just mock DB
        var user = new User
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Email = request.Email
        };

        // TODO: Save to DB

        return await Task.FromResult(user.Id);
    }
}
