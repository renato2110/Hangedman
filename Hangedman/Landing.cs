using System;
using System.Windows.Forms;

namespace Hangedman
{
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Records records = new Records();
            records.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
