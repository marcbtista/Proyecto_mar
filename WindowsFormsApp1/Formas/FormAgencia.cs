using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Formas
{
    public partial class FormAgencia : Form
    {
        public FormAgencia()
        {
            InitializeComponent();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textNombre.Text;
                string preferencias = comboBoxPreferencias.SelectedItem as string;
                DateTime fechaNacimiento = dateTimePickerFechaDeNacimiento.Value;
                if (String.IsNullOrEmpty(textNombre.Text)|| string.IsNullOrEmpty(comboBoxPreferencias.Text))
                {
                    MessageBox.Show("ERROR: INGRESE DATOS PARA NOMBRE Y PREFERENCIAS");
                }
                else
                {
                    string mensaje = $"Gracias por enviar tu solicitud:\n\n" + $"Nombre:{nombre}\n" + $"Preferencias:{preferencias}\n" + $"Fecha de nacimiento:{fechaNacimiento}";
                    MessageBox.Show(mensaje, "Solicitud enviada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("ERROR:Ingrese datos validos");
            }

        }
    }
}
