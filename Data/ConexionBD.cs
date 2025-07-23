using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PrestamosBanco.Data
{
    public class ConexionBD
    {
        private static string connectionString = "server=localhost;database=banco_prestamos;user=root;password=123;";
        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(connectionString);
        }
    }
}