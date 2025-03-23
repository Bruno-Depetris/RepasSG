using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasSG.Formularios.Config {
    public partial class ConfigForm : Form {
        public ConfigForm() {
            InitializeComponent();
        }

        private void parrotButton_AgregarSeccion_Click(object sender, EventArgs e) {
            AgregarSeccion agregarSeccion = new AgregarSeccion();
            agregarSeccion.Show();
        }
    }
}
