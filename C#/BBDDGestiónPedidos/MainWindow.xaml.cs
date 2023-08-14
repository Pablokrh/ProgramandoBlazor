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
using System.Data.SqlClient;
using System.Data;

namespace BBDDGestiónPedidos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly SqlConnection MiConexionSQL;
        //Ahí declara un objeto de la clase SqlConnection, posibilitada por la librería "using System.Data.SqlClient;" Esta linea podría ir al ppio.

        public MainWindow()
        {
            InitializeComponent();
            string MiConexion = ConfigurationManager.ConnectionStrings["BBDDGestiónPedidos.Properties.Settings.BBDDPreviaQuarkConnectionString"].ConnectionString;
            MiConexionSQL = new SqlConnection(MiConexion); //Acá instancia el objeto. Pasa ese string como parámetro al constructor.
            MostrarClientes();
            MuestraTodosPedidos();
        }

        private void MostrarClientes()
        {
            string consulta = "SELECT * FROM Cliente";
            //Ahora falta donde almacenar toda la info de la tabla. Ese string sería solo una linea.

            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, MiConexionSQL);

            using (miAdaptadorSql)
            {
                DataTable clientesTabla = new DataTable();
                //Datatable requiere de la libreria system.data. Con acciones rapidas y refactorizaciones se hace rápido
                //ahí se almacena toda la data.
                miAdaptadorSql.Fill(clientesTabla);
                //.Fill es un método.
                ListadoClientes.DisplayMemberPath = "Nombre";
                //esta linea señala que de la información de la tabla que "Nombre" es lo que se quiere ver en el listbox.
                ListadoClientes.SelectedValuePath = "Id";
                //Id se utilizará mucho luego, es un campo clave.
                ListadoClientes.ItemsSource = clientesTabla.DefaultView;
                //Se especifica de dónde viene toda la información del listbox.
            }
        }

        private void MuestraPedidos()
        {
            //Copia código del otro método muestra y luego modifica.

            string consulta = "SELECT * FROM Pedido P INNER JOIN Cliente C ON C.Id=P.cCliente" + " WHERE C.Id=@CLIENTEID";
            //Antes del WHERE dejé un espacio. Sin ese espacio, estalla la App.

            SqlCommand sqlComando = new SqlCommand(consulta, MiConexionSQL);

            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(sqlComando);
         
            using (miAdaptadorSql)
            {
                sqlComando.Parameters.AddWithValue("@CLIENTEID", ListadoClientes.SelectedValue);
                //Primero va el parámetro, después va el cliente del listbox sobre el cual se hace click.

                DataTable pedidosTabla = new DataTable();

                miAdaptadorSql.Fill(pedidosTabla);
                
                PedidosCliente.DisplayMemberPath = "fechaPedido";
                
                PedidosCliente.SelectedValuePath = "Id";
                //El campo clave no cambia
                PedidosCliente.ItemsSource = pedidosTabla.DefaultView;
            }
        }

        private void MuestraTodosPedidos()
        {
            string consulta = "SELECT *, CONCAT (cCliente, ' ',fechaPedido, ' ',formaPago) AS INFOTOTAL FROM Pedido";
          // Al agregar el asterisco, incluye todos los campos en la consulta. Si no, solamente se podría acceder a infototal, no a cada campo por su parte.
            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, MiConexionSQL);

            using (miAdaptadorSql)
            {
                DataTable pedidosTabla = new DataTable();
                //dice que es una especie de tabla virtual.
                miAdaptadorSql.Fill(pedidosTabla);

                TodosPedidos.DisplayMemberPath = "INFOTOTAL";
                //No se pueden concatenar con + o , los campos. *1
                //La novedad es que aquí se quieren mostrar los 3 campos (todos), no uno solo.
                TodosPedidos.SelectedValue = "Id";
                TodosPedidos.ItemsSource = pedidosTabla.DefaultView;
            }
        }



        private void ListadoClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MuestraPedidos();
        }

        private void eliminaPedido_Click(object sender, RoutedEventArgs e)
        {
          MessageBox.Show(TodosPedidos.SelectedValue.ToString());

            /*string consulta = "DELETE FROM Pedido WHERE Id=@PeI";

            SqlCommand miSqlComando = new SqlCommand(consulta, MiConexionSQL);

            MiConexionSQL.Open();

            miSqlComando.Parameters.AddWithValue("@PeI", TodosPedidos.SelectedValue);
        
            miSqlComando.ExecuteNonQuery();
            //Ejecuta este tipo de consultas.

            MiConexionSQL.Close();*/


            //Cierra la conexión.

            //Ejecuta la consulta, el delete
        }
    }
}
