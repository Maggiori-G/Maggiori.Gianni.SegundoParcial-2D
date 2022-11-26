using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public class Partida {
		Jugador jugadorUno;
		Jugador jugadorDos;
		Juego juego;

		public Partida(Jugador jugadorUno,Jugador jugadorDos,Juego juego) {
			this.jugadorUno=jugadorUno;
			this.jugadorDos=jugadorDos;
			this.juego=juego;
		}

		public Jugador JugadorUno {
			get => jugadorUno;
			set => jugadorUno=value;
		}

		public Jugador JugadorDos {
			get => jugadorDos;
			set => jugadorDos=value;
		}

		public Juego Juego {
			get => juego;
			set => juego=value;
		}


	}
}
