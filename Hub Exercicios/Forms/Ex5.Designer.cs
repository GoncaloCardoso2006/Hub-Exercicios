﻿namespace Hub_Exercicios
{
    partial class Ex5
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            button3 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(66, 58);
            label1.Name = "label1";
            label1.Size = new Size(212, 15);
            label1.TabIndex = 0;
            label1.Text = "Escreva dois nomes nas caixas da texto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(66, 119);
            button1.Name = "button1";
            button1.Size = new Size(221, 23);
            button1.TabIndex = 3;
            button1.Text = "Trocar nomes nas caixas de texto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(66, 148);
            button2.Name = "button2";
            button2.Size = new Size(221, 23);
            button2.TabIndex = 4;
            button2.Text = "Juntar os nomes no rotulo em branco";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(77, 201);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(201, 23);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(280, 273);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Voltar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 7;
            label2.Text = "Sem sessão iniciada!";
            label2.Click += label2_Click;
            // 
            // Ex5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(367, 308);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Ex5";
            Text = "Ex5";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private TextBox textBox3;
        private Button button3;
        private Label label2;
    }
}