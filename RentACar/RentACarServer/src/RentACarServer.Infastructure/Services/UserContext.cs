using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using RentACarServer.Application.Services;

namespace RentACarServer.Infastructure.Services;

internal sealed class UserContext(IHttpContextAccessor accessor):IUserContext
{
    public Guid GetUserId()
    {
        var httpContext = accessor.HttpContext;
        var claimsIdentity = httpContext.User.Claims;
        string? userId = claimsIdentity.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
        if (userId == null)
        {
            throw new ArgumentException("Claims claim types are invalid");
            
        }
        Guid id = Guid.Parse(userId);
        return id;
    }
}