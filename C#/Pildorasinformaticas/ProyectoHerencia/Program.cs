using System;

namespace ProyectoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo Babieca = new Caballo("Babieca");                    
            IMamíferosTerrestres IBabieca = Babieca; //Luego se usa el objeto creado para llamar en el console.e
            ISaltoConPatas IBabieca2 = Babieca;

            Lagartija Yoggy = new Lagartija("Yoggy");
            Humano Juan = new Humano("Juan");
            Gorila Copito = new Gorila("Copito");

            Yoggy.getNombre();

            Humano Jared = new Humano("Jared");
            Jared.getNombre();
            /*Mamiferos[] almacenAnimales = new Mamiferos[3];
            almacenAnimales[0] = Babieca;
            almacenAnimales[1] = Juan;
            almacenAnimales[2] = Copito;

            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].Religion();
            }
            Ballena myWally = new Ballena("Wally");
            myWally.nadar();
            Console.WriteLine("Número de patas de Babieca: " + IBabieca.NumeroPatas()); //Acá se llama al objeto recién creado
            Console.WriteLine("Número de patas con las que Babieca salta: " + IBabieca2.NumeroPatas());
        */}

    }

    abstract class Animales
    {

        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public abstract void getNombre();

    }

    class Mamiferos:Animales //Al poner :animales da error, ya que uno está obligado a desarrollar getNombre(); ya que solo está declarado.
    {
        public Mamiferos(String nombre) //el constructor
        {
            nombreSerVivo = nombre; //El constructor por defecto ha sido reemplazado por este que acabamos de crear. A partir de aquí las subclases marcarán error. Porque se cambió el constructor por defecto. Tienen que llamar al nuevo constructor.         
        }
        
        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías hasta que sean capaces");
        }

        public override void getNombre()
        {
            Console.WriteLine("El nombre del mamífero es: " + nombreSerVivo);
        }

        public virtual void Religion()
        {
            Console.WriteLine("Religión básica instintiva");
        }

        private String nombreSerVivo;
    }


    class Caballo : Mamiferos, IMamíferosTerrestres, IAnimalesYDeportes, ISaltoConPatas 
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo) //así se llama al nuevo constructor... Ahora marca error cuando instanciamos caballo babieca.  
        {

        }
        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
         int IMamíferosTerrestres.NumeroPatas()
        {
            return 4;
        }
        int ISaltoConPatas.NumeroPatas()
        {
            return 2;
        }

        public string TipoDeDeporte()
        {
            return ("Hípica");
        }
        public Boolean EsOlimpico()
        {
            return true;
        }
        
    }


    class Humano : Mamiferos, IMamíferosTerrestres, ISaltoConPatas
        {
        public Humano(String nombreHumano) : base(nombreHumano) { }
        public sealed override void Religion()
        {
            Console.WriteLine("Soy el mayor gil religioso");
        }
        int IMamíferosTerrestres.NumeroPatas()
        {
            return 2;
        }
        int ISaltoConPatas.NumeroPatas()
        {
            return 2;
        }
    }
    class Gorila :Mamiferos, IMamíferosTerrestres
    {
        public   Gorila (String nombreGorila): base(nombreGorila) { }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public override void Religion()
        {
            Console.WriteLine("Pensamiento religioso intermedio ");
        }
        public int NumeroPatas()
        {
            return 2;
        }

    }

    class Chimpance:Gorila
    {

        public Chimpance (string nombreChimpance) : base("nombreChimpance") { }

    } //Si se hubiera querido que gorila no herede a chimpance, había que:

    class Ballena : Mamiferos
    {
        public Ballena(String nombreBallena) : base(nombreBallena)// recibe por parámetro el string, y ese llama con la palabra base al constructor padre, pasándole su nombre.
        {

        }
        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }

    class Lagartija : Animales
    {
        public Lagartija (String nombre)
        {

            nombreReptil = nombre;

        }
        public override void getNombre()
        {
            Console.WriteLine("El nombre del reptil es: "+ nombreReptil);
        }
        private string nombreReptil; //para hacer esto crea el constructor de la clase.
    }
    interface IMamíferosTerrestres
        {
            int NumeroPatas(); //los métodos de una interfaz no se codean, no se desarrollan, solo se declaran. Tampoco llevan modificador de acceso.

        }
        interface IAnimalesYDeportes
        {
        string TipoDeDeporte();
        Boolean EsOlimpico();
        }
        interface ISaltoConPatas
        {
            int NumeroPatas();
        }
}
