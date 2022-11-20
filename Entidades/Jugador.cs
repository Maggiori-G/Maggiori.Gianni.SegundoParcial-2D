using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public class Jugador {
		private int id;
		private string nombre;
		private int cantidadVictorias;
		private int[] dados;
		private Dictionary<string, int> jugadas;
		
		public Jugador(int id,string nombre,int cantidadVictorias) {
			this.id = id;
			this.nombre = nombre;
			this.cantidadVictorias=cantidadVictorias;
			this.dados = new int[5];
			this.jugadas = InicializarDiccionarioDeJugadas();
		}

		public Dictionary<string,int> Jugadas {
			get => this.jugadas;
			set => this.jugadas = value;
		}
		public int Id {
			get => this.id;
		}
		public string Nombre {
			get => this.nombre;
		}
		public int CantidadDeVictorias {
			get => this.cantidadVictorias;
			set => this.cantidadVictorias=value;
		}
		public int[] Dados {
			get => this.dados;
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

		public void TirarDados() {
			Random random = new Random();
			for(int i=0;i<dados.Length;i++) {
				this.dados[i]=random.Next(1,6);
			}
		}
		
		public void ActualizarDiccionarioDeJugadas(string key, int value) {
			if(key is not null && value > 0) {
				foreach(KeyValuePair<string,int> pair in this.Jugadas) {
					if((pair.Key==key && pair.Value!=0) && pair.Value==-1) {
						this.Jugadas[pair.Key] = value;
						break;
					}
				}
			}
		}

	}
}
