using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista {
	public partial class FrmMesa:Form {
		
		Jugador? jugadorUno;
		Jugador? jugadorDos;
		Partida? partida;

		public string Partida {
			get => partida.Registro!;
		}

		public FrmMesa(Jugador j1, Jugador j2) {
			InitializeComponent();
			jugadorUno = j1;
			jugadorDos = j2;
		}

		private void FrmMesa_Load(object sender,EventArgs e) {
			partida = new Partida(jugadorUno!, jugadorDos!, MostrarGanador);
			Sistema.ListaPartidas.Add(partida);
			partida.JuegoJugadorUno.EmpezarPartida();
			partida.JuegoJugadorDos.EmpezarPartida();
			LlenarDataGridJugadas();
			grp_JugadorUno.Text+=jugadorUno!.Nombre;
			grp_JugadorDos.Text+=jugadorDos!.Nombre;
			partida.JuegoJugadorUno.InformePartida+=EscribirTxtTiradasJugadorUno;
			partida.JuegoJugadorDos.InformePartida+=EscribirTxtTiradasJugadorDos;
			partida.JuegoJugadorUno.InformeActualizarPuntos+=ActualizarLabelPuntosJugadorUno;
			partida.JuegoJugadorDos.InformeActualizarPuntos+=ActualizarLabelPuntosJugadorDos;
			partida.JuegoJugadorUno.ActualizarTablaJugadas+=ActualizarTablaJugadorUno;
			partida.JuegoJugadorDos.ActualizarTablaJugadas+=ActualizarTablaJugadorDos;
			partida.InformarGanador();
			
		}

		private void LlenarDataGridJugadas() {
			dgw_JugadasJugadorUno.DataSource=null;
			dgw_JugadasJugadorUno.DataSource=partida!.JuegoJugadorUno.Jugadas.ToList();
			dgw_JugadasJugadorDos.DataSource=null;
			dgw_JugadasJugadorDos.DataSource=partida!.JuegoJugadorDos.Jugadas.ToList();
		}

		private void ActualizarLabelPuntosJugadorUno(int puntaje) {
			if(lbl_PuntosJugadorUno.InvokeRequired) {
				lbl_PuntosJugadorUno.Invoke(new Action<int>(ActualizarLabelPuntosJugadorUno),puntaje);
			}
			else {
				lbl_PuntosJugadorUno.Text=puntaje.ToString();
			}
		}
		
		private void ActualizarLabelPuntosJugadorDos(int puntaje) {
			if(lbl_PuntosJugadorDos.InvokeRequired) {
				lbl_PuntosJugadorDos.Invoke(new Action<int>(ActualizarLabelPuntosJugadorDos),puntaje);
			}
			else {
				lbl_PuntosJugadorDos.Text=puntaje.ToString();
			}
		}

		private void EscribirTxtTiradasJugadorUno(string tirada) {
			if(rtb_RegistroJugadorUno.InvokeRequired) {
				rtb_RegistroJugadorUno.Invoke(new Action<string>(EscribirTxtTiradasJugadorUno),tirada);
			}
			else {
				rtb_RegistroJugadorUno.Text+=$"{tirada}\n";
			}
		}

		private void EscribirTxtTiradasJugadorDos(string tirada) {
			if(rtb_RegistroJugadorDos.InvokeRequired) {
				rtb_RegistroJugadorDos.Invoke(new Action<string>(EscribirTxtTiradasJugadorDos),tirada);
			}
			else {
				rtb_RegistroJugadorDos.Text+=$"{tirada}\n";
			}
		}

		private void ActualizarTablaJugadorUno(List<KeyValuePair<string,int>> tablaJugadas) {
			if(dgw_JugadasJugadorUno.InvokeRequired) {
				dgw_JugadasJugadorUno.Invoke(new Action <List<KeyValuePair<string,int>>>(ActualizarTablaJugadorUno),tablaJugadas);
			}
			else {
				dgw_JugadasJugadorUno.DataSource=null;
				dgw_JugadasJugadorUno.DataSource=tablaJugadas;
			}
		}
		
		private void ActualizarTablaJugadorDos(List<KeyValuePair<string,int>> tablaJugadas) {
			if(dgw_JugadasJugadorDos.InvokeRequired) {
				dgw_JugadasJugadorDos.Invoke(new Action <List<KeyValuePair<string,int>>>(ActualizarTablaJugadorDos),tablaJugadas);
			}
			else {
				dgw_JugadasJugadorDos.DataSource=null;
				dgw_JugadasJugadorDos.DataSource=tablaJugadas;
			}
		}

		private void MostrarGanador(string ganador) {
			if(lbl_Ganador.InvokeRequired) {
				lbl_Ganador.Invoke(new Action<string> (MostrarGanador),ganador);
			}
			else {
				lbl_Ganador.Text=ganador;
			}
		}

		private void btn_CancelarPartida_Click(object sender,EventArgs e) {
			partida!.JuegoJugadorUno.Cancellation.Cancel();
			partida!.JuegoJugadorDos.Cancellation.Cancel();
			if(!partida.PartidaFinalizada) {
				lbl_Ganador.Text="Partida Cancelada";
			}
		}

		private void button1_Click(object sender,EventArgs e) {
			this.Hide();
		}
	}
}
