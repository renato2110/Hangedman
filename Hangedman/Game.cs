﻿using System;
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
        public Game(String playerName)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(playerName)) { 
                player_name_label.Text = playerName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void landing_name_label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
