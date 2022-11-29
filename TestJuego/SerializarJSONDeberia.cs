using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJuego {
	[TestClass]
	public class SerializarJSONDeberia {
		
		public void MostrarMensaje(string mensaje) {
			Console.WriteLine(mensaje);
		}

		[TestMethod]
		public void TestearLecturaYEscrituraJSON_Ok() {
			SerializarJSON<string> serializador = new SerializarJSON<string>();
			serializador.Mensaje+=MostrarMensaje;
			string dato="Prueba en JSON";
			string nombreArchivo="PruebaJSON";
			string resultadoEsperado=string.Empty;

			serializador.Serializar(dato,nombreArchivo);
			resultadoEsperado=serializador.Deserializar(nombreArchivo);

			Console.WriteLine(resultadoEsperado);
			Assert.AreEqual(resultadoEsperado, dato);
		}
	}
}
