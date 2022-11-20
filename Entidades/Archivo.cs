using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public static class Archivo {

		static string ruta;
		
		static Archivo() {
			ruta=Environment.CurrentDirectory;
			ruta+=@"/Archivos";
		}

		public static string? BuscarArchivo(string ruta, string nombreDelArchivo){
			string[] archivos=Directory.GetFiles(ruta);
			foreach (string item in archivos) {
				if(item.Contains(nombreDelArchivo)) {
					return item;
				}
			}
			return null;
		}
		public static bool EscribirArchivo(string dato, string nombreDelArchivo) {
			string rutaCompleta= ruta+@$"/{nombreDelArchivo}"+".txt";
			try {
				if(!Directory.Exists(ruta)) {
					Directory.CreateDirectory(ruta);
				}
				using(StreamWriter sw = new StreamWriter(rutaCompleta)) {
					sw.WriteLine(dato);
				}
				return true;
			}
			catch {
				throw new Exception($"Error en el archivo {rutaCompleta}");
			}
			return false;
		}

		public static bool EscribirConBusqueda(string dato, string nombreDelArchivo) {
			string? rutaCompleta;
			if(!Directory.Exists(ruta)) {
				Directory.CreateDirectory(ruta);
			}
			if(dato is not null && nombreDelArchivo is not null) {
				rutaCompleta = BuscarArchivo(ruta,nombreDelArchivo);
				if(rutaCompleta is not null) {
					using(StreamWriter sw =new StreamWriter(rutaCompleta)) {
						sw.WriteLine(dato);
					}
					return true;
				}
				else {
					throw new Exception("No se encontro el archivo");
				}
			}
			else {
				return false;
			}
		}
		public static string LeerArchivo(string nombreDelArchivo) {
			string? rutaCompleta;
			string datos = string.Empty;
			if(Directory.Exists(ruta)) {
				rutaCompleta = BuscarArchivo(ruta,nombreDelArchivo);
				if(rutaCompleta is not null) {
					using(StreamReader sr =new StreamReader(rutaCompleta)) {
						string? linea;
						linea=sr.ReadToEnd();
						datos+=linea;
					}
				}
				else {
					throw new Exception("No se encontro el archivo");
				}
			}
			return datos;
		}

		
	}
}
