using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCanasta SC = new ShoppingCanasta(new DocTxT(), new TarjetaDeCredito());
            SC.Comprar(new Shopping());
            Console.WriteLine("-----------------------------------\n");
            ShoppingCanasta SC2 = new ShoppingCanasta(new SqlDatabase(), new TarjetaDeCredito());
            SC2.Comprar(new Shopping());
            Console.ReadKey();
        }
    }

    public class Shopping
    {
        
    }

    public class ShoppingCanasta
    {
        private IPersistencia persistencia;
        private IFormaDePago formaDePago;

        public ShoppingCanasta(IPersistencia persistencia, IFormaDePago formaDePago)
        {
            this.formaDePago = formaDePago;
            this.persistencia = persistencia;
        }

        public void Comprar(Shopping shopping)
        {
            persistencia.Save(shopping);
            formaDePago.Pagar(shopping);
        }
    }

    public interface IPersistencia
    {
         void Save(Shopping shopping);
        void InformaPersistencia();

    }

    public class DocTxT : IPersistencia
    {
        public void Save(Shopping shopping)
        {
            InformaPersistencia();
        }

        public void InformaPersistencia()
        {
            Console.WriteLine("Se está 'persistiendo' desde un Doc.Txt");
        }
    }

    public class SqlDatabase:IPersistencia
    {
        public void Save (Shopping shopping)
        {
            InformaPersistencia();
        }
          public void InformaPersistencia()
        {
            Console.WriteLine("Se está 'persistiendo' desde una BBDD Sql");
        }
    }

    public interface IFormaDePago
    {
        void Pagar(Shopping shopping);
        void InformaMedioDePago();
    }
     
    public class TarjetaDeCredito:IFormaDePago
    {
        public void Pagar (Shopping shopping)
        {
            InformaMedioDePago();
        }

        public void InformaMedioDePago()
        {
            Console.WriteLine("Se realizó la transacción por tarjeta de crédito");
        }
    }


}
