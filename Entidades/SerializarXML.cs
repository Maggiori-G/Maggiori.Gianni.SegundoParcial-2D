using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Entidades {
	public class SerializarXML<T>: IManejadoraDeArchivos<T> {
		static string ruta;
		static SerializarXML() {
			ruta = Environment.CurrentDirectory;
			ruta+=@"/Archivos-SerializacionXML";
		}

		public  bool Serializar(T dato, string archivo) {
			string rutaCompleta = ruta + @"/"+archivo+".xml";
			if(archivo is not null) {
				if(!Directory.Exists(ruta)) {
					Directory.CreateDirectory(ruta);
				}
				try {
					using(StreamWriter sw = new StreamWriter(rutaCompleta)) {
						XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
						xmlSerializer.Serialize(sw, dato);
						return true;
					}
				}
				catch {
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
				string rutaCompleta = ruta + @"/"+archivo+".xml";
				if(!Directory.Exists(ruta)) {
					Directory.CreateDirectory(ruta);
				}
				try {
					using(StreamReader sw = new StreamReader(rutaCompleta)) {
						XmlSerializer xmlSerializer=new XmlSerializer(typeof(T));
						datos = (T?)xmlSerializer.Deserialize(sw);
					}
				}
				catch {
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
