using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Security.AccessControl;

using IHost host = Host.CreateDefaultBuilder(args).ConfigureServices((_, services) =>
    services.AddTransient<ITransientOperation, DefaultOperation>()
    .AddScoped<IScopedOperation, DefaultOperation>()
    .AddSingleton<ISingletonOperation, DefaultOperation>()
    //En el caso de arriba, P ej, ISingletonOperation refiere la interfaz usada
    //Y el segundo dato es la clase que se basa en esa interfaz.
    .AddTransient<OperationLogger>()  )
    .Build();

EjemploScopes(host.Services, "Scope 1");
EjemploScopes(host.Services, "Scope 2");
await host.StartAsync(); //Inicio asíncrono 

static void EjemploScopes (IServiceProvider services, string scopeName)
{
    using IServiceScope serviceScope = services.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;

    OperationLogger logger=provider.GetRequiredService<OperationLogger>();
    logger.LogOperations($"{scopeName}: -- Ejecutando... GetRequiredService<OperationLogger>()");
    
    Console.WriteLine();
    /*
    logger=provider.GetRequiredService<OperationLogger>();
    logger.LogOperations($"{scopeName}: -- Ejecutando... GetRequiredService<OperationLogger>()");

    Console.WriteLine();
    */
}


public class DefaultOperation : ITransientOperation, IScopedOperation, ISingletonOperation
//Implementa las 3 interfaces
{
    public string? OperationId { get; set; } = "Pepe";
    //Ese Pepe lo puse yo, porque si no al printearse no aparecía nada en pantalla.

}

public class OperationLogger
{
    private readonly ITransientOperation _transientOperation;
    //Recomienda anteponer el guion bajo a lo que es privado
    private readonly IScopedOperation _scopedOperation;
    private readonly ISingletonOperation _singletonOperation;

    public OperationLogger(
       ITransientOperation transientOperation,
        ISingletonOperation singletonOperation,
        IScopedOperation scopedOperation
    ) /*Esos son los parámetros del constructor */ => (_transientOperation, _scopedOperation, _singletonOperation) =
        (transientOperation, scopedOperation, singletonOperation);
    //Es un constructor bastante afectado.

    public void LogOperations(string scope)
    {
        LogOperations(_transientOperation, scope, "Desde TransientOperation");
        LogOperations(_scopedOperation, scope, "Desde ScopedOperation");
        LogOperations(_singletonOperation, scope, "Desde SingletonOperation");
    }

    private static void LogOperations<T>(T operation, string scope, string msg)
    where T : IOperation =>
    Console.WriteLine($"{scope}: {typeof(T).Name} [{operation.OperationId}] - {msg}");

}





public interface ISingletonOperation : IOperation
{

}

public interface IScopedOperation : IOperation
{

}

public interface ITransientOperation : IOperation
{

}

public interface IOperation
{
    string OperationId { get; }
}
