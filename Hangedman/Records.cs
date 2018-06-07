using Hangedman;
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
    public partial class Records : Form
    {
        private Landing landing;

        public Records(Landing landing)
        {
            InitializeComponent();
            this.landing = landing;
            this.fillTable();
        }

        private void fillTable()
        {
            ServiceReference1.ECCI_GamePortClient server = new ServiceReference1.ECCI_GamePortClient();
            string records = server.getRecords();
            string[] items = records.Split('\n');
            foreach (string item in items)
            {
                if (!item.Equals("")) {
                    Console.WriteLine(item + "!");
                    string[] singleValue = item.Split('-');
                    this.playersList.Items.Add(singleValue[0]);
                    this.timesList.Items.Add(singleValue[1]);
                }
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void landing_startGame_button_Click(object sender, EventArgs e)
        {
            this.Close();
            landing.Show();
        }

        private void Records_FormClosing(object sender, FormClosingEventArgs e)
        {
            landing.Show();
        }
    }
}
