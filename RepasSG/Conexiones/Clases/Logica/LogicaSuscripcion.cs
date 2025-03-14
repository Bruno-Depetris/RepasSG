using RepasSG.Conexiones.BD;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using static RepasSG.Clases.Modelo;

namespace RepasSG.Logica {
    internal class LogicaSuscripcion {
        private static LogicaSuscripcion _instancia;

        public static LogicaSuscripcion Instancia {
            get {
                if (_instancia == null) {
                    _instancia = new LogicaSuscripcion();
                }
                return _instancia;
            }
        }

        public bool AgregarSuscripcion(Suscripcion suscripcion) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = @"INSERT INTO Suscripcion 
                                    (ClienteID, NoDias, NoCome, MenuID, TipoPagoID, Novedad, PrecioDiario, Acumulado, Detalles, RepartidorID) 
                                    VALUES (@ClienteID, @NoDias, @NoCome, @MenuID, @TipoPagoID, @Novedad, @PrecioDiario, @Acumulado, @Detalles, @RepartidorID)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@ClienteID", suscripcion.ClienteID);
                    cmd.Parameters.AddWithValue("@NoDias", suscripcion.NoDias);
                    cmd.Parameters.AddWithValue("@NoCome", suscripcion.NoCome);
                    cmd.Parameters.AddWithValue("@MenuID", suscripcion.MenuID);
                    cmd.Parameters.AddWithValue("@TipoPagoID", suscripcion.TipoPagoID);
                    cmd.Parameters.AddWithValue("@Novedad", suscripcion.Novedad);
                    cmd.Parameters.AddWithValue("@PrecioDiario", suscripcion.PrecioDiario);
                    cmd.Parameters.AddWithValue("@Acumulado", suscripcion.Acumulado);
                    cmd.Parameters.AddWithValue("@Detalles", suscripcion.Detalles);
                    cmd.Parameters.AddWithValue("@RepartidorID", suscripcion.RepartidorID ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al agregar suscripción: " + ex.Message);
                return false;
            }
        }

        public bool EditarSuscripcion(Suscripcion suscripcion) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = @"UPDATE Suscripcion SET 
                                    ClienteID = @ClienteID, NoDias = @NoDias, NoCome = @NoCome, MenuID = @MenuID, 
                                    TipoPagoID = @TipoPagoID, Novedad = @Novedad, PrecioDiario = @PrecioDiario, 
                                    Acumulado = @Acumulado, Detalles = @Detalles, RepartidorID = @RepartidorID 
                                    WHERE SuscripcionID = @SuscripcionID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@ClienteID", suscripcion.ClienteID);
                    cmd.Parameters.AddWithValue("@NoDias", suscripcion.NoDias);
                    cmd.Parameters.AddWithValue("@NoCome", suscripcion.NoCome);
                    cmd.Parameters.AddWithValue("@MenuID", suscripcion.MenuID);
                    cmd.Parameters.AddWithValue("@TipoPagoID", suscripcion.TipoPagoID);
                    cmd.Parameters.AddWithValue("@Novedad", suscripcion.Novedad);
                    cmd.Parameters.AddWithValue("@PrecioDiario", suscripcion.PrecioDiario);
                    cmd.Parameters.AddWithValue("@Acumulado", suscripcion.Acumulado);
                    cmd.Parameters.AddWithValue("@Detalles", suscripcion.Detalles);
                    cmd.Parameters.AddWithValue("@RepartidorID", suscripcion.RepartidorID ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@SuscripcionID", suscripcion.SuscripcionID);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al editar suscripción: " + ex.Message);
                return false;
            }
        }

        public bool EliminarSuscripcion(int suscripcionID) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "DELETE FROM Suscripcion WHERE SuscripcionID = @SuscripcionID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@SuscripcionID", suscripcionID);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al eliminar suscripción: " + ex.Message);
                return false;
            }
        }

        public List<Suscripcion> ObtenerSuscripciones() {
            List<Suscripcion> lista = new List<Suscripcion>();

            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "SELECT * FROM Suscripcion";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            lista.Add(new Suscripcion {
                                SuscripcionID = Convert.ToInt32(reader["SuscripcionID"]),
                                ClienteID = Convert.ToInt32(reader["ClienteID"]),
                                NoDias = reader["NoDias"].ToString(),
                                NoCome = reader["NoCome"].ToString(),
                                MenuID = Convert.ToInt32(reader["MenuID"]),
                                TipoPagoID = Convert.ToInt32(reader["TipoPagoID"]),
                                Novedad = reader["Novedad"].ToString(),
                                PrecioDiario = Convert.ToDecimal(reader["PrecioDiario"]),
                                Acumulado = Convert.ToDecimal(reader["Acumulado"]),
                                Detalles = reader["Detalles"].ToString(),
                                RepartidorID = reader["RepartidorID"] != DBNull.Value ? Convert.ToInt32(reader["RepartidorID"]) : (int?)null
                            });
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al obtener suscripciones: " + ex.Message);
            }

            return lista;
        }

        public Suscripcion ObtenerSuscripcionPorID(int suscripcionID) {
            Suscripcion suscripcion = null;

            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "SELECT * FROM Suscripcion WHERE SuscripcionID = @SuscripcionID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@SuscripcionID", suscripcionID);

                    using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            suscripcion = new Suscripcion {
                                SuscripcionID = Convert.ToInt32(reader["SuscripcionID"]),
                                ClienteID = Convert.ToInt32(reader["ClienteID"]),
                                NoDias = reader["NoDias"].ToString(),
                                NoCome = reader["NoCome"].ToString(),
                                MenuID = Convert.ToInt32(reader["MenuID"]),
                                TipoPagoID = Convert.ToInt32(reader["TipoPagoID"]),
                                Novedad = reader["Novedad"].ToString(),
                                PrecioDiario = Convert.ToDecimal(reader["PrecioDiario"]),
                                Acumulado = Convert.ToDecimal(reader["Acumulado"]),
                                Detalles = reader["Detalles"].ToString(),
                                RepartidorID = reader["RepartidorID"] != DBNull.Value ? Convert.ToInt32(reader["RepartidorID"]) : (int?)null
                            };
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al obtener suscripción por ID: " + ex.Message);
            }

            return suscripcion;
        }
    }
}
