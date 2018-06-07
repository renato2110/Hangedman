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
        private Landing landing;

        public Game(String playerName, Landing landing)
        {
            this.server = new ServiceReference1.ECCI_GamePortClient();
            this.landing = landing;
            InitializeComponent();
            if (!string.IsNullOrEmpty(playerName)) { 
                player_name_label.Text = playerName;
            }            
           tries_count.Text = server.getTries();
           word_label.Text = server.getWord();
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.landing.Show();
        }

        private void CheckWord(String word)
        {
            word_label.Text = this.server.checkWord(word);
            tries_count.Text = server.getTries();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.CheckWord("A");
            buttonA.Enabled = false;
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            this.CheckWord("B");
            buttonB.Enabled = false;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            this.CheckWord("C");
            buttonC.Enabled = false;
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            this.CheckWord("D");
            buttonD.Enabled = false;
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            this.CheckWord("E");
            buttonE.Enabled = false;
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            this.CheckWord("F");
            buttonF.Enabled = false;
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            this.CheckWord("G");
            buttonG.Enabled = false;
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            this.CheckWord("H");
            buttonH.Enabled = false;
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            this.CheckWord("I");
            buttonI.Enabled = false;
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            this.CheckWord("J");
            buttonJ.Enabled = false;
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            this.CheckWord("K");
            buttonK.Enabled = false;
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            this.CheckWord("L");
            buttonL.Enabled = false;
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            this.CheckWord("M");
            buttonM.Enabled = false;
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            this.CheckWord("N");
            buttonN.Enabled = false;
        }

        private void buttonÑ_Click(object sender, EventArgs e)
        {
            this.CheckWord("Ñ");
            buttonÑ.Enabled = false;
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            this.CheckWord("O");
            buttonO.Enabled = false;
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            this.CheckWord("P");
            buttonP.Enabled = false;
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            this.CheckWord("Q");
            buttonQ.Enabled = false;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            this.CheckWord("R");
            buttonR.Enabled = false;
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            this.CheckWord("S");
            buttonS.Enabled = false;
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            this.CheckWord("T");
            buttonT.Enabled = false;
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            this.CheckWord("U");
            buttonU.Enabled = false;
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            this.CheckWord("V");
            buttonV.Enabled = false;
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            this.CheckWord("W");
            buttonW.Enabled = false;
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            this.CheckWord("X");
            buttonX.Enabled = false;
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            this.CheckWord("Y");
            buttonY.Enabled = false;
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            this.CheckWord("Z");
            buttonZ.Enabled = false;
        }
    }
}
