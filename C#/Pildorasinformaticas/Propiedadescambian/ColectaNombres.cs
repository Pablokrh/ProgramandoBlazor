using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Propiedadescambian
{
    public class ColectaNombres : INotifyPropertyChanged
    {
        private string nombre, apellido, nombre_completo;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged (string property) //cada vez que cambie alguna propiedad, se va a ejecutar este método
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;
                OnPropertyChanged("Nombre_Completo");
            }

        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; OnPropertyChanged("Nombre_Completo");}


        }
        public string Nombre_Completo
        {
            get { return nombre_completo= Nombre+ " "+ Apellido;}
            set {}

        }

    }
}
