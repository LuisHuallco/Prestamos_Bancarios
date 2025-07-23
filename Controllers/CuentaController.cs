using PrestamosBanco.Models;
using PrestamosBanco.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace PrestamosBanco.Controllers
{
    public class CuentaController
    {
        public List<CuentaModel> ObtenerCuentas()
        {
            List<CuentaModel> lista = new List<CuentaModel>();

            using (var conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT c.ID, c.Saldo, c.ID_Cliente, cl.Nombre 
                                 FROM cuenta c 
                                 INNER JOIN cliente cl ON c.ID_Cliente = cl.ID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new CuentaModel
                    {
                        ID = reader.GetInt32("ID"),
                        Saldo = reader.GetDecimal("Saldo"),
                        ID_Cliente = reader.GetInt32("ID_Cliente"),
                        NombreCliente = reader.GetString("Nombre")
                    });
                }
            }

            return lista;
        }

        public void AgregarCuenta(CuentaModel cuenta)
        {
            using (var conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO cuenta (Saldo, ID_Cliente) VALUES (@Saldo, @ID_Cliente)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Saldo", cuenta.Saldo);
                cmd.Parameters.AddWithValue("@ID_Cliente", cuenta.ID_Cliente);
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarCuenta(CuentaModel cuenta)
        {
            using (var conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "UPDATE cuenta SET Saldo = @Saldo WHERE ID = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Saldo", cuenta.Saldo);
                cmd.Parameters.AddWithValue("@ID", cuenta.ID);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarCuenta(int id)
        {
            using (var conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "DELETE FROM cuenta WHERE ID = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
            }
        }

        public List<ClienteModel> ObtenerClientes()
        {
            List<ClienteModel> clientes = new List<ClienteModel>();

            using (var conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT ID, Nombre FROM cliente";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    clientes.Add(new ClienteModel
                    {
                        ID = reader.GetInt32("ID"),
                        Nombre = reader.GetString("Nombre")
                    });
                }
            }

            return clientes;
        }
    }
}
