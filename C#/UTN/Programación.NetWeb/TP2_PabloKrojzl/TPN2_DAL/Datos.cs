using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN2_DAL
{
    public class Datos
    {

        public string HolaMundo(string opcion)
        {
            switch (opcion)
            {
                case "Español":
                    return "Hola mundo";

                case "Portugués":
                    return "Olá mundo";

                case "Inglés":
                    return "Hello world";

                case "Japonés":
                    return "こんにちは世界";

                case "Chino":
                    return "你好世界";

                case "Alemán":
                    return "Hallo Welt";

                case "Francés":
                    return "salut monde";

                case "Ruso":
                    return "Привет, мир";
                default:
                    return null;
            }

        }

    }
}
