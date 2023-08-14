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

namespace ComboBox_CheckBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Capitales> ListaCapitales = new List<Capitales>();
            ListaCapitales.Add(new Capitales { NombreCapital = "Madrid" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Bogotá" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Lima" });
            ListaCapitales.Add(new Capitales { NombreCapital = "México DF" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Brasilia" });
            Capitales.ItemsSource = ListaCapitales;
            
        }

        private void TodasC_Checked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = true;
            Bogota.IsChecked = true;
            Lima.IsChecked = true;
            MexicoDF.IsChecked = true;
            Brasilia.IsChecked = true;
        }

        private void TodasC_Unchecked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = false;
            Bogota.IsChecked = false;
            Lima.IsChecked = false;
            MexicoDF.IsChecked = false;
            Brasilia.IsChecked = false;
        }

        private void Individual_checked(object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == true && Bogota.IsChecked == true && Lima.IsChecked == true && MexicoDF.IsChecked == true && Brasilia.IsChecked == true)
                TodasC.IsChecked = true; //Esto hace que si se tildan todas, si ponga la tilde también en la de arriba.
            else
            {
                TodasC.IsChecked = null;//Esto hace que si se tilda una y no todas, aparezca el cuadradito(Null) arriba. Si se activa y se desactiva una casilla, el cuadradito persiste. 

            }
            
        }

        private void Individual_Unchecked (object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == false && Bogota.IsChecked == false && Lima.IsChecked == false && MexicoDF.IsChecked == false && Brasilia.IsChecked == false)
                TodasC.IsChecked = false; 
            else
            {
                TodasC.IsChecked = null; //Ahora si funciona todo bien

            }

        }
    }
    public class Capitales
    {
        public string NombreCapital { get; set; }
    }
}
