using RepasSG.Conexiones.BD;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using static RepasSG.Clases.Modelo;

namespace RepasSG.Logica {
    internal class LogicaTipoPago {
        private static LogicaTipoPago _instancia;

        public static LogicaTipoPago Instancia {
            get {
                if (_instancia == null) {
                    _instancia = new LogicaTipoPago();
                }
                return _instancia;
            }
        }

        public bool AgregarTipoPago(TipoPago tipoPago) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "INSERT INTO TipoPago (Nombre) VALUES (@Nombre)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@Nombre", tipoPago.Nombre);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al agregar tipo de pago: " + ex.Message);
                return false;
            }
        }

        public bool EditarTipoPago(TipoPago tipoPago) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "UPDATE TipoPago SET Nombre = @Nombre WHERE TipoPagoID = @TipoPagoID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@Nombre", tipoPago.Nombre);
                    cmd.Parameters.AddWithValue("@TipoPagoID", tipoPago.TipoPagoID);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al editar tipo de pago: " + ex.Message);
                return false;
            }
        }

        public bool EliminarTipoPago(int tipoPagoID) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "DELETE FROM TipoPago WHERE TipoPagoID = @TipoPagoID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@TipoPagoID", tipoPagoID);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al eliminar tipo de pago: " + ex.Message);
                return false;
            }
        }

        public List<TipoPago> ObtenerTiposPago() {
            List<TipoPago> lista = new List<TipoPago>();

            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "SELECT * FROM TipoPago";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            lista.Add(new TipoPago {
                                TipoPagoID = Convert.ToInt32(reader["TipoPagoID"]),
                                Nombre = reader["Nombre"].ToString()
                            });
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al obtener tipos de pago: " + ex.Message);
            }

            return lista;
        }

        public TipoPago ObtenerTipoPagoPorID(int tipoPagoID) {
            TipoPago tipoPago = null;

            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "SELECT * FROM TipoPago WHERE TipoPagoID = @TipoPagoID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@TipoPagoID", tipoPagoID);

                    using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            tipoPago = new TipoPago {
                                TipoPagoID = Convert.ToInt32(reader["TipoPagoID"]),
                                Nombre = reader["Nombre"].ToString()
                            };
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al obtener tipo de pago por ID: " + ex.Message);
            }

            return tipoPago;
        }
    }
}
