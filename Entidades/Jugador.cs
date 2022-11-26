using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public class Jugador {

		private int id;
		private string? nombreCompleto;
		private int cantidadVictorias;
		private int[] dados;
		public event Action mostrarDados;//testeo borrar despues

		public Jugador() {
		
		}
		
		public Jugador(int id,string nombreCompleto,int cantidadVictorias) {
			this.id = id;
			this.nombreCompleto = nombreCompleto;
			this.cantidadVictorias=cantidadVictorias;
			this.dados = new int[5];
		}

		

		public int Id {
			get => this.id;
			set => this.id = value;
		}

		public string Nombre {
			get => this.nombreCompleto!;
			set => this.nombreCompleto = value;
		}

		public int CantidadDeVictorias {
			get => this.cantidadVictorias;
			set => this.cantidadVictorias=value;
		}

		public int[] Dados {
			get => this.dados;
			set => this.dados = value;
		}

		public void TirarDados() {
			Random random = new Random();
			for(int i=0;i<dados.Length;i++) {
				this.dados[i]=random.Next(1,6);
			}
			mostrarDados?.Invoke();

		}

		public override string ToString() {
			return this.nombreCompleto!;
		}

		public string InformarTirada() {
			StringBuilder sb = new StringBuilder();
			for(int i = 0;i<dados.Length;i++) {
				if(dados.Length-1 == i) {
					sb.Append($"{dados[i]}");
				}
				else {
					sb.Append($"{dados[i]} - ");
				}
			}
			return sb.ToString();
		}

		public static  bool operator ==(Jugador j1, Jugador j2) {
			return j1.id == j2.id;
		}

		public static bool operator !=(Jugador j1, Jugador j2) {
			return !(j1==j2);
		}

		
	}
}
