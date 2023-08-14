using System.Runtime.CompilerServices;

Singleton s1 = Singleton.GetInstance();
Singleton s2 = Singleton.GetInstance();


if (s1 == s2)
{
    Console.WriteLine( "Singleton funciona");
}
else Console.WriteLine( "Singleton falló...Las instancias son distintas");

public sealed class Singleton
    //Sealed es porque no se la puede instanciar
{
    static Singleton() {}

    private static Singleton _instance;

    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            new Singleton();
        }
        return _instance;
    }
    public static void MiMetodo()
    {
        Console.WriteLine(  "Saludos, desde MiMetodo");
    }


}