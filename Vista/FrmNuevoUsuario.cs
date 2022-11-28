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
	public partial class FrmNuevoUsuario:Form {
		public FrmNuevoUsuario() {
			InitializeComponent();
		}

		private void btn_Cancelar_Click(object sender,EventArgs e) {
			this.Close();
		}

		private void btn_Registrarse_Click(object sender,EventArgs e) {
			if(ControlVista.ValidarTextBox(this)) {
				try {
					if(txt_Contraseña.Text ==txt_ConfirmarContraseña.Text) {
						UsuarioDAO.EscribirNuevoUsuario(txt_Nombre.Text.Trim(),txt_NombreUsuario.Text.Trim(),txt_Contraseña.Text.Trim(),txt_Email.Text.Trim());
						this.DialogResult=DialogResult.OK;
					}
					else {
						MessageBox.Show("Error al confirmar contraseña");
					}
				}
				catch(Exception ex) {
					MessageBox.Show(ex.Message);
				}
			}
		}
	}
}
