using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public static class Sistema {
		private static List<Usuario> listaUsuarios;
		private static List<Jugador> listaJugadores;
		private static List<Juego> listaPartidas;

		static Sistema() {
			listaUsuarios = new List<Usuario>();
			listaJugadores = new List<Jugador>();
			listaPartidas = new List<Juego>();
		}
		public static Usuario? VerificarUsuarioExistente(string nombreUsuario, string contraseña) {
			if(!string.IsNullOrEmpty(nombreUsuario)&&!string.IsNullOrEmpty(contraseña)) {
				foreach(Usuario item in listaUsuarios) {
					if(item.NombreUsuario==nombreUsuario && item.Contraseña==contraseña) {
						return item;
					}
				}
			}
			return null;
		}
	}
}
