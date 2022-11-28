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
		public Action<string> ganador;


		public Partida(Jugador jugadorUno,Jugador jugadorDos) {
			juegoJugadorUno= new Juego(jugadorUno);
			juegoJugadorDos= new Juego(jugadorDos);
			partidaFinalizada=false;
			informePartida=string.Empty;
		}
		
		public Partida(Jugador jugadorUno,Jugador jugadorDos, Action<string> ganador):this(jugadorUno,jugadorDos) {
			this.ganador=ganador;
		}

		public Juego JuegoJugadorUno {
			get => juegoJugadorUno;
			set => juegoJugadorUno=value;
		}

		public string PrimerJugador {
			get {
				return juegoJugadorUno.Jugador.ToString();
			}
		}
		
		public string SegundoJugador {
			get {
				return juegoJugadorDos.Jugador.ToString();
			}
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

		public void BuscarGanador() {
			string nombreJugadorGanador = string.Empty;
			while(true) {
				if(!juegoJugadorUno.ChequearSiHayJugadasDisponibles() && !juegoJugadorDos.ChequearSiHayJugadasDisponibles()) {
					nombreJugadorGanador="Empate";
					if(juegoJugadorUno.ContarPuntos() > juegoJugadorDos.ContarPuntos()) {
						JuegoJugadorUno.Jugador.CantidadDeVictorias++;
						nombreJugadorGanador=juegoJugadorUno.Jugador.ToString();
					}
					else if(juegoJugadorUno.ContarPuntos() < juegoJugadorDos.ContarPuntos()) {
						JuegoJugadorDos.Jugador.CantidadDeVictorias++;
						nombreJugadorGanador = juegoJugadorDos.Jugador.ToString();
					}
					ganador?.Invoke(nombreJugadorGanador);
					break;
				}
			}
		}

		public void InformarGanador() {
			Task task= Task.Run(BuscarGanador);
		}
	}
}
