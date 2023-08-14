using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JuegoCartas;

namespace WF_Juego_Cartas
{
    public partial class Form2 : Form
    {
        Mazo mazo;
        private List<Carta> cartasenemigo;

        public Form2()
        {
            InitializeComponent();
            mazo = new Mazo();
            ReparteAUsuario();
            ReparteaEnemigo();
           

        }

        private void ReparteAUsuario()
        {
            int aux = Randomizador.randomiza(0, mazo.MazoCartas.Count);
            lbl_num1.Text = Convert.ToString(mazo.MazoCartas[aux].Numero);
            lbl_palo1.Text = Convert.ToString(mazo.MazoCartas[aux].Palo);
            mazo.MazoCartas.RemoveAt(aux);

            aux = Randomizador.randomiza(0, mazo.MazoCartas.Count);
            lbl_num2.Text = Convert.ToString(mazo.MazoCartas[aux].Numero);
            lbl_palo2.Text = Convert.ToString(mazo.MazoCartas[aux].Palo);
            mazo.MazoCartas.RemoveAt(aux);

            aux = Randomizador.randomiza(0, mazo.MazoCartas.Count);
            lbl_num3.Text = Convert.ToString(mazo.MazoCartas[aux].Numero);
            lbl_palo3.Text = Convert.ToString(mazo.MazoCartas[aux].Palo);
            mazo.MazoCartas.RemoveAt(aux);
        }

        private void ReparteaEnemigo()
        {
            cartasenemigo = new List<Carta>();            

            int aux = Randomizador.randomiza(0, mazo.MazoCartas.Count);           
            cartasenemigo.Add(mazo.MazoCartas[aux]);
            mazo.MazoCartas.RemoveAt(aux);

            aux = Randomizador.randomiza(0, mazo.MazoCartas.Count);         
            cartasenemigo.Add(mazo.MazoCartas[aux]);
            mazo.MazoCartas.RemoveAt(aux);

            aux = Randomizador.randomiza(0, mazo.MazoCartas.Count);        
            cartasenemigo.Add(mazo.MazoCartas[aux]);
            mazo.MazoCartas.RemoveAt(aux);

            for (int i = 0; i < cartasenemigo.Count; i++)
            {
                MessageBox.Show(cartasenemigo[i].Numero+ " de "+ cartasenemigo[i].Palo);

            }
        }




    }

    



}
