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
        public FrmPerfil()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            FrmLogin login = new FrmLogin();

            if(login.ShowDialog() == DialogResult.OK)
            {
                this.txtNombre.Text = login.NombreJugador;
            }
        }
    }
}
