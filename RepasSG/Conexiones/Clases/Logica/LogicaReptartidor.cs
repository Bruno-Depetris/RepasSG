using RepasSG.Conexiones.BD;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using static RepasSG.Clases.Modelo;

namespace RepasSG.Logica {
    internal class LogicaRepartidor {
        private static LogicaRepartidor _instancia;

        public static LogicaRepartidor Instancia {
            get {
                if (_instancia == null) {
                    _instancia = new LogicaRepartidor();
                }
                return _instancia;
            }
        }

        public bool AgregarRepartidor(Repartidor repartidor) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "INSERT INTO Repartidor (Nombre) VALUES (@Nombre)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@Nombre", repartidor.Nombre);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al agregar repartidor: " + ex.Message);
                return false;
            }
        }

        public bool EditarRepartidor(Repartidor repartidor) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "UPDATE Repartidor SET Nombre = @Nombre WHERE RepartidorID = @RepartidorID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@Nombre", repartidor.Nombre);
                    cmd.Parameters.AddWithValue("@RepartidorID", repartidor.RepartidorID);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al editar repartidor: " + ex.Message);
                return false;
            }
        }

        public bool EliminarRepartidor(int repartidorID) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "DELETE FROM Repartidor WHERE RepartidorID = @RepartidorID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@RepartidorID", repartidorID);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al eliminar repartidor: " + ex.Message);
                return false;
            }
        }

        public List<Repartidor> ObtenerRepartidores() {
            List<Repartidor> lista = new List<Repartidor>();

            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "SELECT * FROM Repartidor";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            lista.Add(new Repartidor {
                                RepartidorID = Convert.ToInt32(reader["RepartidorID"]),
                                Nombre = reader["Nombre"].ToString()
                            });
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al obtener repartidores: " + ex.Message);
            }

            return lista;
        }

        public Repartidor ObtenerRepartidorPorID(int repartidorID) {
            Repartidor repartidor = null;

            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "SELECT * FROM Repartidor WHERE RepartidorID = @RepartidorID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@RepartidorID", repartidorID);

                    using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            repartidor = new Repartidor {
                                RepartidorID = Convert.ToInt32(reader["RepartidorID"]),
                                Nombre = reader["Nombre"].ToString()
                            };
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al obtener repartidor por ID: " + ex.Message);
            }

            return repartidor;
        }
    }
}
