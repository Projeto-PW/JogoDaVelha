using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelhaAPP
{
    public partial class frmJogo : Form
    {
        int jogador = 1;
        List<int> jogador1 = new List<int>();
        List<int> jogador2 = new List<int>();
        public frmJogo()
        {
            InitializeComponent();
        }

        private void btnJogo_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton.Text == "")
            {
                int buttonNumber = int.Parse(clickedButton.Name.Split('_')[1]);
                switch (jogador)
                {
                    case 1:
                        clickedButton.Text = "X";
                        clickedButton.ForeColor = Color.Red;
                        lblJogador.ForeColor = Color.Blue;
                        jogador1.Add(buttonNumber);
                        jogador++;
                        if ((jogador1.Contains(1) && jogador1.Contains(2) && jogador1.Contains(3)) ||
                           (jogador1.Contains(4) && jogador1.Contains(5) && jogador1.Contains(6)) ||
                           (jogador1.Contains(7) && jogador1.Contains(8) && jogador1.Contains(9)) ||
                           (jogador1.Contains(1) && jogador1.Contains(5) && jogador1.Contains(9)) ||
                           (jogador1.Contains(3) && jogador1.Contains(5) && jogador1.Contains(7)) ||
                           (jogador1.Contains(1) && jogador1.Contains(4) && jogador1.Contains(7)) ||
                           (jogador1.Contains(2) && jogador1.Contains(5) && jogador1.Contains(8)) ||
                           (jogador1.Contains(3) && jogador1.Contains(6) && jogador1.Contains(9)))
                        {
                            MessageBox.Show("Jogador 1 Venceu!");
                            btnRecomecar_Click(sender, e);
                            lblJogador.ForeColor = Color.Red;
                            lblJogador.Text = "O Jogador 1 Venceu!";
                            return;
                        }
                        break;
                    case 2:
                        clickedButton.Text = "O";
                        clickedButton.ForeColor = Color.Blue;
                        lblJogador.ForeColor = Color.Red;
                        jogador2.Add(buttonNumber);
                        jogador--;
                        if ((jogador2.Contains(1) && jogador2.Contains(2) && jogador2.Contains(3)) ||
                           (jogador2.Contains(4) && jogador2.Contains(5) && jogador2.Contains(6)) ||
                           (jogador2.Contains(7) && jogador2.Contains(8) && jogador2.Contains(9)) ||
                           (jogador2.Contains(1) && jogador2.Contains(5) && jogador2.Contains(9)) ||
                           (jogador2.Contains(3) && jogador2.Contains(5) && jogador2.Contains(7)) ||
                           (jogador2.Contains(1) && jogador2.Contains(4) && jogador2.Contains(7)) ||
                           (jogador2.Contains(2) && jogador2.Contains(5) && jogador2.Contains(8)) ||
                           (jogador2.Contains(3) && jogador2.Contains(6) && jogador2.Contains(9)))
                        {
                            MessageBox.Show("Jogador 2 Venceu!");
                            btnRecomecar_Click(sender, e, true);
                            lblJogador.ForeColor = Color.Blue;
                            lblJogador.Text = "O Jogador 2 Venceu!";
                            return;
                        }
                        break;
                }
                lblJogador.Text = "Jogador " + jogador.ToString() + " joga";
            }
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is Button b && b.Name.StartsWith("btnJogo"))
                {
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            btnComecar.Enabled = false;
            btnRecomecar.Enabled = true;
            lblJogador.Text = "Jogador " + jogador.ToString() + " Joga";
            lblJogador.ForeColor = Color.Red;
        }

        private void btnRecomecar_Click(object sender, EventArgs e, bool finishGame)
        {
            if(finishGame == false)
            {
                foreach (Control c in Controls)
                {
                    if (c is Button b && b.Name.StartsWith("btnJogo"))
                    {
                        b.Enabled = false;
                        b.Text = "";
                    }
                }
            }
            jogador = 1;
            jogador1.Clear();
            jogador2.Clear();
            btnComecar.Enabled = true;
            btnRecomecar.Enabled = false;
            lblJogador.Text = "Clique para começar o jogo";
            lblJogador.ForeColor = Color.Black;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
