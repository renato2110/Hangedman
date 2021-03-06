﻿using System;
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
            Records records = new Records(this);
            this.Hide();
            records.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game game = new Game(landing_name_textBox.Text, this);
            this.Hide();
            game.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void landing_title_label_Click(object sender, EventArgs e)
        {

        }

        private void landing_name_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
