using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public static class Archivo {

		static string ruta;
		public static event Action<string> Mensaje;
		static Archivo() {
			ruta=Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			ruta+=@"/Archivos";
		}

		public static string Ruta {
			get => ruta;
			set => ruta=value;
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
				Mensaje?.Invoke("Archivo creado con exito");
				return true;
			}
			catch {
				Mensaje?.Invoke("Hubo un error creando el archivo");
				throw new Exception($"Error en el archivo {rutaCompleta}");
			}
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
					Mensaje?.Invoke("Archivo leido correctamente");
				}
				else {
					Mensaje?.Invoke("Hubo un error al leer el archivo");
					throw new Exception("No se encontro el archivo");
				}
			}
			return datos;
		}

		public static bool BorrarArchivo(string nombreDelArchivo) {
			try {
				string rutaCompleta= ruta+@$"/{nombreDelArchivo}"+".txt";
				File.Delete(rutaCompleta);
				if(File.Exists(rutaCompleta)) {
					Mensaje?.Invoke("No se pudo eliminar");
				}
				else {
					Mensaje?.Invoke("Eliminado correctamente");
				}
				return true;
			}
			catch {
				return false;
			}
		}
	}
}
