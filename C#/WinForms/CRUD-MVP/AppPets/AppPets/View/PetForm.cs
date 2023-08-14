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
            tabControl1.TabPages.Remove(tabdetail);
            btnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Search
            btnSearch.Click += delegate {SearchEvent.Invoke(this, EventArgs.Empty); };
            
            txtSearchTab2.KeyDown += (s, e) =>
            {                
                 if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke (this, EventArgs.Empty);

            };
            /* ESTO DA ABAJO SERÍA LA VERSIÓN LARGA DE LO DE ARRIBA 
            if (SearchEvent != null)
            {
                SearchEvent(this, EventArgs.Empty);

            }
            */

            //Add
            btnAdd.Click += delegate { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabList);
                tabControl1.TabPages.Add(tabdetail);
                tabdetail.Text = "Add new pet";
            };

            //Edit
            btnEdit.Click += delegate { 
                
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabList);
                tabControl1.TabPages.Add(tabdetail);
                tabdetail.Text = "Edit pet";

            };

            //Save changes
            btnSave.Click += delegate {
                SaveEvent?.Invoke(this, EventArgs.Empty);
            if (IsSuccessful == true)
                {
                    tabControl1.TabPages.Remove(tabdetail);
                    tabControl1.TabPages.Add(tabList); 
                }
                MessageBox.Show(Message);
            };
            /*
            //Cancel
            btnCancel.Click += delegate { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabdetail);
                tabControl1.TabPages.Add(tabList);


            };
            */
            //Delete
            btnDelete.Click += delegate { 
               var result= MessageBox.Show("Are you sure you want to delete the selected pet?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);

                }
            };



        }

        string IPetView.PetId { get { return txtId.Text; } set { txtId.Text = value; } }
        string IPetView.PetName { get { return txtName.Text; } set { txtName.Text = value; } }
        string IPetView.PetColour { get { return txtColour.Text; } set { txtColour.Text = value; } }
        string IPetView.PetType { get { return txtType.Text; } set { txtType.Text=value; } }
        string IPetView.SearchValue { get { return txtSearchTab2.Text; } set { txtSearchTab2.Text = value; } }
        public bool IsEdit { get ; set ; }
        public bool IsSuccessful { get ; set ; }
        public string Message { get ; set ; }

        public event EventHandler SearchEvent;

        public event EventHandler AddNewEvent;

        public event EventHandler EditEvent;

        public event EventHandler DeleteEvent;

        public event EventHandler SaveEvent;
        /*
        public event EventHandler CancelEvent;
        */

        void IPetView.SetPetListBindingSource(BindingSource petList)
        {
            dataGridView1.DataSource = petList;
        }

        void IPetView.Show()
        {
            Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        //Singleto pattern (Open solo una instancia del formulario

        //El nombre del formulario de RJ Code es PetView, no este
        private static PetForm instance;
        
        public static PetForm GetInstance(Form parentContainer)
        {
            if (instance==null || instance.IsDisposed)
            {
                instance = new PetForm();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }

            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabdetail);
            tabControl1.TabPages.Add(tabList);
        }
    }
}
