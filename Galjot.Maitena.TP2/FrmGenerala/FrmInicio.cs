using LibreriaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmGenerala
{
    public partial class FrmInicio : Form
    {
        private bool flag;

        private Jugador unJugador;
        private List<Partida> listaPartidas;

        public FrmInicio()
        {
            InitializeComponent();

            this.flag = false;
            this.listaPartidas = new List<Partida>();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            FrmListaJugadores formLista = new FrmListaJugadores(this.unJugador);

            if (this.unJugador is not null)
            {
                if (formLista.ShowDialog() == DialogResult.OK)
                {
                    FrmJuego formJuego = new FrmJuego(this.unJugador, formLista.JugadorForm);
                    formJuego.Show();
                    this.listaPartidas.Add(formJuego.PartidaForm);
                    

                    //this.listaPartidas = Archivos.LeerArchivoLineaALinea();
                    //this.listaPartidas.Add(formJuego.PartidaForm);

                    //if(Archivos.SobreescribirElArchivo(this.listaPartidas))
                    //{
                    //    MessageBox.Show("Se sobreescribio");
                    //}
                }
            }
            else
            {
                MessageBox.Show("Debe registrarse antes de jugar!", "Atencion!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FrmLogin formLogin;

            if (flag)
            {
                FrmPerfil formPerfil = new FrmPerfil(this.unJugador);

                if(formPerfil.ShowDialog() == DialogResult.OK)
                {
                    this.unJugador = null;
                    flag = false;
                }
            }
            else
            {
                formLogin = new FrmLogin();

                if(formLogin.ShowDialog() == DialogResult.OK)
                {
                    this.unJugador = formLogin.JugadorForm;
                    this.flag = true;
                }  
            }
            
        }

        private void btnReglas_Click(object sender, EventArgs e)
        {
            FrmReglas formReglas = new FrmReglas();
            formReglas.Show();
        }

        private void btnPartidas_Click(object sender, EventArgs e)
        {
            FrmPartidas formPartidas = new FrmPartidas(this.listaPartidas);
            formPartidas.Show();
        }
    }
}
