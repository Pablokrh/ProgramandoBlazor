using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_MasCosas
{
    class Program
    {
        static void Main(string[] args)
        {
            God god = new God();
            int lineaAux = 0;
            bool valido;
            do
            {
                Console.Clear();
                valido = true;
                Console.WriteLine("Introduzca el N° de Id de la empresa para obtener la información de sus empleados:");
                string linea = Console.ReadLine();
                try
                {
                    lineaAux = int.Parse(linea);
                    if (lineaAux < 1 || lineaAux > 2)
                    {
                        valido = false;
                        Console.WriteLine("El número no coincide con ninguna de las empresas existentes");
                        Console.ReadKey();
                    }
                }

                catch (Exception)
                {
                    Console.WriteLine("¡¡Has introducido letritas melonazo!!");
                    valido = false;
                    Console.ReadKey();
                }
                
            } while (valido == false);

            god.GetEmpleadosEmpresa(lineaAux);
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

        public void ShowEmpleadosOrdenados()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados orderby empleado.Nombre select empleado;
            
            foreach (var item in empleados)
            {
                item.ShowDatosEmpleado();
            }


        }
        public void GetEmpleadosLanus()
        {
            IEnumerable<Empleado> empleadosLanus = from empleado in listaEmpleados join empresa in listaEmpresas on empleado.EmpresaId equals empresa.Id where empresa.Nombre=="Lanús" select empleado ;
            foreach (var item in empleadosLanus)
            {
                item.ShowDatosEmpleado();
            }

        }

        public void GetEmpleadosEmpresa(int Id)
        {
            IEnumerable<Empleado> empleadosLanus = from empleado in listaEmpleados join empresa in listaEmpresas on empleado.EmpresaId equals empresa.Id where empresa.Id == Id select empleado;
            //ahí agrego el Id que se pasa por parámetro para ver de qué empresa se trata.
            foreach (var item in empleadosLanus)
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
            Console.WriteLine("La empresa N° " + Id + " es " + Nombre);
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
            Console.WriteLine("El empleado N° " + Id + " es " + Nombre + ". Su cargo es " + Cargo + ", su salario es de $" + Salario + " y pertenece a la empresa " + EmpresaId);
        }
    }
}
