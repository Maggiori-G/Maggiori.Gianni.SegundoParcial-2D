using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public static class JugadorDAO {
		private static SqlCommand sqlCommand;
		private static SqlConnection sqlConnection;

		static JugadorDAO() {
			sqlConnection = new SqlConnection(@"Server=. ;Database=TrabajoGenerala ;Trusted_Connection=True;");
			sqlCommand= new SqlCommand();
			sqlCommand.CommandType=System.Data.CommandType.Text;
			sqlCommand.Connection = sqlConnection;
		}

		public static List<Jugador> GetJugadores() {			
			List<Jugador> list = new List<Jugador>();
			string query="SELECT * FROM Jugadores";
			try {
				sqlConnection.Open();
				sqlCommand.CommandText=query;
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
				while(sqlDataReader.Read()) {
					if(!sqlDataReader.IsDBNull(1)) {
						list.Add(new Jugador(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetInt32(2)));
					}
					else {
						throw new Exception("Error en la base de datos");
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

		public static void EscribirNuevoJugador(string nombre) {
			string query="INSERT INTO Jugadores VALUES (@nombreCompleto, @cantidadVictorias)";
			try {
				EjecutarConParametros(query, nombre);
			}
			catch {
				throw new Exception("Ocurrio un error al crear un nuevo jugador");
			}
		}

		public static void EjecutarConParametros(string query, string nombreJugador) {
			if(!string.IsNullOrEmpty(query) && !string.IsNullOrEmpty(nombreJugador)) {
				try {
					sqlConnection.Open();
					sqlCommand.Parameters.Clear();
					sqlCommand.CommandText = query;
					sqlCommand.Parameters.AddWithValue("@nombreCompleto",nombreJugador);
					sqlCommand.Parameters.AddWithValue("@cantidadVictorias",0);
					sqlCommand.ExecuteNonQuery();
				}
				catch {
					throw new Exception("No se pudo Crear el nuevo usuario");
				}
				finally {
					if(sqlCommand is not null && sqlConnection.State == System.Data.ConnectionState.Open) {
						sqlConnection.Close();
					}
				}
			}
		}

		public static Jugador BuscarJugadorPorNombre(string nombreCompleto) {			
			Jugador? jugador = null;
			string query="SELECT * FROM Jugadores WHERE nombreCompleto=@nombreCompleto";
			try {
				sqlConnection.Open();
				sqlCommand.CommandText=query;
				sqlCommand.Parameters.Clear();
				sqlCommand.Parameters.AddWithValue("@nombreCompleto",nombreCompleto);
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
				if(sqlDataReader.Read()) {
					if(!sqlDataReader.IsDBNull(1)) {
						jugador = new Jugador(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetInt32(2));
					}
				}
				return jugador!;
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

		public static bool EliminarPorNombre(string nombre) {
			string query="DELETE FROM Jugadores WHERE nombreCompleto=@nombre";
			try {
				sqlConnection.Open();
				sqlCommand.CommandText=query;
				sqlCommand.Parameters.Clear();
				sqlCommand.Parameters.AddWithValue("@nombre", nombre);
				sqlCommand.ExecuteNonQuery();
				return true;
			}
			catch {
				return false;
			}
			finally {
				if(sqlCommand is not null && sqlConnection.State == System.Data.ConnectionState.Open) {
					sqlConnection.Close();
				}
			}
		}

		public static List<Jugador> CrearRankingDeVictorias() {
			List<Jugador> jugadores = new List<Jugador>();
			string query="SELECT * FROM Jugadores ORDER BY cantidadVictorias DESC";

			try {
				sqlConnection.Open();
				sqlCommand.CommandText=query;
				sqlCommand.Parameters.Clear();
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
				while(sqlDataReader.Read()) {
					if(!sqlDataReader.IsDBNull(1)) {
						jugadores.Add(new Jugador(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetInt32(2)));
					}
				}
			}
			catch {
				throw new Exception("Ocurrio un error al consultar el ranking de victorias");
			}
			finally {
				if(sqlCommand is not null && sqlConnection.State == System.Data.ConnectionState.Open) {
					sqlConnection.Close();
				}
			}
			return jugadores;
		}

		public static void ActualizarVictoriasJugadorDAO(Jugador jugador) {
			string query="UPDATE Jugadores SET cantidadVictorias=@victorias WHERE id=@id";
			try {
				sqlConnection.Open();
				sqlCommand.CommandText=query;
				sqlCommand.Parameters.Clear();
				sqlCommand.Parameters.AddWithValue("@victorias",jugador.CantidadDeVictorias);
				sqlCommand.Parameters.AddWithValue("@id",jugador.Id);
				sqlCommand.ExecuteNonQuery();
			}
			catch {
				throw new Exception("Ocurrio un error al consultar el ranking de victorias");
			}
			finally {
				if(sqlCommand is not null && sqlConnection.State == System.Data.ConnectionState.Open) {
					sqlConnection.Close();
				}
			}
		}
	}
}
