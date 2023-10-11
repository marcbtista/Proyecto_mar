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
    public partial class FormaUsuarioIngre : Form
    {
        public FormaUsuarioIngre()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = textUsuario.Text;
                string contraseña = textContraseña.Text;
                if (usuario.Equals("progra") && contraseña.Equals("3PM"))
                {
                    FormaIngreso formaIngreso = new FormaIngreso();
                    formaIngreso.Show();
                }
                else if (String.IsNullOrEmpty(textUsuario.Text) || String.IsNullOrEmpty(textContraseña.Text)) 
                {
                    MessageBox.Show("ERROR: INGRESE DATOS PARA USUARIO Y CONTRASEÑA");
                }
                else
                {
                    MessageBox.Show("Error : Usuario y contraseña no validos ");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error ingrese datos validos");
            }
        }
    }
}
