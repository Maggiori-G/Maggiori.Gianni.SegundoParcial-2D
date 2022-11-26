using Entidades;

namespace TestJuego {
	[TestClass]
	public class TestGenerala {


		[TestMethod]
		public void TestearBaseDeDatosCargadaConExito() {
			List<Jugador> lista = new List<Jugador>();

			lista=JugadorDAO.GetJugadores();
			Assert.IsTrue(lista.Count>0);

		}
		
		[TestMethod]
		public void TestearArmarJuego() {
			Jugador jugador = new Jugador(1,"gianni",0);
			Juego juego = new Juego(jugador);

			while(juego.ChequearSiHayJugadasDisponibles()) {
				juego.JugarTurno();
				foreach(KeyValuePair<string,int> item in juego.Jugadas) {
					Console.WriteLine(item);
				}
			}
			Assert.IsTrue(!juego.ChequearSiHayJugadasDisponibles());
		}

		[TestMethod]
		public void TestearSiEsEscalera() {
			Jugador jugador = new Jugador(1,"gianni",0);
			Juego juego = new Juego(jugador);
			int[] dados = {1,5,4,2,3};
			int[] dadosDos = {6,2,3,4,5};

			jugador.Dados=dados;

			Assert.IsTrue(juego.EsEscalera());
		}
	}
}