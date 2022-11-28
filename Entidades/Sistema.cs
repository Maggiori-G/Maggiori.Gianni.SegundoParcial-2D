using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public static class Sistema {

		private static List<Usuario> listaUsuarios;
		private static List<Jugador> listaJugadores;
		private static List<Partida> listaPartidas;

		static Sistema() {
			listaUsuarios = new List<Usuario>();
			listaJugadores = new List<Jugador>();
			listaPartidas = new List<Partida>();
		}

		public static List<Usuario> ListaUsuarios {
			get => listaUsuarios;
			set => listaUsuarios=value;
		}

		public static List<Jugador> ListaJugadores {
			get => listaJugadores;
			set => listaJugadores=value;
		}

		public static List<Partida> ListaPartidas {
			get => listaPartidas;
			set => listaPartidas=value;
		}

		public static Usuario? VerificarUsuarioExistente(string nombreUsuario, string contraseña) {
			if(!string.IsNullOrEmpty(nombreUsuario) && !string.IsNullOrEmpty(contraseña)) {
				foreach(Usuario item in listaUsuarios) {
					if(item.NombreUsuario==nombreUsuario && item.Contraseña==contraseña) {
						return item;
					}
				}
			}
			return null;
		}

		public static bool ValidarMesaConJugadoresIguales(Jugador jugadorUno, Jugador jugadorDos) {
			if(jugadorUno is not null && jugadorDos is not null) {
				return jugadorUno==jugadorDos;
			}
			return false;
		}
	}
}
