using System.IO;


try
{
    if ("miArchivo.txt" == null)
    {
        StreamWriter sw = new StreamWriter("miArchivo.txt");
        sw.WriteLine("Esta linea fue escrita en el momento:" + DateTime.Now);
        sw.Close();
    }

    else
    {
        StreamWriter sw = new StreamWriter("miArchivo.txt",true);
        //Ese booleano indica que se va a hacer un append. Es decir:
        //Se usa WriteLine pero no sobreescribe sino que agrega.
        sw.WriteLine("Esta linea fue escrita en el momento:" + DateTime.Now);
        sw.Close();
    }
    

}
catch (Exception ex)
{
    Console.WriteLine("Ha ocurrido un error: " + ex.Message);
}

string texto;

try
{
     StreamReader sr= new StreamReader("miArchivo.txt");
    //Si no se especifica la carpeta, busca en: C:\Users\Pcablo\Desktop\Programando\C#\Open Bootcamp\C#Basico\UsoDeArchivos\UsoDeArchivos\bin\Debug\net7.0\U
    var linea = sr.ReadLine();

    while (linea != null)
    {
        Console.WriteLine(linea);
        linea = sr.ReadLine();
    }
    sr.Close(); 
}

catch (Exception ex)
{
    Console.WriteLine("Ha ocurrido un error: "+ex.Message);
}
finally
//Esto se hace al final, salga bien o salga mal el try
{
    Console.WriteLine( "Final del try-catch-finally" );
}
