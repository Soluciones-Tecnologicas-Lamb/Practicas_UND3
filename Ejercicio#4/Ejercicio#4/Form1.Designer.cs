﻿namespace Ejercicio_4
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
            textBox1 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(298, 54);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Verificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 121);
            label1.Name = "label1";
            label1.Size = new Size(377, 15);
            label1.TabIndex = 1;
            label1.Text = "© 2025 Soluciones Tecnológicas Lamb. Todos los derechos reservados.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 9);
            label2.Name = "label2";
            label2.Size = new Size(159, 15);
            label2.TabIndex = 2;
            label2.Text = "Comprueba si es Palindroma";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 57);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 4;
            label3.Text = "Ingresa la palabra:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 145);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Ejercicio #4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
    }
}
