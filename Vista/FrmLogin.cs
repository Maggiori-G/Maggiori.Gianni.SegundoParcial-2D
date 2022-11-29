using Entidades;

namespace Vista {
	public partial class FrmLogin:Form {
		public FrmLogin() {
			InitializeComponent();
			
		}

		private void btn_Salir_Click(object sender,EventArgs e) {
			this.Close();
		}
		private void FrmLogin_Load(object sender,EventArgs e) {
			
		}

		private void btn_Ingresar_Click(object sender,EventArgs e) {
			try {
				Sistema.ListaUsuarios=UsuarioDAO.GetUsuarios();
			}
			catch (Exception ex) {
				DialogResult respuesta=MessageBox.Show($"{ex.Message} - Cerrando aplicacion","Error de Conexion",MessageBoxButtons.OK,MessageBoxIcon.Error);
				if(respuesta == DialogResult.OK) {
					this.Close();
				}
			}
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
			this.txt_NombreUsuario.Text="Tanito";
			this.txt_Contrase�a.Text="admin1234";
		}

		private void btn_NuevoUsuario_Click(object sender,EventArgs e) {
			FrmNuevoUsuario nuevoUsuario = new FrmNuevoUsuario();
			this.Hide();
			nuevoUsuario.ShowDialog();
			if(nuevoUsuario.DialogResult==DialogResult.OK) {
				this.Show();
			}
		}
	}
}