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
    public partial class FrmPerfil : Form
    {
        private Jugador usuario;

        public FrmPerfil(Jugador jugador)
        {
            InitializeComponent();
            this.usuario = jugador;
        }

        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = this.usuario.Nombre;
            this.txtNombre.Enabled = false;

            this.lblAbandonos.Text = this.usuario.Abandonos.ToString();
            this.lblVictorias.Text = this.usuario.Victorias.ToString();
            this.lblDerrotas.Text = this.usuario.Derrotas.ToString();
            this.lblEmpates.Text = this.usuario.Empates.ToString();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
