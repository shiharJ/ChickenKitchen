namespace ChickenKitchen.Application.Common.interfaces.Authentication;

public interface IJwTokenGenerator {
    string GenerateToken(Guid id, string firstName, string lastName);
}