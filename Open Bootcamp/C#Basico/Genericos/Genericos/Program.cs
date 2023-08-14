Generic<String> str = new Generic<string>();
str.Campo = "Pepe";
Console.WriteLine(str.Campo); //="Pepe"
Console.WriteLine("Tipo de dato genérico: "+ str.Campo.GetType().Name);

public class Generic<T>
{
    public T Campo { get; set; }
}
/*
 * ESTAS 2 LINEAS AQUÍ DAN ERROR, ARRIBA ANDAN JOYA
Console.WriteLine(str.Campo); //="Pepe"
Console.WriteLine("Tipo de dato genérico: " + str.Campo.GetType().Name);
*/