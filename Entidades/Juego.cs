using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public class Juego{

		private Jugador jugadorUno;
		private Jugador jugadorDos;
		private	Jugador? ganador;
		private List<string> desarrolloDeLaPartida;

		public Jugador JugadorUno {
			get => jugadorUno;
			set => jugadorUno=value;
		}
		public Jugador JugadorDos {
			get => jugadorDos;
			set => jugadorDos=value;
		}
		public Jugador? Ganador {
			get => ganador;
			set => ganador=value;
		}

		public Juego(Jugador jugadorUno,Jugador jugadorDos) {
			this.jugadorUno=jugadorUno;
			this.jugadorDos=jugadorDos;
			desarrolloDeLaPartida= new List<string>();
		}

		public int ContarPuntos(Jugador jugador) {
			int puntosTotales=0;
			if(jugador is not null) {
				foreach(KeyValuePair<string,int> pair in jugador.Jugadas) {
					puntosTotales+=pair.Value;
				}
			}
			return puntosTotales;
		}

		public bool EsEscalera(Jugador jugador) {
			if(jugador is not null) {
				for(int i = 0;i<jugador.Dados.Length; i++) {
					if((jugador.Dados.Contains(1) || jugador.Dados.Contains(6)) &&
						jugador.Dados.Contains(2) && jugador.Dados.Contains(3) && jugador.Dados.Contains(4) && jugador.Dados.Contains(5)) {
						return true;
					}
				}
			}
			return false;
		}

		public bool EsFull(Jugador jugador) {
			int contadorTrio=0;
			int contadorDuo=0;
			bool retorno=false;
			if(jugador is not null) {
				for(int i = 0;i<jugador.Dados.Length-1;i++) {
					if(jugador.Dados[i] == jugador.Dados[i+1]) {
						contadorTrio++;
					}
					else {
						contadorDuo++;
					}
				}
			}
			if(contadorTrio == 3 && contadorDuo == 2) {
				retorno=true;
			}
			return retorno;
		}

		public bool EsPoker(Jugador jugador) {
			int contador=0;
			bool retorno=false;
			if(jugador is not null) {
				for(int i = 0;i<jugador.Dados.Length-1;i++) {
					if(jugador.Dados[i] != jugador.Dados[i+1]) {
						contador++;
					}
				}
			}
			if(contador >= 4) {
				retorno=true;
			}
			return retorno;
		}

		public bool EsGenerala(Jugador jugador) {
			if(jugador is not null) {
				for(int i = 0;i<jugador.Dados.Length-1;i++) {
					if(jugador.Dados[i] != jugador.Dados[i+1]) {
						return false;
					}
				}
			}
			return true;
		}

		public int ContarDadosIguales(Jugador jugador, out int posicionConMayorCantidadDeIgualdades) {
			int contadorDeRepeticiones=1;
			int cantidadMaximaDeRepeticiones=0;
			int posicionConMasRepeticion=0;
			if(jugador is not null) {
				for(int i=0;i<jugador.Dados.Length;i++) {
					for(int j = i+1;j<jugador.Dados.Length;j++) {
						if(jugador.Dados[i]==jugador.Dados[j]) {
							contadorDeRepeticiones++;
						}
					}
					if(i==0 || contadorDeRepeticiones>cantidadMaximaDeRepeticiones && contadorDeRepeticiones>jugador.Dados.Length) {
						cantidadMaximaDeRepeticiones=contadorDeRepeticiones;
						posicionConMasRepeticion=i;
						contadorDeRepeticiones=1;
					}
					
				}
			}
			posicionConMayorCantidadDeIgualdades=posicionConMasRepeticion;
			return cantidadMaximaDeRepeticiones;
		}
		
		public KeyValuePair<string, int> BuscarValoresNoEspeciales(Jugador jugador) {
			int posicion;
			int cantidadDeRepeticionesDelDado=ContarDadosIguales(jugador, out posicion);
			int valorDelDado=jugador.Dados[posicion];
			int valorDeLaJugada=cantidadDeRepeticionesDelDado*valorDelDado;
			string estaEsLaKey="Al "+valorDelDado.ToString();
			KeyValuePair<string, int> retorno= new KeyValuePair<string, int>(estaEsLaKey,valorDeLaJugada);
			return retorno;
		}

		public void AnotarJugadaNoEspecial(Jugador jugador, KeyValuePair<string,int> jugada) {
			if(jugador is not null) {
				if(jugador.Jugadas[jugada.Key]==-1) {
					jugador.Jugadas[jugada.Key]=jugada.Value;
				}
				foreach(KeyValuePair<string, int> item in jugador.Jugadas) {
					if(item.Value==-1) {
						jugador.Jugadas[item.Key]=0;
						break;
					}
				}
			}
		}
		
		public void TomarRegistroDeLaPartida(Jugador jugador) {
			//hacer un metodo que tome los registros de cada jugada
		}

		public void JugarTurno(Jugador jugador) {
			KeyValuePair<string, int> jugadaNoEspecial;
			if(jugador is not null){
				jugador.TirarDados();
				if(EsEscalera(jugador)) {
					jugador.ActualizarDiccionarioDeJugadas("Escalera", 25);
				}
				else if(EsFull(jugador)) {
					jugador.ActualizarDiccionarioDeJugadas("Full", 35);
				}
				else if(EsPoker(jugador)) {
					jugador.ActualizarDiccionarioDeJugadas("Poker", 45);
				}
				else if(EsGenerala(jugador)) {
					jugador.ActualizarDiccionarioDeJugadas("Generala", 55);
				}
				else {
					jugadaNoEspecial=BuscarValoresNoEspeciales(jugador);
					AnotarJugadaNoEspecial(jugador, jugadaNoEspecial);
				}
			}
		}

	}
}