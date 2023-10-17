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
    public partial class FormConversor : Form
    {
        public FormConversor()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double kilometros = double.Parse(textKilometros.Text);
                if (kilometros < 0)
                {
                    MessageBox.Show("Error: ingrese datos positivos");
                }
                else
                {
                    double millas = kilometros * 0.62137;
                    double pies = kilometros * 3280.84;
                    double metros = kilometros * 1000;

                    labelMillas.Text = millas.ToString();
                    labelPies.Text = pies.ToString();
                    labelMetros.Text = metros.ToString();
                }


            }
            catch(FormatException)
            {
                MessageBox.Show("Error: ingrese datos validos");
            }
        }
    }
}
