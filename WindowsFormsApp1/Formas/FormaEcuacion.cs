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
    public partial class FormaEcuacion : Form
    {
        public FormaEcuacion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormaHome home = new FormaHome();
            home.Show();
            Hide();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try //Vigilar el siguiente codigo
            {
                //Declarando variables que almacenan los valores ingresados
                double valora = double.Parse(textValorA.Text);
                double valorb = double.Parse(textValorB.Text);
                double valorc = double.Parse(textValorC.Text);

                double ecuacion = (valorb * valorb) - (4 * valora * valorc);//Declarando ecuacion para que haga las operaciones 

                if (ecuacion > 0) //Si ecuacion es mayor que 0 realizar lo siguiente
                {
                    double xone = (-valorb + Math.Sqrt(ecuacion)) / (2 * valora);//Variables que almacenan resultados para casos > 0
                    double xtwo = (-valorb - Math.Sqrt(ecuacion)) / (2 * valora);

                    //Imprimir el resultado en los label de la interfaz
                    labelOne.Text = xone.ToString();
                    labelTwo.Text = xtwo.ToString();

                }
                else if (ecuacion == 0) //Si ecuacion es igual a 0 realizar lo siguiente y imprimrlo en el label de resultado

                {
                    double x = -valorb / (2 * valora);
                    labelResultado.Text = "Una solución real: x = " + x;
                }
                else //Si no cumple ninguno de los anteriores imprimir en el label el siguiente mensaje
                {
                    labelResultado.Text = "No hay soluciones reales";
                }
            }
            catch (FormatException)//Error para cuando se ingresa un letra o caracter especial
            {
                MessageBox.Show("ERROR: Ingrese valores validos");
            }
        }

        private void FormaEcuacion_Load(object sender, EventArgs e)
        {

        }
    }
}
