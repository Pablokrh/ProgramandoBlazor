using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;

namespace Vista
{
    public partial class Form2AgregarEmpleado : Form
    {
        private readonly FormPrincipal form1;
        private string[] casadoCombo;
        private List<EmpleadoEntidades> listEmpleados;
        string nombreCompleto = "";
        string dni = "";
        int edad = 0;
        bool casado = false;
        decimal salario = 0;
        private string mbox = "¿Está seguro que desea agregar al empleado?";
        EmpleadoNegocios empleado;

        List<string> msjError = new List<string>();


        public Form2AgregarEmpleado(FormPrincipal form1, List<EmpleadoEntidades>listaEmpleados)
        {
            InitializeComponent();
            this.form1 = form1;
            empleado = new EmpleadoNegocios();
            listEmpleados = listaEmpleados;
            casadoCombo = new string[2] { "Soltero", "Casado" };
            cbCasado.DataSource = casadoCombo;            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Hide();
            form1.Show();
        }

        public void SeleccionaCampos()
        {
            msjError.Clear();     
            nombreCompleto = txtNombreCompleto.Text;
            if (nombreCompleto.Trim() == "") msjError.Add("Has dejado vacío el campo 'Nombre Completo' ");
                      
            dni = txtDni.Text;
            if (dni.Trim() == "") msjError.Add("Has dejado vacío el campo 'DNI' ");
            else
            {
                if (int.Parse(dni) < 0) msjError.Add("En el campo 'DNI' debes ingresar un valor númerico válido");
            }    
            
            
            if ((txtEdad.Text).Trim() == "") msjError.Add("Has dejado vacío el campo 'Edad' ");
            else
            {
                edad = int.Parse(txtEdad.Text);
                if (edad < 16) msjError.Add("La edad ingresada no es válida");
            }
            
            if ((txtSalario.Text).Trim() == "") msjError.Add("Has dejado vacío el campo 'Salario' ");
            else
            {
                salario = decimal.Parse(txtSalario.Text);
                if (salario <= 0) msjError.Add("El salario ingresado no es válido");
            }          
            
            if (cbCasado.Text.ToString() == "Casado") casado = true;
            else casado = false;     

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {           
                SeleccionaCampos();
            if (msjError.Count > 0)
            {
                string msj = "";
                foreach (var item in msjError)
                {
                    msj += item + Environment.NewLine;
                }
                MessageBox.Show(msj, "Datos no válidos");
            }
            else
            {
                if (MessageBox.Show(mbox, "Empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {                    
                        if (empleado.DNIExistente(dni) == false)
                        {
                            listEmpleados = (empleado.AgregarEmpleado(nombreCompleto, dni, edad, casado, salario));
                            MessageBox.Show("Empleado agregado correctamente" + Environment.NewLine + "Nombre completo: " + nombreCompleto + " DNI: " + dni + " Edad: " + edad + Environment.NewLine + "Salario: $" + salario + " Casado: " + casado);
                        }

                        else
                        {
                            MessageBox.Show("Ya se enuentra registrado un empleado con el DNI suministrado" + Environment.NewLine + "Por favor, revisar los datos");
                        }                    
                }
            }
                form1.MostrarEmpleados(listEmpleados);            
        }


    }
}
