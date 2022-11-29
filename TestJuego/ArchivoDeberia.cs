using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJuego {
	[TestClass]
	public class ArchivoDeberia {
		
		public void ImprimirMensaje(string mensaje) {
			Console.WriteLine(mensaje);
		}


		[TestMethod]
		public void EscribirArchivo_Ok() {
			string dato = "Archivo de prueba";
			string nombreArchivo="ArchivoPrueba";
			string rutaCompleta=Archivo.Ruta+@$"\{nombreArchivo}"+".txt";
			Archivo.EscribirArchivo(dato, nombreArchivo);
			Archivo.Mensaje+=ImprimirMensaje;
			Assert.AreEqual(Archivo.BuscarArchivo(Archivo.Ruta,nombreArchivo),rutaCompleta);

			Archivo.BorrarArchivo(nombreArchivo);
		}
		
		[TestMethod]
		public void LeerArchivo_Ok() {
			string dato = "Esto es otra prueba";
			string nombreArchivo="ArchivoPrueba";
			string lectura=string.Empty;
			string rutaCompleta=Archivo.Ruta+@$"\{nombreArchivo}"+".txt";

			Archivo.EscribirArchivo(dato, nombreArchivo);
			Archivo.Mensaje+=ImprimirMensaje;
			lectura=Archivo.LeerArchivo(nombreArchivo).Trim();
			
			
			Console.WriteLine(lectura);
			Assert.IsTrue(dato == lectura);
			Assert.AreEqual(dato, lectura);
			Archivo.BorrarArchivo(nombreArchivo);
		}
	}
}
