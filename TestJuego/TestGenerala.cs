using Entidades;

namespace TestJuego {
	[TestClass]
	public class TestGenerala {


		[TestMethod]
		public void TestearBaseDeDatosCargadaConExito() {
			List<Jugador> lista = new List<Jugador>();

			lista=JugadorDAO.GetJugadores();

			//Console.WriteLine(lista.Count);
			Assert.IsTrue(lista.Count>0);

		}
		
		
		[TestMethod]
		public void TestearDadosIguales() {
			Jugador jugador1=new Jugador(0, "Eze Tabo", 20);
			Jugador jugador2=new Jugador(0, "Gianni Maggiori", 20);
			Juego juegoNuevo = new Juego(jugador1,jugador2);
			int contadorDeDados=0;
			int posicionDelDadoRepetido=0;
			
			jugador1.TirarDados();
			for(int i = 0;i<5;i++) {
				Console.WriteLine(jugador1.Dados[i]);
			}

			contadorDeDados=juegoNuevo.ContarDadosIguales(jugador1, out posicionDelDadoRepetido);

			Console.WriteLine($"numero repetido: {jugador1.Dados[posicionDelDadoRepetido]}, Cantidad: {contadorDeDados}");

			Assert.IsTrue(true);
		}
		
		

	}
}