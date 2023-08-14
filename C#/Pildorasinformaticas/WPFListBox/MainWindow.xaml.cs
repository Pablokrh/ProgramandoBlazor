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

namespace WPFListBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> ListaPob = new List<Poblaciones>(); //Acá crea una lista
            //Como se meten objetos (cada población) en la lista
            ListaPob.Add(new Poblaciones() { Poblacion1 = "Madrid", Temperatura1 = 15, Poblacion2 = "Barcelona", Temperatura2 = 17, Diferencia = 2 });
            ListaPob.Add(new Poblaciones() { Poblacion1 = "Lanús", Temperatura1 = 25, Poblacion2 = "Banfield", Temperatura2 = 2, Diferencia=23 });
            ListaPob.Add(new Poblaciones() { Poblacion1 = "Haedo", Temperatura1 = 18, Poblacion2 = "Morón", Temperatura2 = 19, Diferencia=1 });
            ListaPob.Add(new Poblaciones() { Poblacion1 = "Bariloche", Temperatura1 = 9, Poblacion2 = "Mendoza", Temperatura2 = 12, Diferencia=3 });
            listaPoblaciones.ItemsSource = ListaPob;
            //Ahí mismo instancia, o crea, los objetos que va a meter en la lista. Lo que después irá al listbox.
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (listaPoblaciones.SelectedItem != null)
            {
                MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + " °C " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + " °C ");
            }
            else
            {
                MessageBox.Show("Debes seleccionar un elemento");
            }
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (listaPoblaciones.SelectedItem != null)
            {
                MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + " °C " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + " °C ");
            }
            else
            {
                MessageBox.Show("Debes seleccionar un elemento");
            }
        }
    }
    public class Poblaciones
    {
        public string Poblacion1 { get; set; }

        public int Temperatura1 { get; set; }
        public string Poblacion2 { get; set; }
        public int Temperatura2 { get; set; }

        public int Diferencia { get; set; }
    }


}
