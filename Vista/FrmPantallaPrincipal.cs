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

		public FrmPantallaPrincipal(Usuario usuario) {
			InitializeComponent();
			usuarioLogueado = usuario;
			this.Text="La Generala Fruta - Usuario: "+usuarioLogueado.NombreUsuario;
		}

		private void FrmPantallaPrincipal_FormClosed(object sender,FormClosedEventArgs e) {
			Environment.Exit(0);
		}

		private void ActualizarJugadoresBaseDeDatos() {
			cmb_PrimerJugador.DataSource=JugadorDAO.GetJugadores();
			cmb_SegundoJugador.DataSource=JugadorDAO.GetJugadores();
		}

		private void brn_Salir_Click(object sender,EventArgs e) {
			this.Close();
		}

		private void btn_CrearMesa_Click(object sender,EventArgs e) {
			if(!Sistema.ValidarMesaConJugadoresIguales((Jugador)cmb_PrimerJugador.SelectedItem,(Jugador)cmb_SegundoJugador.SelectedItem)){
				FrmMesa frmMesa = new FrmMesa((Jugador)cmb_PrimerJugador.SelectedItem, (Jugador)cmb_SegundoJugador.SelectedItem);
				frmMesa.Show();
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
	}
}
