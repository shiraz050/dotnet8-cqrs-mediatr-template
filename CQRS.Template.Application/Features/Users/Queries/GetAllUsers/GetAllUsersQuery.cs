using MediatR;
using System.Collections.Generic;

namespace CQRS.Template.Application.Features.Users.Queries.GetAllUsers;

public class GetAllUsersQuery : IRequest<IEnumerable<UserDto>> { }
