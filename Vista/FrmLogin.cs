using Entidades;

namespace Vista {
	public partial class FrmLogin:Form {
		public FrmLogin() {
			InitializeComponent();
		}

		private void btn_Salir_Click(object sender,EventArgs e) {
			this.Close();
		}

		private void btn_Ingresar_Click(object sender,EventArgs e) {
			Usuario? usuario;
			if(ControlVista.ValidarTextBox(this)) {
				usuario=Sistema.VerificarUsuarioExistente(txt_NombreUsuario.Text.Trim(),txt_Contrase�a.Text.Trim());
				if(usuario is not null) {
					FrmPantallaPrincipal pantallaPrincipal = new FrmPantallaPrincipal(usuario);
					this.Hide();
					DialogResult resultado=pantallaPrincipal.ShowDialog();
					if(resultado==DialogResult.OK) {
						this.Show();
					}
				}
				else {
					MessageBox.Show("No se encontr� el usuario");
				}
			}
			else {
				MessageBox.Show("Debe ingresar nombre de usuario y contrase�a");
			}
		}

		private void btn_Autocompletar_Click(object sender,EventArgs e) {
			this.txt_NombreUsuario.Text="Gianni";
			this.txt_Contrase�a.Text="admin1234";
		}
	}
}