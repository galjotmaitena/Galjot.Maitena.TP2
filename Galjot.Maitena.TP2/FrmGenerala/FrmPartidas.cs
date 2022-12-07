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
    public partial class FrmPartidas : Form
    {
        private List<Partida> partidas;
        private delegate void Delegado();

        public FrmPartidas(List<Partida> partidas)
        {
            InitializeComponent();
            this.partidas = partidas;
        }

        private void FrmPartidas_Load(object sender, EventArgs e)
        {
            //List<Partida> list = new List<Partida>();
            //Partida partida1 = new Partida(new Jugador("tomi", "snnqinqi", Sexo.Hombre, 1), new Jugador("maite", "ioloil", 0, 2), 20, 30, new Jugador("maite", "ioloil", 0, 2));
            //Partida partida2 = new Partida(new Jugador("fabri", "dsda", Sexo.Hombre, 3), new Jugador("mati", "fwew", Sexo.Hombre, 4), 20, 30, new Jugador("maite", "ioloil", 0, 2));
            //Partida partida3 = new Partida(new Jugador("maxi", "snnqinqi", Sexo.Hombre, 5), new Jugador("nene", "ioloil", Sexo.Hombre, 6), 20, 30, new Jugador("maite", "ioloil", 0, 2));

            //list.Add(partida1);
            //list.Add(partida2);
            //list.Add(partida3);

            ////if(Archivos.AgregarAlArchivo(list))
            ////{
            //foreach (Partida item in Archivos.LeerArchivoLineaALinea())
            //{
            //    this.lstPartidasFinalizadas.DataSource += item.Jugadores[0].Nombre + item.Jugadores[1].Nombre + item.Total[0] + item.Total[1] + item.Jugadores[1].Nombre + "\n";
            //        //this.lstPartidasFinalizadas.Text += item.Jugadores[0].Nombre + item.Jugadores[1].Nombre + item.Total[0] + item.Total[1] + item.Jugadores[1].Nombre + "\n";
            //}
            ////}
            try
            {
                Task.Run(this.CargarPartidas);
            }
            catch(Exception)
            {
                return;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Run(this.CargarPartidas);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void CargarPartidas()
        {
            if(this.InvokeRequired)
            {
                Delegado delegado = new Delegado(this.CargarPartidas);
                this.BeginInvoke(delegado);
            }
            else
            {
                this.lstPartidasEnJuego.Items.Clear();

                foreach (Partida item in this.partidas)
                {
                    this.lstPartidasEnJuego.Items.Add(item);
                }
            }
        }
    }
}
