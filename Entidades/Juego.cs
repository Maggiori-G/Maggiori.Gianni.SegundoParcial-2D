using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public delegate void DelegadoInformarPartida(string tirada);
	public delegate void DelegadoActualizarPuntos(int puntos);
	public delegate void DelegadoActualizarJugadas(List<KeyValuePair<string,int>> tablaDeJugadas);
	public class Juego{

		Jugador jugador;
		private Dictionary<string, int> jugadas;
		public event DelegadoInformarPartida InformePartida;
		public event DelegadoActualizarPuntos InformeActualizarPuntos;
		public event DelegadoActualizarJugadas ActualizarTablaJugadas;
		CancellationTokenSource cancellation; 

		public Dictionary<string,int> Jugadas {
			get => jugadas;
			set => jugadas=value;
		}

		public Jugador Jugador {
			get => jugador;
			set => jugador=value;
		}
		public CancellationTokenSource Cancellation {
			get => cancellation;
			set => cancellation=value;
		}

		public Juego(Jugador jugador) {
			this.jugador=jugador;
			jugadas=InicializarDiccionarioDeJugadas();
			cancellation = new CancellationTokenSource();
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
					if(pair.Value!=-1) {
						puntosTotales+=pair.Value;
					}
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
			int valor=0;
			bool retorno=false;
			contador=ContarDadosIguales(ref valor);
			
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
			jugador.TirarDados();
			if(EsGenerala() && ValidarJugadaParaRealizar("Generala")) {
				this.ActualizarDiccionarioDeJugadas("Generala", 55);
			}
			else {
				if(EsPoker() && ValidarJugadaParaRealizar("Poker")) {
					this.ActualizarDiccionarioDeJugadas("Poker", 45);
				}
				else {
					if(EsFull() && ValidarJugadaParaRealizar("Full")) {
						this.ActualizarDiccionarioDeJugadas("Full", 35);
					}
					else {
						if(EsEscalera() && ValidarJugadaParaRealizar("Escalera")) {
							this.ActualizarDiccionarioDeJugadas("Escalera", 25);
						}
						else {
							int puntaje;
							string keyJugada = BuscarJuegoNoEspecialDisponible(out puntaje);
							if(!string.IsNullOrEmpty(keyJugada)) {
								ActualizarDiccionarioDeJugadas(keyJugada,puntaje);
							}
							else {
								TacharJugada();
							}
						}
					}
				}
			}
		}

		public string BuscarJuegoNoEspecialDisponible(out int puntaje)
        {
            string jugadaElegida = string.Empty;
            int contador;
            int contadorMayorRepeticiones = 0;
            int numeroMayor = 0;
            int numero = 0;
			puntaje=0;
            foreach (string item in jugadas.Keys){
                if (item.Contains("Al ") && jugadas[item] == -1){
                    contador = 0;
                    for (int i = 0; i < jugador.Dados.Length; i++){
                        if (item.Contains(jugador.Dados[i].ToString())){
                            contador++;
                            numero = jugador.Dados[i];
                        }
                    }
                    if (contador > contadorMayorRepeticiones || (contador == contadorMayorRepeticiones && (numero*contador) > (numeroMayor*contadorMayorRepeticiones))){
                        contadorMayorRepeticiones = contador;
                        jugadaElegida = item;
                        numeroMayor = numero;
                    }
                }    
            }
			if(!string.IsNullOrEmpty(jugadaElegida)) {
				puntaje=numeroMayor*contadorMayorRepeticiones;
			}
            return jugadaElegida;
        }

		public void TacharJugada() {
			foreach(KeyValuePair<string,int> item in jugadas) {
				if(item.Value ==-1) {
					jugadas[item.Key] = 0;
					break;
				}
			}
		}

		public bool ValidarJugadaParaRealizar(string jugada) {
			if(!string.IsNullOrEmpty(jugada)) {
				if(jugadas[jugada]==-1) {
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

		public void EmpezarPartida() {
			Task jugarPartida=Task.Run(() => JugarPartida(this.cancellation.Token));
		}

		public void JugarPartida(CancellationToken cancellation) {
			while(ChequearSiHayJugadasDisponibles() && !cancellation.IsCancellationRequested) {
				JugarTurno();
				InformePartida?.Invoke(this.jugador.InformarTirada());
				InformeActualizarPuntos?.Invoke(ContarPuntos());
				ActualizarTablaJugadas?.Invoke(jugadas.ToList());
				Thread.Sleep(2500);
			}
		}


		public string MostrarInformacionJuego() {
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(jugador.MostrarInformacionJugador());
			sb.AppendLine($"Tabla del juego realizado:");
			foreach(KeyValuePair<string,int> item in jugadas) {
				sb.AppendLine($"{item.ToString()}");
			}
			sb.AppendLine($"Y termino la partida con: {ContarPuntos()}");
			return sb.ToString();
		}
	}
}