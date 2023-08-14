using static System.Runtime.InteropServices.JavaScript.JSType;

Cliente cliente = new Cliente();
cliente.NombreCompleto = "Pablo Krojzl";
cliente.Telefono = "541159123081";
cliente.Direccion = "Venezuela 3558";
cliente.Email = "pablokrh@gmail.com";
cliente.EsClienteNuevo = true;
Console.WriteLine(cliente.Imprimedatos());


public struct Cliente
{
    public string NombreCompleto { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }
    public string Email { get; set; }
    public bool EsClienteNuevo { get; set; }

  public string Imprimedatos()
    {
        return "Cliente " + NombreCompleto + ". Número de teléfono: " + Telefono + " .Dirección: " + Direccion +
            ". Email: " + Email + " . Cliente nuevo: " + EsClienteNuevo;
    }

}
    