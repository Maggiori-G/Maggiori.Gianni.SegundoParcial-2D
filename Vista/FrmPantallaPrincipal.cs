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
	public partial class FrmPantallaPrincipal:Form {
		Usuario usuarioLogueado;
		SerializarJSON<List<Jugador>> serializadorJSON;
		SerializarXML<List<Jugador>> serializadorXML;
		public FrmPantallaPrincipal(Usuario usuario) {
			InitializeComponent();
			usuarioLogueado = usuario;
			this.Text="La Generala Fruta - Usuario: "+usuarioLogueado.NombreUsuario;
			serializadorJSON = new SerializarJSON<List<Jugador>>();
			serializadorXML = new SerializarXML<List<Jugador>>();
		}

		private void FrmPantallaPrincipal_Load(object sender,EventArgs e) {

		}

		private void ConfigurarDataGridPartidas() {
			dgw_Partidas.Columns["JuegoJugadorUno"].Visible=false;
			dgw_Partidas.Columns["JuegoJugadorDos"].Visible=false;
			dgw_Partidas.Columns["PartidaFinalizada"].Visible=false;
		}

		private void FrmPantallaPrincipal_FormClosed(object sender,FormClosedEventArgs e) {
			Environment.Exit(0);
		}

		private void ActualizarJugadoresBaseDeDatos() {
			try {
				cmb_PrimerJugador.DataSource=JugadorDAO.GetJugadores();
				cmb_SegundoJugador.DataSource=JugadorDAO.GetJugadores();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void brn_Salir_Click(object sender,EventArgs e) {
			this.Close();
		}

		private void btn_CrearMesa_Click(object sender,EventArgs e) {
			if(!Sistema.ValidarMesaConJugadoresIguales((Jugador)cmb_PrimerJugador.SelectedItem,(Jugador)cmb_SegundoJugador.SelectedItem)){
				FrmMesa frmMesa = new FrmMesa((Jugador)cmb_PrimerJugador.SelectedItem, (Jugador)cmb_SegundoJugador.SelectedItem);
				frmMesa.Show();
				dgw_Partidas.DataSource=null;
				dgw_Partidas.DataSource=Sistema.ListaPartidas;
				ConfigurarDataGridPartidas();
			}
			else {
				MessageBox.Show("No se puede crear una mesa con jugadores repetidos");
			}
		}

		private void btm_JugadoresSQL_Click(object sender,EventArgs e) {
			this.ActualizarJugadoresBaseDeDatos();
		}

		private void btn_NuevoJugador_Click(object sender,EventArgs e) {
			FrmNuevoJugador nuevoJugador = new FrmNuevoJugador();
			nuevoJugador.Show();
		}

		private void btn_ExportarJugadoresJSON_Click(object sender,EventArgs e) {
			try {
				serializadorJSON.Serializar(JugadorDAO.GetJugadores(),"JugadoresEnJson");
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void btn_ExportarJugadoresXML_Click(object sender,EventArgs e) {
			try {
				serializadorXML.Serializar(JugadorDAO.GetJugadores(),"JugadoresEnXML");
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void btn_ImportarJugadoresJSON_Click(object sender,EventArgs e) {
			try {
				Sistema.ListaJugadores = serializadorJSON.Deserializar("JugadoresEnJson");
				cmb_PrimerJugador.DataSource=Sistema.ListaJugadores;
				cmb_SegundoJugador.DataSource=Sistema.ListaJugadores;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void btn_ImportarJugadoresXML_Click(object sender,EventArgs e) {
			try {
				Sistema.ListaJugadores = serializadorXML.Deserializar("JugadoresEnXML");
				cmb_PrimerJugador.DataSource=Sistema.ListaJugadores;
				cmb_SegundoJugador.DataSource=Sistema.ListaJugadores;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void button3_Click(object sender,EventArgs e) {

		}
	}
}
