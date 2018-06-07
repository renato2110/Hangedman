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
    public partial class GameOver : Form
    {
        private Game game;
        private Landing landing;
        private String player;

        public GameOver(String message, String player, Game game, Landing landing)
        {
            InitializeComponent();
            this.message.Text = message;
            this.game = game;
            this.landing = landing;
            this.player = player;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.game.Close();
            this.landing.Hide();
            Game newGame = new Game(this.player, this.landing);
            newGame.Show();
            this.Close();
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            this.game.Close();
            this.Close();
        }

        private void GameOver_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.game.Close();
        }
    }
}
