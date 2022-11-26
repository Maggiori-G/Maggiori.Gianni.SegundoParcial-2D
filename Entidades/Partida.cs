using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public class Partida {
	
		Juego juegoJugadorUno;
		Juego juegoJugadorDos;
		private bool partidaFinalizada;
		private string informePartida;

		public Partida(Jugador jugadorUno,Jugador jugadorDos) {
			juegoJugadorUno= new Juego(jugadorUno);
			juegoJugadorDos= new Juego(jugadorDos);
			partidaFinalizada=false;
			informePartida=string.Empty;
		}

		public Juego JuegoJugadorUno {
			get => juegoJugadorUno;
			set => juegoJugadorUno=value;
		}

		public Juego JuegoJugadorDos {
			get => juegoJugadorDos;
			set => juegoJugadorDos=value;
		}
		public bool PartidaFinalizada {
			get => partidaFinalizada;
			set => partidaFinalizada=value;
		}
		public string InformePartida {
			get => informePartida;
			set => informePartida=value;
		}
	}
}
