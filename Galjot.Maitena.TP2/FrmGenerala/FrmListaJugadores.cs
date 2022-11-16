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
        public FrmListaJugadores()
        {
            InitializeComponent();
            lista = new ListaJugadores();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if(lista.ProbarConexion())
            {
                foreach (Jugador item in lista.Traer())
                {
                    this.lstJugadores.Items.Add(item);
                }
            }
        }

        
     
    }
}
