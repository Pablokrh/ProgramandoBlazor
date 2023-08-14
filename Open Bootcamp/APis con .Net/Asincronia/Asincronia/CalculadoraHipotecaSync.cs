using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asincronia
{
    public static class CalculadoraHipotecaSync
    {
        public static int ObtenerAnosDeVidaLaboral()
        {
            Console.WriteLine("\nObteniendo años de vida laboral...");
            Task.Delay(5000).Wait();
            //Simula un proceso que demora 5 segundos.
            return new Random().Next(1,35);
        }

        public static bool EsTipoDeContratoIndefinido()
        {
            Console.WriteLine("\nVerificando si el tipo de contrato es indefinido...");
            Task.Delay(5000).Wait();
            return (new Random().Next(1,10)) % 2 == 0;
        }

        public static int ObtenerSueldoNeto()
        {
            Console.WriteLine("\nObteniendo sueldo neto...");
            Task.Delay(4000).Wait();
            return (new Random().Next(800, 6001));
        }

        public static int ObtenerGastosMensuales()
        {
            Console.WriteLine("\nObteniendo gastos mensuales...");
            Task.Delay(6000).Wait();
            return (new Random().Next(200, 1000));
        }

        public static bool AnalizarInformacionParaConcederHipoteca(
            int anosDeVidaLaboral,
            bool tipoDeContratoEsIndefinido,
            int sueldoNeto,
            int gastosMensuales,
            int cantidadSolicitada,
            int aniosAPagar
            )
        {
            Console.WriteLine("\nAnalizando información para conceder hipóteca...");
            if (anosDeVidaLaboral < 2)
            {
                return false; 
            }

            var cuota = (cantidadSolicitada / aniosAPagar) / 12;


            if (cuota>=sueldoNeto || cuota> (sueldoNeto / 2))
            {
                return false;
            }

            var PorcentajeGastoSobreSueldo = ((gastosMensuales * 100) / sueldoNeto);
            if (PorcentajeGastoSobreSueldo > 30)
            {
                return false;
            }
            if ((cuota + gastosMensuales) >= sueldoNeto)
            {
                return false;
            }

            if (!tipoDeContratoEsIndefinido)
            {
                if ((cuota + gastosMensuales) > (sueldoNeto / 3))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;

        }
    }
}
