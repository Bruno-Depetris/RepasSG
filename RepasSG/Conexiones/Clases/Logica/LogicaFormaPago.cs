using RepasSG.Conexiones.BD;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using static RepasSG.Clases.Modelo;

namespace RepasSG.Logica {
    internal class LogicaFormaPago {
        private static LogicaFormaPago _instancia;

        public static LogicaFormaPago Instancia {
            get {
                if (_instancia == null) {
                    _instancia = new LogicaFormaPago();
                }
                return _instancia;
            }
        }

        public bool AgregarFormaPago(FormaPago formaPago) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "INSERT INTO FormaPago (Nombre) VALUES (@Nombre)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@Nombre", formaPago.Nombre);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al agregar forma de pago: " + ex.Message);
                return false;
            }
        }

        public bool EditarFormaPago(FormaPago formaPago) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "UPDATE FormaPago SET Nombre = @Nombre WHERE FormaPagoID = @FormaPagoID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@Nombre", formaPago.Nombre);
                    cmd.Parameters.AddWithValue("@FormaPagoID", formaPago.FormaPagoID);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al editar forma de pago: " + ex.Message);
                return false;
            }
        }

        public bool EliminarFormaPago(int formaPagoID) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "DELETE FROM FormaPago WHERE FormaPagoID = @FormaPagoID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@FormaPagoID", formaPagoID);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al eliminar forma de pago: " + ex.Message);
                return false;
            }
        }

        public List<FormaPago> ObtenerFormasPago() {
            List<FormaPago> lista = new List<FormaPago>();

            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "SELECT * FROM FormaPago";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            lista.Add(new FormaPago {
                                FormaPagoID = Convert.ToInt32(reader["FormaPagoID"]),
                                Nombre = reader["Nombre"].ToString()
                            });
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al obtener formas de pago: " + ex.Message);
            }

            return lista;
        }

        public FormaPago ObtenerFormaPagoPorID(int formaPagoID) {
            FormaPago formaPago = null;

            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "SELECT * FROM FormaPago WHERE FormaPagoID = @FormaPagoID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@FormaPagoID", formaPagoID);

                    using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            formaPago = new FormaPago {
                                FormaPagoID = Convert.ToInt32(reader["FormaPagoID"]),
                                Nombre = reader["Nombre"].ToString()
                            };
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al obtener forma de pago por ID: " + ex.Message);
            }

            return formaPago;
        }
    }
}
