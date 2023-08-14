using Asincronia;
using System.Diagnostics;

//Iniciamos un contador de tiempo síncrono
Stopwatch sw = Stopwatch.StartNew();
sw.Start();
/*
Console.WriteLine("\nBienvenido a la calculadora de Hipotécas Síncrona");
var aniosDeVidaLaboral = CalculadoraHipotecaSync.ObtenerAnosDeVidaLaboral();
Console.WriteLine("\nAños de vida laboral obtenidos: "+ aniosDeVidaLaboral);

var esTipoDeContratoIndefinido = CalculadoraHipotecaSync.EsTipoDeContratoIndefinido();
Console.WriteLine("\nTipo de contrato indefinido: "+ esTipoDeContratoIndefinido);

var sueldoNeto = CalculadoraHipotecaSync.ObtenerSueldoNeto();
Console.WriteLine("\nSueldo neto: $"+ sueldoNeto);

var gastos = CalculadoraHipotecaSync.ObtenerGastosMensuales();
Console.WriteLine("\nGastos mensuales: $"+gastos);

var hipotecaConcedida = CalculadoraHipotecaSync.AnalizarInformacionParaConcederHipoteca(aniosDeVidaLaboral, esTipoDeContratoIndefinido, sueldoNeto, gastos, cantidadSolicitada:50000, aniosAPagar: 25);

//Signigica: si es true, se guarda Aprobada Y SI NO Denegada
var resultado = hipotecaConcedida ? "Aprobada" : "Denegada";

Console.WriteLine($"\nAnálisis finalizado. Su solicitud de hipotéca ha sido: {resultado} ");

sw.Stop();

Console.WriteLine("\nLa operación ha tardado: "+ sw.Elapsed);
*/
//Reiniciamos el contador de tiempo. Tareas asíncronas: 
sw.Restart();
Console.WriteLine("\n*********************************************");
Console.WriteLine("\nBienvenido a la calculadora de Hipotécas Asíncrona");
Console.WriteLine("\n*********************************************");

Task <int> aniosDeVidaLaboralTask = CalculadoraHipotecaAsync.ObtenerAnosDeVidaLaboral();

Task <bool> esTipoDeContratoIndefinidoTask = CalculadoraHipotecaAsync.EsTipoDeContratoIndefinido();

Task <int> sueldoNetoTask = CalculadoraHipotecaAsync.ObtenerSueldoNeto();

Task <int> gastosTask = CalculadoraHipotecaAsync.ObtenerGastosMensuales();

//Arma una lista con estas tareas.
var analisisHipotecasTasks = new List<Task>
{
    aniosDeVidaLaboralTask,
    esTipoDeContratoIndefinidoTask,
    sueldoNetoTask,
    gastosTask
};


//Se ejecutará mientras haya tareas pendientes
while (analisisHipotecasTasks.Any())
{
    Task tareaFinalizada = await Task.WhenAny(analisisHipotecasTasks);

    if (tareaFinalizada == aniosDeVidaLaboralTask)
    {
        Console.WriteLine("\nAños de vida laboral obtenidos: " + aniosDeVidaLaboralTask.Result);
    }
    else if (tareaFinalizada == esTipoDeContratoIndefinidoTask)
    {
        Console.WriteLine("\nTipo de contrato indefinido: " + esTipoDeContratoIndefinidoTask.Result);
    }
    else if (tareaFinalizada == sueldoNetoTask)
    {
        Console.WriteLine("\nSueldo neto: $" + sueldoNetoTask.Result);
    }

    else if (tareaFinalizada == gastosTask)
    {
        Console.WriteLine("\nGastos mensuales: $" + gastosTask.Result);

    }
    //Esto hace que se vaya printeado en el orden en que van terminando.
    //Si se completa alguna se printea eso, y luego la quita de la lista.
    //Solo si sale del bucle (es decir, si terimna todas las tareas), pasa a la tarea siguiente. 
    //Igual sin el bucle la app no se rompe.
    analisisHipotecasTasks.Remove(tareaFinalizada);
}

    var hipotecaConcedidaAsync = CalculadoraHipotecaAsync.AnalizarInformacionParaConcederHipoteca(aniosDeVidaLaboralTask.Result, esTipoDeContratoIndefinidoTask.Result, sueldoNetoTask.Result, gastosTask.Result, cantidadSolicitada: 50000, aniosAPagar: 25);


    var resultadoAsync = hipotecaConcedidaAsync ? "Aprobada" : "Denegada";

    Console.WriteLine($"\nAnálisis asincrónico finalizado. Su solicitud de hipoteca ha sido: {resultadoAsync} ");

    sw.Stop();
    Console.WriteLine($"\nLa operación asíncrona ha durado {sw.Elapsed}");

    Console.ReadLine();
