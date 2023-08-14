string nombre;
string apellido;
int edad;
string sabeProgramar;

Console.WriteLine("Introduzca el nombre de la persona:");
nombre = Console.ReadLine();
Console.WriteLine("Introduzca el apellido de la persona:");
apellido = Console.ReadLine();
Console.WriteLine("Introduzca la edad de la persona:");
edad=int.Parse(Console.ReadLine());
Console.WriteLine("Introduzca si la persona sabe programar: (si - no)");
sabeProgramar= Console.ReadLine();

string msj = $"La persona se llama {apellido}, {nombre}. Tiene {edad} años de edad y {sabeProgramar} sabe programar";

Console.WriteLine(msj);

