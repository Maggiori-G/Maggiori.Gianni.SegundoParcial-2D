using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJuego {
	[TestClass]
	public class UsuarioDAODeberia {

		[TestMethod]
		public void TestearBaseDeDatosUsuarioCargadaConExito() {
			List<Usuario> lista = new List<Usuario>();

			lista=UsuarioDAO.GetUsuarios();

			Assert.IsTrue(lista.Count>0);
		}
		
		[TestMethod]
		public void VerificarUsuarioEscrito_Ok() {
			string nombreCompleto="Fulanito de Prueba";
			string nombreUsuario="Fulanito";
			string contraseña="fulanito123";
			string email="ejemplo@fulanito.com";
			List<Usuario> usuarios=new List<Usuario>();

			UsuarioDAO.EscribirNuevoUsuario(nombreCompleto,nombreUsuario,contraseña,email);
			usuarios=UsuarioDAO.GetUsuarios();

			Assert.IsFalse(usuarios.TrueForAll(x => x.Email != email));
		}

		[TestMethod]
		public void BuscarUsuario_Ok() {
			string nombreCompleto="Fulanito de Prueba";
			string nombreUsuario="Fulanito";
			string contraseña="fulanito123";
			string email="ejemplo@fulanito.com";
			Usuario? usuario = null;

			UsuarioDAO.EscribirNuevoUsuario(nombreCompleto, nombreUsuario, contraseña,email);
			usuario=UsuarioDAO.BuscarUsuario(email);

			Assert.IsNotNull(usuario);
			Assert.AreEqual(email,usuario.Email);
		}
		
		[TestMethod]
		public void BuscarUsuario_Error() {
			string email="esperandoException@fulanito.com";

			Assert.ThrowsException<Exception>(() => UsuarioDAO.BuscarUsuario(email));
		}
	}
}
