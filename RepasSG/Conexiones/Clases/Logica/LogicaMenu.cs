using RepasSG.Clases;
using RepasSG.Conexiones.BD;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace RepasSG.Logica {
    internal class LogicaMenu {
        private static LogicaMenu _instancia;

        public static LogicaMenu Instancia {
            get {
                if (_instancia == null) {
                    _instancia = new LogicaMenu();
                }
                return _instancia;
            }
        }

        public bool AgregarMenu(Modelo.Menu menu) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "INSERT INTO Menu (NombreComida, Detalles, Precio, SeccionID) VALUES (@NombreComida, @Detalles, @Precio, @SeccionID)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@NombreComida", menu.NombreComida);
                    cmd.Parameters.AddWithValue("@Detalles", menu.Detalles);
                    cmd.Parameters.AddWithValue("@Precio", menu.Precio);
                    cmd.Parameters.AddWithValue("@SeccionID", menu.SeccionID);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al agregar menú: " + ex.Message);
                return false;
            }
        }

        public bool EditarMenu(Modelo.Menu menu) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "UPDATE Menu SET NombreComida = @NombreComida, Detalles = @Detalles, Precio = @Precio, SeccionID = @SeccionID WHERE MenuID = @MenuID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@NombreComida", menu.NombreComida);
                    cmd.Parameters.AddWithValue("@Detalles", menu.Detalles);
                    cmd.Parameters.AddWithValue("@Precio", menu.Precio);
                    cmd.Parameters.AddWithValue("@SeccionID", menu.SeccionID);
                    cmd.Parameters.AddWithValue("@MenuID", menu.MenuID);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al editar menú: " + ex.Message);
                return false;
            }
        }

        public bool EliminarMenu(int menuID) {
            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "DELETE FROM Menu WHERE MenuID = @MenuID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@MenuID", menuID);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al eliminar menú: " + ex.Message);
                return false;
            }
        }

        public List<Modelo.Menu> ObtenerMenus() {
            List<Modelo.Menu> lista = new List<Modelo.Menu>();

            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "SELECT * FROM Menu";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            lista.Add(new Modelo.Menu {
                                MenuID = Convert.ToInt32(reader["MenuID"]),
                                NombreComida = reader["NombreComida"].ToString(),
                                Detalles = reader["Detalles"].ToString(),
                                Precio = Convert.ToDecimal(reader["Precio"]),
                                SeccionID = Convert.ToInt32(reader["SeccionID"])
                            });
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al obtener menús: " + ex.Message);
            }

            return lista;
        }

        public Modelo.Menu ObtenerMenuPorID(int menuID) {
            Modelo.Menu menu = null;

            try {
                using (SQLiteConnection conexion = Conexion.Conectar.ObtenerConexion()) {
                    string query = "SELECT * FROM Menu WHERE MenuID = @MenuID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@MenuID", menuID);

                    using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            menu = new Modelo.Menu {
                                MenuID = Convert.ToInt32(reader["MenuID"]),
                                NombreComida = reader["NombreComida"].ToString(),
                                Detalles = reader["Detalles"].ToString(),
                                Precio = Convert.ToDecimal(reader["Precio"]),
                                SeccionID = Convert.ToInt32(reader["SeccionID"])
                            };
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Error al obtener menú por ID: " + ex.Message);
            }

            return menu;
        }
    }
}
