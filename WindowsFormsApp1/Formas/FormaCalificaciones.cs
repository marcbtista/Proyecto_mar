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
    public partial class FormaCalificaciones : Form
    {
        public FormaCalificaciones()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float calif1 = float.Parse(textCalif1.Text);
                float calif2 = float.Parse(textCalif2.Text);
                float calif3 = float.Parse(textCalif3.Text);
                float promedio = (calif1 + calif2 + calif3) / 3;
                if (calif1 <0 || calif2 <0 || calif3 <0)
                {
                    MessageBox.Show("Error: Ingrese datos mayores 0");
                }
                else if (calif1 >10 || calif2 >10 || calif3 >10)
                {
                    MessageBox.Show("Error: Ingrese datos menores a 10'");
                }
                else if (String.IsNullOrEmpty(textCalif1.Text) || String.IsNullOrEmpty(textCalif2.Text) || String.IsNullOrEmpty(textCalif3.Text))
                {
                    MessageBox.Show("Error: Por favor ingrese datos para cada una de las calificaciones ");
                }
                else if (promedio >=6)
                {
                    labelAprobadoOno.Text = "Aprobaste";
                    labelPromedio.Text = promedio.ToString();

                }
                else
                {
                    labelAprobadoOno.Text ="No aprobaste :(" ;
                    labelPromedio.Text = promedio.ToString();
                }

            }
            catch(FormatException)
            {
                MessageBox.Show("Error ingrese datos validos");
            }
        }
    }
}
