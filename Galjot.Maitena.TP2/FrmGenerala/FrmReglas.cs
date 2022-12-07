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
    public partial class FrmReglas : Form
    {
        public FrmReglas()
        {
            InitializeComponent();
        }

        private void FrmReglas_Load(object sender, EventArgs e)
        {
            this.rcbReglas.ReadOnly = true;

            Reglas.CrearReglas();

            if (Reglas.GuardarReglas())
            {
                List<String> aux = Reglas.CargarReglas();

                if (aux is not null)
                {
                    foreach (string item in aux)
                    {
                        this.rcbReglas.Text += item;
                    }
                }
            }
        }
    }
}
