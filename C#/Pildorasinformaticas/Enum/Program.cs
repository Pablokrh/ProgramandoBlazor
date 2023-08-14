using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado Jauria = new Empleado(Bonus.extra, 1900.60);
            Console.WriteLine("El salario de Jauria es: "+ Jauria.getSalario());
        }
    }

    class Empleado
    {

        public Empleado (Bonus BonusEmpleado, double Salario)
        {

            Bonus = (double)BonusEmpleado;
            this.Salario = Salario;

        } 
        public double getSalario()
        {
            return Salario + Bonus;
        }

        private double Salario, Bonus;
    }
    enum Bonus { bajo=500, normal=1000, bueno=1500, extra=3000}

}
