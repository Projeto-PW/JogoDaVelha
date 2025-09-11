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
            switch(jogador)
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
            clickedButton.Enabled = false;
            lblJogador.Text = "Jogador " + jogador.ToString() + " joga";
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            btnJogo1.Enabled = true;
            btnJogo2.Enabled = true;
            btnJogo3.Enabled = true;
            btnJogo4.Enabled = true;
            btnJogo5.Enabled = true;
            btnJogo6.Enabled = true;
            btnJogo7.Enabled = true;
            btnJogo8.Enabled = true;
            btnJogo9.Enabled = true;
            btnComecar.Enabled = false;
            btnRecomecar.Enabled = true;
            lblJogador.Text = "Jogador " + jogador.ToString() + " Joga";
            lblJogador.ForeColor = Color.Red;
        }

        private void btnRecomecar_Click(object sender, EventArgs e)
        {
            btnJogo1.Enabled = false;
            btnJogo1.Text = "";
            btnJogo2.Enabled = false;
            btnJogo2.Text = "";
            btnJogo3.Enabled = false;
            btnJogo3.Text = "";
            btnJogo4.Enabled = false;
            btnJogo4.Text = "";
            btnJogo5.Enabled = false;
            btnJogo5.Text = "";
            btnJogo6.Enabled = false;
            btnJogo6.Text = "";
            btnJogo7.Enabled = false;
            btnJogo7.Text = "";
            btnJogo8.Enabled = false;
            btnJogo8.Text = "";
            btnJogo9.Enabled = false;
            btnJogo9.Text = "";
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
