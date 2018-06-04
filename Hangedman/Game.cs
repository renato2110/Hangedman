using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangedman
{
    public partial class Game : Form
    {
        private ServiceReference1.ECCI_GamePortClient server;

        public Game(String playerName)
        {
            this.server = new ServiceReference1.ECCI_GamePortClient();
            InitializeComponent();
            if (!string.IsNullOrEmpty(playerName)) { 
                player_name_label.Text = playerName;
            }            
            tries_count.Text = server.getTries();
            word_label.Text = server.getWord();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            word_label.Text = this.server.checkWord("A");
        }

        private void landing_name_label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}
