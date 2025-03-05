namespace practikf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // не трогать хуйню !!
        private void task1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void task1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void task2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void task3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }
    }
}
