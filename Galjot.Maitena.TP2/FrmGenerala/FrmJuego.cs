using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDeClases;

namespace FrmGenerala
{
    public partial class FrmJuego : Form
    {
        private List<Button> listaBotones;
        private List<Button> listaAuxiliar;
        private List<Label> listaSimples;
        private List<Label> listaMayores;

        List<int> auxiliar;
        List<int> valores;

        private Partida unaPartida;

        private bool flagUno;
        private bool flagDos;
        private bool flagTres;
        private bool flagCuatro;
        private bool flagCinco;

        public FrmJuego()
        {
            InitializeComponent();

            this.listaBotones = new List<Button>();
            this.listaAuxiliar = new List<Button>();

            this.auxiliar = new List<int>();
            this.valores = new List<int>();

            this.flagUno = false;
            this.flagDos = false;
            this.flagTres = false;
            this.flagCuatro = false;
            this.flagCinco = false;

            this.listaBotones.Add(this.btnUno);
            this.listaBotones.Add(this.btnDos);
            this.listaBotones.Add(this.btnTres);
            this.listaBotones.Add(this.btnCuatro);
            this.listaBotones.Add(this.btnCinco);

            //this.listaSimples.Add(this.lblUno);
            //this.listaSimples.Add(this.lblDos);
            //this.listaSimples.Add(this.lblTres);
            //this.listaSimples.Add(this.lblCuatro);
            //this.listaSimples.Add(this.lblCinco);
            //this.listaSimples.Add(this.lblSeis);

            //this.listaMayores.Add(this.lblEscalera);
            //this.listaMayores.Add(this.lblFull);
            //this.listaMayores.Add(this.lblPoker);
            //this.listaMayores.Add(this.lblGenerala);
            //this.listaMayores.Add(this.lblGenerala2);

            this.unaPartida = new Partida(new Jugador("mai", "algo", Sexo.Mujer), new Jugador("alguien", "algo", Sexo.Mujer));
        }

        private void btnTirar_Click(object sender, EventArgs e)
        {
            valores = Turno.AgregarValores(listaBotones.Count);

            if (this.unaPartida.TurnoJugador.Count != 0)
            {
                if (this.unaPartida.TurnoJugador.Count % 2 == 0)
                {
                    this.Turnos(unaPartida.Jugadores[0]);
                }
                else
                {
                    if (this.unaPartida.TurnoJugador.Count % 2 != 0)
                    {
                        this.Turnos(unaPartida.Jugadores[1]);
                    }
                }
            }
            else
            {
                this.Close();
            }
        }

        private void Tirar()
        {
            for (int i = 0; i < listaBotones.Count; i++)
            {
                for (int j = 0; j < valores.Count; j++)
                {
                    if (j == i)
                    {
                        listaBotones[i].Text = valores[j].ToString();
                    }
                }
            }
        }

        private void Turnos(Jugador unJugador)
        {
            this.txtUsuario.Text = unJugador.Nombre.ToString();

            this.Tirar();

            unaPartida.TurnoJugador.Peek().Tiradas--;

            this.btnTirar.Text = $"TIRAR({unaPartida.TurnoJugador.Peek().Tiradas + 1})";

            if (unaPartida.TurnoJugador.Peek().Tiradas == 0)
            {
                unaPartida.TurnoJugador.Dequeue();
            }
        }

        private EventHandler Evento(object sender, EventArgs e)
        {
            Puntos puntos = new Puntos();
            Jugada jugada;
            //int cantidad;

            jugada = puntos.CalcularJugadasMayores(this.auxiliar, 0);

            if(jugada == Jugada.Full)
            {
                this.lblFull.Text = puntos.CalcularPuntos(jugada).ToString();
                
            }
            //if(jugada == Jugada.Simple)
            //{
            //    for (int i = 1; i < 6; i++)
            //    {
            //        cantidad = puntos.CalcularCantidadIguales(i, this.valores);
            //        puntos.CalcularJugadasSimples(i, cantidad);

                    
            //    }
            //}
            MessageBox.Show($"TOTAL: {jugada.ToString()}");

            return null;
        }

        #region Clicks
        private void btnUno_Click(object sender, EventArgs e)
        {
            if(!this.flagUno)
            {
                this.btnUno.Location = new Point(28, 349);
                this.listaBotones.Remove(this.btnUno);
                this.auxiliar.Add(int.Parse(this.btnUno.Text));
                this.flagUno = true;
            }
            else
            {
                this.btnUno.Location = new Point(84, 62);
                this.listaBotones.Add(this.btnUno);
                this.auxiliar.Remove(int.Parse(this.btnUno.Text));
                this.flagUno = false;
            }
           
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            if (!this.flagDos)
            {
                this.btnDos.Location = new Point(132, 349);
                this.listaBotones.Remove(this.btnDos);
                this.auxiliar.Add(int.Parse(this.btnDos.Text));
                this.flagDos = true;
            }
            else
            {
                this.btnDos.Location = new Point(224, 62);
                this.listaBotones.Add(this.btnDos);
                this.auxiliar.Add(int.Parse(this.btnDos.Text));
                this.flagDos = false;
            }
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (!this.flagTres)
            {
                this.btnTres.Location = new Point(236, 349);
                this.listaBotones.Remove(this.btnTres);
                this.auxiliar.Add(int.Parse(this.btnTres.Text));
                this.flagTres = true;
            }
            else
            {
                this.btnTres.Location = new Point(361, 62);
                this.listaBotones.Add(this.btnTres);
                this.auxiliar.Remove(int.Parse(this.btnTres.Text));
                this.flagTres = false;
            }
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            if (!this.flagCuatro)
            {
                this.btnCuatro.Location = new Point(340, 349);
                this.listaBotones.Remove(this.btnCuatro);
                this.auxiliar.Add(int.Parse(this.btnCuatro.Text));
                this.flagCuatro = true;
            }
            else
            {
                this.btnCuatro.Location = new Point(159, 183);
                this.listaBotones.Add(this.btnCuatro);
                this.auxiliar.Add(int.Parse(this.btnCuatro.Text));
                this.flagCuatro = false;
            }
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (!this.flagCinco)
            {
                this.btnCinco.Location = new Point(444, 349);
                this.listaBotones.Remove(this.btnCinco);
                this.auxiliar.Add(int.Parse(this.btnCinco.Text));
                this.flagCinco = true;
            }
            else
            {
                this.btnCinco.Location = new Point(307, 183);
                this.listaBotones.Add(this.btnCinco);
                this.auxiliar.Add(int.Parse(this.btnCinco.Text));
                this.flagCinco = false;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Evento(sender, e);
        }
    }
}
