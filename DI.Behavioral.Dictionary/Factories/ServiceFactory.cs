using DI.Behavioral.Dictionary.Enums;
using DI.Behavioral.Dictionary.Interfaces;

namespace DI.Behavioral.Dictionary.Factories;

public class ServiceFactory(IDictionary<EType, Func<IEmailService>> instructions): IServiceFactory
{
    public IEmailService Create(EType type)
    {
        if (instructions.ContainsKey(type))
        {
            return instructions[type]();
        }
        throw new ArgumentException($"{type} not inject");
    }
}
