using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            God god = new God();
            god.GetBoxeador();
            Console.ReadKey();
        }
    }
    class God
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;

        public God()
        {
            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "Lanús" });
            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "RapiRobo" });
            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Carlos Ireneo", Cargo = "Panquequero", Salario = 25800, EmpresaId = 1 });
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Juán Díaz", Cargo = "Boxeador", Salario = 30000, EmpresaId = 2 });
            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "Roberto Nazario", Cargo = "Administrativo", Salario = 500000, EmpresaId = 1 });
            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "Luis Miguel Majul", Cargo = "Trapeador", Salario = 1250000, EmpresaId = 2 });
        }

        public void GetBoxeador()
        {
            IEnumerable<Empleado> boxeadores = from empleado in listaEmpleados where empleado.Cargo == "Boxeador" select empleado;

            foreach (var item in boxeadores)
            {
                item.ShowDatosEmpleado();
            }
        }
    }

    public class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public void ShowDatosEmpresa()
        {
            Console.WriteLine("La empresa N° "+ Id+ " es " + Nombre);
        }
    }

    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        //Clave foránea
        public int EmpresaId { get; set; }

        public void ShowDatosEmpleado()
        {
            Console.WriteLine("El empleado N° " + Id + " es " + Nombre + ". Su cargo es "+ Cargo + ", su salario es de $"+Salario + " y pertenece a la empresa "+ EmpresaId);
        }
    }

}
