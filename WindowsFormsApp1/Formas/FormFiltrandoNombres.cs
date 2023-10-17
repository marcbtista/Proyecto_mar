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
    public partial class FormFiltrandoNombres : Form
    {
        public FormFiltrandoNombres()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string[] nombresPermitidos = { "Juan", "Luis", "Pedro" };
                if (nombresPermitidos.Contains(textNombre.Text))
                {
                    comboBoxListado.Items.Add(textNombre.Text);
                    textNombre.Clear();
                }
                else
                {
                    MessageBox.Show("Nombre no permitido: solo se permiten nombres como Juan, Luis o Pedro");
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Error ingrese datos validos");
            }
        }
    }
}
