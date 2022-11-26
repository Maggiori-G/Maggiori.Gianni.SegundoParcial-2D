using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public class Juego{

		Jugador jugador;
		private string informeDePartida;
		private Dictionary<string, int> jugadas;

		public string InformeDePartida {
			get => informeDePartida;
			set => informeDePartida=value;
		}

		public Dictionary<string,int> Jugadas {
			get => jugadas;
			set => jugadas=value;
		}

		public Juego(Jugador jugador) {
			this.jugador=jugador;
			informeDePartida=string.Empty;
			jugadas=InicializarDiccionarioDeJugadas();
		}

		private Dictionary<string, int> InicializarDiccionarioDeJugadas() 
		{
			Dictionary<string, int> dic = new Dictionary<string, int>()
			{
				{"Al 1",-1},
				{"Al 2",-1},
				{"Al 3",-1},
				{"Al 4",-1},
				{"Al 5",-1},
				{"Al 6",-1},
				{"Escalera",-1},
				{"Full",-1},
				{"Poker",-1},
				{"Generala",-1}
			};
			return dic;
		}

		public void ActualizarDiccionarioDeJugadas(string key, int value) {
			if(key is not null && value > 0) {
				foreach(KeyValuePair<string,int> pair in jugadas) {
					if(pair.Key==key && pair.Value==-1) {
						jugadas[pair.Key] = value;
						break;
					}
				}
			}
		}

		public int ContarPuntos() {
			int puntosTotales=0;
			if(jugadas is not null) {
				foreach(KeyValuePair<string,int> pair in jugadas) {
					puntosTotales+=pair.Value;
				}
			}
			return puntosTotales;
		}

		public bool EsEscalera() {
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

		public bool EsFull() {
			bool hayTrio=false;
			bool hayPar=false;
			int contador=0;
			bool retorno=false;
			if(jugador is not null) {
				for(int i = 0;i<jugador.Dados.Length;i++) {
					contador=0;
					for(int j = 0;j<jugador.Dados.Length;j++) {
						if(jugador.Dados[i]==jugador.Dados[j]) {
							contador++;
						}
					}
					if(contador==3) {
						hayTrio=true;
					}
					else if(contador==2) {
						hayPar=true;
					}
				}
				if(hayTrio && hayPar) {
					retorno = true;
				}
			}
			return retorno;
		}

		public bool EsPoker() {
			int contador=0;
			bool retorno=false;
			ContarDadosIguales(ref contador);
			
			if(contador == 4) {
				retorno=true;
			}
			return retorno;
		}

		public bool EsGenerala() {
			if(jugador is not null) {
				for(int i = 0;i<jugador.Dados.Length-1;i++) {
					if(jugador.Dados[i] != jugador.Dados[i+1]) {
						return false;
					}
				}
			}
			return true;
		}
		
		public int ContarDadosIguales(ref int valorDadoMasRepetido) {
			int contadorDadosIguales=1;
			int mayorCantidadDadosIguales=0;
			for(int i = 0;i<jugador.Dados.Length;i++) {
				
				for(int j = i+1;j<jugador.Dados.Length;j++) {
					if(jugador.Dados[i]==jugador.Dados[j]) {
						contadorDadosIguales++;
					}
				}
				if(i==0 || contadorDadosIguales>mayorCantidadDadosIguales && contadorDadosIguales < jugador.Dados.Length) {
					mayorCantidadDadosIguales=contadorDadosIguales;
					valorDadoMasRepetido=jugador.Dados[i];
					contadorDadosIguales=1;
				}
			}
			return mayorCantidadDadosIguales;
		}

		public int ContarDadosIguales(int numeroBuscado) {
			int contadorDadosIguales=0;
			for(int i = 0;i<jugador.Dados.Length;i++) {
				if(jugador.Dados[i]==numeroBuscado) {
					contadorDadosIguales++;
				}
			}
			return contadorDadosIguales;
		}
		
		public void JugarTurno() {
			int valorDadoMasRepetido=0;
			int cantidadDadosRepetidos=0;
			bool flagJugadaNoEspecial=false;
			jugador.TirarDados();
			if(EsGenerala() && !ValidarJugadaYaRealizada("Generala")) {
				this.ActualizarDiccionarioDeJugadas("Generala", 55);
			}
			else {
				if(EsPoker() && !ValidarJugadaYaRealizada("Poker")) {
					this.ActualizarDiccionarioDeJugadas("Poker", 45);
				}
				else {
					if(EsFull() && !ValidarJugadaYaRealizada("Full")) {
						this.ActualizarDiccionarioDeJugadas("Full", 35);
					}
					else {
						if(EsEscalera() && !ValidarJugadaYaRealizada("Escalera")) {
							this.ActualizarDiccionarioDeJugadas("Escalera", 25);
						}
						else {
							cantidadDadosRepetidos=ContarDadosIguales(ref valorDadoMasRepetido);
							if(!ValidarJugadaYaRealizada($"Al {valorDadoMasRepetido}")){
								ActualizarDiccionarioDeJugadas($"Al {valorDadoMasRepetido}",cantidadDadosRepetidos*valorDadoMasRepetido);
							}
							else {
								foreach(KeyValuePair<string, int> item in jugadas) {
									if(item.Key != "Poker" && item.Key != "Generala" && item.Key != "Full" && item.Key!="Escalera") {
										if(item.Value == -1 && BuscarJugadaNoEspecialDisponible(item,1, ref valorDadoMasRepetido, ref cantidadDadosRepetidos)) {
											ActualizarDiccionarioDeJugadas($"Al {valorDadoMasRepetido}",cantidadDadosRepetidos*valorDadoMasRepetido);
											flagJugadaNoEspecial=true;
											break;
										}
									}
								}
								if(!flagJugadaNoEspecial) {
									foreach(KeyValuePair<string, int> item in jugadas) {
										if(item.Key != "Poker" && item.Key != "Generala" && item.Key != "Full" && item.Key!="Escalera") {
											if(item.Value == -1 && BuscarJugadaNoEspecialDisponible(item,0, ref valorDadoMasRepetido, ref cantidadDadosRepetidos)) {
												ActualizarDiccionarioDeJugadas(item.Key,cantidadDadosRepetidos*valorDadoMasRepetido);
												flagJugadaNoEspecial=true;
												break;
											}
										}
									}	
								}
								if(!flagJugadaNoEspecial) {
									TacharJugadaNoEspecial();

								}
							}
						}
					}
				}
			}
		}
		

		public bool BuscarJugadaNoEspecialDisponible(KeyValuePair<string, int> jugadas, int cantidadABuscar, ref int valorDelDado, ref int repeticiones) {
			string[] valorBuscar=jugadas.Key.Split(" ");
			int contador=0;			
			for(int i = 0;i<jugador.Dados.Length;i++) {
				if(jugador.Dados[i].ToString() == valorBuscar[1]) {
					contador++;
				}
			}
			if(contador>cantidadABuscar) {
				valorDelDado=int.Parse(valorBuscar[1]);
				repeticiones=contador;
				return true;
			}
			return false;
		}

		public void TacharJugadaNoEspecial() {
			foreach(KeyValuePair<string,int> item in jugadas) {
				if(item.Value ==-1) {
					jugadas[item.Key] = 0;
					break;
				}
			}
		}

		public bool ValidarJugadaYaRealizada(string jugada) {
			if(!string.IsNullOrEmpty(jugada)) {
				if(jugadas[jugada]>0) {
					return true;
				}
			}
			return false;
		}

		public bool ChequearSiHayJugadasDisponibles() {
			foreach(KeyValuePair<string, int> item in jugadas) {
				if(item.Value ==-1) {
					return true;
				}
			}
			return false;
		}

		public string TomarRegistroJugadas() {
			StringBuilder sb = new StringBuilder();
				foreach(string item in jugadas.Keys) {
					sb.AppendLine($"{item} - {jugadas[item]}");
				}
			return sb.ToString();
		}

	}
}