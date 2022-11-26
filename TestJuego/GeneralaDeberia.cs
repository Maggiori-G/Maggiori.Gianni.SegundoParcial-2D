using Entidades;

namespace TestJuego {
	[TestClass]
	public class GeneralaDeberia {

		[TestMethod]
		public void TestearArmarJuego() {
			Jugador jugador = new Jugador(1,"gianni",0);
			Juego juego = new Juego(jugador);

			while(juego.ChequearSiHayJugadasDisponibles()) {
				juego.JugarTurno();
			}

			Assert.IsTrue(!juego.ChequearSiHayJugadasDisponibles());
		}
		
		[DataRow(1,2,3,4,5)]
		[DataRow(6,2,3,4,5)]
		[DataRow(4,2,5,3,1)]
		[DataRow(4,6,5,3,2)]
		[TestMethod]
		public void TestearSiEsEscalera_Ok(int uno, int dos, int tres, int cuatro, int cinco) {
			Jugador jugador = new Jugador(1,"gianni",0);
			Juego juego = new Juego(jugador);
			int[] dados = {uno,dos,tres,cuatro,cinco};

			jugador.Dados=dados;

			Assert.IsTrue(juego.EsEscalera());
		}
		
		[DataRow(2,2,3,4,5)]
		[DataRow(5,2,3,4,5)]
		[DataRow(4,3,3,3,1)]
		[DataRow(5,6,5,3,5)]
		[TestMethod]
		public void TestearSiEsEscalera_Error(int uno, int dos, int tres, int cuatro, int cinco) {
			Jugador jugador = new Jugador(1,"gianni",0);
			Juego juego = new Juego(jugador);
			int[] dados = {uno,dos,tres,cuatro,cinco};

			jugador.Dados=dados;

			Assert.IsFalse(juego.EsEscalera());
		}
		
		[DataRow(2,2,2,4,4)]
		[DataRow(5,5,1,1,5)]
		[DataRow(1,3,3,3,1)]
		[DataRow(5,6,5,6,5)]
		[TestMethod]
		public void TestearSiEsFull_Ok(int uno, int dos, int tres, int cuatro, int cinco) {
			Jugador jugador = new Jugador(1,"gianni",0);
			Juego juego = new Juego(jugador);
			int[] dados = {uno,dos,tres,cuatro,cinco};
			

			jugador.Dados=dados;

			Assert.IsTrue(juego.EsFull());
		}

		[DataRow(2,2,1,4,4)]
		[DataRow(5,5,5,1,5)]
		[DataRow(1,3,2,3,1)]
		[DataRow(5,6,4,6,5)]
		[TestMethod]
		public void TestearSiEsFull_Error(int uno, int dos, int tres, int cuatro, int cinco) {
			Jugador jugador = new Jugador(1,"gianni",0);
			Juego juego = new Juego(jugador);
			int[] dados = {uno,dos,tres,cuatro,cinco};
			

			jugador.Dados=dados;

			Assert.IsFalse(juego.EsFull());
		}

		[DataRow(4,4,1,4,4)]
		[DataRow(5,5,5,1,5)]
		[DataRow(1,1,1,3,1)]
		[DataRow(6,6,6,6,5)]
		[TestMethod]
		public void TestearSiEsPoker_Ok(int uno, int dos, int tres, int cuatro, int cinco) {
			Jugador jugador = new Jugador(1,"gianni",0);
			Juego juego = new Juego(jugador);
			int[] dados = {uno,dos,tres,cuatro,cinco};
			

			jugador.Dados=dados;

			Assert.IsTrue(juego.EsPoker());
		}
		
		[DataRow(4,5,1,4,4)]
		[DataRow(5,6,5,1,5)]
		[DataRow(1,2,1,3,1)]
		[DataRow(6,4,6,6,5)]
		[TestMethod]
		public void TestearSiEsPoker_Error(int uno, int dos, int tres, int cuatro, int cinco) {
			Jugador jugador = new Jugador(1,"gianni",0);
			Juego juego = new Juego(jugador);
			int[] dados = {uno,dos,tres,cuatro,cinco};
			

			jugador.Dados=dados;

			Assert.IsFalse(juego.EsPoker());
		}

		[DataRow(5,5,5,5,5)]
		[DataRow(1,1,1,1,1)]
		[TestMethod]
		public void TestearSiEsGenerala_Ok(int uno, int dos, int tres, int cuatro, int cinco) {
			Jugador jugador = new Jugador(1,"gianni",0);
			Juego juego = new Juego(jugador);
			int[] dados = {uno,dos,tres,cuatro,cinco};
			

			jugador.Dados=dados;

			Assert.IsTrue(juego.EsGenerala());
		}

		[DataRow(1,1,1,1,5)]
		[DataRow(1,1,3,1,1)]
		[DataRow(6,1,3,1,1)]
		[TestMethod]
		public void TestearSiEsGenerala_Error(int uno, int dos, int tres, int cuatro, int cinco) {
			Jugador jugador = new Jugador(1,"gianni",0);
			Juego juego = new Juego(jugador);
			int[] dados = {uno,dos,tres,cuatro,cinco};
			

			jugador.Dados=dados;

			Assert.IsFalse(juego.EsGenerala());
		}
		
		[DataRow(1,1,1,1,5,1,4)]
		[DataRow(3,1,3,2,6,3,2)]
		[DataRow(4,4,1,2,4,4,3)]
		[TestMethod]
		public void TestearContarDadosIgualesNumeroEspecifico_Ok(int uno, int dos, int tres, int cuatro, int cinco, int numeroBuscar, int cantidadDeRepeticionesEsperada) {
			Jugador jugador = new Jugador(1,"gianni",0);
			Juego juego = new Juego(jugador);
			int[] dados = {uno,dos,tres,cuatro,cinco};

			int contador=0;
			jugador.Dados=dados;
			contador=juego.ContarDadosIguales(numeroBuscar);
			
			Assert.IsTrue(contador==cantidadDeRepeticionesEsperada);
		}

		[DataRow(1,1,1,1,5,1,2)]
		[DataRow(3,1,3,2,6,3,3)]
		[DataRow(4,4,1,2,4,4,5)]
		[TestMethod]
		public void TestearContarDadosIgualesNumeroEspecifico_Error(int uno, int dos, int tres, int cuatro, int cinco, int numeroBuscar, int cantidadDeRepeticionesEsperada) {
			Jugador jugador = new Jugador(1,"gianni",0);
			Juego juego = new Juego(jugador);
			int[] dados = {uno,dos,tres,cuatro,cinco};

			int contador=0;
			jugador.Dados=dados;
			contador=juego.ContarDadosIguales(numeroBuscar);
			
			Assert.IsFalse(contador==cantidadDeRepeticionesEsperada);
		}

		[DataRow(5,5,5,2,2,"Al 2", 4)]
		[DataRow(3,3,5,5,1,"Al 3", 6)]
		[DataRow(5,5,5,5,5,"", 0)]
		[TestMethod]
		public void TestearBuscarJugadaNoDisponible_Ok(int uno, int dos, int tres, int cuatro, int cinco, string resultadoEsperado, int puntajeRealizado) {
			Jugador jugador = new Jugador(1,"Gianni",0);
			Juego juego =new Juego(jugador);
			int[] dados = {uno,dos,tres,cuatro,cinco};
			string jugada;
			int puntaje=0;
			jugador.Dados = dados;
			juego.Jugadas = new Dictionary<string, int>()
			{
				{"Al 1",-1},
				{"Al 2",-1},
				{"Al 3",-1},
				{"Al 4",-1},
				{"Al 5",15},
				{"Al 6",-1},
				{"Escalera",-1},
				{"Full",-1},
				{"Poker",-1},
				{"Generala",-1}
			};
			
			jugada=juego.BuscarJuegoNoEspecialDisponible(out puntaje);
			

			Assert.AreEqual(resultadoEsperado, jugada);
			Assert.AreEqual(puntajeRealizado, puntaje);
		}
		
		
		[DataRow(4,2,6,8,10,18,0,35,0,55,138)]
		[DataRow(1,4,3,4,5,12,25,0,45,0,99)]
		[DataRow(2,4,3,8,15,18,0,35,0,0,85)]
		[DataRow(0,0,6,0,5,0,25,35,0,0,71)]
		[TestMethod]
		public void TestearContarPuntosCuantaCorrectamenteElPuntaje(int uno, int dos, int tres, int cuatro, int cinco, int seis, int escalera, int full, int poker, int generala, int puntajeEsperado) {
			Jugador jugador = new Jugador(1,"Gianni",0);
			Juego juego =new Juego(jugador);
			juego.Jugadas = new Dictionary<string, int>()
			{
				{"Al 1",uno},
				{"Al 2",dos},
				{"Al 3",tres},
				{"Al 4",cuatro},
				{"Al 5",cinco},
				{"Al 6",seis},
				{"Escalera",escalera},
				{"Full",full},
				{"Poker",poker},
				{"Generala",generala}
			};

			int puntaje=juego.ContarPuntos();
			
			Assert.AreEqual(puntajeEsperado,puntaje);
		}
		

	}
}