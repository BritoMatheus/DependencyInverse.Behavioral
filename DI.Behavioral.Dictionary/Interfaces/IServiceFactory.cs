using DI.Behavioral.Dictionary.Enums;

namespace DI.Behavioral.Dictionary.Interfaces
{
    public interface IServiceFactory
    {
        IEmailService Create(EType type);
    }
}
