using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vinci_Ejercicio_Id
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            String nombre= ObtenNombre.ObtenerNombre(txtId.Text);
            lblNombre.Text = nombre;

        }
    }

    public static  class ObtenNombre
    {
        public static string ObtenerNombre(string id)
        {
            int idNumerica = int.Parse(id);
            IdNombres Id = new IdNombres();
            String nombre= Id.NombrePorId (idNumerica);
            return nombre;
        }


    }




    public class IdNombres
    
    {
        SortedList<int, string> NombreListaId;
        string nombre;



        public string NombrePorId (int id)
        {
            NombreListaId = new SortedList<int, string>();
            NombreListaId.Add(1, "Juana");
            NombreListaId.Add(2, "Jorge");
            NombreListaId.Add(3, "Matías");
            NombreListaId.Add(4, "Salomón");
            NombreListaId.Add(5, "Julián");
            NombreListaId.Add(6, "Pepe");
            NombreListaId.Add(7, "Joshua");
            NombreListaId.Add(8, "Martina");
            NombreListaId.Add(9, "Cecilia");
            NombreListaId.Add(10, "Pedro");


            foreach (KeyValuePair<int,string> tt in NombreListaId)
            {
                if (tt.Key == id)
                {
                    nombre= tt.Value;

                }
                

            }
            return nombre;


        }



    }







}
