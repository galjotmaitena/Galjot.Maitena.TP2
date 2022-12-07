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
    public partial class FrmRegistrarse : FrmLogin
    {
        private ListaJugadores lista;
        private List<Jugador> listaAux;
        
        public FrmRegistrarse()
        {
            InitializeComponent();
            this.lista = new ListaJugadores();
            this.listaAux = new List<Jugador>();
        }

        private void FrmRegistrarse_Load(object sender, EventArgs e)
        {
            if(this.lista.ProbarConexion())
            {
                this.listaAux = this.lista.Traer();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Sexo auxiliar = Sexo.Mujer; 

            if (base.delegado(txtNombre) || base.delegado(txtClave))
            {
                MessageBox.Show("Ingreso numeros");
            }
            else
            {
                if(rdbHombre.Checked)
                {
                    auxiliar = Sexo.Hombre;
                }

                Jugador unJugador = new Jugador(this.txtNombre.Text, this.txtClave.Text, auxiliar, this.lista.UltimoID+1);
                //MessageBox.Show(unJugador.ToString());

                if (this.lista.ProbarConexion())
                {
                    this.lista.Agregar(unJugador);

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

    }
}
