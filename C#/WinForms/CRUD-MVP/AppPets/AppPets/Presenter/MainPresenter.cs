using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPets.Model;
using AppPets.View;
using AppPets.Repositories;

namespace AppPets.Presenter
{
    class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowPetView += ShowPetsView;
        }

        private void ShowPetsView(object sender, EventArgs e)
        {
            IPetView view = PetForm.GetInstance((MainView)mainView);
            //Linea de arriba es parte del singleton.
            IPetRepository repository = new PetRepository(sqlConnectionString);
            new PetPresenter(view, repository);
            //En esta linea de arriba está haciendo una inyección de dependencias. Cumpliendo también con la inversión de dependencias...
            //Ya que depende de abstracciones (interfaces) y no de detalles.
        }
    }
}
