using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppPets.Model;
using AppPets.View;
using AppPets.Presenter.Common;

namespace AppPets.Presenter
{
   public class PetPresenter
    {
        private IPetRepository repository;
        public IPetView view;
        private BindingSource petsBindingSource;
        private IEnumerable<PetModel> petList;
        //public PetPresenter(IPetRepository repository, IPetView view, BindingSource petsBindingSource, IEnumerable<PetModel> petList)
        //No se si me equivoqué o qué, pero antes el constructor era la linea de arriba

        public PetPresenter(IPetView view, IPetRepository repository)
        {
            this.repository = repository;
            this.view = view;
            petsBindingSource = new BindingSource();
           

            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchPet;
            this.view.AddNewEvent += AddNewPet;
            this.view.EditEvent += LoadSelectedPetToEdit;
            this.view.DeleteEvent += DeleteSelectedPet;
            this.view.SaveEvent += SavePet;
           // this.view.CancelEvent += CancelAction;

            //Set pets bindingSource
            this.view.SetPetListBindingSource(petsBindingSource);

            //Load pets list
            LoadAllPetList();

            //Show View
            this.view.Show();
        }

        //Methods. Son los que se van a realizar cuando alguno de los eventos se ejecuten.

        private void LoadAllPetList()
        {
            petList = repository.GetAll();
            petsBindingSource.DataSource=petList;
        }

        private void SearchPet(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                petList = repository.GetByValue(this.view.SearchValue);
            else petList = repository.GetAll();
            petsBindingSource.DataSource = petList;

        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SavePet(object sender, EventArgs e)
        {
            var model = new PetModel();
            model.Id = Convert.ToInt32(view.PetId);
            model.Name = view.PetName;
            model.Type = view.PetType;
            model.Colour = view.PetColour;
            try
            {
                new ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Pet edited successfully";   
                }

                else
                {
                    repository.Add(model);
                    view.Message = " Pet added successfully";
                }
                view.IsSuccessful = true;
                LoadAllPetList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        
        }

        private void CleanViewFields()
        {
            view.PetId = "0";
            view.PetName = "";
            view.PetType = "";
            view.PetColour = "";
        }

        private void DeleteSelectedPet(object sender, EventArgs e)
        {
            try
            {
                var pet = (PetModel)petsBindingSource.Current;
                repository.Delete(pet.Id);
                view.IsSuccessful = true;
                view.Message = "Pet deleted successfully";
                LoadAllPetList();
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not deleted pet";

            }        }

        private void LoadSelectedPetToEdit(object sender, EventArgs e)
        {
            var pet = (PetModel)petsBindingSource.Current;
            view.PetId = pet.Id.ToString();
            view.PetName = pet.Name;
            view.PetType = pet.Type;
            view.PetColour = pet.Colour;
            view.IsEdit = true;
        }

        private void AddNewPet(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

       
    }
}
