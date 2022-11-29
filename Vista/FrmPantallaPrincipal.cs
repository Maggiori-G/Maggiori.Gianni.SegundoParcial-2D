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
		private List<FrmMesa> listaDeMesas;
		public FrmPantallaPrincipal(Usuario usuario) {
			InitializeComponent();
			usuarioLogueado = usuario;
			this.Text="La Generala Fruta - Usuario: "+usuarioLogueado.NombreUsuario;
			serializadorJSON = new SerializarJSON<List<Jugador>>();
			serializadorXML = new SerializarXML<List<Jugador>>();
			listaDeMesas = new List<FrmMesa>();
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
			if(cmb_PrimerJugador.SelectedItem is not null || cmb_SegundoJugador.SelectedItem is not null) {
				if(!Sistema.ValidarMesaConJugadoresIguales((Jugador)cmb_PrimerJugador.SelectedItem!,(Jugador)cmb_SegundoJugador.SelectedItem!)){
					FrmMesa frmMesa = new FrmMesa((Jugador)cmb_PrimerJugador.SelectedItem!, (Jugador)cmb_SegundoJugador.SelectedItem!);
					frmMesa.Show();
					listaDeMesas.Add(frmMesa);
					dgw_Partidas.DataSource=null;
					dgw_Partidas.DataSource=Sistema.ListaPartidas;
					ConfigurarDataGridPartidas();
				}
				else {
					MessageBox.Show("No se puede crear una mesa con jugadores repetidos");
				}
			}
			else {
				MessageBox.Show("Debe seleccionar los dos jugadores para poder abrir una mesa de juego");
			}
		}

		private void btm_JugadoresSQL_Click(object sender,EventArgs e) {
			this.ActualizarJugadoresBaseDeDatos();
		}

		private void btn_NuevoJugador_Click(object sender,EventArgs e) {
			FrmNuevoJugador nuevoJugador = new FrmNuevoJugador();
			nuevoJugador.ShowDialog();
			this.Hide();
			if(nuevoJugador.DialogResult==DialogResult.OK) {
				this.Show();
			}
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
				Sistema.ListaJugadores.Clear();
				Sistema.ListaJugadores = serializadorJSON.Deserializar("JugadoresEnJson");
				cmb_PrimerJugador.DataSource=serializadorJSON.Deserializar("JugadoresEnJson");
				cmb_SegundoJugador.DataSource=serializadorJSON.Deserializar("JugadoresEnJson");
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void btn_ImportarJugadoresXML_Click(object sender,EventArgs e) {
			try {
				Sistema.ListaJugadores.Clear();
				Sistema.ListaJugadores = serializadorXML.Deserializar("JugadoresEnXML");
				cmb_PrimerJugador.DataSource=serializadorXML.Deserializar("JugadoresEnXML");
				cmb_SegundoJugador.DataSource=serializadorXML.Deserializar("JugadoresEnXML");
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void btn_RankingVictorias_Click(object sender,EventArgs e) {
			FrmRankingVictorias ranking = new FrmRankingVictorias();
			ranking.Show();
		}

		private void btn_AbrirMesa_Click(object sender,EventArgs e) {
			if(Sistema.ListaPartidas.Count>0) {
				Partida partidaAux;
				partidaAux=(Partida)dgw_Partidas.CurrentRow.DataBoundItem;
				foreach(FrmMesa item in this.listaDeMesas) {
					if(item.Partida ==partidaAux.Registro) {
						item.Show();
					}
				}
			}
			else {
				MessageBox.Show("No hay partidas disponibles para mostrar");
			}
		}
	}
}
