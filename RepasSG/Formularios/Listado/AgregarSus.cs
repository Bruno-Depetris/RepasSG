using RepasSG.Formularios.Movimientos;
using RepasSG.Logica;
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
    public partial class AgregarSus : Form {
        public AgregarSus() {
            InitializeComponent();

            hopeComboBox_Menu.DropDownStyle = ComboBoxStyle.DropDownList;
            hopeComboBox_EsEnvio.DropDownStyle = ComboBoxStyle.DropDownList;

            hopeComboBox_EsEnvio.Items.Insert(0,"Seleccionar");
            hopeComboBox_EsEnvio.Items.Insert(1, "Enviar");
            hopeComboBox_EsEnvio.Items.Insert(2, "Retira");

            hopeComboBox_EsEnvio.SelectedIndex = 0;

            panel_envio.Visible = false;

            hopeComboBox_Repartidor.DropDownStyle = ComboBoxStyle.DropDownList;
            hopeComboBox_Repartidor.Items.Insert(0, "Seleccionar");
            hopeComboBox_Repartidor.SelectedIndex = 0;

            hopeComboBox_Menu.DropDownStyle = ComboBoxStyle.DropDownList;
            hopeComboBox_Menu.Items.Insert(0, "Seleccionar");
            hopeComboBox_Menu.SelectedIndex = 0;
            foreach (var dato in LogicaRepartidor.Instancia.ObtenerRepartidores()) {
                int i = 0;
                i++;

                hopeComboBox_Repartidor.Items.Insert(i, $"{dato.Nombre}");
            }

            foreach (var dato in LogicaMenu.Instancia.ObtenerMenus()) {
                int i = 0;
                i++;

                hopeComboBox_Menu.Items.Insert(i, $"{dato.NombreComida} - {dato.Precio}");
            }
        }


        private void hopeComboBox_EsEnvio_SelectedIndexChanged(object sender, EventArgs e) {
            if (hopeComboBox_EsEnvio.SelectedIndex == 0 || hopeComboBox_EsEnvio.SelectedIndex == 2) {
                panel_envio.Visible = false;
            }else {
                panel_envio.Visible=true;
            }
        }


        private void airForm1_Click(object sender, EventArgs e) {

        }

        private bool ValidacionCliente() {
            Mensaje msj = new Mensaje();
            if (string.IsNullOrEmpty(hopeTextBox_Nombre.Text)) {
                msj.Show("Error", "Ingrese un nombre", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                return false;
            }
            if (string.IsNullOrEmpty(hopeTextBox_Direccion.Text)) {
                msj.Show("Error", "Ingrese una Direccion", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                return false;
            }
            if (string.IsNullOrEmpty(hopeTextBox_Telefono.Text) || char.IsLetter(Convert.ToChar(hopeTextBox_Telefono.Text))) {
                msj.Show("Error", "Ingrese un telefono", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                return false;
            }

            return true;
        }

        private void LogicaEnvioRetiro() {
            string tipoEntrega = "Retiro"; // Valor por defecto

            switch (true) {
                case var _ when hopeCheckBox_EvioLunes.Checked:
                    tipoEntrega = "Lunes";
                    break;
                case var _ when hopeCheckBox_EvioMartes.Checked:
                    tipoEntrega = "Martes";
                    break;
                case var _ when hopeCheckBox_EvioMiercoles.Checked:
                    tipoEntrega = "Miercoles";
                    break;
                case var _ when hopeCheckBox_EvioJueves.Checked:
                    tipoEntrega = "Jueves";
                    break;
                case var _ when hopeCheckBox_EvioViernes.Checked:
                    tipoEntrega = "Viernes";
                    break;
                case var _ when hopeCheckBox_EvioSabado.Checked:
                    tipoEntrega = "Sabado";
                    break;
                default:
                    tipoEntrega = "No se ha seleccionado ningún día de envío, todos los días son Retiro.";
                    break;
            }

            if (tipoEntrega == ) {

            }

            Console.WriteLine(tipoEntrega);

        }

        private void hopeCheckBox_EvioLunes_CheckedChanged(object sender, EventArgs e) {
            if(hopeCheckBox_VaLunes.Checked == true && hopeCheckBox_EvioLunes.Checked == false) {
                
            }
            
        }

        private void hopeCheckBox_EvioMartes_CheckedChanged(object sender, EventArgs e) {

        }

        private void hopeCheckBox_EvioMiercoles_CheckedChanged(object sender, EventArgs e) {

        }

        private void hopeCheckBox_EvioJueves_CheckedChanged(object sender, EventArgs e) {

        }

        private void hopeCheckBox_EvioViernes_CheckedChanged(object sender, EventArgs e) {

        }

        private void hopeCheckBox_EvioSabado_CheckedChanged(object sender, EventArgs e) {

        }
    }
}
