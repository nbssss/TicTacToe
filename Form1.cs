namespace kolko_i_krzyzyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool player1 = true;
        int move = 0;

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Restart();
            resultO.Text = "0";
            resultX.Text = "0";
            lblWho.Text = "O";
            player1 = true;
        }

        private void Restart()
        {
            move = 0;
            Button[] all = new Button[9];   // tablica 9 przycisków

            /*
            all[0] = btn1;
            all[1] = btn2;
            all[2] = btn3;
            all[3] = btn4;
            all[4] = btn5;
            all[5] = btn6;
            all[6] = btn7;
            all[7] = btn8;
            all[8] = btn9;
            */

            for (int i = 0; i < all.Length; i++)
            {
                all[i] = (Button)this.Controls.Find("btn" + (i + 1), true)[0];
            }

            foreach (Button b in all)
            {
                b.Enabled = true;
                b.Text = "";
            }
        }
        private void Check()
        {
            if (btn1.Text != "" && btn1.Text == btn2.Text && btn2.Text == btn3.Text)
            {
                Win();
            }
            else if (btn4.Text != "" && btn4.Text == btn5.Text && btn5.Text == btn6.Text)
            {
                Win();
            }
            else if (btn7.Text != "" && btn7.Text == btn8.Text && btn8.Text == btn9.Text)
            {
                Win();
            }
            else if (btn1.Text != "" && btn1.Text == btn4.Text && btn4.Text == btn7.Text)
            {
                Win();
            }
            else if (btn2.Text != "" && btn2.Text == btn5.Text && btn5.Text == btn8.Text)
            {
                Win();
            }
            else if (btn3.Text != "" && btn3.Text == btn6.Text && btn6.Text == btn9.Text)
            {
                Win();
            }
            else if (btn1.Text != "" && btn1.Text == btn5.Text && btn5.Text == btn9.Text)
            {
                Win();
            }
            else if (btn3.Text != "" && btn3.Text == btn5.Text && btn5.Text == btn7.Text)
            {
                Win();
            }
            else if (move == 9)
            {
                MessageBox.Show("REMIS", "Koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Restart();
            }
        }

        private void Win()
        {
            MessageBox.Show("WYGRYWA GRACZ: " + (player1 ? "O" : "X"), "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (player1)
            {
                resultO.Text = ((int.Parse(resultO.Text)) + 1).ToString();
            }
            else
            {
                resultX.Text = ((int.Parse(resultX.Text)) + 1).ToString();
            }
            Restart();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (move >= 5)
            {
                Check();
            }

            player1 = !player1;     // zmiana gracza po wykonaniu ruchu
            lblWho.Text = player1 ? "O" : "X";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (move >= 5)
            {
                Check();
            }

            player1 = !player1;     // zmiana gracza po wykonaniu ruchu
            lblWho.Text = player1 ? "O" : "X";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (move >= 5)
            {
                Check();
            }

            player1 = !player1;     // zmiana gracza po wykonaniu ruchu
            lblWho.Text = player1 ? "O" : "X";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (move >= 5)
            {
                Check();
            }

            player1 = !player1;     // zmiana gracza po wykonaniu ruchu
            lblWho.Text = player1 ? "O" : "X";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (move >= 5)
            {
                Check();
            }

            player1 = !player1;     // zmiana gracza po wykonaniu ruchu
            lblWho.Text = player1 ? "O" : "X";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (move >= 5)
            {
                Check();
            }

            player1 = !player1;     // zmiana gracza po wykonaniu ruchu
            lblWho.Text = player1 ? "O" : "X";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (move >= 5)
            {
                Check();
            }

            player1 = !player1;     // zmiana gracza po wykonaniu ruchu
            lblWho.Text = player1 ? "O" : "X";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (move >= 5)
            {
                Check();
            }

            player1 = !player1;     // zmiana gracza po wykonaniu ruchu
            lblWho.Text = player1 ? "O" : "X";

        }
        private void btn9_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (move >= 5)
            {
                Check();
            }

            player1 = !player1;     // zmiana gracza po wykonaniu ruchu
            lblWho.Text = player1 ? "O" : "X";

        }

    }
}

