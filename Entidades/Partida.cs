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
			partidaFinalizada=false;
		}
		
		public Partida(Jugador jugadorUno,Jugador jugadorDos, Action<string> ganador):this(jugadorUno,jugadorDos) {
			this.ganador=ganador;
		}

		public string Registro {
			get => registro;
			set => registro=value;
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


		public void BuscarGanador() {
			try {
				string nombreJugadorGanador = string.Empty;
				while(true) {
					if(!juegoJugadorUno.ChequearSiHayJugadasDisponibles() && !juegoJugadorDos.ChequearSiHayJugadasDisponibles()) {
						nombreJugadorGanador="Empate";
						if(juegoJugadorUno.ContarPuntos() > juegoJugadorDos.ContarPuntos()) {
							JuegoJugadorUno.Jugador.Victorias++;
							JugadorDAO.ActualizarVictoriasJugadorDAO(JuegoJugadorUno.Jugador);
							nombreJugadorGanador=juegoJugadorUno.Jugador.ToString();
						}
						else if(juegoJugadorUno.ContarPuntos() < juegoJugadorDos.ContarPuntos()) {
							JuegoJugadorDos.Jugador.Victorias++;
							JugadorDAO.ActualizarVictoriasJugadorDAO(JuegoJugadorDos.Jugador);
							nombreJugadorGanador = juegoJugadorDos.Jugador.ToString();
						}
						PartidaFinalizada=true;
						ganador?.Invoke(nombreJugadorGanador);
						Archivo.EscribirArchivo(this.InformacionCompletaDeLaPartida(),"Registro de la partida "+this.Registro);
						break;
					}
				}
			}
			catch {
				throw new Exception("No se pudo jugar la partida");
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
