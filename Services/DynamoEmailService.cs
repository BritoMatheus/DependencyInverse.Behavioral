using DI.Behavioral.Dictionary.Enums;
using DI.Behavioral.Dictionary.Interfaces;

namespace DI.Behavioral.Dictionary.Services;

public class DynamoEmailService : IEmailService
{
    public EType Get()
    {
        return EType.DynamoDb;
    }
}
