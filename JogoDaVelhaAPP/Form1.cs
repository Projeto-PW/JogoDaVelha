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
        public frmJogo()
        {
            InitializeComponent();
        }

        private void btnJogo_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton.Text == "")
            {
                switch (jogador)
                {
                    case 1:
                        clickedButton.Text = "X";
                        clickedButton.ForeColor = Color.Red;
                        lblJogador.ForeColor = Color.Blue;
                        jogador++;
                        break;
                    case 2:
                        clickedButton.Text = "O";
                        clickedButton.ForeColor = Color.Blue;
                        lblJogador.ForeColor = Color.Red;
                        jogador--;
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
                    b.Enabled = true;
            }
            btnComecar.Enabled = false;
            btnRecomecar.Enabled = true;
            lblJogador.Text = "Jogador " + jogador.ToString() + " Joga";
            lblJogador.ForeColor = Color.Red;
        }

        private void btnRecomecar_Click(object sender, EventArgs e)
        {
            foreach(Control c in Controls)
            {
                if(c is Button b && b.Name.StartsWith("btnJogo"))
                {
                    b.Enabled = false;
                    b.Text = "";
                }
            }
            jogador = 1;
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
