namespace ChickenKitchen.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Register(string firstName,string lastName,string email,string token);
    AuthenticationResult Login(string email,string token);
}