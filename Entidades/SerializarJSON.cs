using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Entidades {
	public class SerializarJSON<T>where T: class, IManejadoraDeArchivos<T> {
		static string ruta;
		static SerializarJSON() {
			ruta = Environment.CurrentDirectory;
			ruta+=@"/Archivos-SerializacionJSON";
		}

		public bool Serializar(T dato,string nombreDelArchivo) {
			string rutaCompleta=ruta+@"/"+nombreDelArchivo+".json";
			string objetoJSON=string.Empty;
			if(!string.IsNullOrEmpty(nombreDelArchivo)) {
				if(!Directory.Exists(ruta)) {
					Directory.CreateDirectory(ruta);
				}
				try {
					JsonSerializerOptions opciones = new JsonSerializerOptions();
					opciones.WriteIndented=true;
					objetoJSON=JsonSerializer.Serialize(dato, opciones);
					File.WriteAllText(rutaCompleta, objetoJSON);
					return true;
				}
				catch {
					throw new Exception("Error al leer el archivo");
				}
			}
			else {
				throw new Exception("Error en el archivo");
			}
		}

		public T Deserializar(string nombreDelArchivo) {
			T? datos = default;
			string rutaCompleta=ruta+@"/"+nombreDelArchivo+".json";
			string archivoJSON=string.Empty;
			if(!Directory.Exists(ruta)) {
				Directory.CreateDirectory(ruta);
			}
			try {
				archivoJSON = File.ReadAllText(rutaCompleta);
				datos=JsonSerializer.Deserialize<T>(archivoJSON);
				return datos!;
			}
			catch {
				throw new Exception("Error al leer el archivo");
			}
		}
	}
}
