If @if=new If();
@if.Operaciones(500);

Console.Clear();
Ejercicio2 e = new Ejercicio2();
e.ConSwitch();

public class Ejercicio2
{
    public void ConSwitch()
    {
        Console.WriteLine("Seleccione el lenguaje deseado a través de su índice numérico:");
        Console.WriteLine("1 - C#");
        Console.WriteLine("2 - Java");
        Console.WriteLine("3 - JavaScript");
        Console.WriteLine("4 - Python");
        Console.WriteLine("5 - C++");
        
        int opcion=int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Has seleccionado C#");
                break;
            case 2:
                Console.WriteLine("Has seleccionado Java");
                break;
            case 3:
                Console.WriteLine("Has seleccionado JavaScript");
                break;
            case 4:
                Console.WriteLine("Has seleccionado Python");
                break;
            case 5:
                Console.WriteLine("Has seleccionado C++");
                break;
            default:
                break;

        }

    }


}

public class If
{
    public void Operaciones(double precio)
    {
        Console.WriteLine("Introduzca a continuación el nombre del cliente:");
        string nombre = Console.ReadLine();
        Console.WriteLine("Introduzca a continuación el Email del cliente:");
        string email = Console.ReadLine();
        Console.WriteLine("Introduzca a continuación si el cliente tiene un cupón de descuento: (si - no)");
        string aux = Console.ReadLine();
        bool cupon=false;

        if (aux == "si" || aux == "Si")
        {
            cupon = true;
        }
        else if (aux == "no" || aux == "No")
        {
            cupon = false;
        } 

        if (cupon)
        {
            precio = precio * 0.75;
            Console.WriteLine("El precio final (descuento incluido es de: $"+precio);
        }
        else Console.WriteLine("El precio final es de: $"+precio); 

    }


}