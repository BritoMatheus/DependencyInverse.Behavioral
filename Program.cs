using DI.Behavioral.Dictionary.Enums;
using DI.Behavioral.Dictionary.Interfaces;
using DI.Behavioral.Dictionary.DI;
using Microsoft.Extensions.DependencyInjection;

var serviceColletion = new ServiceCollection();

serviceColletion.AddServices();

var serviceProvider = serviceColletion.BuildServiceProvider();

using (var scope = serviceProvider.CreateScope())
{
    var serviceFactory = scope.ServiceProvider.GetService<IServiceFactory>();


    var sqlService = serviceFactory.Create(EType.SQL);
    var sqlReturn = sqlService.Get();
    Console.WriteLine($"SQL type returns {sqlReturn}");


    var dynamoService = serviceFactory.Create(EType.DynamoDb);
    var dynamoReturn = dynamoService.Get();
    Console.WriteLine($"Dynamo type returns {dynamoReturn}");

    Console.ReadLine();
}



