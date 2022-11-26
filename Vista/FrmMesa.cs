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

		public FrmMesa(Jugador j1, Jugador j2) {
			InitializeComponent();
			jugadorUno = j1;
			jugadorDos = j2;
		}

		

		private void FrmMesa_Load(object sender,EventArgs e) {
			partida = new Partida(jugadorUno!, jugadorDos!);
			grp_JugadorUno.Text+=jugadorUno!.Nombre;
			grp_JugadorDos.Text+=jugadorDos!.Nombre;
			lbl_PuntosJugadorUno.Visible=false;
			lbl_PuntosJugadorDos.Visible=false;
			//lbl_PuntosJugadorUno.Text=juego.ContarPuntos(juego.JugadasJugadorUno).ToString();
			//lbl_PuntosJugadorDos.Text=juego.ContarPuntos(juego.JugadasJugadorDos).ToString();
			LlenarDataGridJugadas();
		}

		private void LlenarDataGridJugadas() {
			dgw_JugadasJugadorUno.DataSource=null;
			dgw_JugadasJugadorUno.DataSource=partida!.JuegoJugadorUno.Jugadas.ToList();
			dgw_JugadasJugadorDos.DataSource=null;
			dgw_JugadasJugadorDos.DataSource=partida!.JuegoJugadorDos.Jugadas.ToList();
		}

		

	}
}
