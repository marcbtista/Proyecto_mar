
namespace WindowsFormsApp1.Formas
{
    partial class FormConversor
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
            this.labelMillas = new System.Windows.Forms.Label();
            this.labelPies = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.textKilometros = new System.Windows.Forms.TextBox();
            this.labelMetros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese kilometros";
            // 
            // labelMillas
            // 
            this.labelMillas.AutoSize = true;
            this.labelMillas.Location = new System.Drawing.Point(72, 202);
            this.labelMillas.Name = "labelMillas";
            this.labelMillas.Size = new System.Drawing.Size(35, 13);
            this.labelMillas.TabIndex = 1;
            this.labelMillas.Text = "label2";
            // 
            // labelPies
            // 
            this.labelPies.AutoSize = true;
            this.labelPies.Location = new System.Drawing.Point(246, 202);
            this.labelPies.Name = "labelPies";
            this.labelPies.Size = new System.Drawing.Size(35, 13);
            this.labelPies.TabIndex = 2;
            this.labelPies.Text = "label3";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(440, 250);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 3;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // textKilometros
            // 
            this.textKilometros.Location = new System.Drawing.Point(157, 66);
            this.textKilometros.Name = "textKilometros";
            this.textKilometros.Size = new System.Drawing.Size(100, 20);
            this.textKilometros.TabIndex = 4;
            // 
            // labelMetros
            // 
            this.labelMetros.AutoSize = true;
            this.labelMetros.Location = new System.Drawing.Point(416, 202);
            this.labelMetros.Name = "labelMetros";
            this.labelMetros.Size = new System.Drawing.Size(35, 13);
            this.labelMetros.TabIndex = 5;
            this.labelMetros.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Millas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pies";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Metros";
            // 
            // FormConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(538, 298);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMetros);
            this.Controls.Add(this.textKilometros);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.labelPies);
            this.Controls.Add(this.labelMillas);
            this.Controls.Add(this.label1);
            this.Name = "FormConversor";
            this.Text = "FormConversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMillas;
        private System.Windows.Forms.Label labelPies;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.TextBox textKilometros;
        private System.Windows.Forms.Label labelMetros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}