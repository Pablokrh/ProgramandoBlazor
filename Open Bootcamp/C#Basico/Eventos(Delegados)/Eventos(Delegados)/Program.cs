using System.Diagnostics;
using System.Linq;

SuscriptorCalc calculadora = new SuscriptorCalc(15,8);
calculadora.ResultadoSuma();
calculadora.ResultadoResta();

public class EdictorCalc
{
    public delegate void EjemploDelegado();
    //Esta linea y la que vienen van juntas.
    public event EjemploDelegado ejemploEvento;

    public void Sumar (int a, int b)
    {
        if (ejemploEvento != null)
        {
            ejemploEvento();
            Console.WriteLine(  $"La suma es : {a+b}");

        }
        else
        {
            Console.WriteLine(  "No tienes una suscripción al evento");
        }

    }

    public void Restar(int a, int b)
    {
        if (ejemploEvento != null)
        {
            ejemploEvento();
            Console.WriteLine($"La resta es : {a - b}");

        }
        else
        {
            Console.WriteLine("No tienes una suscripción al evento");
        }

    }

    public void Saludar()
    {
        Console.WriteLine("¡Saludos, gran capitano!");
    }
}

//Suscriptor
public class SuscriptorCalc
{
    EdictorCalc editor;
    private readonly int A;
    private readonly int B;

    public void EventHandler()
    {
        Console.WriteLine("Se imprime el resultado de la operación:");
    }

    public SuscriptorCalc(int A, int B)
    {
        editor = new EdictorCalc();
        this.A = A;
        this.B = B;
        editor.ejemploEvento += EventHandler;
    }
    public void ResultadoSuma()
    {
        editor.Sumar(A, B);
        Console.Write("Qué bien que hayas elegido sumar... ");
        editor.Saludar();
    }

    public void ResultadoResta()
    {
        editor.Restar(A, B);
        Console.Write("Bue, falta y resto yo... ");
        editor.Saludar();
    }
}
