using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquinoBatoBatoPick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int num = rand.Next(1, 4);
            string compChoice = "";

            if (num == 1)
            {
                compChoice = "Bato";
            }
            else if (num == 2)
            {
                compChoice = "Papel";
            }
            else if (num == 3)
            {
                compChoice = "Gunting";
            }

            lblResult.Text = compChoice;

            int computer = Convert.ToInt32(lblComputerScore.Text);
            int user = Convert.ToInt32(lblUserScore.Text);

            while (!((computer == 3 && user < computer) || (user == 3 && computer < user)))
            {
                if (rdbBato.Checked == true && compChoice == "Bato" || rdbPapel.Checked == true && compChoice == "Papel" || rdbGunting.Checked == true && compChoice == "Gunting")
                {
                    lblResult.Text = "It's a tie! Computer's choice is " + compChoice;
                    rdbBato.Checked = false;
                    rdbGunting.Checked = false;
                    rdbPapel.Checked = false;
                    return;
                }
                else if (rdbBato.Checked == true && compChoice == "Papel" || rdbPapel.Checked == true && compChoice == "Gunting" || rdbGunting.Checked == true && compChoice == "Bato")
                {
                    lblResult.Text = "Computer Wins! Computer's choice is " + compChoice;
                    computer++;
                    lblComputerScore.Text = computer.ToString();
                    rdbBato.Checked = false;
                    rdbGunting.Checked = false;
                    rdbPapel.Checked = false;
                    return;
                }
                else if (rdbBato.Checked == true && compChoice == "Gunting" || rdbPapel.Checked == true && compChoice == "Bato" || rdbGunting.Checked == true && compChoice == "Papel")
                {
                    lblResult.Text = "User Wins! Computer's choice is " + compChoice;
                    user++;
                    lblUserScore.Text = user.ToString();
                    rdbBato.Checked = false;
                    rdbGunting.Checked = false;
                    rdbPapel.Checked = false;
                    return;
                }
            }

            if (computer == 3 && user < computer)
            {
                MessageBox.Show("Winner : Computer", "Congratulations", MessageBoxButtons.OK);
                rdbBato.Checked = false;
                rdbGunting.Checked = false;
                rdbPapel.Checked = false;
                computer = 0;
                user = 0;
                lblUserScore.Text = user.ToString();
                lblComputerScore.Text = computer.ToString();
            }
            else if (user == 3 && user > computer)
            {
                MessageBox.Show("Winner : User", "Congratulations", MessageBoxButtons.OK);
                rdbBato.Checked = false;
                rdbGunting.Checked = false;
                rdbPapel.Checked = false;
                computer = 0;
                user = 0;
                lblUserScore.Text = user.ToString();
                lblComputerScore.Text = computer.ToString();
            }
        }
    }
}
