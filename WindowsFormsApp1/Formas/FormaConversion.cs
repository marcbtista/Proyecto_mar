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
    public partial class FormaConversion : Form
    {
        public FormaConversion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormaConversion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormaHome home = new FormaHome();
            home.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try//Vigilar el siguiente codigo
            {

                double pmexicanos = double.Parse(textmexicanos.Text);//Declarar variable que almacene datos ingresados 
                if (pmexicanos < 0) //Si pmexicanos es menor que 0 arrojar el siguiente mensaje de error
                {
                    MessageBox.Show("ERROR: Por favor, ingrese un valor positivo en pesos mexicanos.");
                }
                else //Si no se cumple la condicion:
                {
                    double dolares = (pmexicanos / 2) * 0.057; // Declaramos variables que almacenen nuestro resultado para dolares y euros
                    double euros = (pmexicanos / 2) * 0.054;

                    labelDolares.Text = dolares.ToString(); // Arroja el resultado de la variable dolares y euros en los label
                    labelEuros.Text = euros.ToString();
                }
            }
            catch (FormatException)//Mandar mensaje de error para cuando ingrese alguna letra o caracter especial
            {
                MessageBox.Show("ERROR: Ingrese datos validos");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
