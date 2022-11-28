using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades {
	public class Partida {
	
		Juego juegoJugadorUno;
		Juego juegoJugadorDos;
		private bool partidaFinalizada;
		public Action<string> ganador;
		private string registro;

		public Partida(Jugador jugadorUno,Jugador jugadorDos) {
			juegoJugadorUno= new Juego(jugadorUno);
			juegoJugadorDos= new Juego(jugadorDos);
			this.registro=Sistema.GenerarCodigoAlfanumericoRandom();
		}
		
		public Partida(Jugador jugadorUno,Jugador jugadorDos, Action<string> ganador):this(jugadorUno,jugadorDos) {
			this.ganador=ganador;
		}

		public Juego JuegoJugadorUno {
			get => juegoJugadorUno;
			set => juegoJugadorUno=value;
		}

		public string Primer_Jugador {
			get {
				return juegoJugadorUno.Jugador.ToString();
			}
		}
		
		public string Segundo_Jugador {
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

		public string Registro {
			get => registro;
			set => registro=value;
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
					Archivo.EscribirArchivo(this.InformacionCompletaDeLaPartida(),"Registro de la partida "+this.Registro);
					break;
				}
			}
		}

		public void InformarGanador() {
			Task task= Task.Run(BuscarGanador);
		}

		public string InformacionCompletaDeLaPartida() {
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Registro de la partida: {this.registro}");
			sb.AppendLine(juegoJugadorUno.MostrarInformacionJuego());
			sb.AppendLine(juegoJugadorDos.MostrarInformacionJuego());
			
			return sb.ToString();
		}
	}
}
