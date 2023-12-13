namespace Hub_Exercicios
{
    partial class F_Ex10
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(109, 140);
            button1.Name = "button1";
            button1.Size = new Size(144, 61);
            button1.TabIndex = 0;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(59, 86);
            label1.Name = "label1";
            label1.Size = new Size(254, 15);
            label1.TabIndex = 1;
            label1.Text = "Dica a pass tem a ver com o \"King\" do Discord.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(24, 111);
            label2.Name = "label2";
            label2.Size = new Size(319, 15);
            label2.TabIndex = 2;
            label2.Text = "E com o numero da camisola do Costa do Martim Margaça";
            // 
            // button2
            // 
            button2.Location = new Point(279, 289);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 5;
            label3.Text = "Sem sessão iniciada!";
            label3.Click += label3_Click;
            // 
            // F_Ex10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(366, 324);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "F_Ex10";
            Text = "Ex10";
            Load += F_Ex10_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
    }
}