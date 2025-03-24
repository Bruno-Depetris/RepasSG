using RepasSG.Formularios.Principal;
using RepasSG.Formularios.Vender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RepasSG.Conexiones.BD.Conexion;

namespace RepasSG {
    internal static class Program {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() {
            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Conectar.Comprobar();
            Application.Run(new Repas());
        }
    }
}
