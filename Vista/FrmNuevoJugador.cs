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
				JugadorDAO.EscribirNuevoJugador(txt_NuevoJugador.Text.Trim());
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void btn_Cancelar_Click(object sender,EventArgs e) {
			this.Close();
		}
	}
}
