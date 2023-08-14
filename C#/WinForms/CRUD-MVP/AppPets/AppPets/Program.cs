using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppPets.Model;
using AppPets.Presenter;
using AppPets.View;
using AppPets.Repositories;
using System.Configuration;

namespace AppPets
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConexion"].ConnectionString;

            IMainView view = new MainView();
            new MainPresenter(view, sqlConnectionString);           
            Application.Run((Form)view);
        }
    }
}
