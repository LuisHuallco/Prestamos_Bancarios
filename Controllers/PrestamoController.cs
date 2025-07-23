using PrestamosBanco.Data;
using PrestamosBanco.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace PrestamosBanco.Controllers
{
    public class PrestamoController
    {
        public List<PrestamoModel> ObtenerPrestamos()
        {
            var lista = new List<PrestamoModel>();

            using (var conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT p.ID, p.ID_Cliente, cl.Nombre, p.Monto, p.Interes, p.Plazo
                                 FROM prestamo p
                                 INNER JOIN cliente cl ON p.ID_Cliente = cl.ID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new PrestamoModel
                    {
                        ID = reader.GetInt32("ID"),
                        ID_Cliente = reader.GetInt32("ID_Cliente"),
                        NombreCliente = reader.GetString("Nombre"),
                        Monto = reader.GetDecimal("Monto"),
                        Interes = reader.GetDecimal("Interes"),
                        Plazo = reader.GetInt32("Plazo")
                    });
                }
            }

            return lista;
        }

        public void AgregarPrestamo(PrestamoModel prestamo)
        {
            using (var conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO prestamo (ID_Cliente, Monto, Interes, Plazo) VALUES (@cliente, @monto, @interes, @plazo)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cliente", prestamo.ID_Cliente);
                cmd.Parameters.AddWithValue("@monto", prestamo.Monto);
                cmd.Parameters.AddWithValue("@interes", prestamo.Interes);
                cmd.Parameters.AddWithValue("@plazo", prestamo.Plazo);
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarPrestamo(PrestamoModel prestamo)
        {
            using (var conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "UPDATE prestamo SET Monto = @monto, Interes = @interes, Plazo = @plazo WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@monto", prestamo.Monto);
                cmd.Parameters.AddWithValue("@interes", prestamo.Interes);
                cmd.Parameters.AddWithValue("@plazo", prestamo.Plazo);
                cmd.Parameters.AddWithValue("@id", prestamo.ID);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarPrestamo(int id)
        {
            using (var conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "DELETE FROM prestamo WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
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
