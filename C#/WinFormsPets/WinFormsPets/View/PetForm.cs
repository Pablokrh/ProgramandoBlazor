using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppPets.View
{
    public partial class PetForm : Form, IPetView
    {

        public PetForm()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate {searchEvent.Invoke(this, EventArgs.Empty); };
            
            txtSearchTab2.KeyDown += (s, e) =>
            {                
                 if (e.KeyCode == Keys.Enter)
                     SearchEvent?.Invoke+=(this, EventArgs.Empty);

            };
        }

        string IPetView.PetId { get { return txtId.Text; } set { txtId.Text = value; } }
        string IPetView.PetName { get { return txtName.Text; } set { txtName.Text = value; } }
        string IPetView.PetColour { get { return txtColour.Text; } set { txtColour.Text = value; } }
        string IPetView.PetType { get { return txtType.Text; } set { txtType.Text=value; } }
        string IPetView.SearchValue { get { return txtSearchTab2.Text; } set { txtSearchTab2.Text = value; } }
        bool IPetView.IsEdit { get ; set ; }
        bool IPetView.IsSuccessful { get ; set ; }
        string IPetView.Message { get ; set ; }

        public event EventHandler SearchEvent
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

       public event EventHandler AddNewEvent
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        public event EventHandler EditEvent
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        public event EventHandler DeleteEvent
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        public event EventHandler SaveEvent
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        public event EventHandler CancelEvent
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        void IPetView.SetPetListBindingSource(BindingSource petList)
        {
            dataGridView1.DataSource = petList;
        }

        void IPetView.Show()
        {
            throw new NotImplementedException();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
