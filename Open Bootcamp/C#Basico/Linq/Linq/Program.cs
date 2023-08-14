//Origen de datos
int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//Obtener Datos
var pares=
    from numero in numeros
    where (numero%2 == 0)
    select numero;  
var impares=
      from numero in numeros
      where (numero % 2 != 0)
      select numero;
var numsAltos=
    from numero in numeros
    where (numero>5)
    select numero;

Console.WriteLine(  "Números pares:");
foreach (var item in pares)
{
    Console.Write(item+ " ");
}
Console.WriteLine("\nNúmeros impares:");

foreach (var item in impares)
{
    Console.Write(item + " ");
}
Console.WriteLine("\nNúmeros altos:");

foreach (var item in numsAltos)
{
    Console.Write(item + " ");
}
