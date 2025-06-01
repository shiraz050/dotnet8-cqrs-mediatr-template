using MediatR;

namespace CQRS.Template.Application.Features.Users.Commands.CreateUser;

public class CreateUserCommand : IRequest<Guid>
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
