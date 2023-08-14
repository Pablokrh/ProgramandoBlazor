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

namespace Primera_Interfaz
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid miGrid = new Grid();
            this.Content = miGrid;
            Button miBoton = new Button();
            WrapPanel miWrap = new WrapPanel();
            miBoton.Width=200;
            miBoton.Height=100;
            TextBlock txt1 = new TextBlock(); //Aquí se instancia un objeto de tipo textblock
            TextBlock txt2 = new TextBlock();
            TextBlock txt3 = new TextBlock();
            txt1.FontSize = 15;
            txt2.FontSize = 15;
            txt3.FontSize = 15;
            txt1.Text = " Click "; //Acá se le da el valor este
            miWrap.Children.Add(txt1); //Acá le agrega el txt a Wrap
           
            txt2.Text = " Enviar ";
            miWrap.Children.Add(txt2);

            txt3.Text = " Muerte!!! ";
            miWrap.Children.Add(txt3);
            miBoton.Content = miWrap;


            miGrid.Children.Add(miBoton); //Children porque es el hijo del Grid
        
        }



    }
}
