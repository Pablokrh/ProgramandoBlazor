﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DTO
{
    public class TarjetaDTO
    {
        [Required(ErrorMessage = "Ingrese nombre del titular")]

        public string? Titular {get; set;}

        [Required(ErrorMessage = "Ingrese número de tarjeta")]

        public string? Numero { get; set;}

        [Required(ErrorMessage = "Ingrese vigencia")]

        public string? Vigencia { get; set;}

        [Required(ErrorMessage = "Ingrese código CVV")]

        public string? CVV { get; set;}
    }
}