using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formas;

namespace WindowsFormsApp1.Formas
{
    public partial class FormaHome : Form
    {
        public FormaHome()
        {
            InitializeComponent();
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaRegistro registro = new FormaRegistro();
            registro.Show();
        }

        private void menuVideo01_Click(object sender, EventArgs e)
        {
            FormaVideo video = new FormaVideo();
            video.Show();

        }

        private void formasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ejercicioAdicional1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaAdicional1 adicional1 = new FormaAdicional1();
            adicional1.Show();
        }

        private void ejercicioAdicional2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaAdicional2 adicional2 = new FormaAdicional2();
            adicional2.Show();
        }

        private void menuCalculadora_Click(object sender, EventArgs e)
        {
            FormaCalculadora formaCalculadora = new FormaCalculadora();
            formaCalculadora.Show();
        }

        private void conversionDePesosMexicanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaConversion formaConversion = new FormaConversion();
            formaConversion.Show();
        }

        private void frecuenciaCardiacaMaximaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaFrecuencia formaFrecuencia = new FormaFrecuencia();
            formaFrecuencia.Show();
        }

        private void nuevoSalarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaNuevoSalario nuevoSalario = new FormaNuevoSalario();
            nuevoSalario.Show();
        }

        private void calculadoraParaResolverEcuacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaEcuacion formaEcuacion = new FormaEcuacion();
            formaEcuacion.Show();
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaCalificaciones formaCalificaciones = new FormaCalificaciones();
            formaCalificaciones.Show();
        }

        private void usuarioValidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaUsuarioIngre formaUsuarioIngre = new FormaUsuarioIngre();
            formaUsuarioIngre.Show();
        }

        private void visorDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVisor formVisor = new FormVisor();
            formVisor.Show();
        }
    }
}
