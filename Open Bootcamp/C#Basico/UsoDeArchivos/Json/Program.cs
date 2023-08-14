//Conseguir un JSON de una API y usar su contenido
//Json es el formato de la API.

using System.Net;

//Creamos un request y un response para obtener el JSON que queremos.
//Request es la petición al servidor de la API
//El response es donde guardamos los datos.
HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://cat-fact.herokuapp.com/facts");
HttpWebResponse response = (HttpWebResponse)request.GetResponse();

//Creo un Stream
Stream streameo = response.GetResponseStream();
StreamReader reader= new StreamReader(streameo);

var json = reader.ReadToEnd();

Console.WriteLine(json);

int[][] matriz = new int [3][3];
matriz[0]= new int []{ 1,2,3};
matriz[1]= new int []{ 4,5,6};
matriz[2]= new int []{ 7,8,9};

for (int i = 0; i < matriz.GetLength(0); i++)
{
	for (int j = 0; j < 3; j++)
	{
        Console.Write(matriz[i][j]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine( "Cantidad de valores en la matriz "+ matriz.GetLength(1));
