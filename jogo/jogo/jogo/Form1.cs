using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo
{
    public partial class frmJogo : Form
    {
        private String[] palavras; // cria vetor com as palavras
        private String[] dicas; // idem //////   /////////    
        private String palavra;
        private String tela;
        private int tentativas;
        private int pospalavra;
        public frmJogo()
        {
            InitializeComponent();
            this.IniciarVetor(); // cria os dois vetores ao iniciar o programa
        }
        private void IniciarVetor() {
            // inicia vetor
            palavras = new String[3]; // atribui a quantidade de palavras na string
            dicas = new String[3];

            palavras[0] = "banana";
            dicas[0] = "Fruta tropical";

            palavras[1] = "superMan";
            dicas[1] = "Super herói";

            palavras[2] = "Notebook";
            dicas[2] = "Equipamento eletrónico";
        }
        private void IniciarJogo() {
            Random r = new Random();//
            pospalavra = r.Next(0,3);
            // seleciona a palavra
            palavra = palavras[pospalavra];
            //exibir o texto na tela
            tela = "";
            for(int i =0; i< palavra.Length; i++)
            {
                tela = tela + "#";
            }
            txtPalavra.Text = tela;
            lbldica.Text = dicas[pospalavra];
            //total de tentativas
            tentativas = 6;            
            
            txtLetrasDigitadas.Text = "";
        }
        private void button1_Click(object sender, EventArgs e){
            Mensagem.Visible = false;
            pnJogo.Visible = true;
            btnStart.Visible = false;
            this.IniciarJogo();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmJogo_Load(object sender, EventArgs e)
        {
            btnAtualizar.Visible = false;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            
            Boolean encontrou = false;
            Char letra = '0';
            if (txtLetrasDigitadas.Text.Length <= 0)
            {
                txtLetrasDigitadas.Text = txtLetrasDigitadas.Text + txtLetra.Text;
            }else{
                txtLetrasDigitadas.Text = txtLetrasDigitadas.Text +" - "+txtLetra.Text;                
            }
            
            //int pletra = 0;
            try
            {
                letra = Convert.ToChar(txtLetra.Text);
            }
            catch
            {
                MessageBox.Show("Informe um caracter válido.");
                return;
            }            
            String txt = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] == letra)
                {
                    encontrou = true;
                    //pletra = i;
                    // atualizar o texto na tela
                    txt = txt + txtLetra.Text;
                }
                else
                {
                    txt = txt + tela[i];
                }
            }
                tela = txt;
                txtPalavra.Text = tela;                
                txtLetra.Clear();
            if (encontrou == false) {
                tentativas--;
                if(tentativas == 1){
                    MessageBox.Show("Sua última chance :)");                    
                }if (tentativas == 0) {
                    MessageBox.Show("Perdeu :(");                }
                else
                {
                    MessageBox.Show("A letra informada não possui na palavra, tente outra letra.");
                }                
            }

            if (txtPalavra.Text.IndexOf('#') == -1) {
                pnJogo.Visible = false;
                Mensagem.Visible = true;
                imgWin.Visible = true;
                imgGO.Visible = false;
                btnStart.Visible = true;
            }
            if(tentativas == 5)
            {
                pictureBox1.Image = Properties.Resources._2;
            }
            if (tentativas == 4)
            {
                pictureBox1.Image = Properties.Resources._3;
            }
            if (tentativas == 3)
            {
                pictureBox1.Image = Properties.Resources._4;
            }
            if (tentativas == 2)
            {
                pictureBox1.Image = Properties.Resources._5;
            }
            if (tentativas == 1)
            {
                pictureBox1.Image = Properties.Resources._6;
            }            
            if (tentativas <= 0)
            {
                pnJogo.Visible = false;
                Mensagem.Visible = true;
                imgWin.Visible = false;
                imgGO.Visible = true;
                btnStart.Visible = true;
            }
        }

        private void pnJogo_Paint(object sender, PaintEventArgs e)
        {
            btnAtualizar.Visible = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.IniciarJogo();
        }

        private void txtLetra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLetrasDigitadas_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
