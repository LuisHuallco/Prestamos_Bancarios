using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PrestamosBanco.Data;
using PrestamosBanco.Models;

namespace PrestamosBanco.Controllers
{
    public class ClienteController
    {
        // Obtener todos los clientes
        public List<ClienteModel> ObtenerClientes()
        {
            List<ClienteModel> lista = new List<ClienteModel>();

            using (var conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT * FROM cliente";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new ClienteModel
                    {
                        ID = reader.GetInt32("ID"),
                        Nombre = reader.GetString("Nombre"),
                        Telefono = reader.IsDBNull(reader.GetOrdinal("Telefono")) ? "" : reader.GetString("Telefono")
                    });
                }
            }

            return lista;
        }

        // Agregar cliente
        public void AgregarCliente(ClienteModel cliente)
        {
            using (var conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO cliente (Nombre, Telefono) VALUES (@Nombre, @Telefono)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.ExecuteNonQuery();
            }
        }

        // Editar cliente
        public void EditarCliente(ClienteModel cliente)
        {
            using (var conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "UPDATE cliente SET Nombre = @Nombre, Telefono = @Telefono WHERE ID = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@ID", cliente.ID);
                cmd.ExecuteNonQuery();
            }
        }

        // Eliminar cliente
        public void EliminarCliente(int id)
        {
            using (var conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "DELETE FROM cliente WHERE ID = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
