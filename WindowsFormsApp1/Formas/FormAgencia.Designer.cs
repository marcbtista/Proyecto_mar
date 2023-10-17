
namespace WindowsFormsApp1.Formas
{
    partial class FormAgencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPreferencias = new System.Windows.Forms.ComboBox();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preferencias";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(302, 107);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 26);
            this.textNombre.TabIndex = 3;
            // 
            // dateTimePickerFechaDeNacimiento
            // 
            this.dateTimePickerFechaDeNacimiento.Location = new System.Drawing.Point(302, 168);
            this.dateTimePickerFechaDeNacimiento.Name = "dateTimePickerFechaDeNacimiento";
            this.dateTimePickerFechaDeNacimiento.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerFechaDeNacimiento.TabIndex = 4;
            // 
            // comboBoxPreferencias
            // 
            this.comboBoxPreferencias.FormattingEnabled = true;
            this.comboBoxPreferencias.Items.AddRange(new object[] {
            "Hombre y Mujer ",
            "Mujer y Mujer ",
            "Hombre y hombre",
            "No me interesa"});
            this.comboBoxPreferencias.Location = new System.Drawing.Point(302, 220);
            this.comboBoxPreferencias.Name = "comboBoxPreferencias";
            this.comboBoxPreferencias.Size = new System.Drawing.Size(121, 28);
            this.comboBoxPreferencias.TabIndex = 5;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(513, 330);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(110, 42);
            this.buttonEnviar.TabIndex = 6;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // FormAgencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.comboBoxPreferencias);
            this.Controls.Add(this.dateTimePickerFechaDeNacimiento);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAgencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDeNacimiento;
        private System.Windows.Forms.ComboBox comboBoxPreferencias;
        private System.Windows.Forms.Button buttonEnviar;
    }
}