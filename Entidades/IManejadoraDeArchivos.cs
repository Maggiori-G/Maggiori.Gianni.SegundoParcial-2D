using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public interface IManejadoraDeArchivos<T> {

		public bool Serializar(T dato, string ruta);

		public T Deserializar(string nombreDelArchivo);

	}
}
