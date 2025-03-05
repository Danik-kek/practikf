namespace practikf
{
    partial class Form3
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
            label5 = new Label();
            textBoxC = new TextBox();
            textBoxB = new TextBox();
            textBoxA = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            button2 = new Button();
            button_Help = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(267, 54);
            label5.Name = "label5";
            label5.Size = new Size(332, 20);
            label5.TabIndex = 27;
            label5.Text = "Введите коэффициенты уравнения ax+b^2x+c";
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(520, 130);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(125, 27);
            textBoxC.TabIndex = 26;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(334, 130);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(125, 27);
            textBoxB.TabIndex = 25;
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(141, 130);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(125, 27);
            textBoxA.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(563, 107);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 23;
            label3.Text = "С";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(387, 107);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 21;
            label2.Text = "В";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 107);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 20;
            label1.Text = "А";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(334, 241);
            button1.Name = "button1";
            button1.Size = new Size(103, 30);
            button1.TabIndex = 19;
            button1.Text = "Корни";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(292, 218);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 28;
            label6.Text = "Кол-во корней";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(292, 274);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 29;
            label7.Text = "Результат";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(12, 408);
            button2.Name = "button2";
            button2.Size = new Size(103, 30);
            button2.TabIndex = 30;
            button2.Text = "Очистка";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button_Help
            // 
            button_Help.Location = new Point(685, 408);
            button_Help.Name = "button_Help";
            button_Help.Size = new Size(103, 30);
            button_Help.TabIndex = 31;
            button_Help.Text = "Справка\r\n\r\n\r\n\r\n\r\n\r\nя хороший";
            button_Help.UseVisualStyleBackColor = true;
            button_Help.Click += button_Help_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Location = new Point(334, 185);
            button3.Name = "button3";
            button3.Size = new Size(122, 30);
            button3.TabIndex = 32;
            button3.Text = "Дискриминант";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button_Help);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxC);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form3";
            Text = "quadro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox textBoxC;
        private TextBox textBoxB;
        private TextBox textBoxA;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label6;
        private Label label7;
        private Button button2;
        private Button button_Help;
        private Button button3;
    }
}