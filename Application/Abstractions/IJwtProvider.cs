using Domain.Entities;

namespace Application.Common;

public interface IAuthentication
{
    string GenerateToken(User user);
}