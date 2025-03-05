namespace practikf
{
    partial class Form2
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
            label4 = new Label();
            label3 = new Label();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(356, 341);
            button1.Name = "button1";
            button1.Size = new Size(103, 30);
            button1.TabIndex = 10;
            button1.Text = "Определить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 195);
            label1.Name = "label1";
            label1.Size = new Size(227, 20);
            label1.TabIndex = 11;
            label1.Text = "Тип треугольника по сторонам";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 227);
            label2.Name = "label2";
            label2.Size = new Size(199, 20);
            label2.TabIndex = 12;
            label2.Text = "Тип треугольника по углам";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(331, 284);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 13;
            label4.Text = "Площадь";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(331, 254);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 14;
            label3.Text = "Периметр";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(148, 136);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(125, 27);
            textBoxA.TabIndex = 15;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(341, 136);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(125, 27);
            textBoxB.TabIndex = 16;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(527, 136);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(125, 27);
            textBoxC.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 100);
            label5.Name = "label5";
            label5.Size = new Size(256, 20);
            label5.TabIndex = 18;
            label5.Text = "введите длины сторон треугольник";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(textBoxC);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "triangle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private Label label5;
    }
}