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
	public partial class FrmNuevoJugador:Form {
		public FrmNuevoJugador() {
			InitializeComponent();
		}

		private void btn_Aceptar_Click(object sender,EventArgs e) {
			try {
				if(!string.IsNullOrEmpty(txt_NuevoJugador.Text)) {
					JugadorDAO.EscribirNuevoJugador(txt_NuevoJugador.Text.Trim());
					Sistema.ListaJugadores.Add(new Jugador(Sistema.ListaJugadores.Count+1,txt_NuevoJugador.Text.Trim(),0));
					this.DialogResult=DialogResult.OK;
				}
				else {
					MessageBox.Show("Debe ingresar el nombre del nuevo jugador");
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void btn_Cancelar_Click(object sender,EventArgs e) {
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

	}
}
