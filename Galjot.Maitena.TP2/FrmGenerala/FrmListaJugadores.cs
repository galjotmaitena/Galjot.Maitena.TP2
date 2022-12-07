using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDeClases;

namespace FrmGenerala
{
    public partial class FrmListaJugadores : Form
    {
        private ListaJugadores lista;
        private Jugador unJugador;
        private Jugador jugadorLogeado;

        public FrmListaJugadores(Jugador jugadorLogeado)
        {
            InitializeComponent();

            this.lista = new ListaJugadores();
            this.jugadorLogeado = jugadorLogeado;
        }

        public Jugador JugadorForm
        {
            get { return this.unJugador; }
        }

        private void FrmListaJugadores_Load(object sender, EventArgs e)
        {
            if (lista.ProbarConexion())
            {
                foreach (Jugador item in lista.Traer())
                {
                    if(item != this.jugadorLogeado)
                    {
                        this.lstJugadores.Items.Add(item);
                    }
                    
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int index = this.lstJugadores.SelectedIndex;

            if(index == -1)
            {
                return;
            }

            this.unJugador = (Jugador)this.lstJugadores.SelectedItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
