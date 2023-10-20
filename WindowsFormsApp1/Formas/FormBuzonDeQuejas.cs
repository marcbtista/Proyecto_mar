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
    public partial class FormBuzonDeQuejas : Form
    {
        public FormBuzonDeQuejas()
        {
            InitializeComponent();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textNombre.Text;
                string NoControl = textNoControl.Text;
                string asignatura = comboBoxAsignatura.SelectedItem as string;
                string comentario = textBoxComentario.Text;
                if (String.IsNullOrEmpty(textNombre.Text) || string.IsNullOrEmpty(comboBoxAsignatura.Text) || string.IsNullOrEmpty(textNoControl.Text))
                {
                    MessageBox.Show("ERROR: Complete todos los datos");
                }
                else
                {
                    string mensaje = $"Gracias por enviar tu queja:\n\n" + $"Hola:{nombre}\n" + $"Tu queja ha sido enviada y pronto se dara respuesta";
                    MessageBox.Show(mensaje, "Queja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("error: ingrese datos validos");
            }
        }
    }
}
