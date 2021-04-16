using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CantStopServer; //inclusão do using para usar o servidor 

namespace ProjetoTokio // nome do projeto
{

    public partial class formPrincipal : Form
    {

        public formPrincipal()
        {

            InitializeComponent();// inicia o form
            lblVersao.Text = "Versão: " + Jogo.Versao;//exibe a versão da dll na tela
        }

        //formulario principal 
        public void Form1_Load(object sender, EventArgs e)
        {

        }

        /**************************BOTÃO DE LISTAR PARTIDAS**************************/
        public void btnListaPartida_Click(object sender, EventArgs e)
        {
            lstListaPartida.Items.Clear();//limpa a list box ao clica no botão novamente
            string retonar = Jogo.ListarPartidas("T");//listar partida existentes

            retonar = retonar.Replace("\r", ""); //continua na próxima linha
            string[] linha = retonar.Split('\n');//separa cada informação após um vírgula

            //for para adicionar cada partida na listbox
            for (int i = 0; i < linha.Length; i++)
            {
                lstListaPartida.Items.Add(linha[i]);
            }


        }

        /**************************BOTÃO DE LISTAR JOGADORES DA PARTIDA**************************/
        public void BtnJogadores_Click(object sender, EventArgs e)
        {
            txtJogadores.Clear();//limpa a listbox ao selecionar uma nova partida
            string linha = lstListaPartida.SelectedItem.ToString();//seleciona a partida e transforma em string
            string[] itens = linha.Split(','); //separa os as informaçãos (id, nome, Status)
            int id = Convert.ToInt32(itens[0]);//converte id(string) em id (numero inteiro)

            txtJogadores.Text = Jogo.ListarJogadores(id);//lista os jogadores (id da partida passado como parametro)
        }

        /**************************BOTÃO DE CRIAR NOVA PARTIDA**************************/
        public void bntCriarPartida_Click(object sender, EventArgs e)
        {
            string criacao = txtCriacao.Text; //recebe nome da partida
            string senhaCriacao = txtSenhaCriacao.Text;//recebe senha da partida

            string criar = Jogo.CriarPartida(criacao, senhaCriacao);//criar partida (nome,senha)

            //tratamento de erros 
            if (criar.StartsWith("ERRO"))//se as 4 letras(ERRO) = true
            {
                MessageBox.Show(criar); //exibe o erro na tela
            }

        }
        /**************************BOTÃO DE INICIAR PARTIDA**************************/
        public void btnIniciaPartida_Click(object sender, EventArgs e)
        {

            string senhaJogador = txtSenhaJogador.Text;//pega a senha do jogador da textbox
            int idDoJogador = Convert.ToInt32(txtIdJogador.Text); //converte o id da textbox em inteiro
            
            string inicio = Jogo.IniciarPartida(idDoJogador,senhaJogador);//id do jogador e snnha gerado ai cria-lo


            if (inicio.StartsWith("ERRO"))//se as 4 letras(ERRO) = true
            {
                MessageBox.Show(inicio); //exibe o erro na tela
            }

        }

       /**************************BOTÃO DE ENTRAR COMO JOGADOR NA PARTIDA**************************/
        public void btnEntraPartida_Click(object sender, EventArgs e)
        {
            string linha = lstListaPartida.SelectedItem.ToString();//seleciona a partida
            string[] itens = linha.Split(',');//divide as informações após uma virgula
            int id = Convert.ToInt32(itens[0]);//converte o primeiro item[0] do vetor em numero inteiro

            string jogador = txtNomeJogador.Text; //recebe o nome do jogador
            string senhaEntrar = txtSenhaEntrar.Text; //recebe a senha da partida


            string exibirTabu = Jogo.EntrarPartida(id, jogador, senhaEntrar);// entrar na partida (id da partida, nome do jogador, senha da partida)

            /*tratamento de erros*/
            if (exibirTabu.StartsWith("ERRO"))//se as 4 letras(ERRO) = true
            {
                MessageBox.Show(exibirTabu);//exibe o erro na tela
            }
            else//se não houver nenhum erro...
            {
                //split pegar o id do jogador
                string[] idDoJogador = exibirTabu.Split(',');
                txtIdJogador.Text = idDoJogador[0]; // colocando  na textbox o id do jogador

                //split pegar a senha gerada para o jogador
                string[] senha = exibirTabu.Split(','); 
                txtSenhaJogador.Text = senha[1]; // colocando  na textbox a senha do jogador

                //split para pegar a cor do jogador na partida
                string[] cor = exibirTabu.Split(',');
                txtCor.Text = cor[2]; // colocando  na textbox o cor do jogador  
            }
        }

        /**************************BOTÃO DE VERIFICAR VEZ**************************/
        public void bntVerificaVez_Click(object sender, EventArgs e)
        {
            string linha = lstListaPartida.SelectedItem.ToString();//seleciona a partida e transforma em string
            string[] itens = linha.Split(','); //separa os as informaçãos (id, nome, Status)
            int id = Convert.ToInt32(itens[0]);//converte id(string) em id (numero inteiro)

            string vez = txtVerificaVez.Text = Jogo.VerificarVez(id);

            if (vez.StartsWith("ERRO"))//se as 4 letras(ERRO) = true
            {
                MessageBox.Show(vez); //exibe o erro na tela
            }
            
        }

        /**************************BOTÃO DE ROLAR DADOS**************************/

        public void button1_Click(object sender, EventArgs e)
        {
            txtDado.Clear(); //limpar textbox


            int idJogador = Convert.ToInt32(txtIdJogador.Text); //converter texto textbox em inteiro
            
            string senhaJogador = txtSenhaJogador.Text; //atribuir no parametro senha do jogador


            string rolar = txtDado.Text = Jogo.RolarDados(idJogador, senhaJogador); //passar os paraametros para rolagem do dado
            
            if (rolar.StartsWith("ERRO"))//se as 4 letras(ERRO) = true
            {
                MessageBox.Show(rolar); //exibe o erro na tela
            }

          
        }

        /**************************BOTÃO EXIBIR TABULEIRO*****************************/
        public void btnExibirTabuleiro_Click(object sender, EventArgs e)
        {
            string linha = lstListaPartida.SelectedItem.ToString();//seleciona a partida e transforma em string
            string[] itens = linha.Split(','); //separa os as informaçãos (id, nome, Status)
            int id = Convert.ToInt32(itens[0]);//converte id(string) em id (numero inteiro)

            string exibirTabu = Jogo.ExibirTabuleiro(id);


            if (exibirTabu.StartsWith("ERRO"))//se as 4 letras(ERRO) = true
            {
                MessageBox.Show(exibirTabu); //exibe o erro na tela
            }
            else//se não houver nenhum erro...
            {
                Tabuleiro formTabuleiro = new Tabuleiro();

                formTabuleiro.idPartida = id;
                
                formTabuleiro.ShowDialog();

            }

        }
        //Tabuleiro deve ter 11 colunas

        public void txtNomeJogador_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtSenhaEntrar_TextChanged(object sender, EventArgs e)
        {

        }

        public void lblVersao_Click(object sender, EventArgs e)
        {

        }
        public void txtCriacao_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtSenhaCriacao_TextChanged(object sender, EventArgs e)
        {

        }

        public void lstListaPartida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void textTabuleiro_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblJog_Click(object sender, EventArgs e)
        {

        }
    }
}
    
        
    

