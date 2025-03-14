using RepasSG.Conexiones.BD;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using static RepasSG.Clases.Modelo;

namespace RepasSG.Logica {
    internal class LogicaApertura {
        private static LogicaApertura _instancia;

        public static LogicaApertura Instancia {
            get {
                if (_instancia == null) {
                    _instancia = new LogicaApertura();
                }
                return _instancia;
            }
        }

        public bool AgregarApertura(Apertura apertura) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "INSERT INTO Apertura (Fecha, Monto) VALUES (@Fecha, @Monto)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@Fecha", apertura.Fecha);
                    cmd.Parameters.AddWithValue("@Monto", apertura.Monto);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al agregar apertura: " + ex.Message);
                return false;
            }
        }

        public bool EditarApertura(Apertura apertura) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "UPDATE Apertura SET Fecha = @Fecha, Monto = @Monto WHERE AperturaID = @AperturaID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@Fecha", apertura.Fecha);
                    cmd.Parameters.AddWithValue("@Monto", apertura.Monto);
                    cmd.Parameters.AddWithValue("@AperturaID", apertura.AperturaID);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al editar apertura: " + ex.Message);
                return false;
            }
        }

        public bool EliminarApertura(int aperturaID) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "DELETE FROM Apertura WHERE AperturaID = @AperturaID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@AperturaID", aperturaID);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al eliminar apertura: " + ex.Message);
                return false;
            }
        }

        public List<Apertura> ObtenerAperturas() {
            List<Apertura> lista = new List<Apertura>();

            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "SELECT * FROM Apertura";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            lista.Add(new Apertura {
                                AperturaID = Convert.ToInt32(reader["AperturaID"]),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Monto = Convert.ToDecimal(reader["Monto"])
                            });
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al obtener aperturas: " + ex.Message);
            }

            return lista;
        }

        public Apertura ObtenerAperturaPorID(int aperturaID) {
            Apertura apertura = null;

            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "SELECT * FROM Apertura WHERE AperturaID = @AperturaID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@AperturaID", aperturaID);

                    using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            apertura = new Apertura {
                                AperturaID = Convert.ToInt32(reader["AperturaID"]),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Monto = Convert.ToDecimal(reader["Monto"])
                            };
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al obtener apertura por ID: " + ex.Message);
            }

            return apertura;
        }
    }
}
