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

        string diasVa = string.Empty;
        string diasNoVa = string.Empty;
        string diasRetira = string.Empty;
        string diasEnvio = string.Empty;
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
            if (hopeCheckBox_VaLunes.Checked == true && hopeCheckBox_EvioLunes.Checked == false) {
                diasVa = "Lunes ";

            } else if (hopeCheckBox_VaLunes.Checked == true && hopeCheckBox_EvioLunes.Checked == true) {
                diasVa = "Lunes ";
                diasEnvio = "Lunes ";
            }
            if (hopeCheckBox_VaMartes.Checked == true && hopeCheckBox_EvioMartes.Checked == false) {
                diasVa += "- Martes ";

            } else if (hopeCheckBox_VaMartes.Checked == true && hopeCheckBox_EvioMartes.Checked == true) {
                diasVa += "- Martes ";
                diasEnvio += "- Martes ";
            }
            if (hopeCheckBox_VaMiercoles.Checked == true && hopeCheckBox_EvioMiercoles.Checked == false) {
                diasVa = "- Miercoles ";

            } else if (hopeCheckBox_VaMiercoles.Checked == true && hopeCheckBox_EvioMiercoles.Checked == true) {
                diasVa = "- Miercoles";
                diasEnvio = "- Miercoles";
            }
            if (hopeCheckBox_VaJueves.Checked == true && hopeCheckBox_EvioJueves.Checked == false) {
                diasVa = " - Jueves ";

            } else if (hopeCheckBox_VaJueves.Checked == true && hopeCheckBox_EvioJueves.Checked == true) {
                diasVa = " - Jueves ";
                diasEnvio = " - Jueves ";
            }
            if (hopeCheckBox_VaViernes.Checked == true && hopeCheckBox_EvioViernes.Checked == false) {
                diasVa = " - Viernes ";

            } else if (hopeCheckBox_VaViernes.Checked == true && hopeCheckBox_EvioViernes.Checked == true) {
                diasVa = " - Viernes ";
                diasEnvio = " - Viernes ";
            }
            if (hopeCheckBox_VaSabado.Checked == true && hopeCheckBox_EvioSabado.Checked == false) {
                diasVa = " - Sabado ";

            } else if (hopeCheckBox_VaSabado.Checked == true && hopeCheckBox_EvioSabado.Checked == true) {
                diasVa = " - Sabado ";
                diasEnvio = " - Sabado ";
            }
        }

        private void hopeCheckBox_EvioLunes_CheckedChanged(object sender, EventArgs e) {
            if(hopeCheckBox_VaLunes.Checked == true && hopeCheckBox_EvioLunes.Checked == false) {
                diasVa = "Lunes ";
                
            }else if (hopeCheckBox_VaLunes.Checked == true && hopeCheckBox_EvioLunes.Checked == true) {
                diasVa = "Lunes ";
                diasEnvio = "Lunes ";
            }
            
        }

        private void hopeCheckBox_EvioMartes_CheckedChanged(object sender, EventArgs e) {
            if (hopeCheckBox_VaMartes.Checked == true && hopeCheckBox_EvioMartes.Checked == false) {
                diasVa += "- Martes ";

            } else if (hopeCheckBox_VaMartes.Checked == true && hopeCheckBox_EvioMartes.Checked == true) {
                diasVa += "- Martes ";
                diasEnvio += "- Martes ";
            }
        }

        private void hopeCheckBox_EvioMiercoles_CheckedChanged(object sender, EventArgs e) {
            if (hopeCheckBox_VaMiercoles.Checked == true && hopeCheckBox_EvioMiercoles.Checked == false) {
                diasVa = "- Miercoles ";

            } else if (hopeCheckBox_VaMiercoles.Checked == true && hopeCheckBox_EvioMiercoles.Checked == true) {
                diasVa = "- Miercoles";
                diasEnvio = "- Miercoles";
            }
        }

        private void hopeCheckBox_EvioJueves_CheckedChanged(object sender, EventArgs e) {
            if (hopeCheckBox_VaJueves.Checked == true && hopeCheckBox_EvioJueves.Checked == false) {
                diasVa = " - Jueves ";

            } else if (hopeCheckBox_VaJueves.Checked == true && hopeCheckBox_EvioJueves.Checked == true) {
                diasVa = " - Jueves ";
                diasEnvio = " - Jueves ";
            }
        }

        private void hopeCheckBox_EvioViernes_CheckedChanged(object sender, EventArgs e) {
            if (hopeCheckBox_VaViernes.Checked == true && hopeCheckBox_EvioViernes.Checked == false) {
                diasVa = " - Viernes ";

            } else if (hopeCheckBox_VaViernes.Checked == true && hopeCheckBox_EvioViernes.Checked == true) {
                diasVa = " - Viernes ";
                diasEnvio = " - Viernes ";
            }
        }

        private void hopeCheckBox_EvioSabado_CheckedChanged(object sender, EventArgs e) {
            if (hopeCheckBox_VaSabado.Checked == true && hopeCheckBox_EvioSabado.Checked == false) {
                diasVa = " - Sabado ";

            } else if (hopeCheckBox_VaSabado.Checked == true && hopeCheckBox_EvioSabado.Checked == true) {
                diasVa = " - Sabado ";
                diasEnvio = " - Sabado ";
            }
        }

        private void parrotButton_Agregar_Click(object sender, EventArgs e) {
            Mensaje msj = new Mensaje();
            if (string.IsNullOrEmpty(hopeTextBox_NoCome.Text)) {
                msj.Show("Error","que no come?",Color.White,Color.Red,Mensaje.TipoIcono.Error,Mensaje.TipoSonido.Intermedio);
                hopeTextBox_NoCome.Focus();
            }

            msj.Show("Cargado", "comida cargada", Color.White, Color.Green, Mensaje.TipoIcono.Ok, Mensaje.TipoSonido.simple);
        }
    }
}
