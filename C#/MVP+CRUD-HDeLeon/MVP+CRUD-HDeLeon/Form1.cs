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

namespace MVP_CRUD_HDeLeon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        #region HELPER
        private void Refrescar()
        {
            using (HDeLeonEntities1 db = new HDeLeonEntities1())
            //HDeLeonEntities es un nombre que se genera apenas se crea el ADO
            {
                var lst = from d in db.TablaUsuario
                          select d;
                dataGridView1.DataSource = lst.ToList();
            }
        }
        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Presentation.formTabla FormTabla = new Presentation.formTabla();
            FormTabla.ShowDialog();
            Refrescar();

        }

        private int? GetId(int? id)
        {
            try
            {
                return id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                //Acá se obtiene el Id de la fila seleccionada
            }
            catch { return null; }
        }

        private void btn_Click(object sender, EventArgs e)
        {

            int? id = 0;
            id= GetId(id);           

            if (id != null)
            {
                Presentation.formTabla formTabla = new Presentation.formTabla(id);
                //Acá se manda al constructor del otro formulario este Id
                formTabla.ShowDialog();
                Refrescar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = 0;
            id = GetId(id);
            using (HDeLeonEntities1 db = new HDeLeonEntities1())
            {
                TablaUsuario tablaUsuario = db.TablaUsuario.Find(id);
                db.TablaUsuario.Remove(tablaUsuario);
                db.SaveChanges();
            }
            Refrescar();
        }
    }
}
