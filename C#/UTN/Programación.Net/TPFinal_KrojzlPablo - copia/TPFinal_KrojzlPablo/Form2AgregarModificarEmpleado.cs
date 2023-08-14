using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entidades;
using ControladorTablas;

namespace TPFinal_KrojzlPablo
{
    public partial class Form2AgregarModificarEmpleado : Form
    {
        private readonly Form1 form1;
        private string[] casadoCombo;
        private List<Empleado> listEmpleados;
        string nombreCompleto = "";
        string dni = "";
        int edad = 0;
        int id = 0;
        bool casado = false;
        decimal salario = 0;
        bool modificar;
        private string mbox = "¿Está seguro que desea agregar al empleado?";
        Class1 class1;
        Empleado empleado;

        List<string> msjError = new List<string>();


        public Form2AgregarModificarEmpleado(Form1 form1, List<Empleado>listaEmpleados)
        {
            InitializeComponent();
            this.form1 = form1;
            class1 = new Class1();
            listEmpleados = listaEmpleados;
            casadoCombo = new string[2] { "Soltero", "Casado" };
            cbCasado.DataSource = casadoCombo;            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Hide();
            form1.Show();
        }

        public void ModificarEmpleado(Empleado emp, int id)
        {
            empleado = emp;
            mbox = "¿Está seguro que desea actualizar los datos del empleado?";
            modificar = true;        
            txtDni.SelectedText = emp.Dni;
            txtEdad.Text = emp.Edad.ToString();
            txtNombreCompleto.Text = emp.NombreCompleto;;
            txtSalario.Text = emp.Salario.ToString();
            this.id = id;
            if (emp.Casado == true) cbCasado.SelectedItem = "Casado";
            else cbCasado.SelectedItem = "Soltero";

            if (emp.Casado == true) cbCasado.SelectedItem = "Casado";
            else cbCasado.SelectedItem = "Soltero";

        }

        public void SeleccionaCampos()
        {
           msjError.Clear();

            try
            {
                nombreCompleto = txtNombreCompleto.Text;
                if (nombreCompleto.Trim() == "") msjError.Add("Has dejado vacío el campo 'Nombre Completo' ");
            }

            catch (Exception ex)
            {
                msjError.Add(ex.Message);
            }
            try
            {
                dni = txtDni.Text;
                if (dni.Trim() == "") msjError.Add("Has dejado vacío el campo 'DNI' ");
                else
                {
                    if ((long.TryParse(dni, out long aux) == false) || int.Parse(dni) < 0) msjError.Add("En el campo 'DNI' debes ingresar un valor númerico válido");
                }
            }
            catch (Exception ex)
            {
                msjError.Add(ex.Message);
            }

            try
            {
                if ((txtEdad.Text).Trim() == "") msjError.Add("Has dejado vacío el campo 'Edad' ");
                else
                {
                    edad = int.Parse(txtEdad.Text);
                    if (edad < 16) msjError.Add("La edad ingresada no es válida");
                }

            }
            catch (FormatException)
            {
                msjError.Add("En el campo 'Edad' debes ingresar un valor númerico válido");
            }
            catch (Exception ex)
            {
                msjError.Add(ex.Message);
            }

            try
            {
                if ((txtSalario.Text).Trim() == "") msjError.Add("Has dejado vacío el campo 'Salario' ");
                else
                {
                    salario = decimal.Parse(txtSalario.Text);
                    if (salario <= 0) msjError.Add("El salario ingresado no es válido");
                }
            }
            catch (FormatException)
            {
                msjError.Add("En el campo 'Salario' debes ingresar un valor númerico válido");
            }
            catch (Exception ex)
            {
                msjError.Add("Salario: " + ex.Message);
            }
            
            if (cbCasado.Text.ToString() == "Casado") casado = true;
            else casado = false;     

        }

        private void btnAgregarModificar_Click(object sender, EventArgs e)
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
                    if (modificar == false)
                    {
                        if (class1.DNIExistente(dni) == false)
                        {
                            listEmpleados = (class1.AgregarEmpleado(nombreCompleto, dni, edad, casado, salario));
                            MessageBox.Show("Empleado agregado correctamente" + Environment.NewLine + "Nombre completo: " + nombreCompleto + " DNI: " + dni + " Edad: " + edad + Environment.NewLine + "Salario: $" + salario + " Casado: " + casado);
                        }

                        else
                        {
                            MessageBox.Show("Ya se enuentra registrado un empleado con el DNI suministrado" + Environment.NewLine + "Por favor, revisar los datos");
                        }

                    }
                    else
                    {
                        if (txtDni.Text!= empleado.Dni && class1.DNIExistente(dni) == true)
                        {
                            MessageBox.Show("Ya se enuentra registrado un empleado con el DNI suministrado" + Environment.NewLine + "Por favor, revisar los datos");
                        }

                        else
                        {
                            listEmpleados = class1.ModificarEmpleado(nombreCompleto, dni, edad, casado, salario, id);
                            MessageBox.Show("Empleado modificado correctamente" + Environment.NewLine + "Nombre completo: " + nombreCompleto + " DNI: " + dni + " Edad: " + edad + Environment.NewLine + "Salario: $" + salario + " Casado: " + casado);
                        }
                    }
                }
            }
                form1.MostrarEmpleados(listEmpleados);
            
        }
    
        private void btncasado_Click(object sender, EventArgs e)
        {
            MessageBox.Show((txtcasado2.Checked).ToString());
        }

    }
}
