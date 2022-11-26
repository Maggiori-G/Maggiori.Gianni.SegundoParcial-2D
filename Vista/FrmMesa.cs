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
		Juego juego;

		public FrmMesa(Partida partida) {
			InitializeComponent();
			
		}

		

		private void FrmMesa_Load(object sender,EventArgs e) {
			grp_JugadorUno.Text+=jugadorUno!.Nombre;
			grp_T2.Text+=jugadorDos!.Nombre;
			lbl_PuntosJugadorUno.Visible=false;
			lbl_PuntosJugadorDos.Visible=false;
			//lbl_PuntosJugadorUno.Text=juego.ContarPuntos(juego.JugadasJugadorUno).ToString();
			//lbl_PuntosJugadorDos.Text=juego.ContarPuntos(juego.JugadasJugadorDos).ToString();
			LlenarDataGridJugadas();
		}

		private void LlenarDataGridJugadas() {
			dgw_JugadasJugadorUno.DataSource=null;
			
			dgw_JugadasJugadorDos.DataSource=null;
			
		}

		private void MostrarTiradasRichTexboxJugadorUno() {
			rtb_RegistroJugadorUno.AppendText(jugadorUno!.InformarTirada()+"\n");
		}

		private void MostrarTiradasRichTexboxJugadorUno(string jugada) {
			rtb_RegistroJugadorUno.AppendText(jugada+"\n");
		}

		private void MostrarTiradasRichTexboxJugadorDos() {
			rtb_RegistroJugadorDos.AppendText(jugadorDos!.InformarTirada()+"\n");
		}

	}
}
