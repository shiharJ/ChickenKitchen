using ChickenKitchen.Application.Common.interfaces.Services;

namespace ChickenKitchen.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider{
    public DateTime UtcNow => DateTime.UtcNow;
}