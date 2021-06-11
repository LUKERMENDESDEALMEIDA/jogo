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

    public partial class Form1 : Form
    {

        public Form1()
        {
            this.listarJog = new DataTable();
            InitializeComponent();// inicia o form
            lblVersao.Text = "Versão: " + Jogo.Versao;//exibe a versão da dll na tela
        }

        //formulario principal 
        public void Form1_Load(object sender, EventArgs e)
        {

        }
        public DataTable listarJog { get; set; }
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

            string listJog = txtJogadores.Text = Jogo.ListarJogadores(id);//lista os jogadores (id da partida passado como parametro)


            
        }

        public void jogadoresPart(string idJog, string nickJog, string cor)
        {
            Tabuleiro formTabu = new Tabuleiro();

            formTabu.idJogador = idJog;
            formTabu.nickName = nickJog;
            formTabu.corJogador = cor;

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
            txtCriacao.Clear();
            txtSenhaCriacao.Clear();



        }
        /**************************BOTÃO DE INICIAR PARTIDA**************************/
        public void btnIniciaPartida_Click(object sender, EventArgs e)
        {

            string senhaJogador = txtSenhaJogador.Text;//pega a senha do jogador da textbox
            int idDoJogador = Convert.ToInt32(txtIdJogador.Text); //converte o id da textbox em inteiro

            string inicio = Jogo.IniciarPartida(idDoJogador, senhaJogador);//id do jogador e senha gerado ai cria-lo


            if (inicio.StartsWith("ERRO"))//se as 4 letras(ERRO) = true
            {

                MessageBox.Show(inicio); //exibe o erro na tela
            }

            this.tmVezDado.Start();

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
            txtNomeJogador.Clear();
            txtSenhaEntrar.Clear();


        }
       
        
        /**************************BOTÃO DE VERIFICAR VEZ**************************/
        public void bntVerificaVez_Click(object sender, EventArgs e)
        {

        }

        /**************************BOTÃO DE ROLAR DADOS**************************/
        private void btnRolarDado_Click(object sender, EventArgs e)
        {

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
                string senhaJogador = txtSenhaJogador.Text;
                string idJogador = txtIdJogador.Text;
             

                Tabuleiro formTabuleiro = new Tabuleiro();

                formTabuleiro.idPartida = id;
                formTabuleiro.senhaJogador = senhaJogador;
                formTabuleiro.idJogador = idJogador;
                



                formTabuleiro.ShowDialog();

            }

        }

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

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}




