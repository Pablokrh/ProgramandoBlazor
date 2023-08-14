using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace Pildoras_Linq_SQL_CRUD
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClasses1DataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();
            string miConexion = ConfigurationManager.ConnectionStrings["Pildoras_Linq_SQL_CRUD.Properties.Settings.PildorasLinqSQLCRUD"].ConnectionString;
            //Primero va el nombre del proyecto actual y al final el nombre de la cadena de conexiòn guardada
            dataContext = new DataClasses1DataContext(miConexion);
            //  InsertaEmpresas();
            //  InsertaEmpleados();
            // InsertaCargos();
            // InsertaEmpleadoCargo();
            //   ActualizaEmpleado();
            EliminaEmpleado();
        }

        public void InsertaEmpresas()
        {
            dataContext.ExecuteCommand("delete from Empresa");

            Empresa empresa1 = new Empresa();
            empresa1.Nombre = "Lanús";           
            dataContext.Empresa.InsertOnSubmit(empresa1);

            Empresa empresa2 = new Empresa();
            empresa2.Nombre = "Google";            
            dataContext.Empresa.InsertOnSubmit(empresa2);
            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.Empresa;    

        }

        public void InsertaEmpleados()
        {
            dataContext.ExecuteCommand("delete from Empleado");

            Empresa empresaLanús = dataContext.Empresa.First(empresucha => empresucha.Nombre.Equals("Lanús"));
            Empresa empresaGoogle = dataContext.Empresa.First(empresucha => empresucha.Nombre.Equals("Google"));

            List<Empleado> listaEmpleados = new List<Empleado>();
            listaEmpleados.Add(new Empleado { Nombre = "Pablo", Apellido = "Krojzl", EmpresaId = empresaLanús.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Lucas", Apellido = "Ocampo", EmpresaId = empresaGoogle.Id }); 
            listaEmpleados.Add(new Empleado { Nombre = "Jorge", Apellido = "Goirriarán", EmpresaId = empresaLanús.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Antonio", Apellido = "Fernández", EmpresaId = empresaGoogle.Id });
            dataContext.Empleado.InsertAllOnSubmit(listaEmpleados);
            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.Empleado;
        }

        public void InsertaCargos()
        {
            dataContext.ExecuteCommand("delete from Cargo");

            List<Cargo> listaCargos = new List<Cargo>();
            listaCargos.Add(new Cargo { NombreCargo = "Presidente/a" });
            listaCargos.Add(new Cargo { NombreCargo = "Secretario/a" });
            listaCargos.Add(new Cargo { NombreCargo = "Administrativo/a" });
            listaCargos.Add(new Cargo { NombreCargo = "Informático/a" });
            listaCargos.Add(new Cargo { NombreCargo = "Sicario/a" });
            listaCargos.Add(new Cargo { NombreCargo = "Jardinero/a" });
            dataContext.Cargo.InsertAllOnSubmit(listaCargos);
            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.Cargo;
           

        }

        public void InsertaEmpleadoCargo()
        {
            dataContext.ExecuteCommand("delete from CargoEmpleado");

            Empleado Pablo = dataContext.Empleado.First(emp => emp.Nombre.Equals("Pablo"));
            Empleado Lucas = dataContext.Empleado.First(emp => emp.Nombre.Equals("Lucas"));
            Empleado Jorge = dataContext.Empleado.First(emp => emp.Nombre.Equals("Jorge"));
            Empleado Antonio = dataContext.Empleado.First(emp => emp.Nombre.Equals("Antonio"));

            Cargo pre = dataContext.Cargo.First(carg => carg.NombreCargo.Equals("Presidente/a"));
            Cargo sec = dataContext.Cargo.First(carg => carg.NombreCargo.Equals("Secretario/a"));
            Cargo adm = dataContext.Cargo.First(carg => carg.NombreCargo.Equals("Administrativo/a"));
            Cargo inf = dataContext.Cargo.First(carg => carg.NombreCargo.Equals("Informático/a"));
            Cargo sic = dataContext.Cargo.First(carg => carg.NombreCargo.Equals("Sicario/a"));
            Cargo jar = dataContext.Cargo.First(carg => carg.NombreCargo.Equals("Jardinero/a"));

            CargoEmpleado cargoPablo = new CargoEmpleado();
            cargoPablo.Empleado = Pablo;
            cargoPablo.CargoId = pre.Id;

            CargoEmpleado cargoLucas = new CargoEmpleado();
            cargoLucas.Empleado = Lucas;
            cargoLucas.CargoId = inf.Id;

            CargoEmpleado cargoJorge = new CargoEmpleado();
            cargoJorge.Empleado = Jorge;
            cargoJorge.CargoId = sic.Id;

            CargoEmpleado cargoAntonio = new CargoEmpleado();
            cargoAntonio.Empleado = Antonio;
            cargoAntonio.CargoId = adm.Id;


            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.CargoEmpleado;
        }

        public void ActualizaEmpleado()
        {
            Empleado Lucas = dataContext.Empleado.First(emp => emp.Nombre.Equals("Lucas"));

            Lucas.Nombre = "Lucas Carlos";
            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.Empleado;

        }

        public void EliminaEmpleado()
        {
           Empleado Jorge= dataContext.Empleado.First(emp => emp.Nombre.Equals("Jorge"));
            dataContext.Empleado.DeleteOnSubmit(Jorge);
            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.Empleado;



        }

    }
}
