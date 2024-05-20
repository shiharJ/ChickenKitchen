namespace ChickenKitchen.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Register(string firstName, string lastName, string email, string token)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            firstName,
            lastName,
            email,
            "token");
    }

    public AuthenticationResult Login(string email, string token)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            "firstName",
            "lastName",
            email,
            "token");
    }
}