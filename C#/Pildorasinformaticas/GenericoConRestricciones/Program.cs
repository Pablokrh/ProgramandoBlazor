using System;

namespace GenericoConRestricciones
{
    class Program
    {
        static void Main(string[] args)
        {

            AlmacenEmpleados<Director> Empleados = new AlmacenEmpleados<Director>(3);
            Empleados.Agregar(new Director(4500));
            Empleados.Agregar(new Director(5000));
            Empleados.Agregar(new Director(15000));

            AlmacenEmpleados<Secretaria> EmpleaSecre = new AlmacenEmpleados<Secretaria>(6);
            EmpleaSecre.Agregar(new Secretaria(800));
            EmpleaSecre.Agregar(new Secretaria(750));
            EmpleaSecre.Agregar(new Secretaria(800));
            EmpleaSecre.Agregar(new Secretaria(820));
            EmpleaSecre.Agregar(new Secretaria(500));
            EmpleaSecre.Agregar(new Secretaria(350));



        }
    }


    interface IParaEmpleados
    {

        double getSalario();
    }


    class AlmacenEmpleados <T> where T:IParaEmpleados
    {
        //Esta clase es igual a la del video anterior de genericos, con la restricción de la lina anterior.
        public AlmacenEmpleados (int z)
        {

            DatosEmpleado = new T[z];
        }

        public void Agregar (T obj)
        {

            DatosEmpleado[i] = obj;
            i++;

        }

        public T GetEmpleado (int i)
        {

            return DatosEmpleado[i];
        }

        private int i = 0;
        private T[] DatosEmpleado;

    }


    class Director:IParaEmpleados
    {
        public Director (double salario)
        {
            this.salario = salario;

        }

        private double salario;

        public double getSalario()
        {
            return salario;
        }
    }


    class Secretaria : IParaEmpleados
    {
            public Secretaria (double salario)
        {
            this.salario = salario;

        }

        public double getSalario()
        {
            return salario;
        }
        private double salario;

    }

    class Electricista : IParaEmpleados
    {

        public Electricista(double salario)
        {
            this.salario = salario;

        }

        public double getSalario()
        {
            return salario;
        }
        private double salario;

    }


}
