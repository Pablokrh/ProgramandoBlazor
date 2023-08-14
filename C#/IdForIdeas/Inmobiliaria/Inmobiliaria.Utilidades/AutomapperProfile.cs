using Inmobiliaria.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Inmobiliaria.DTO;

namespace Inmobiliaria.Utilidades
{
    public class AutomapperProfile:Profile
    {
        public AutomapperProfile()        
        {

            CreateMap<Usuario, UsuarioDTO>();
            CreateMap<UsuarioDTO, Usuario>();
            CreateMap<SesionDTO, Usuario>();

            CreateMap<Inmueble, InmuebleDTO>();
            CreateMap<InmuebleDTO, Inmueble>();

            CreateMap<Imagen,  ImagenDTO>();
            CreateMap<ImagenDTO,  Imagen>();

        }
    }
}
