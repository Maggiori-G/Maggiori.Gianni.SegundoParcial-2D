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
			try {
				Sistema.ListaUsuarios=UsuarioDAO.GetUsuarios();
			}
			catch (Exception ex) {
				DialogResult respuesta=MessageBox.Show($"{ex.Message} - Cerrando aplicacion","Error de Conexion",MessageBoxButtons.OK,MessageBoxIcon.Error);
				if(respuesta == DialogResult.OK) {
					this.Close();
				}
			}
			
		}

		private void btn_Ingresar_Click(object sender,EventArgs e) {
			Usuario? usuario;
			if(ControlVista.ValidarTextBox(this)) {
				usuario=Sistema.VerificarUsuarioExistente(txt_NombreUsuario.Text.Trim(),txt_Contraseña.Text.Trim());
				if(usuario is not null) {
					FrmPantallaPrincipal pantallaPrincipal = new FrmPantallaPrincipal(usuario);
					this.Hide();
					DialogResult resultado=pantallaPrincipal.ShowDialog();
					if(resultado==DialogResult.OK) {
						this.Show();
					}
				}
				else {
					MessageBox.Show("No se encontró el usuario");
				}
			}
			else {
				MessageBox.Show("Debe ingresar nombre de usuario y contraseña");
			}
		}

		private void btn_Autocompletar_Click(object sender,EventArgs e) {
			this.txt_NombreUsuario.Text="Tanito";
			this.txt_Contraseña.Text="admin1234";
		}

	}
}