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
    public partial class FormaFrecuencia : Form
    {
        public FormaFrecuencia()
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
                int edad = int.Parse(textEdad.Text);// Variable que almacena los datos ingresados
                if (edad <=0 ) //Si edad es menor o igual que 0 arrojar el siguiente mensaje de error
                {
                    MessageBox.Show("ERROR: Ingrese valores positivos o mayores que 0 para edad");
                }
                else if (edad > 100) //Si edad es mayor que 100 mandar el siguiente mensaje de error
                {
                    MessageBox.Show("ERROR: La edad no puede ser mayor que 150.");
                }
                else //Si no se cumplen las condicionales 
                {
                    int fcm = 220 - edad;// Variable que almacena resultado

                    labelFrecuencia.Text = fcm.ToString();// Arrojar resultado en label frecuencia
                }
            }

            catch (FormatException)// Si se ingresa alguna letra o caracter invalido arrojar mensaje de error 
            {
                MessageBox.Show("ERROR: Ingrese datos validos");
            }
        }

        private void FormaFrecuencia_Load(object sender, EventArgs e)
        {

        }
    }
}
