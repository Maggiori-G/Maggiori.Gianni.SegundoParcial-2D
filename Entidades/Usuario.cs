using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public class Usuario {
		private int id;
		private string? nombreCompleto;
		private string? nombreUsuario;
		private string? contraseña;
		private string? email;

		public Usuario() {}

		public Usuario(int id,string nombreCompleto,string nombreUsuario,string contraseña,string email) {
			this.id=id;
			this.nombreCompleto=nombreCompleto;
			this.nombreUsuario=nombreUsuario;
			this.contraseña=contraseña;
			this.email=email;
		}

		public int Id {
			get => id;
		}
		public string NombreCompleto {
			get => nombreCompleto!;
			set => this.nombreCompleto = value;
		}
		public string NombreUsuario {
			get => nombreUsuario!;
			set => nombreUsuario=value;
		}
		public string Contraseña {
			get => contraseña!;
			set => contraseña=value;
		}
		public string Email {
			get => email!;
			set => email=value;
		}

		
	}
}
