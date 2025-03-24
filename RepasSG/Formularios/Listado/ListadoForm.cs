using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasSG.Formularios.Listado {
    public partial class ListadoForm : Form {
        public ListadoForm() {
            InitializeComponent();
            hopeComboBox_Dias.DropDownStyle = ComboBoxStyle.DropDownList;
            hopeComboBox_Dias.Items.Insert(0, "Seleccionar");
            hopeComboBox_Dias.Items.Insert(1, "Lunes");
            hopeComboBox_Dias.Items.Insert(2, "Martes");
            hopeComboBox_Dias.Items.Insert(3, "Miercoles");
            hopeComboBox_Dias.Items.Insert(4, "Jueves");
            hopeComboBox_Dias.Items.Insert(5, "Viernes");
            hopeComboBox_Dias.Items.Insert(6, "Sabado");

            hopeComboBox_Dias.SelectedIndex = 0;
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void parrotButton_Agregar_Click(object sender, EventArgs e) {

        }
    }
}
