using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasSG.Formularios.Vender {
    public partial class FormaPagoForm : Form {
        public FormaPagoForm() {
            InitializeComponent();

            hopeComboBox_FormaPago.Items.Insert(0,"Seleccionar");
            


            hopeComboBox_FormaPago.SelectedIndex = 0;
            hopeComboBox_FormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void CargarComboBox() {
            
        }
    }
}
