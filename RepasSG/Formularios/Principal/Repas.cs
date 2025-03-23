using RepasSG.Formularios.Clientes;
using RepasSG.Formularios.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasSG.Formularios.Principal {
    public partial class Repas : Form {
        public Repas() {
            InitializeComponent();
        }
        private Form FormActivo = null;
        private ReaLTaiizor.Controls.ParrotButton botonAnterior = null;
        private void AbrirFormNuevo(Form FormHijo) {
            // Cerrar el formulario activo anterior
            if (FormActivo != null) {
                FormActivo.Close();
            }

            // Configurar el nuevo formulario
            FormActivo = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            panel_Contenedor.Controls.Add(FormHijo);
            panel_Contenedor.Tag = FormHijo;
            FormHijo.Show();
        }
        private void Indicador(ReaLTaiizor.Controls.ParrotButton botonActual) {
            // Cambiar el color del panel
            panel_Indicador.Height = botonActual.Height;
            panel_Indicador.Top = botonActual.Top;
            panel_Indicador.Left = botonActual.Left - 15;

            // Si hay un botón anterior y es diferente al actual, restaurar su color
            if (botonAnterior != null && botonAnterior != botonActual) {
                botonAnterior.BackgroundColor = Color.FromArgb(40, 40, 40); // Color por defecto
            }


            // Actualizar la referencia al botón actual como el último presionado
            botonAnterior = botonActual;

            // Traer el panel al frente
            panel_Indicador.BringToFront();
        }

        private void parrotButton_Vender_Click(object sender, EventArgs e) {
            AbrirFormNuevo(new NuevaCompra());
            Indicador(parrotButton_Vender);
        }

        private void parrotButton_Clientes_Click(object sender, EventArgs e) {
            Indicador(parrotButton_Clientes);
        }

        private void parrotButton_Movimientos_Click(object sender, EventArgs e) {
            Indicador(parrotButton_Movimientos);
        }

        private void parrotButton_Suscripcion_Click(object sender, EventArgs e) {
            Indicador(parrotButton_Suscripcion);
        }

        private void parrotButton_Configuracion_Click(object sender, EventArgs e) {
            AbrirFormNuevo(new ConfigForm());
            Indicador(parrotButton_Configuracion);
        }
    }
}
