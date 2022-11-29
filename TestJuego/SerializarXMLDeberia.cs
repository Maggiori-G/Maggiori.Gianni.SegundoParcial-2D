using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJuego {
	[TestClass]
	public class SerializarXMLDeberia {

		public void MostrarMensaje(string mensaje) {
			Console.WriteLine(mensaje);
		}

		[TestMethod]
		public void TestearLecturaYEscritura_Ok() {
			SerializarXML<string> serializador = new SerializarXML<string>();
			serializador.Mensaje+=MostrarMensaje;
			string dato="Prueba en XML";
			string nombreArchivo="PruebaXML";
			string resultadoEsperado=string.Empty;

			serializador.Serializar(dato,nombreArchivo);
			resultadoEsperado=serializador.Deserializar(nombreArchivo);

			Assert.AreEqual(resultadoEsperado, dato);
		}
	}
}
