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
    public partial class FormPruebaMatematica : Form
    {
        // Crea un objeto aleatorio llamado Random
        // para generar números aleatorios.
        Random randomizer = new Random();

        // Estas variables enteras almacenan los números
        // para el problema de suma.
        int addend1;
        int addend2;

        // Estas variables enteras almacenan los números
        // para el problema de resta.
        int minuend;
        int subtrahend;

        // Estas variables enteras almacenan los números
        // para el problema de multiplicación. 
        int multiplicand;
        int multiplier;

        // Estas variables enteras almacenan los números
        // para el problema de división. 
        int dividend;
        int divisor;

        // Esta variable entera realiza un seguimiento de la
        // tiempo restante.
        int timeLeft;
        public void StartTheQuiz()
        {
            // Completa el problema de suma.
            // Genera dos números aleatorios para sumar.
            // Almacena los valores en las variables 'addend1' y 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Convierte los dos números generados aleatoriamente
            // en cadenas para que se puedan mostrar
            // en los controles de etiqueta
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // 'sum' es el nombre del control NumericUpDown.
            // Este paso asegura que su valor sea cero antes
            // agregándole cualquier valor.
            sum.Value = 0;

            // Completa el problema de resta.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // Completa el problema de multiplicación.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // Completa el problema de división.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            // Inicia el cronómetro.
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }
        public FormPruebaMatematica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // Si CheckTheAnswer() devuelve verdadero, entonces el usuario
                // acerté la respuesta. detener el cronómetro
                // y mostrar un cuadro de mensaje.
                timer1.Stop();
                MessageBox.Show("¡Tienes todas las respuestas correctas!",
                                "¡Felicidades!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // Si CheckTheAnswer() devuelve falso, sigue contando
                // abajo. Disminuya el tiempo restante en un segundo y
                // muestra el nuevo tiempo restante al actualizar el
                // Etiqueta de tiempo restante.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + "segundos";
            }
            else
            {
                // Si al usuario se le acabó el tiempo, detiene el cronómetro, muestra
                // un cuadro de mensaje y complete las respuestas.
                timer1.Stop();
                timeLabel.Text = "¡Se acabó el tiempo!";
                MessageBox.Show("No terminaste a tiempo.", "¡Lo siento!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Selecciona la respuesta completa en el control NumericUpDown.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void plusLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void FormPruebaMatematica_Load(object sender, EventArgs e)
        {

        }

        private void plusRightLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
