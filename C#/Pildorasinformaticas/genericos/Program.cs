using System;

namespace genericos
{
    class Program
    {
        static void Main(string[] args)
        {

            AlmacenObjetos <DateTime> Archivos = new AlmacenObjetos<DateTime>(4);
            
            Archivos.Agregar(new DateTime());
            Archivos.Agregar(new DateTime());
            Archivos.Agregar(new DateTime());
            Archivos.Agregar(new DateTime());
            Console.WriteLine(Archivos.getElemento(2));
            //El método no devuelve un string sino un object. 
            //Hay que hacer un casting 
            date NombrePersona = Archivos.getElemento(3);
            Console.WriteLine(NombrePersona);
            //supongase que quiera almacenar objetos de tipo empleado. La cosa se complica un poco mas.
           /* Archivos.Agregar(new Empleado(1500)); //de esta forma se abrevia un poco
            Archivos.Agregar(new Empleado(2330));
            Archivos.Agregar(new Empleado(2670));
            Archivos.Agregar(new Empleado(3200)); //hasta acá no da, hay que hacer un casting

            string salarioEmpleado = (Empleado)Archivos.getElemento(2);
            Console.WriteLine(salarioEmpleado.getSalario());*/
        }

         class AlmacenObjetos <T> //Por convención es una T. Se manejará cualquier tipo de objetos
        {
            public AlmacenObjetos (int z) //le llegarían cuántos objetos va a almacenar el array
            {
                datosElemento = new T [z]; 
            }

            public void Agregar (T Obj)
            {
                datosElemento[i] = Obj; //este es el objeto que se le pasa también por parámetro.
                i++;
            }

            public T getElemento (int i) //este entero especifica la posición del array de la cual quiero obtener información
            {
                return datosElemento[i];
            }


            private T [] datosElemento;
            private int i = 0; //contador
         }

        class Empleado
        {

            public Empleado (double salario)
            {
                this.salario = salario;
            }
            public double getSalario()
            {

                return salario;

            }
            private double salario;

        }

        //Lo que dice es que todo hereda de Object
    }
}
