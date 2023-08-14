using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos.CorreoElectronico
{
   public class SystemSupportMail:ServidorDeCorreoMaestro
    {

        public SystemSupportMail()
        {
            senderMail = "Pablo.Krojzl@gmail.com";
            password = "nzgsyjbgcjncwfip";
            host = "smtp.gmail.com";
            port =587;
            ssl = true;
            IntializeSmtpClient();
        }

        //Afirma que acá se pueden escribir msgs automáticos para enviar notificaciones, etc.

    }
}
