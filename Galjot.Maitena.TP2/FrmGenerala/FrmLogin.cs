using LibreriaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrmGenerala
{
    public partial class FrmLogin : Form
    {
        private delegate bool MiDelegado(object sender, EventArgs e);
        protected ValidarTxt delegado;
        private ListaJugadores lista;
        private List<Jugador> listaJugadores;

        private Jugador jugador;

        public Jugador JugadorForm
        {
            get { return this.jugador; }
        }

        public FrmLogin()
        {
            InitializeComponent();
            this.lista = new ListaJugadores();
            this.listaJugadores = new List<Jugador>();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            delegado += new ValidarTxt(Validacion);   
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(!(delegado.Invoke(txtNombre) || delegado.Invoke(txtClave)))
            {
                Jugador unJugador = new Jugador(this.txtNombre.Text, this.txtClave.Text, 0, 0);

                if (this.lista.ProbarConexion())
                {
                    this.listaJugadores = this.lista.Traer();

                    foreach (Jugador item in listaJugadores)
                    {
                        if (item == unJugador)
                        {
                            this.jugador = item;

                            this.DialogResult = DialogResult.OK;

                            break;
                        }
                    }

                    if (this.jugador is null)
                    {
                        MessageBox.Show("Usuario no encontrado");
                    }
                    else
                    {
                        FrmPerfil formPerfil = new FrmPerfil(this.JugadorForm);
                        formPerfil.Show();
                        this.Close();
                    }  
                }
                else
                {
                    MessageBox.Show("Error");
                }
                
            }
        }

        protected bool Validacion(object txt)
        {
            TextBox auxiliar = (TextBox)txt;
            int aux;
            bool retorno = false;

            if (int.TryParse(auxiliar.Text, out aux))
            {
                retorno = true;
            }   
            
            return retorno;
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FrmRegistrarse registrarse = new FrmRegistrarse();

            if (registrarse.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Registrado");
            }
        }
    }
}
