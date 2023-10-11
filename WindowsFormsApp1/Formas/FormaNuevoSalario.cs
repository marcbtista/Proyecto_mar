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
    public partial class FormaNuevoSalario : Form
    {
        public FormaNuevoSalario()
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
                float salarioact = float.Parse(textSalario.Text);// Variable que alamcena datos ingresados
                if (salarioact < 0) //Si salario es menor que 0 arrojar el siguiente mensaje de error
                {
                    MessageBox.Show("ERROR: Ingrese valores positivos para salario");
                }
                else //Si no se cumple la condicion realizar lo siguiente
                {
                    float salarionew = (salarioact * 25 / 100); // Variable que contiene el 25 % de su salario actual
                    float nuevosalario = salarionew + salarioact; // Variable que suma salario actual + el 25%, para obtener nuevo salario

                    labelNuevo.Text = nuevosalario.ToString(); //Arrojar nuevo salario en el label nuevo
                }
            }
            catch (FormatException)// Si se detecta alguna letra o caracter extraño arrojar el siguiente mensaje
            {
                MessageBox.Show("ERROR: Ingrese datos validos");
            }
        }

        private void FormaNuevoSalario_Load(object sender, EventArgs e)
        {

        }
    }
}
