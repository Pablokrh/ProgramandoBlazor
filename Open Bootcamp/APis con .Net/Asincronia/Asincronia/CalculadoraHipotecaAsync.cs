using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asincronia
{
    public static class CalculadoraHipotecaAsync
    {

        public static async Task<int> ObtenerAnosDeVidaLaboral()
        {
            Console.WriteLine("\nObteniendo años de vida laboral...");
            await Task.Delay(5000);
            //Simula un proceso que demora 5 segundos.
            return new Random().Next(1, 35);
        }

        public static async Task <bool> EsTipoDeContratoIndefinido()
        {
            Console.WriteLine("\nVerificando si el tipo de contrato es indefinido...");
            await Task.Delay(5000);
            return (new Random().Next(1, 10)) % 2 == 0;
        }

        public static async Task <int> ObtenerSueldoNeto()
        {
            Console.WriteLine("\nObteniendo sueldo neto...");
            await Task.Delay(4000);
            return (new Random().Next(800, 6001));
        }

        public static async Task <int> ObtenerGastosMensuales()
        {
            Console.WriteLine("\nObteniendo gastos mensuales...");
            await Task.Delay(6000);
            return (new Random().Next(200, 1000));
        }

        //Este no es asincrónico
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


            if (cuota >= sueldoNeto || cuota > (sueldoNeto / 2))
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
