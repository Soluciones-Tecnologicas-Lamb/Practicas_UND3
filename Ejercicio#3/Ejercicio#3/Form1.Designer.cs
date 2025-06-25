namespace Ejercicio_3
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboEntrada = new ComboBox();
            comboSalida = new ComboBox();
            textEntrada = new TextBox();
            label7 = new Label();
            lbl_resultado = new Label();
            button1 = new Button();
            lbl_unidad = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 212);
            label1.Name = "label1";
            label1.Size = new Size(377, 15);
            label1.TabIndex = 0;
            label1.Text = "© 2025 Soluciones Tecnológicas Lamb. Todos los derechos reservados.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 48);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 1;
            label2.Text = "Unidad de entrada";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 9);
            label4.Name = "label4";
            label4.Size = new Size(215, 15);
            label4.TabIndex = 3;
            label4.Text = "CONVERSOR DE UNIDADES DE MEDIDA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(115, 66);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 4;
            label5.Text = "Ingrese entrada";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(256, 98);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 5;
            label6.Text = "Unidad de salida";
            // 
            // comboEntrada
            // 
            comboEntrada.FormattingEnabled = true;
            comboEntrada.Items.AddRange(new object[] { "Metros", "Centimetros", "Pulgadas" });
            comboEntrada.Location = new Point(256, 66);
            comboEntrada.Name = "comboEntrada";
            comboEntrada.Size = new Size(121, 23);
            comboEntrada.TabIndex = 6;
            // 
            // comboSalida
            // 
            comboSalida.FormattingEnabled = true;
            comboSalida.Items.AddRange(new object[] { "Metros", "Centimetros", "Pulgadas" });
            comboSalida.Location = new Point(256, 116);
            comboSalida.Name = "comboSalida";
            comboSalida.Size = new Size(121, 23);
            comboSalida.TabIndex = 7;
            // 
            // textEntrada
            // 
            textEntrada.Location = new Point(115, 91);
            textEntrada.Name = "textEntrada";
            textEntrada.Size = new Size(100, 23);
            textEntrada.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(204, 142);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 10;
            label7.Text = "Resultado";
            // 
            // lbl_resultado
            // 
            lbl_resultado.AutoSize = true;
            lbl_resultado.Location = new Point(218, 174);
            lbl_resultado.Name = "lbl_resultado";
            lbl_resultado.Size = new Size(33, 15);
            lbl_resultado.TabIndex = 11;
            lbl_resultado.Text = "NEW";
            // 
            // button1
            // 
            button1.Location = new Point(12, 90);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Convertir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl_unidad
            // 
            lbl_unidad.AutoSize = true;
            lbl_unidad.Location = new Point(290, 174);
            lbl_unidad.Name = "lbl_unidad";
            lbl_unidad.Size = new Size(45, 15);
            lbl_unidad.TabIndex = 14;
            lbl_unidad.Text = "Unidad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 236);
            Controls.Add(lbl_unidad);
            Controls.Add(button1);
            Controls.Add(lbl_resultado);
            Controls.Add(label7);
            Controls.Add(textEntrada);
            Controls.Add(comboSalida);
            Controls.Add(comboEntrada);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ejercicio #3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboEntrada;
        private ComboBox comboSalida;
        private TextBox textEntrada;
        private TextBox textBox2;
        private Label label7;
        private Label lbl_resultado;
        private Button button1;
        private Label lbl_unidad;
    }
}
