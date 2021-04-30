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

            listJog = listJog.Remove(listJog.Length - 1);
            string[] listaJogSplit = listJog.Split('-');

            foreach (string linhaJog in listaJogSplit)
            {

                string[] valor = linhaJog.Split(',');

                DataRow datarow = listarJog.NewRow();
                datarow["Id"] = valor[0];
                datarow["Nick"] = valor[1];
                datarow["Cor"] = valor[2];


                listarJog.Rows.Add(datarow);

                this.jogadoresPart(valor[0], valor[1], valor[2]);

            }


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

        private void tmVezDado_Tick(object sender, EventArgs e)
        {
            txtVerificaVez.Clear();
            string[] itens = lstListaPartida.SelectedItem.ToString().Split(',');//seleciona a partida e transforma em string
            int id = Convert.ToInt32(itens[0]);//converte id(string) em id (numero inteiro)



            //string nomeJogador = txtJogadores.Text;
            //string[] nickPlayer = nomeJogador.Split(',');
            string vez = txtVerificaVez.Text = Jogo.VerificarVez(id); //nickPlayer[1];// Nick do Player

            string[] minhaVez = vez.Split(',');

            if (vez.StartsWith("ERRO"))//se as 4 letras(ERRO) = true
            {
                tmVezDado.Stop();
                //MessageBox.Show(vez); //exibe o erro na tela
                Jogo.VerificarVez(id);

            }
            else
            {

                rolarDados();

                tmVezDado.Stop();
            }
        }
        void rolarDados()
        {
            txtDado.Clear(); //limpar textbox

            int idJogador = Convert.ToInt32(txtIdJogador.Text);//converte o primeiro item[0] do vetor em numero inteiro
            string senhaJogador = txtSenhaJogador.Text;

            string rolar = txtDado.Text = Jogo.RolarDados(idJogador, senhaJogador);




            if (rolar.StartsWith("ERRO"))//se as 4 letras(ERRO) = true
            {
                MessageBox.Show(rolar);//exibe o erro na tela
            }
            else
            {
                rolar.Replace("\r", "");
                string[] separar = rolar.Split('\n');
                double casa1 = Convert.ToInt32(separar[0]);
                double casa2 = Convert.ToInt32(separar[1]);
                double casa3 = Convert.ToInt32(separar[2]);
                double casa4 = Convert.ToInt32(separar[3]);

                string casa1T = (casa1 / 10).ToString();
                string casa2T = (casa2 / 10).ToString();
                string casa3T = (casa3 / 10).ToString();
                string casa4T = (casa4 / 10).ToString();

                string[] dado1 = casa1T.Split(',');
                string[] dado2 = casa2T.Split(',');
                string[] dado3 = casa3T.Split(',');
                string[] dado4 = casa4T.Split(',');

                txtDadoRolado1.Text = dado1[1];
                txtDadoRolado2.Text = dado2[1];
                txtDadoRolado3.Text = dado3[1];
                txtDadoRolado4.Text = dado4[1];


                //funções de exibição dos dados na tela
                Dice1(); //dado1
                Dice2(); //dado2
                Dice3(); //dado3
                Dice4(); //dado4

                int valores1 = Convert.ToInt32(txtDadoRolado1.Text);
                int valores2 = Convert.ToInt32(txtDadoRolado2.Text);
                int valores3 = Convert.ToInt32(txtDadoRolado3.Text);
                int valores4 = Convert.ToInt32(txtDadoRolado4.Text);

                int resultado0 = valores1 + valores2;
                int resultado1 = valores3 + valores4;
                int resultado2 = valores2 + valores4;
                int resultado3 = valores1 + valores3;
                int resultado4 = valores1 + valores4;
                int resultado5 = valores2 + valores3;

                string res1 = resultado0.ToString();
                txtCombinacao0.Text = res1;

                string res2 = resultado1.ToString();
                txtCombinacao1.Text = res2;

                string res3 = resultado2.ToString();
                txtCombinacao2.Text = res3;

                string res4 = resultado3.ToString();
                txtCombinacao3.Text = res4;

                string res5 = resultado4.ToString();
                txtCombinacao4.Text = res5;

                string res6 = resultado5.ToString();
                txtCombinacao5.Text = res6;


                radCombinacao1.Text = txtCombinacao0.Text + " " + txtCombinacao1.Text;
                radCombinacao2.Text = txtCombinacao2.Text + " " + txtCombinacao3.Text;
                radCombinacao3.Text = txtCombinacao4.Text + " " + txtCombinacao5.Text;
            }
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
                Tabuleiro formTabuleiro = new Tabuleiro();

                formTabuleiro.idPartida = id;



                formTabuleiro.ShowDialog();

            }

        }

        // """""""""""""""""""SOMAR DADOS""""""""""""""""""""""""""""""

        void Dice1()
        {

            if (txtDadoRolado1.Text == "1")
            {
                picDadoRolado1.Image = ProjetoTokio.Properties.Resources.dado1;
            }
            if (txtDadoRolado1.Text == "2")
            {
                picDadoRolado1.Image = ProjetoTokio.Properties.Resources.dado2;
            }
            if (txtDadoRolado1.Text == "3")
            {
                picDadoRolado1.Image = ProjetoTokio.Properties.Resources.dado3;
            }
            if (txtDadoRolado1.Text == "4")
            {
                picDadoRolado1.Image = ProjetoTokio.Properties.Resources.dado4;
            }
            if (txtDadoRolado1.Text == "5")
            {
                picDadoRolado1.Image = ProjetoTokio.Properties.Resources.dado5;
            }
            if (txtDadoRolado1.Text == "6")
            {
                picDadoRolado1.Image = ProjetoTokio.Properties.Resources.dado6;
            }
        }
        void Dice2()
        {

            if (txtDadoRolado2.Text == "1")
            {
                picDadoRolado2.Image = ProjetoTokio.Properties.Resources.dado1;
            }
            if (txtDadoRolado2.Text == "2")
            {
                picDadoRolado2.Image = ProjetoTokio.Properties.Resources.dado2;
            }
            if (txtDadoRolado2.Text == "3")
            {
                picDadoRolado2.Image = ProjetoTokio.Properties.Resources.dado3;
            }
            if (txtDadoRolado2.Text == "4")
            {
                picDadoRolado2.Image = ProjetoTokio.Properties.Resources.dado4;
            }
            if (txtDadoRolado2.Text == "5")
            {
                picDadoRolado2.Image = ProjetoTokio.Properties.Resources.dado5;
            }
            if (txtDadoRolado2.Text == "6")
            {
                picDadoRolado2.Image = ProjetoTokio.Properties.Resources.dado6;
            }
        }
        void Dice3()
        {

            if (txtDadoRolado3.Text == "1")
            {
                picDadoRolado3.Image = ProjetoTokio.Properties.Resources.dado1;
            }
            if (txtDadoRolado3.Text == "2")
            {
                picDadoRolado3.Image = ProjetoTokio.Properties.Resources.dado2;
            }
            if (txtDadoRolado3.Text == "3")
            {
                picDadoRolado3.Image = ProjetoTokio.Properties.Resources.dado3;
            }
            if (txtDadoRolado3.Text == "4")
            {
                picDadoRolado3.Image = ProjetoTokio.Properties.Resources.dado4;
            }
            if (txtDadoRolado3.Text == "5")
            {
                picDadoRolado3.Image = ProjetoTokio.Properties.Resources.dado5;
            }
            if (txtDadoRolado3.Text == "6")
            {
                picDadoRolado3.Image = ProjetoTokio.Properties.Resources.dado6;
            }
        }
        void Dice4()
        {

            if (txtDadoRolado4.Text == "1")
            {
                picDadoRolado4.Image = ProjetoTokio.Properties.Resources.dado1;
            }
            if (txtDadoRolado4.Text == "2")
            {
                picDadoRolado4.Image = ProjetoTokio.Properties.Resources.dado2;
            }
            if (txtDadoRolado4.Text == "3")
            {
                picDadoRolado4.Image = ProjetoTokio.Properties.Resources.dado3;
            }
            if (txtDadoRolado4.Text == "4")
            {
                picDadoRolado4.Image = ProjetoTokio.Properties.Resources.dado4;
            }
            if (txtDadoRolado4.Text == "5")
            {
                picDadoRolado4.Image = ProjetoTokio.Properties.Resources.dado5;
            }
            if (txtDadoRolado4.Text == "6")
            {
                picDadoRolado4.Image = ProjetoTokio.Properties.Resources.dado6;
            }
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            int idJog = Convert.ToInt32( txtIdJogador.Text);
            string senhaJog = txtSenhaJogador.Text;
            string ordem = txtOrdem.Text;
            string trilha = txtTrilha.Text;

            string mover = Jogo.Mover(idJog, senhaJog, ordem, trilha);

            if (mover.StartsWith("ERRO"))//se as 4 letras(ERRO) = true
            {
                MessageBox.Show(mover); //exibe o erro na tela
            }
        }

        void Mover()
        {
            string[] itens = lstListaPartida.SelectedItem.ToString().Split(','); ;//seleciona a partida e transforma em string
            int id = Convert.ToInt32(itens[0]);//converte id(string) em id (numero inteiro)

            txtExibeTabuleiro.Text = Jogo.ExibirTabuleiro(id);
            // Jogo.Mover(Convert.ToInt32(txtIdJogador.Text),txtSenhaJogador);
        }

        private void txtDadoRolado1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCombinacao1_TextChanged(object sender, EventArgs e)
        {

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

        public void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void textTabuleiro_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblJog_Click(object sender, EventArgs e)
        {

        }

        

        /* public void btnMover_Click(object sender, EventArgs e)
         {
             int idJog = Convert.ToInt32(txtIdJogador.Text);
             string senhaJog = txtSenhaJogador.Text;
             string ordemDado = txtOrdem.Text;
             string trilha = txtTrilha.Text;

             string mover = Jogo.Mover(idJog, senhaJog, ordemDado, trilha);

             if (mover.StartsWith("ERRO"))//se as 4 letras(ERRO) = true
             {
                 MessageBox.Show(mover); //exibe o erro na tela
             }

             private void txtExibeTabuleiro_TextChanged(object sender, EventArgs e)
             {

             }

             private void button1_Click(object sender, EventArgs e)
             {
                 Mover();
 >>>>>>> ffed302f559c982e52e4f1ad037c6a5e8c01026d

         }}*/
    }
}




