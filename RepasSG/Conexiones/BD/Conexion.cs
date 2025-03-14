using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasSG.Conexiones.BD {
    internal class Conexion {
        internal class Conectar {
            private static string pathDB = Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "RepasDB.db");
            private static string cadena = $"Data Source={Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "RepasDB.db")};Version=3;";

            private static string cadenaAppData = $"Data Source={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Predits", "RepasDB.db")};Version=3;";
            private static string pathDBAppData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Repas", "RepasDB.db");
            private static string BackUp = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BackUpAllResto", "RepasDB.db");

            public string datos = string.Empty;

            public static void Comprobar() {
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Predits");
                if (!Directory.Exists(folderPath)) {
                    Directory.CreateDirectory(folderPath);
                    Console.WriteLine("La carpeta no existia, fue creada con exito");

                }
                Console.WriteLine("Carpeta encontrada con exito");

                if (!File.Exists(pathDBAppData)) {

                    if (File.Exists(pathDB)) {
                        File.Copy(pathDB, pathDBAppData, true);
                    } else {
                        Console.WriteLine("El archivo de base de datos original no se encuentra en la ruta especificada.");
                    }
                }


            }
            public static string CrearBackUp() {
                try {
                    string backupFolderPath = Path.GetDirectoryName(BackUp);

                    if (!Directory.Exists(backupFolderPath)) {
                        Directory.CreateDirectory(backupFolderPath);
                        Console.WriteLine("La carpeta de respaldo no existía, fue creada con éxito");
                    }


                    if (!File.Exists(BackUp)) {

                        if (File.Exists(pathDBAppData)) {
                            File.Copy(pathDBAppData, BackUp, true);
                        } else {
                            Console.WriteLine("El archivo no se encuentra en ruta especificada");
                        }
                        Console.WriteLine("backUpCreado");

                    } else {


                    }

                } catch (Exception ex) {

                    Console.WriteLine("HUBO UN ERROR" + ex);
                    return "error";
                }

                return BackUp;
            }
            public static SQLiteConnection ObtenerConexion() {
                try {
                    string cadenaConexion = cadenaAppData;
                    var conexion = new SQLiteConnection(cadenaConexion);
                    conexion.Open();

                    return conexion;

                } catch (Exception ex) {
                    Console.WriteLine($"Error al obtener la conexión: {ex.Message}");
                    throw;
                }
            }

        }
    }
}
