using RepasSG.Conexiones.BD;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using static RepasSG.Clases.Modelo;

namespace RepasSG.Logica {
    internal class LogicaSeccion {
        private static LogicaSeccion _instancia;

        public static LogicaSeccion Instancia {
            get {
                if (_instancia == null) {
                    _instancia = new LogicaSeccion();
                }
                return _instancia;
            }
        }

        public bool AgregarSeccion(Seccion seccion) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "INSERT INTO Seccion (Nombre) VALUES (@Nombre)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@Nombre", seccion.Nombre);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al agregar sección: " + ex.Message);
                return false;
            }
        }

        public bool EditarSeccion(Seccion seccion) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "UPDATE Seccion SET Nombre = @Nombre WHERE SeccionID = @SeccionID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@Nombre", seccion.Nombre);
                    cmd.Parameters.AddWithValue("@SeccionID", seccion.SeccionID);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al editar sección: " + ex.Message);
                return false;
            }
        }

        public bool EliminarSeccion(int seccionID) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "DELETE FROM Seccion WHERE SeccionID = @SeccionID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@SeccionID", seccionID);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al eliminar sección: " + ex.Message);
                return false;
            }
        }

        public List<Seccion> ObtenerSecciones() {
            List<Seccion> lista = new List<Seccion>();

            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "SELECT * FROM Seccion";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            lista.Add(new Seccion {
                                SeccionID = Convert.ToInt32(reader["SeccionID"]),
                                Nombre = reader["Nombre"].ToString()
                            });
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al obtener secciones: " + ex.Message);
            }

            return lista;
        }

        public Seccion ObtenerSeccionPorID(int seccionID) {
            Seccion seccion = null;

            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "SELECT * FROM Seccion WHERE SeccionID = @SeccionID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@SeccionID", seccionID);

                    using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            seccion = new Seccion {
                                SeccionID = Convert.ToInt32(reader["SeccionID"]),
                                Nombre = reader["Nombre"].ToString()
                            };
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al obtener sección por ID: " + ex.Message);
            }

            return seccion;
        }
    }
}
