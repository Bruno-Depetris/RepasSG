using RepasSG.Conexiones.BD;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using static RepasSG.Clases.Modelo;

namespace RepasSG.Logica {
    internal class LogicaPedido {
        private static LogicaPedido _instancia;

        public static LogicaPedido Instancia {
            get {
                if (_instancia == null) {
                    _instancia = new LogicaPedido();
                }
                return _instancia;
            }
        }

        public bool AgregarPedido(Pedido pedido) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "INSERT INTO Pedido (Fecha, ClienteID, MenuID, Cantidad, FormaPagoID) VALUES (@Fecha, @ClienteID, @MenuID, @Cantidad, @FormaPagoID)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@Fecha", pedido.Fecha);
                    cmd.Parameters.AddWithValue("@ClienteID", pedido.ClienteID);
                    cmd.Parameters.AddWithValue("@MenuID", pedido.MenuID);
                    cmd.Parameters.AddWithValue("@Cantidad", pedido.Cantidad);
                    cmd.Parameters.AddWithValue("@FormaPagoID", pedido.FormaPagoID);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al agregar pedido: " + ex.Message);
                return false;
            }
        }

        public bool EditarPedido(Pedido pedido) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "UPDATE Pedido SET Fecha = @Fecha, ClienteID = @ClienteID, MenuID = @MenuID, Cantidad = @Cantidad, FormaPagoID = @FormaPagoID WHERE PedidoID = @PedidoID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@Fecha", pedido.Fecha);
                    cmd.Parameters.AddWithValue("@ClienteID", pedido.ClienteID);
                    cmd.Parameters.AddWithValue("@MenuID", pedido.MenuID);
                    cmd.Parameters.AddWithValue("@Cantidad", pedido.Cantidad);
                    cmd.Parameters.AddWithValue("@FormaPagoID", pedido.FormaPagoID);
                    cmd.Parameters.AddWithValue("@PedidoID", pedido.PedidoID);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al editar pedido: " + ex.Message);
                return false;
            }
        }

        public bool EliminarPedido(int pedidoID) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "DELETE FROM Pedido WHERE PedidoID = @PedidoID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@PedidoID", pedidoID);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al eliminar pedido: " + ex.Message);
                return false;
            }
        }

        public List<Pedido> ObtenerPedidos() {
            List<Pedido> lista = new List<Pedido>();

            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "SELECT * FROM Pedido";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            lista.Add(new Pedido {
                                PedidoID = Convert.ToInt32(reader["PedidoID"]),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                ClienteID = Convert.ToInt32(reader["ClienteID"]),
                                MenuID = Convert.ToInt32(reader["MenuID"]),
                                Cantidad = Convert.ToInt32(reader["Cantidad"]),
                                FormaPagoID = Convert.ToInt32(reader["FormaPagoID"])
                            });
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al obtener pedidos: " + ex.Message);
            }

            return lista;
        }

        public Pedido ObtenerPedidoPorID(int pedidoID) {
            Pedido pedido = null;

            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "SELECT * FROM Pedido WHERE PedidoID = @PedidoID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@PedidoID", pedidoID);

                    using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            pedido = new Pedido {
                                PedidoID = Convert.ToInt32(reader["PedidoID"]),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                ClienteID = Convert.ToInt32(reader["ClienteID"]),
                                MenuID = Convert.ToInt32(reader["MenuID"]),
                                Cantidad = Convert.ToInt32(reader["Cantidad"]),
                                FormaPagoID = Convert.ToInt32(reader["FormaPagoID"])
                            };
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al obtener pedido por ID: " + ex.Message);
            }

            return pedido;
        }
    }
}
