using DI.Behavioral.Dictionary.Enums;
using DI.Behavioral.Dictionary.Interfaces;

namespace DI.Behavioral.Dictionary.Services;

public class SqlEmailService : IEmailService
{
    public EType Get()
    {
        return  EType.SQL;
    }
}
