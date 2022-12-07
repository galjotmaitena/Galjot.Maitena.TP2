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
        //
        private ListaJugadores listaTomi;
        //
        private List<Button> listaBotones;
        private List<Button> listaAuxiliar;

        List<int> auxiliar;
        List<int> valores;

        private Partida unaPartida;

        private bool flagUno;
        private bool flagDos;
        private bool flagTres;
        private bool flagCuatro;
        private bool flagCinco;

        private int puntosExtras;

        private ValidarPuntos validador;
        private ValidarPuntos2 validador2;

        private bool flagTiradas;
        private bool partidaTerminada;

        public Partida PartidaForm
        {
            get { return this.unaPartida; }
        }

        public FrmJuego(Jugador unJugador, Jugador otroJugador)
        {
            InitializeComponent();


            this.listaTomi = new ListaJugadores();


            this.partidaTerminada = false;

            this.listaBotones = new List<Button>();
            this.listaAuxiliar = new List<Button>();

            this.auxiliar = new List<int>();
            this.valores = new List<int>();

            this.flagTiradas = false;

            this.puntosExtras = 0;

            this.listaBotones.Add(this.btnUno);
            this.listaBotones.Add(this.btnDos);
            this.listaBotones.Add(this.btnTres);
            this.listaBotones.Add(this.btnCuatro);
            this.listaBotones.Add(this.btnCinco);

            this.validador = new ValidarPuntos(this.ValidarSimples);
            this.validador2 = new ValidarPuntos2(this.ValidarMayores);

            this.unaPartida = new Partida(unJugador, otroJugador);
            
        }

        private void btnTirar_Click(object sender, EventArgs e)
        {
            valores = Turno.AgregarValores(listaBotones.Count);

            this.lblUsuario1.Text = this.unaPartida.Jugadores[0].Nombre;
            this.lblUsuario2.Text = this.unaPartida.Jugadores[1].Nombre;

            if (this.unaPartida.TurnoJugador.Count != 0)
            {
                if (this.unaPartida.TurnoJugador.Count % 2 == 0)
                {
                    this.Turnos(unaPartida.Jugadores[0]);

                    this.grpJugador2.Enabled = false;
                    this.grpJugador1.Enabled = true;

                    this.lblTotal_1.Text = this.unaPartida.Puntos[0].CalcularTotal().ToString();
                }
                else
                {
                    this.Turnos(unaPartida.Jugadores[1]);

                    this.grpJugador1.Enabled = false;
                    this.grpJugador2.Enabled = true;

                    this.lblTotal_2.Text = this.unaPartida.Puntos[1].CalcularTotal().ToString();
                }
            }
            else
            {
                MessageBox.Show(this.unaPartida.ObtenerGanador(), "Resultado final!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.unaPartida.Total[0] = this.unaPartida.Puntos[0].CalcularTotal();
                this.unaPartida.Total[1] = this.unaPartida.Puntos[1].CalcularTotal();

                this.partidaTerminada = true;
                this.listaTomi.Modificar(this.unaPartida.Jugadores[0]);
                this.listaTomi.Modificar(this.unaPartida.Jugadores[1]);
                this.Close();
            }
        }
        
        private void Tirar(List<Button> botones, List<int> valores)
        {
            for (int i = 0; i < botones.Count; i++)
            {
                for (int j = 0; j < valores.Count; j++)
                {
                    if (j == i)
                    {
                        botones[i].Text = valores[j].ToString();
                    }
                }
            }
        }

        private void Turnos(Jugador unJugador)
        {
            this.Tirar(this.listaBotones, this.valores);

            unaPartida.TurnoJugador.Peek().Tiradas--;

            this.btnTirar.Text = $"TIRAR({unaPartida.TurnoJugador.Peek().Tiradas + 1})";

            if (unaPartida.TurnoJugador.Peek().Tiradas == 0 && flagTiradas == false)
            {
                this.btnTirar.Enabled = false;
                MessageBox.Show("Ingrese los puntos", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(unaPartida.TurnoJugador.Peek().Tiradas == 2)
                {
                    this.puntosExtras = 5;

                    this.ReiniciarDados();

                    valores = Turno.AgregarValores(this.listaBotones.Count);
                    this.Tirar(this.listaBotones, this.valores);
                }
                else
                {
                    this.puntosExtras = 0;
                    this.flagTiradas = false;
                }
            }

            
        }

        #region Clicks
        private void btnUno_Click(object sender, EventArgs e)
        {
            if(!this.flagUno)
            {
                this.btnUno.Location = new Point(328, 349);

                this.listaAuxiliar.Add(this.btnUno);
                this.listaBotones.Remove(this.btnUno);

                this.auxiliar.Add(int.Parse(this.btnUno.Text));

                this.flagUno = true;
            }
            else
            {
                this.btnUno.Location = new Point(360, 67);

                this.listaBotones.Add(this.btnUno);
                this.listaAuxiliar.Remove(this.btnUno);

                this.auxiliar.Remove(int.Parse(this.btnUno.Text));

                this.flagUno = false;
            }
           
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            if (!this.flagDos)
            {
                this.btnDos.Location = new Point(432, 349);

                this.listaAuxiliar.Add(this.btnDos);
                this.listaBotones.Remove(this.btnDos);

                this.auxiliar.Add(int.Parse(this.btnDos.Text));

                this.flagDos = true;
            }
            else
            {
                this.btnDos.Location = new Point(543, 65);

                this.listaBotones.Add(this.btnDos);
                this.listaAuxiliar.Remove(this.btnDos);

                this.auxiliar.Remove(int.Parse(this.btnDos.Text));

                this.flagDos = false;
            }
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (!this.flagTres)
            {
                this.btnTres.Location = new Point(536, 349);

                this.listaAuxiliar.Add(this.btnTres);
                this.listaBotones.Remove(this.btnTres);

                this.auxiliar.Add(int.Parse(this.btnTres.Text));

                this.flagTres = true;
            }
            else
            {
                this.btnTres.Location = new Point(713, 65);

                this.listaBotones.Add(this.btnTres);
                this.listaAuxiliar.Remove(this.btnTres);

                this.auxiliar.Remove(int.Parse(this.btnTres.Text));

                this.flagTres = false;
            }
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            if (!this.flagCuatro)
            {
                this.btnCuatro.Location = new Point(640, 349);

                this.listaAuxiliar.Add(this.btnCuatro);
                this.listaBotones.Remove(this.btnCuatro);

                this.auxiliar.Add(int.Parse(this.btnCuatro.Text));

                this.flagCuatro = true;
            }
            else
            {
                this.btnCuatro.Location = new Point(445, 187);

                this.listaBotones.Add(this.btnCuatro);
                this.listaAuxiliar.Remove(this.btnCuatro);

                this.auxiliar.Remove(int.Parse(this.btnCuatro.Text));

                this.flagCuatro = false;
            }
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (!this.flagCinco)
            {
                this.btnCinco.Location = new Point(744, 349);

                this.listaAuxiliar.Add(this.btnCinco);
                this.listaBotones.Remove(this.btnCinco);

                this.auxiliar.Add(int.Parse(this.btnCinco.Text));

                this.flagCinco = true;
            }
            else
            {
                this.btnCinco.Location = new Point(638, 184);

                this.listaBotones.Add(this.btnCinco);
                this.listaAuxiliar.Remove(this.btnCinco);

                this.auxiliar.Remove(int.Parse(this.btnCinco.Text));

                this.flagCinco = false;
            }
        }
        #endregion

        #region Puntos

        #region Jugador 1
        private void txt1_TextChanged(object sender, EventArgs e)
        {
            if (this.validador.Invoke(this.txt1_1, 1))
            {
                this.txt1_1.Enabled = false;
                this.unaPartida.Puntos[0].Uno = int.Parse(this.txt1_1.Text);

                unaPartida.TurnoJugador.Dequeue();

                this.ReiniciarDados();

                this.flagTiradas = true;
                this.btnTirar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            if (this.validador.Invoke(this.txt2_1, 2))
            {
                this.txt2_1.Enabled = false;
                this.unaPartida.Puntos[0].Dos = int.Parse(this.txt2_1.Text);

                unaPartida.TurnoJugador.Dequeue();

                this.ReiniciarDados();

                this.flagTiradas = true;
                this.btnTirar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            if (this.validador.Invoke(this.txt3_1, 3))
            {
                this.txt3_1.Enabled = false;
                this.unaPartida.Puntos[0].Tres = int.Parse(this.txt3_1.Text);

                unaPartida.TurnoJugador.Dequeue();

                this.ReiniciarDados();

                this.flagTiradas = true;
                this.btnTirar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {
            if (this.validador.Invoke(this.txt4_1, 4))
            {
                this.txt4_1.Enabled = false;
                this.unaPartida.Puntos[0].Cuatro = int.Parse(this.txt4_1.Text);

                unaPartida.TurnoJugador.Dequeue();

                this.ReiniciarDados();

                this.flagTiradas = true;
                this.btnTirar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {
            if (this.validador.Invoke(this.txt5_1, 5))
            {
                this.txt5_1.Enabled = false;
                this.unaPartida.Puntos[0].Cinco = int.Parse(this.txt5_1.Text);

                unaPartida.TurnoJugador.Dequeue();

                this.ReiniciarDados();

                this.flagTiradas = true;
                this.btnTirar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txt6_TextChanged(object sender, EventArgs e)
        {
            if (this.validador.Invoke(this.txt6_1, 6))
            {
                this.txt6_1.Enabled = false;
                this.unaPartida.Puntos[0].Seis = int.Parse(this.txt6_1.Text);

                unaPartida.TurnoJugador.Dequeue();

                this.ReiniciarDados();

                this.flagTiradas = true;
                this.btnTirar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        //*********************************************************

        private void txtE_TextChanged(object sender, EventArgs e)
        {
            if (this.validador2.Invoke(this.txtE_1, Jugada.Escalera))
            {
                this.txtE_1.Enabled = false;
                this.unaPartida.Puntos[0].Escalera = int.Parse(this.txtE_1.Text);

                unaPartida.TurnoJugador.Dequeue();

                this.ReiniciarDados();

                this.flagTiradas = true;
                this.btnTirar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txtF_TextChanged(object sender, EventArgs e)
        {
            if (this.validador2.Invoke(this.txtF_1, Jugada.Full))
            {
                this.txtF_1.Enabled = false;
                this.unaPartida.Puntos[0].Full = int.Parse(this.txtF_1.Text);

                unaPartida.TurnoJugador.Dequeue();

                this.ReiniciarDados();

                this.flagTiradas = true;
                this.btnTirar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txtP_TextChanged(object sender, EventArgs e)
        {
            if (this.validador2.Invoke(this.txtP_1, Jugada.Poker))
            {
                this.txtP_1.Enabled = false;
                this.unaPartida.Puntos[0].Poker = int.Parse(this.txtP_1.Text);

                unaPartida.TurnoJugador.Dequeue();

                this.ReiniciarDados();

                this.flagTiradas = true;
                this.btnTirar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txtG_TextChanged(object sender, EventArgs e)
        {
            if (this.validador2.Invoke(this.txtG_1, Jugada.Generala))
            {
                this.txtG_1.Enabled = false;
                this.unaPartida.Puntos[0].Generala = int.Parse(this.txtG_1.Text);

                unaPartida.TurnoJugador.Dequeue();

                this.ReiniciarDados();

                this.flagTiradas = true;
                this.btnTirar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txtG2_TextChanged(object sender, EventArgs e)
        {
            if (this.validador2.Invoke(this.txtG2_1, Jugada.GeneralaReal))
            {
                this.txtG2_1.Enabled = false;
                this.unaPartida.Puntos[0].GeneralaReal = int.Parse(this.txtG2_1.Text);

                unaPartida.TurnoJugador.Dequeue();

                this.ReiniciarDados();

                this.flagTiradas = true;
                this.btnTirar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        #endregion

        #region Jugador 2

        private void txt1_2_TextChanged(object sender, EventArgs e)
        {
            if (this.validador.Invoke(this.txt1_2, 1))
            {
                this.txt1_2.Enabled = false;
                this.unaPartida.Puntos[1].Uno = int.Parse(this.txt1_2.Text);

                unaPartida.TurnoJugador.Dequeue();

                this.ReiniciarDados();

                this.flagTiradas = true;
                this.btnTirar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txt2_2_TextChanged(object sender, EventArgs e)
        {
            if (this.validador.Invoke(this.txt2_2, 2))
            {
                this.txt2_2.Enabled = false;
                this.unaPartida.Puntos[1].Dos = int.Parse(this.txt2_2.Text);

                unaPartida.TurnoJugador.Dequeue();

                this.ReiniciarDados();

                this.flagTiradas = true;
                this.btnTirar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txt3_2_TextChanged(object sender, EventArgs e)
        {
            if (this.validador.Invoke(this.txt3_2, 3))
            {
                this.txt3_2.Enabled = false;
                this.unaPartida.Puntos[1].Tres = int.Parse(this.txt3_2.Text);

                unaPartida.TurnoJugador.Dequeue();

                this.ReiniciarDados();

                this.flagTiradas = true;
                this.btnTirar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txt4_2_TextChanged(object sender, EventArgs e)
        {
            if (this.validador.Invoke(this.txt4_2, 4))
            {
                this.txt4_2.Enabled = false;
                this.unaPartida.Puntos[1].Cuatro = int.Parse(this.txt4_2.Text);

                unaPartida.TurnoJugador.Dequeue();

                this.ReiniciarDados();

                this.flagTiradas = true;
                this.btnTirar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txt5_2_TextChanged(object sender, EventArgs e)
        {
            if (this.validador.Invoke(this.txt5_2, 5))
            {
                this.txt5_2.Enabled = false;
                this.unaPartida.Puntos[1].Cinco = int.Parse(this.txt5_2.Text);

                unaPartida.TurnoJugador.Dequeue();

                this.ReiniciarDados();

                this.flagTiradas = true;
                this.btnTirar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txt6_2_TextChanged(object sender, EventArgs e)
        {
            if (this.validador.Invoke(this.txt6_2, 6))
            {
                this.txt6_2.Enabled = false;
                this.unaPartida.Puntos[1].Seis = int.Parse(this.txt6_2.Text);

                unaPartida.TurnoJugador.Dequeue();

                this.ReiniciarDados();

                this.flagTiradas = true;
                this.btnTirar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        //****************************************************************************

        private void txtE_2_TextChanged(object sender, EventArgs e)
        {
            if (this.validador2.Invoke(this.txtE_2, Jugada.Escalera))
            {
                this.txtE_2.Enabled = false;
                this.unaPartida.Puntos[1].Escalera = int.Parse(this.txtE_2.Text);

                unaPartida.TurnoJugador.Dequeue();

                this.ReiniciarDados();

                this.flagTiradas = true;
                this.btnTirar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txtF_2_TextChanged(object sender, EventArgs e)
        {
            if (this.validador2.Invoke(this.txtF_2, Jugada.Full))
            {
                this.txtF_2.Enabled = false;
                this.unaPartida.Puntos[1].Full = int.Parse(this.txtF_2.Text);

                unaPartida.TurnoJugador.Dequeue();

                this.ReiniciarDados();

                this.flagTiradas = true;
                this.btnTirar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txtP_2_TextChanged(object sender, EventArgs e)
        {
            if (this.validador2.Invoke(this.txtP_2, Jugada.Poker))
            {
                this.txtP_2.Enabled = false;
                this.unaPartida.Puntos[1].Poker = int.Parse(this.txtP_2.Text);

                unaPartida.TurnoJugador.Dequeue();

                this.ReiniciarDados();

                this.flagTiradas = true;
                this.btnTirar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txtG_2_TextChanged(object sender, EventArgs e)
        {
            if (this.validador2.Invoke(this.txtG_2, Jugada.Generala))
            {
                this.txtG_2.Enabled = false;
                this.unaPartida.Puntos[1].Generala = int.Parse(this.txtG_2.Text);

                unaPartida.TurnoJugador.Dequeue();

                this.ReiniciarDados();

                this.flagTiradas = true;
                this.btnTirar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txtG2_2_TextChanged(object sender, EventArgs e)
        {
            if (this.validador2.Invoke(this.txtG2_2, Jugada.GeneralaReal))
            {
                this.txtG2_2.Enabled = false;
                this.unaPartida.Puntos[1].GeneralaReal = int.Parse(this.txtG2_2.Text);

                unaPartida.TurnoJugador.Dequeue();

                this.ReiniciarDados();

                this.flagTiradas = true;
                this.btnTirar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        #endregion

        #endregion

        #region Validaciones

        private bool ValidarSimples(object txt, int numero)
        {
            Puntos puntos = new Puntos();
            TextBox ingreso = (TextBox)txt;
            bool retorno = false;

            if ((puntos.CalcularCantidadIguales(numero, this.auxiliar) * numero).ToString() == ingreso.Text || "0" == ingreso.Text)
            {
                retorno = true;
            }

            return retorno;
        }

        private bool ValidarMayores(object txt, Jugada jugada)
        {
            Puntos puntos = new Puntos();
            Jugada jugadaAux = puntos.CalcularJugadasMayores(this.auxiliar);
            TextBox ingreso = (TextBox)txt;
            bool retorno = false;

            if (jugada == jugadaAux && puntos.CalcularPuntos(jugada, this.puntosExtras).ToString() == ingreso.Text || "0" == ingreso.Text)
            {
                retorno = true;
            }

            return retorno;
        }
        #endregion

        private void ReiniciarDados()
        {
            this.btnUno.Location = new Point(360, 67);
            this.btnDos.Location = new Point(543, 65);
            this.btnTres.Location = new Point(713, 65);
            this.btnCuatro.Location = new Point(445, 187);
            this.btnCinco.Location = new Point(638, 184);

            this.flagUno = false;
            this.flagDos = false;
            this.flagTres = false;
            this.flagCuatro = false;
            this.flagCinco = false;

            int len = this.listaAuxiliar.Count;

            for (int i = 0; i < len; i++)
            {
                this.listaBotones.Add(this.listaAuxiliar[0]);
                this.listaAuxiliar.Remove(this.listaAuxiliar[0]);

                this.valores.Add(this.auxiliar[0]);
                this.auxiliar.Remove(this.auxiliar[0]);
            }
        }

        private void FrmJuego_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!this.partidaTerminada)
            {
                if (MessageBox.Show("Si presiona SI la partida se dara por abandonada y el ganador sera el otro jugador", "Atencion!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    if (this.unaPartida.TurnoJugador.Count % 2 == 0)
                    {
                        this.unaPartida.Jugadores[0].Abandonos++;
                        this.unaPartida.Jugadores[1].Victorias++;
                    }
                    else
                    {
                        this.unaPartida.Jugadores[1].Abandonos++;
                        this.unaPartida.Jugadores[0].Victorias++;
                    }
                }
            }
        }
    }
}
