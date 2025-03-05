namespace practikf
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
            menuStrip1 = new MenuStrip();
            task1ToolStripMenuItem = new ToolStripMenuItem();
            task1ToolStripMenuItem1 = new ToolStripMenuItem();
            task2ToolStripMenuItem = new ToolStripMenuItem();
            task3ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { task1ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // task1ToolStripMenuItem
            // 
            task1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { task1ToolStripMenuItem1, task2ToolStripMenuItem, task3ToolStripMenuItem });
            task1ToolStripMenuItem.Name = "task1ToolStripMenuItem";
            task1ToolStripMenuItem.Size = new Size(83, 24);
            task1ToolStripMenuItem.Text = "task map";
            task1ToolStripMenuItem.Click += task1ToolStripMenuItem_Click;
            // 
            // task1ToolStripMenuItem1
            // 
            task1ToolStripMenuItem1.Name = "task1ToolStripMenuItem1";
            task1ToolStripMenuItem1.Size = new Size(126, 26);
            task1ToolStripMenuItem1.Text = "task1";
            task1ToolStripMenuItem1.Click += task1ToolStripMenuItem1_Click;
            // 
            // task2ToolStripMenuItem
            // 
            task2ToolStripMenuItem.Name = "task2ToolStripMenuItem";
            task2ToolStripMenuItem.Size = new Size(126, 26);
            task2ToolStripMenuItem.Text = "task2";
            task2ToolStripMenuItem.Click += task2ToolStripMenuItem_Click;
            // 
            // task3ToolStripMenuItem
            // 
            task3ToolStripMenuItem.Name = "task3ToolStripMenuItem";
            task3ToolStripMenuItem.Size = new Size(126, 26);
            task3ToolStripMenuItem.Text = "task3";
            task3ToolStripMenuItem.Click += task3ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem task1ToolStripMenuItem;
        private ToolStripMenuItem task1ToolStripMenuItem1;
        private ToolStripMenuItem task2ToolStripMenuItem;
        private ToolStripMenuItem task3ToolStripMenuItem;
    }
}
