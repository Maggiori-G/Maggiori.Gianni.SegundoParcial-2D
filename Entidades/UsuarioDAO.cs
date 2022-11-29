using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public static class UsuarioDAO {

		private static SqlCommand sqlCommand;
		private static SqlConnection sqlConnection;

		static UsuarioDAO() {
			sqlConnection = new SqlConnection(@"Server=. ;Database=TrabajoGenerala; Trusted_Connection=True;");
			sqlCommand= new SqlCommand();
			sqlCommand.CommandType=System.Data.CommandType.Text;
			sqlCommand.Connection = sqlConnection;
		}

		public static List<Usuario> GetUsuarios() {
			List<Usuario> list = new List<Usuario>();
			string query="SELECT * FROM Usuarios";
			try {
				sqlConnection.Open();
				sqlCommand.CommandText=query;
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
				while(sqlDataReader.Read()) {
					if(!sqlDataReader.IsDBNull(1) || !sqlDataReader.IsDBNull(2) || !sqlDataReader.IsDBNull(3) && !sqlDataReader.IsDBNull(4)) {
						list.Add(new Usuario(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2),sqlDataReader.GetString(3),sqlDataReader.GetString(4)));
					}
					else {
						throw new Exception("Error al leer la base de datos");
					}
				}
				return list;
			}
			catch(Exception){
				throw new Exception("No se pudo leer de la base de datos");
			}
			finally {
				if(sqlCommand is not null && sqlConnection.State == System.Data.ConnectionState.Open) {
					sqlConnection.Close();
				}				
			}
		}
		
		public static int EscribirNuevoUsuario(string nombreCompleto, string nombreUsuario, string contraseña, string email) {
			string query="INSERT INTO Usuarios VALUES (@nombreCompleto,@nombreUsuario,@contraseña,@email)";
			try {
				return EjecutarConParametros(query,nombreCompleto,nombreUsuario,contraseña,email);
			}
			catch {
				throw new Exception("Error al actualizar la base de datos");
			}
		}

		public static int EjecutarConParametros(string query, string nombreCompleto, string nombreUsuario, string contraseña, string email) {
			try {
				if(!string.IsNullOrEmpty(query) && !string.IsNullOrEmpty(nombreCompleto) && !string.IsNullOrEmpty(nombreUsuario) && !string.IsNullOrEmpty(contraseña) && !string.IsNullOrEmpty(email)) {
					sqlConnection.Open();
					sqlCommand.Parameters.Clear();
					sqlCommand.CommandText = query;
					sqlCommand.Parameters.AddWithValue("@nombreCompleto",nombreCompleto);
					sqlCommand.Parameters.AddWithValue("@nombreUsuario",nombreUsuario);
					sqlCommand.Parameters.AddWithValue("@contraseña",contraseña);
					sqlCommand.Parameters.AddWithValue("@email",email);
					return sqlCommand.ExecuteNonQuery();
				}
				else {
					throw new Exception("Error al crear el usuario en la base de datos");
				}
			}
			catch {
				throw new Exception("Error al crear el usuario en la base de datos");
			}
			finally {
				if(sqlCommand is not null && sqlConnection.State == System.Data.ConnectionState.Open) {
					sqlConnection.Close();
				}
			}
		}

		public static Usuario? BuscarUsuario (string email) {
			string query="SELECT * FROM Usuarios WHERE email=@email";
			if(!string.IsNullOrEmpty(email)) {
				try {
					sqlConnection.Open();
					sqlCommand.Parameters.Clear();
					sqlCommand.CommandText=query;
					sqlCommand.Parameters.AddWithValue("@email",email);
					SqlDataReader lectura = sqlCommand.ExecuteReader();
					if(lectura.Read()) {
						return new Usuario(lectura.GetInt32(0), lectura.GetString(1), lectura.GetString(2), lectura.GetString(3), lectura.GetString(4));
					}
					else {
						throw new Exception("No se encontro el usuario");
					}
				}
				catch {
					throw;
				}
				finally {
					if(sqlCommand is not null && sqlConnection.State == System.Data.ConnectionState.Open) {
						sqlConnection.Close();
					}
				}
			}
			return null;
		}
	}
}
