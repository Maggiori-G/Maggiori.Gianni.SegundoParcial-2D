using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Entidades {
	public class SerializarXML<T>: IManejadoraDeArchivos<T>where T:class {
		static string ruta;
		public event Action<string> Mensaje;
		static SerializarXML() {
			ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			ruta+=@"/Archivos";
		}
		
		public bool Serializar(T dato, string archivo) {
			string rutaCompleta = ruta + @"/"+archivo+".xml";
			if(archivo is not null) {
				if(!Directory.Exists(ruta)) {
					Directory.CreateDirectory(ruta);
				}
				try {
					using(StreamWriter sw = new StreamWriter(rutaCompleta,false,Encoding.UTF8)) {
						XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
						xmlSerializer.Serialize(sw, dato);
					}
					Mensaje?.Invoke("Archivo serializado correctamente");
					return true;
				}
				catch {
					Mensaje?.Invoke("Ocurrio un error al serializar el archivo");
					throw new Exception("Error al escribir el archivo");
				}
			}
			else {
				throw new Exception("Error al serializar el archivo");
			}
		}

		public T Deserializar(string nombreDelArchivo) {
			string archivo = string.Empty;
			T? datos=default;
			if(archivo is not null) {
				string rutaCompleta = ruta + @"/"+nombreDelArchivo+".xml";
				if(!Directory.Exists(ruta)) {
					Directory.CreateDirectory(ruta);
				}
				try {
					using(StreamReader sw = new StreamReader(rutaCompleta)) {
						XmlSerializer xmlSerializer=new XmlSerializer(typeof(T));
						datos = (T?)xmlSerializer.Deserialize(sw);
					}
					Mensaje?.Invoke("Archivo guardado correctamente");
				}
				catch {
					Mensaje?.Invoke("Ocurrio un error al guardar un archivo");
					throw new Exception("Error al leer el archivo");
				}
			}
			else {
				throw new Exception("Error en el archivo");
			}
			return datos!;
		} 
	}
}
