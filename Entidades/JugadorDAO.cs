using System;
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

	}
}
