using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP_CRUD_HDeLeon.Models;

namespace MVP_CRUD_HDeLeon.Presentation
{
    public partial class formTabla : Form
    {
        private readonly int? _id;
        TablaUsuario tabla = null;
        //Se agrega este Id y la Tabla. El constructor recibe el parámetro y si Id es distinto
        //de 0 llena los textbox con la data de la BBDD
        public formTabla(int? id= null)
        {
            InitializeComponent();
            _id = id;
            if (_id != null) CargaDatos();
        }

        private void CargaDatos()
        {
            using (HDeLeonEntities1 db = new HDeLeonEntities1())
                tabla = db.TablaUsuario.Find(_id);
            txtCorreo.Text = tabla.Correo;
            txtNombre.Text = tabla.Nombre;
            dtpFechaNacimiento.Value = tabla.FechaNacimiento;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (HDeLeonEntities1 db = new HDeLeonEntities1())
            {
                
                if (_id == null)
                {
                     tabla = new TablaUsuario();
                    //TablaUsuario es el nombre que le di con SQLSERVERMANAGEMENT a la tabla
                }
                tabla.Nombre = txtNombre.Text;
                tabla.Correo = txtCorreo.Text;
                tabla.FechaNacimiento = dtpFechaNacimiento.Value;
                //Ahí captura la data de los textbox y los mando
                if (_id == null)
                {
                    db.TablaUsuario.Add(tabla);
                }

                else
                {
                    db.Entry(tabla).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
                //Con estos 2 ya los agrega a la BBDD
                this.Close();
            }
        }
    }
}
