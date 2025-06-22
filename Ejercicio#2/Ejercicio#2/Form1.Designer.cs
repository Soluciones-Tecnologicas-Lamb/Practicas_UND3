namespace Ejercicio_2
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            textMIN = new TextBox();
            textSEG = new TextBox();
            labREST = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 96);
            label1.Name = "label1";
            label1.Size = new Size(377, 15);
            label1.TabIndex = 0;
            label1.Text = "© 2025 Soluciones Tecnológicas Lamb. Todos los derechos reservados.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 9);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Temporizador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 32);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "MIN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(229, 32);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 3;
            label4.Text = "SEG";
            // 
            // button1
            // 
            button1.Location = new Point(12, 9);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // textMIN
            // 
            textMIN.Location = new Point(109, 50);
            textMIN.Name = "textMIN";
            textMIN.Size = new Size(67, 23);
            textMIN.TabIndex = 5;
            // 
            // textSEG
            // 
            textSEG.Location = new Point(208, 50);
            textSEG.Name = "textSEG";
            textSEG.Size = new Size(67, 23);
            textSEG.TabIndex = 6;
            // 
            // labREST
            // 
            labREST.AutoSize = true;
            labREST.Location = new Point(317, 50);
            labREST.Name = "labREST";
            labREST.Size = new Size(52, 15);
            labREST.TabIndex = 7;
            labREST.Text = "Restante";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 120);
            Controls.Add(labREST);
            Controls.Add(textSEG);
            Controls.Add(textMIN);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ejercicio #2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private TextBox textMIN;
        private TextBox textSEG;
        private Label labREST;
    }
}
