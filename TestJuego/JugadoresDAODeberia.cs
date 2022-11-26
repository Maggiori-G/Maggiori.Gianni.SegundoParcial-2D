using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJuego {
	public  class JugadoresDAODeberia {

		[TestMethod]
		public void TestearBaseDeDatosJugadoresCargadaConExito() {
			List<Jugador> lista = new List<Jugador>();

			lista=JugadorDAO.GetJugadores();

			Assert.IsTrue(lista.Count>0);
		}
	}
}
