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
    public partial class FormMatriculayPromedio : Form
    {
        public FormMatriculayPromedio()
        {
            InitializeComponent();
        }

        private void FormMatriculayPromedio_Load(object sender, EventArgs e)
        {

        }

        private void buttonVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                int matricula =int.Parse( textBox1.Text);
                decimal calif1 = numericUpDown1.Value;
                decimal calif2 = numericUpDown2.Value;
                decimal calif3 = numericUpDown3.Value;
                decimal calif4 = numericUpDown4.Value;
                decimal calif5 = numericUpDown5.Value;

                decimal promedio =( calif1 + calif2 + calif3 + calif4 + calif5 )/ 5;

                string mensaje = $"PROMEDIO:\n\n" + $"Hola:{matricula}\n" + $"Tu promedio es:{promedio}";
                MessageBox.Show(mensaje, "Promedio", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(FormatException)
            {
                MessageBox.Show("Error ingrese dstos validos");
            }
        }
    }
}
