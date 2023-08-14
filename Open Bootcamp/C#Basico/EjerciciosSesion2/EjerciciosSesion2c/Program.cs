
int numMayorOIgual = 20;
Console.WriteLine("El número {0} es mayor o igual que 18",numMayorOIgual);
Console.WriteLine(numMayorOIgual>=18);
Console.WriteLine("-------------------------------\n");

char caracter = 'b';
Console.WriteLine("¿Es el carácter '{0}' igual a 'a'?", caracter);
Console.WriteLine(caracter=='a');
Console.WriteLine("-------------------------------\n");

char caracter2 = 'a';
Console.WriteLine("Es el número {0} mayor o igual que 18 y el carácter '{1}' igual a 'a'",numMayorOIgual,caracter2);
Console.WriteLine(numMayorOIgual>=18 && caracter2=='a');
Console.WriteLine("-------------------------------\n");

Console.WriteLine("Es el número {0} mayor o igual que 18 o el carácter '{1}' igual a 'a'", numMayorOIgual, caracter);
Console.WriteLine(numMayorOIgual >= 18 || caracter == 'a');