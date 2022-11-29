using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJuego {
	[TestClass]
	public  class JugadorDAODeberia {

		[TestMethod]
		public void TestearBaseDeDatosJugadoresCargadaConExito() {
			List<Jugador> lista = new List<Jugador>();

			lista=JugadorDAO.GetJugadores();

			Assert.IsTrue(lista.Count>0);
		}

		[TestMethod]
		public void VerificarEscritura_Ok() {
			string nombre="Fulanito de Prueba";
			Jugador? jugadorBuscado=null;

			JugadorDAO.EscribirNuevoJugador(nombre);
			jugadorBuscado=JugadorDAO.BuscarJugadorPorNombre(nombre);

			Assert.IsTrue(jugadorBuscado.Nombre == nombre);
		}
		
		[TestMethod]
		public void VerificarEscritura_OkPuntoDos() {
			string nombre="Fulanito de Prueba";
			List<Jugador>? listaJugadores=null;

			JugadorDAO.EscribirNuevoJugador(nombre);
			listaJugadores=JugadorDAO.GetJugadores();

			Assert.IsFalse(listaJugadores.TrueForAll(x => x.Nombre != nombre));
		}
		
		[TestMethod]
		public void VerificarEliminado_Ok() {
			string nombre="Fulanito de Prueba";
			List<Jugador>? listaJugadores=null;

			JugadorDAO.EscribirNuevoJugador(nombre);
			JugadorDAO.EliminarPorNombre(nombre);
			listaJugadores=JugadorDAO.GetJugadores();

			Assert.IsTrue(listaJugadores.TrueForAll(x => x.Nombre != nombre));
		}
	}
}
