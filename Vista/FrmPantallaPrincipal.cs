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

		private void MostrarMensajeExitoso() {

		}
		
	}
}
