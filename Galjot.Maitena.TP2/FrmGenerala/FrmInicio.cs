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
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            FrmJuego formJuego = new FrmJuego();
            formJuego.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil formPerfil = new FrmPerfil();
            formPerfil.Show();
        }

        private void btnReglas_Click(object sender, EventArgs e)
        {
            FrmListaJugadores lista = new FrmListaJugadores();
            lista.Show();
        }
    }
}
