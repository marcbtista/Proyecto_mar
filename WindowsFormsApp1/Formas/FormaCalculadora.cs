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
    public partial class FormaCalculadora : Form
    {
        public FormaCalculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try // Vigilar el siguiente codigo 
            {
                float baseT = float.Parse(textBase.Text);// Declaramos variables que contienen los datos ingresados por el usuario
                float altura = float.Parse(textAltura.Text);
                if (baseT <= 0 || altura <= 0) //Condicion if para verificar si la base y altura ingresados es mayor que 0
                {
                    MessageBox.Show("ERROR: Ingrese valores positivos para la base y altura");//Mandar un mensaje de error si la condicion se cumple
                }
                else//Si no se cumple realizar la operacion para resultado del area
                {
                    float area = (baseT * altura) / 2;

                    labelArea.Text = area.ToString();//Arrojar resultado de la variable area en el label
                }
            }
            catch(FormatException)//Mandar mensaje de error cuando ingrese alguna letra o caracter extraño
            {
                MessageBox.Show("ERROR: Ingrese datos validos");
            }
        }

        private void FormaCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormaHome home = new FormaHome();
            home.Show();
            Hide();
        }
    }
}
