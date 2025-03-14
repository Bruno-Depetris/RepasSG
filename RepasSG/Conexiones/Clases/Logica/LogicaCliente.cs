using System;
using System.Collections.Generic;
using System.Data.SQLite;
using RepasSG.Conexiones.BD;
using static RepasSG.Clases.Modelo;
using RepasSG.Clases;

namespace RepasSG.Logica {
    internal class LogicaCliente {
        private static LogicaCliente _instancia;

        public static LogicaCliente Instancia {
            get {
                if (_instancia == null) {
                    _instancia = new LogicaCliente();
                }
                return _instancia;
            }
        }

        // 🔹 Agregar Cliente
        public bool AgregarCliente(Cliente cliente) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "INSERT INTO Clientes (Nombre, Direccion, Telefono, Email) VALUES (@Nombre, @Direccion, @Telefono, @Email)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                    cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);


                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error al agregar cliente: {ex.Message}");
                return false;
            }
        }

        // 🔹 Listar Clientes
        public List<Cliente> ListarClientes() {
            List<Cliente> listaClientes = new List<Cliente>();

            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "SELECT * FROM Clientes";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            Cliente cliente = new Cliente {
                                ClienteID = Convert.ToInt32(reader["ClienteID"]),
                                Nombre = reader["Nombre"].ToString(),
                                Direccion = reader["Direccion"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                            };
                            listaClientes.Add(cliente);
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error al listar clientes: {ex.Message}");
            }

            return listaClientes;
        }

        // 🔹 Editar Cliente
        public bool EditarCliente(Cliente cliente) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "UPDATE Clientes SET Nombre = @Nombre, Direccion = @Direccion, Telefono = @Telefono, Email = @Email WHERE ClienteID = @ClienteID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                    cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    cmd.Parameters.AddWithValue("@ClienteID", cliente.ClienteID);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error al editar cliente: {ex.Message}");
                return false;
            }
        }

        // 🔹 Eliminar Cliente
        public bool EliminarCliente(int id) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "DELETE FROM Clientes WHERE ClienteID = @ClienteID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@ClienteID", id);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error al eliminar cliente: {ex.Message}");
                return false;
            }
        }
    }
}
