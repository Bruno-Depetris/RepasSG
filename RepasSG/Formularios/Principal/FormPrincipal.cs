using RepasSG.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasSG {
    public partial class FormPrincipal : Form {
        public FormPrincipal() {
            InitializeComponent();
        }

        private Form FormActivo = null;

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
            panel_ContenedorPadre.Controls.Add(FormHijo);
            panel_ContenedorPadre.Tag = FormHijo;
            FormHijo.Show();
        }
        private void timer_Fecha_Tick(object sender, EventArgs e) {
            DateTime fechaActual = DateTime.Now;
            bigLabel_Fecha.Text = DateTime.Now.ToString("dd/MM/yy");
            bigLabel_Dia.Text = char.ToUpper(fechaActual.ToString("dddd")[0]) + fechaActual.ToString("dddd").Substring(1);
        }
        private void parrotButton_Listado_Click(object sender, EventArgs e) {
            AbrirFormNuevo(new Listado());
        }


    }
}
