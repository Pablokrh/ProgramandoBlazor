using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria.DTO;

public partial class UsuarioDTO
{
    public int IdUsuario { get; set; }

    [Required(ErrorMessage ="Ingresar nombre completo")]
    public string? NombreCompleto { get; set; }

    [Required(ErrorMessage = "Ingresar correo electrónico")]

    public string? Correo { get; set; }

    [Required(ErrorMessage = "Ingresar contraseña")]

    public string? Clave { get; set; }

    [Required(ErrorMessage = "Ingresar confirmación de contraseña")]
    //Esto se agrega, no está presenta en model
    public string? ConfirmarClave { get; set; }

    public string? Rol { get; set; }

    public DateTime? FechaCreacion { get; set; }
}
