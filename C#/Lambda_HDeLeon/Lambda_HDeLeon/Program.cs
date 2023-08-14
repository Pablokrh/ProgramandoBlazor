
using System.ComponentModel.Design;
using System.Threading.Channels;

Func<int, int> b = (a) => a * 2;
Console.WriteLine( b(4));
/* b es el nombre de la variable. El 4 es el parámetro que se pasa a la función.
 * El primer int representa el input, el segundo el output
 * Dice HDeLeon que b es un delegado
 * El return está implícito
 
 */

Func<int, int, int> multiplica = (a, c) => a * c;
Console.WriteLine(multiplica(4, 5));
//Ahí le paso 2 parámetros.

Console.WriteLine("------------------------------------"+Environment.NewLine);
//Sentencias lambda. Con mas de una linea, llaves y un return explícito.

Func<int, int, int> mayor = (a, c) =>
{
    if (a > c) return a;
    else if (a < c) return c;
    else return 0;
};
int result = mayor(4, 10);

Console.WriteLine(result);

Console.WriteLine("------------------------------------" + Environment.NewLine);

//Ahora algo mas jodido:

List<int> numeros = new List<int>() { 3,6,7,4,1,10,9,8};

Func<int, bool> ObtenPares = (numero) => numero % 2 == 0;

var pares = numeros.Where(ObtenPares);

foreach (var item in pares)
{
    Console.Write(item + " . ");
}

Action<int> Printeo = (numero) => Console.WriteLine("\n----------------------------------------\n" + numero);
Printeo(5);
Printeo(12);

Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_\n");
Action<List<int>> PrinteaLista = (lista) =>
{
    lista.ForEach(item => Console.Write(item+" - "));
};
PrinteaLista(numeros);

Console.WriteLine("\n-------------------------------------\n");
//Funcion que recibe por parámetro otra funcion (Oooohhhh!!!)
Func<int, Func<int, int>, int> FuncionSuperior = (numero, FuncionInferior) =>
{
    if (numero > 100)
    {
        return FuncionInferior(numero);
    }
    else return numero; 

};
var res = FuncionSuperior(600, n => n * 2);
//  n=>n*2 es la segunda funcion, la de orden inferior.
Console.WriteLine(res);



