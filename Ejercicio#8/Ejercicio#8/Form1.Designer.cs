namespace Ejercicio_8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            lbl_resultado = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(297, 89);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Matura MT Script Capitals", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 28);
            label1.TabIndex = 1;
            label1.Text = "Contador de palabras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 142);
            label2.Name = "label2";
            label2.Size = new Size(377, 15);
            label2.TabIndex = 2;
            label2.Text = "© 2025 Soluciones Tecnológicas Lamb. Todos los derechos reservados.";
            // 
            // lbl_resultado
            // 
            lbl_resultado.AutoSize = true;
            lbl_resultado.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_resultado.ForeColor = Color.Red;
            lbl_resultado.Location = new Point(204, 118);
            lbl_resultado.Name = "lbl_resultado";
            lbl_resultado.Size = new Size(0, 24);
            lbl_resultado.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(618, 23);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(297, 37);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 5;
            label4.Text = "Ingrese la oracion";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 166);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(lbl_resultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Ejercicio #8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label lbl_resultado;
        private TextBox textBox1;
        private Label label4;
    }
}
