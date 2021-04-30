
namespace ProjetoTokio
{
    partial class Form1
    {

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnListaPartida = new System.Windows.Forms.Button();
            this.BtnJogadores = new System.Windows.Forms.Button();
            this.btnEntraPartida = new System.Windows.Forms.Button();
            this.bntCriarPartida = new System.Windows.Forms.Button();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.txtCriacao = new System.Windows.Forms.TextBox();
            this.lstListaPartida = new System.Windows.Forms.ListBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.txtSenhaCriacao = new System.Windows.Forms.TextBox();
            this.lblPartida = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenhaEntrar = new System.Windows.Forms.TextBox();
            this.lblSenhaEntrar = new System.Windows.Forms.Label();
            this.lblJogador = new System.Windows.Forms.Label();
            this.btnIniciaPartida = new System.Windows.Forms.Button();
            this.txtJogadores = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.lblSenhaJogadorEntrada = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.bntVerificaVez = new System.Windows.Forms.Button();
            this.lblTabelaTrilha = new System.Windows.Forms.Label();
            this.lblTabelaPosicao = new System.Windows.Forms.Label();
            this.lblTabelaJogador = new System.Windows.Forms.Label();
            this.lblTabelaTipo = new System.Windows.Forms.Label();
            this.lblTabelaVermelho = new System.Windows.Forms.Label();
            this.lblTabelaAzul = new System.Windows.Forms.Label();
            this.lblTabelaVerde = new System.Windows.Forms.Label();
            this.lblTableaAmarelo = new System.Windows.Forms.Label();
            this.btnExibirTabuleiro = new System.Windows.Forms.Button();
            this.txtVerificaVez = new System.Windows.Forms.TextBox();
            this.txtDadoRolado4 = new System.Windows.Forms.TextBox();
            this.txtDadoRolado3 = new System.Windows.Forms.TextBox();
            this.txtDadoRolado2 = new System.Windows.Forms.TextBox();
            this.txtDadoRolado1 = new System.Windows.Forms.TextBox();
            this.picDadoRolado4 = new System.Windows.Forms.PictureBox();
            this.picDadoRolado3 = new System.Windows.Forms.PictureBox();
            this.picDadoRolado2 = new System.Windows.Forms.PictureBox();
            this.picDadoRolado1 = new System.Windows.Forms.PictureBox();
            this.txtDado = new System.Windows.Forms.TextBox();
            this.btnRolarDado = new System.Windows.Forms.Button();
            this.txtCombinacao0 = new System.Windows.Forms.TextBox();
            this.txtCombinacao1 = new System.Windows.Forms.TextBox();
            this.txtCombinacao2 = new System.Windows.Forms.TextBox();
            this.txtCombinacao3 = new System.Windows.Forms.TextBox();
            this.txtCombinacao4 = new System.Windows.Forms.TextBox();
            this.txtCombinacao5 = new System.Windows.Forms.TextBox();
            this.tmVezDado = new System.Windows.Forms.Timer(this.components);
            this.radCombinacao3 = new System.Windows.Forms.RadioButton();
            this.radCombinacao2 = new System.Windows.Forms.RadioButton();
            this.radCombinacao1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picDadoRolado4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDadoRolado3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDadoRolado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDadoRolado1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListaPartida
            // 
            this.btnListaPartida.BackColor = System.Drawing.Color.HotPink;
            this.btnListaPartida.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnListaPartida.Location = new System.Drawing.Point(75, 146);
            this.btnListaPartida.Name = "btnListaPartida";
            this.btnListaPartida.Size = new System.Drawing.Size(155, 39);
            this.btnListaPartida.TabIndex = 0;
            this.btnListaPartida.Text = "Partidas";
            this.btnListaPartida.UseVisualStyleBackColor = false;
            this.btnListaPartida.Click += new System.EventHandler(this.btnListaPartida_Click);
            // 
            // BtnJogadores
            // 
            this.BtnJogadores.BackColor = System.Drawing.Color.HotPink;
            this.BtnJogadores.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnJogadores.Location = new System.Drawing.Point(645, 130);
            this.BtnJogadores.Name = "BtnJogadores";
            this.BtnJogadores.Size = new System.Drawing.Size(100, 30);
            this.BtnJogadores.TabIndex = 2;
            this.BtnJogadores.Text = "Jogadores";
            this.BtnJogadores.UseVisualStyleBackColor = false;
            this.BtnJogadores.Click += new System.EventHandler(this.BtnJogadores_Click);
            // 
            // btnEntraPartida
            // 
            this.btnEntraPartida.BackColor = System.Drawing.Color.HotPink;
            this.btnEntraPartida.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEntraPartida.Location = new System.Drawing.Point(77, 444);
            this.btnEntraPartida.Name = "btnEntraPartida";
            this.btnEntraPartida.Size = new System.Drawing.Size(153, 35);
            this.btnEntraPartida.TabIndex = 4;
            this.btnEntraPartida.Text = "Entrar na Partida";
            this.btnEntraPartida.UseVisualStyleBackColor = false;
            this.btnEntraPartida.Click += new System.EventHandler(this.btnEntraPartida_Click);
            // 
            // bntCriarPartida
            // 
            this.bntCriarPartida.BackColor = System.Drawing.Color.HotPink;
            this.bntCriarPartida.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.bntCriarPartida.Location = new System.Drawing.Point(75, 310);
            this.bntCriarPartida.Name = "bntCriarPartida";
            this.bntCriarPartida.Size = new System.Drawing.Size(155, 41);
            this.bntCriarPartida.TabIndex = 5;
            this.bntCriarPartida.Text = "Criar Partida";
            this.bntCriarPartida.UseVisualStyleBackColor = false;
            this.bntCriarPartida.Click += new System.EventHandler(this.bntCriarPartida_Click);
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtNomeJogador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeJogador.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeJogador.Location = new System.Drawing.Point(76, 371);
            this.txtNomeJogador.Multiline = true;
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(159, 24);
            this.txtNomeJogador.TabIndex = 6;
            this.txtNomeJogador.TextChanged += new System.EventHandler(this.txtNomeJogador_TextChanged);
            // 
            // txtCriacao
            // 
            this.txtCriacao.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtCriacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCriacao.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriacao.Location = new System.Drawing.Point(75, 211);
            this.txtCriacao.Multiline = true;
            this.txtCriacao.Name = "txtCriacao";
            this.txtCriacao.Size = new System.Drawing.Size(159, 27);
            this.txtCriacao.TabIndex = 7;
            this.txtCriacao.TextChanged += new System.EventHandler(this.txtCriacao_TextChanged);
            // 
            // lstListaPartida
            // 
            this.lstListaPartida.BackColor = System.Drawing.Color.LavenderBlush;
            this.lstListaPartida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstListaPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstListaPartida.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListaPartida.FormattingEnabled = true;
            this.lstListaPartida.ItemHeight = 16;
            this.lstListaPartida.Location = new System.Drawing.Point(47, 12);
            this.lstListaPartida.Name = "lstListaPartida";
            this.lstListaPartida.Size = new System.Drawing.Size(229, 112);
            this.lstListaPartida.TabIndex = 1;
            this.lstListaPartida.SelectedIndexChanged += new System.EventHandler(this.lstListaPartida_SelectedIndexChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(310, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(237, 59);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Can\'t Stop";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblVersao.Location = new System.Drawing.Point(723, 496);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(47, 15);
            this.lblVersao.TabIndex = 10;
            this.lblVersao.Text = "Versão:";
            this.lblVersao.Click += new System.EventHandler(this.lblVersao_Click);
            // 
            // txtSenhaCriacao
            // 
            this.txtSenhaCriacao.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtSenhaCriacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenhaCriacao.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaCriacao.Location = new System.Drawing.Point(75, 267);
            this.txtSenhaCriacao.Multiline = true;
            this.txtSenhaCriacao.Name = "txtSenhaCriacao";
            this.txtSenhaCriacao.Size = new System.Drawing.Size(159, 27);
            this.txtSenhaCriacao.TabIndex = 11;
            this.txtSenhaCriacao.TextChanged += new System.EventHandler(this.txtSenhaCriacao_TextChanged);
            // 
            // lblPartida
            // 
            this.lblPartida.AutoSize = true;
            this.lblPartida.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPartida.Location = new System.Drawing.Point(24, 214);
            this.lblPartida.Name = "lblPartida";
            this.lblPartida.Size = new System.Drawing.Size(46, 15);
            this.lblPartida.TabIndex = 12;
            this.lblPartida.Text = "Partida";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSenha.Location = new System.Drawing.Point(24, 270);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 15);
            this.lblSenha.TabIndex = 13;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenhaEntrar
            // 
            this.txtSenhaEntrar.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtSenhaEntrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenhaEntrar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaEntrar.Location = new System.Drawing.Point(76, 401);
            this.txtSenhaEntrar.Multiline = true;
            this.txtSenhaEntrar.Name = "txtSenhaEntrar";
            this.txtSenhaEntrar.Size = new System.Drawing.Size(159, 28);
            this.txtSenhaEntrar.TabIndex = 14;
            this.txtSenhaEntrar.TextChanged += new System.EventHandler(this.txtSenhaEntrar_TextChanged);
            // 
            // lblSenhaEntrar
            // 
            this.lblSenhaEntrar.AutoSize = true;
            this.lblSenhaEntrar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSenhaEntrar.Location = new System.Drawing.Point(19, 401);
            this.lblSenhaEntrar.Name = "lblSenhaEntrar";
            this.lblSenhaEntrar.Size = new System.Drawing.Size(46, 30);
            this.lblSenhaEntrar.TabIndex = 15;
            this.lblSenhaEntrar.Text = "Senha \r\nPartida";
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblJogador.Location = new System.Drawing.Point(19, 374);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(51, 15);
            this.lblJogador.TabIndex = 16;
            this.lblJogador.Text = "Jogador";
            // 
            // btnIniciaPartida
            // 
            this.btnIniciaPartida.BackColor = System.Drawing.Color.HotPink;
            this.btnIniciaPartida.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnIniciaPartida.Location = new System.Drawing.Point(357, 106);
            this.btnIniciaPartida.Name = "btnIniciaPartida";
            this.btnIniciaPartida.Size = new System.Drawing.Size(157, 79);
            this.btnIniciaPartida.TabIndex = 17;
            this.btnIniciaPartida.Text = "Iniciar Partida";
            this.btnIniciaPartida.UseVisualStyleBackColor = false;
            this.btnIniciaPartida.Click += new System.EventHandler(this.btnIniciaPartida_Click);
            // 
            // txtJogadores
            // 
            this.txtJogadores.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtJogadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJogadores.Cursor = System.Windows.Forms.Cursors.No;
            this.txtJogadores.Enabled = false;
            this.txtJogadores.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJogadores.Location = new System.Drawing.Point(623, 12);
            this.txtJogadores.Multiline = true;
            this.txtJogadores.Name = "txtJogadores";
            this.txtJogadores.Size = new System.Drawing.Size(138, 107);
            this.txtJogadores.TabIndex = 22;
            // 
            // txtCor
            // 
            this.txtCor.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtCor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCor.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCor.Enabled = false;
            this.txtCor.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.ForeColor = System.Drawing.Color.Red;
            this.txtCor.Location = new System.Drawing.Point(319, 242);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(100, 16);
            this.txtCor.TabIndex = 23;
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtSenhaJogador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenhaJogador.Cursor = System.Windows.Forms.Cursors.No;
            this.txtSenhaJogador.Enabled = false;
            this.txtSenhaJogador.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaJogador.ForeColor = System.Drawing.Color.Red;
            this.txtSenhaJogador.Location = new System.Drawing.Point(442, 242);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(100, 16);
            this.txtSenhaJogador.TabIndex = 24;
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtIdJogador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdJogador.Cursor = System.Windows.Forms.Cursors.No;
            this.txtIdJogador.Enabled = false;
            this.txtIdJogador.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdJogador.ForeColor = System.Drawing.Color.Red;
            this.txtIdJogador.Location = new System.Drawing.Point(376, 295);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdJogador.Size = new System.Drawing.Size(100, 16);
            this.txtIdJogador.TabIndex = 25;
            this.txtIdJogador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSenhaJogadorEntrada
            // 
            this.lblSenhaJogadorEntrada.AutoSize = true;
            this.lblSenhaJogadorEntrada.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSenhaJogadorEntrada.Location = new System.Drawing.Point(435, 224);
            this.lblSenhaJogadorEntrada.Name = "lblSenhaJogadorEntrada";
            this.lblSenhaJogadorEntrada.Size = new System.Drawing.Size(105, 15);
            this.lblSenhaJogadorEntrada.TabIndex = 27;
            this.lblSenhaJogadorEntrada.Text = "Senha do Jogador";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCor.Location = new System.Drawing.Point(316, 224);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(90, 15);
            this.lblCor.TabIndex = 28;
            this.lblCor.Text = "Cor do Jogador";
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblIdJogador.Location = new System.Drawing.Point(389, 279);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(83, 15);
            this.lblIdJogador.TabIndex = 29;
            this.lblIdJogador.Text = "ID do Jogador";
            // 
            // bntVerificaVez
            // 
            this.bntVerificaVez.BackColor = System.Drawing.Color.HotPink;
            this.bntVerificaVez.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.bntVerificaVez.Location = new System.Drawing.Point(645, 259);
            this.bntVerificaVez.Name = "bntVerificaVez";
            this.bntVerificaVez.Size = new System.Drawing.Size(100, 30);
            this.bntVerificaVez.TabIndex = 30;
            this.bntVerificaVez.Text = "Verificar Vez";
            this.bntVerificaVez.UseVisualStyleBackColor = false;
            this.bntVerificaVez.Click += new System.EventHandler(this.bntVerificaVez_Click);
            // 
            // lblTabelaTrilha
            // 
            this.lblTabelaTrilha.Location = new System.Drawing.Point(0, 0);
            this.lblTabelaTrilha.Name = "lblTabelaTrilha";
            this.lblTabelaTrilha.Size = new System.Drawing.Size(100, 23);
            this.lblTabelaTrilha.TabIndex = 0;
            // 
            // lblTabelaPosicao
            // 
            this.lblTabelaPosicao.Location = new System.Drawing.Point(0, 0);
            this.lblTabelaPosicao.Name = "lblTabelaPosicao";
            this.lblTabelaPosicao.Size = new System.Drawing.Size(100, 23);
            this.lblTabelaPosicao.TabIndex = 0;
            // 
            // lblTabelaJogador
            // 
            this.lblTabelaJogador.Location = new System.Drawing.Point(0, 0);
            this.lblTabelaJogador.Name = "lblTabelaJogador";
            this.lblTabelaJogador.Size = new System.Drawing.Size(100, 23);
            this.lblTabelaJogador.TabIndex = 0;
            // 
            // lblTabelaTipo
            // 
            this.lblTabelaTipo.Location = new System.Drawing.Point(0, 0);
            this.lblTabelaTipo.Name = "lblTabelaTipo";
            this.lblTabelaTipo.Size = new System.Drawing.Size(100, 23);
            this.lblTabelaTipo.TabIndex = 0;
            // 
            // lblTabelaVermelho
            // 
            this.lblTabelaVermelho.Location = new System.Drawing.Point(0, 0);
            this.lblTabelaVermelho.Name = "lblTabelaVermelho";
            this.lblTabelaVermelho.Size = new System.Drawing.Size(100, 23);
            this.lblTabelaVermelho.TabIndex = 0;
            // 
            // lblTabelaAzul
            // 
            this.lblTabelaAzul.Location = new System.Drawing.Point(0, 0);
            this.lblTabelaAzul.Name = "lblTabelaAzul";
            this.lblTabelaAzul.Size = new System.Drawing.Size(100, 23);
            this.lblTabelaAzul.TabIndex = 0;
            // 
            // lblTabelaVerde
            // 
            this.lblTabelaVerde.Location = new System.Drawing.Point(0, 0);
            this.lblTabelaVerde.Name = "lblTabelaVerde";
            this.lblTabelaVerde.Size = new System.Drawing.Size(100, 23);
            this.lblTabelaVerde.TabIndex = 0;
            // 
            // lblTableaAmarelo
            // 
            this.lblTableaAmarelo.Location = new System.Drawing.Point(0, 0);
            this.lblTableaAmarelo.Name = "lblTableaAmarelo";
            this.lblTableaAmarelo.Size = new System.Drawing.Size(100, 23);
            this.lblTableaAmarelo.TabIndex = 0;
            // 
            // btnExibirTabuleiro
            // 
            this.btnExibirTabuleiro.BackColor = System.Drawing.Color.HotPink;
            this.btnExibirTabuleiro.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExibirTabuleiro.Location = new System.Drawing.Point(354, 345);
            this.btnExibirTabuleiro.Name = "btnExibirTabuleiro";
            this.btnExibirTabuleiro.Size = new System.Drawing.Size(160, 50);
            this.btnExibirTabuleiro.TabIndex = 43;
            this.btnExibirTabuleiro.Text = "Exibir Tabuleiro";
            this.btnExibirTabuleiro.UseVisualStyleBackColor = false;
            this.btnExibirTabuleiro.Click += new System.EventHandler(this.btnExibirTabuleiro_Click);
            // 
            // txtVerificaVez
            // 
            this.txtVerificaVez.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtVerificaVez.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVerificaVez.Cursor = System.Windows.Forms.Cursors.No;
            this.txtVerificaVez.Enabled = false;
            this.txtVerificaVez.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerificaVez.Location = new System.Drawing.Point(623, 177);
            this.txtVerificaVez.Multiline = true;
            this.txtVerificaVez.Name = "txtVerificaVez";
            this.txtVerificaVez.Size = new System.Drawing.Size(138, 77);
            this.txtVerificaVez.TabIndex = 31;
            // 
            // txtDadoRolado4
            // 
            this.txtDadoRolado4.Location = new System.Drawing.Point(499, 493);
            this.txtDadoRolado4.Multiline = true;
            this.txtDadoRolado4.Name = "txtDadoRolado4";
            this.txtDadoRolado4.Size = new System.Drawing.Size(26, 23);
            this.txtDadoRolado4.TabIndex = 115;
            this.txtDadoRolado4.Visible = false;
            // 
            // txtDadoRolado3
            // 
            this.txtDadoRolado3.Location = new System.Drawing.Point(498, 428);
            this.txtDadoRolado3.Multiline = true;
            this.txtDadoRolado3.Name = "txtDadoRolado3";
            this.txtDadoRolado3.Size = new System.Drawing.Size(26, 23);
            this.txtDadoRolado3.TabIndex = 114;
            this.txtDadoRolado3.Visible = false;
            // 
            // txtDadoRolado2
            // 
            this.txtDadoRolado2.Location = new System.Drawing.Point(455, 493);
            this.txtDadoRolado2.Multiline = true;
            this.txtDadoRolado2.Name = "txtDadoRolado2";
            this.txtDadoRolado2.Size = new System.Drawing.Size(26, 23);
            this.txtDadoRolado2.TabIndex = 113;
            this.txtDadoRolado2.Visible = false;
            // 
            // txtDadoRolado1
            // 
            this.txtDadoRolado1.Location = new System.Drawing.Point(454, 428);
            this.txtDadoRolado1.Multiline = true;
            this.txtDadoRolado1.Name = "txtDadoRolado1";
            this.txtDadoRolado1.Size = new System.Drawing.Size(26, 23);
            this.txtDadoRolado1.TabIndex = 112;
            this.txtDadoRolado1.Visible = false;
            this.txtDadoRolado1.TextChanged += new System.EventHandler(this.txtDadoRolado1_TextChanged);
            // 
            // picDadoRolado4
            // 
            this.picDadoRolado4.BackColor = System.Drawing.Color.Transparent;
            this.picDadoRolado4.Location = new System.Drawing.Point(711, 381);
            this.picDadoRolado4.Name = "picDadoRolado4";
            this.picDadoRolado4.Size = new System.Drawing.Size(50, 50);
            this.picDadoRolado4.TabIndex = 111;
            this.picDadoRolado4.TabStop = false;
            // 
            // picDadoRolado3
            // 
            this.picDadoRolado3.BackColor = System.Drawing.Color.Transparent;
            this.picDadoRolado3.Location = new System.Drawing.Point(711, 313);
            this.picDadoRolado3.Name = "picDadoRolado3";
            this.picDadoRolado3.Size = new System.Drawing.Size(50, 50);
            this.picDadoRolado3.TabIndex = 110;
            this.picDadoRolado3.TabStop = false;
            // 
            // picDadoRolado2
            // 
            this.picDadoRolado2.BackColor = System.Drawing.Color.Transparent;
            this.picDadoRolado2.Location = new System.Drawing.Point(636, 381);
            this.picDadoRolado2.Name = "picDadoRolado2";
            this.picDadoRolado2.Size = new System.Drawing.Size(50, 50);
            this.picDadoRolado2.TabIndex = 109;
            this.picDadoRolado2.TabStop = false;
            // 
            // picDadoRolado1
            // 
            this.picDadoRolado1.BackColor = System.Drawing.Color.Transparent;
            this.picDadoRolado1.Location = new System.Drawing.Point(636, 313);
            this.picDadoRolado1.Name = "picDadoRolado1";
            this.picDadoRolado1.Size = new System.Drawing.Size(50, 50);
            this.picDadoRolado1.TabIndex = 108;
            this.picDadoRolado1.TabStop = false;
            // 
            // txtDado
            // 
            this.txtDado.Location = new System.Drawing.Point(354, 428);
            this.txtDado.Multiline = true;
            this.txtDado.Name = "txtDado";
            this.txtDado.Size = new System.Drawing.Size(88, 51);
            this.txtDado.TabIndex = 107;
            this.txtDado.Visible = false;
            // 
            // btnRolarDado
            // 
            this.btnRolarDado.BackColor = System.Drawing.Color.HotPink;
            this.btnRolarDado.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRolarDado.Location = new System.Drawing.Point(645, 444);
            this.btnRolarDado.Name = "btnRolarDado";
            this.btnRolarDado.Size = new System.Drawing.Size(100, 30);
            this.btnRolarDado.TabIndex = 106;
            this.btnRolarDado.Text = "Rolar Dado";
            this.btnRolarDado.UseVisualStyleBackColor = false;
            this.btnRolarDado.Click += new System.EventHandler(this.btnRolarDado_Click);
            // 
            // txtCombinacao0
            // 
            this.txtCombinacao0.Location = new System.Drawing.Point(785, 284);
            this.txtCombinacao0.Multiline = true;
            this.txtCombinacao0.Name = "txtCombinacao0";
            this.txtCombinacao0.Size = new System.Drawing.Size(35, 26);
            this.txtCombinacao0.TabIndex = 116;
            this.txtCombinacao0.TextChanged += new System.EventHandler(this.txtCombinacao1_TextChanged);
            // 
            // txtCombinacao1
            // 
            this.txtCombinacao1.Location = new System.Drawing.Point(785, 319);
            this.txtCombinacao1.Multiline = true;
            this.txtCombinacao1.Name = "txtCombinacao1";
            this.txtCombinacao1.Size = new System.Drawing.Size(35, 26);
            this.txtCombinacao1.TabIndex = 117;
            // 
            // txtCombinacao2
            // 
            this.txtCombinacao2.Location = new System.Drawing.Point(785, 355);
            this.txtCombinacao2.Multiline = true;
            this.txtCombinacao2.Name = "txtCombinacao2";
            this.txtCombinacao2.Size = new System.Drawing.Size(35, 26);
            this.txtCombinacao2.TabIndex = 118;
            // 
            // txtCombinacao3
            // 
            this.txtCombinacao3.Location = new System.Drawing.Point(785, 385);
            this.txtCombinacao3.Multiline = true;
            this.txtCombinacao3.Name = "txtCombinacao3";
            this.txtCombinacao3.Size = new System.Drawing.Size(35, 26);
            this.txtCombinacao3.TabIndex = 119;
            // 
            // txtCombinacao4
            // 
            this.txtCombinacao4.Location = new System.Drawing.Point(785, 414);
            this.txtCombinacao4.Multiline = true;
            this.txtCombinacao4.Name = "txtCombinacao4";
            this.txtCombinacao4.Size = new System.Drawing.Size(35, 26);
            this.txtCombinacao4.TabIndex = 120;
            // 
            // txtCombinacao5
            // 
            this.txtCombinacao5.Location = new System.Drawing.Point(785, 444);
            this.txtCombinacao5.Multiline = true;
            this.txtCombinacao5.Name = "txtCombinacao5";
            this.txtCombinacao5.Size = new System.Drawing.Size(35, 26);
            this.txtCombinacao5.TabIndex = 121;
            // 
            // tmVezDado
            // 
            this.tmVezDado.Interval = 3000;
            this.tmVezDado.Tick += new System.EventHandler(this.tmVezDado_Tick);
            // 
            // radCombinacao3
            // 
            this.radCombinacao3.AutoSize = true;
            this.radCombinacao3.Location = new System.Drawing.Point(554, 356);
            this.radCombinacao3.Name = "radCombinacao3";
            this.radCombinacao3.Size = new System.Drawing.Size(14, 13);
            this.radCombinacao3.TabIndex = 141;
            this.radCombinacao3.TabStop = true;
            this.radCombinacao3.UseVisualStyleBackColor = true;
            // 
            // radCombinacao2
            // 
            this.radCombinacao2.AutoSize = true;
            this.radCombinacao2.Location = new System.Drawing.Point(554, 332);
            this.radCombinacao2.Name = "radCombinacao2";
            this.radCombinacao2.Size = new System.Drawing.Size(14, 13);
            this.radCombinacao2.TabIndex = 140;
            this.radCombinacao2.TabStop = true;
            this.radCombinacao2.UseVisualStyleBackColor = true;
            // 
            // radCombinacao1
            // 
            this.radCombinacao1.AutoSize = true;
            this.radCombinacao1.Location = new System.Drawing.Point(554, 310);
            this.radCombinacao1.Name = "radCombinacao1";
            this.radCombinacao1.Size = new System.Drawing.Size(14, 13);
            this.radCombinacao1.TabIndex = 139;
            this.radCombinacao1.TabStop = true;
            this.radCombinacao1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(822, 487);
            this.Controls.Add(this.radCombinacao3);
            this.Controls.Add(this.radCombinacao2);
            this.Controls.Add(this.radCombinacao1);
            this.Controls.Add(this.txtCombinacao5);
            this.Controls.Add(this.txtCombinacao4);
            this.Controls.Add(this.txtCombinacao3);
            this.Controls.Add(this.txtCombinacao2);
            this.Controls.Add(this.txtCombinacao1);
            this.Controls.Add(this.txtCombinacao0);
            this.Controls.Add(this.txtDadoRolado4);
            this.Controls.Add(this.txtDadoRolado3);
            this.Controls.Add(this.txtDadoRolado2);
            this.Controls.Add(this.txtDadoRolado1);
            this.Controls.Add(this.picDadoRolado4);
            this.Controls.Add(this.picDadoRolado3);
            this.Controls.Add(this.picDadoRolado2);
            this.Controls.Add(this.picDadoRolado1);
            this.Controls.Add(this.txtDado);
            this.Controls.Add(this.btnRolarDado);
            this.Controls.Add(this.btnExibirTabuleiro);
            this.Controls.Add(this.txtVerificaVez);
            this.Controls.Add(this.bntVerificaVez);
            this.Controls.Add(this.lblIdJogador);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblSenhaJogadorEntrada);
            this.Controls.Add(this.txtIdJogador);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtJogadores);
            this.Controls.Add(this.btnIniciaPartida);
            this.Controls.Add(this.lblJogador);
            this.Controls.Add(this.lblSenhaEntrar);
            this.Controls.Add(this.txtSenhaEntrar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblPartida);
            this.Controls.Add(this.txtSenhaCriacao);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCriacao);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.bntCriarPartida);
            this.Controls.Add(this.btnEntraPartida);
            this.Controls.Add(this.BtnJogadores);
            this.Controls.Add(this.lstListaPartida);
            this.Controls.Add(this.btnListaPartida);
            this.Name = "Form1";
            this.Text = "Projeto Tokyo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDadoRolado4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDadoRolado3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDadoRolado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDadoRolado1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnListaPartida;
        public System.Windows.Forms.Button BtnJogadores;
        public System.Windows.Forms.Button btnEntraPartida;
        public System.Windows.Forms.Button bntCriarPartida;
        public System.Windows.Forms.TextBox txtNomeJogador;
        public System.Windows.Forms.TextBox txtCriacao;
        public System.Windows.Forms.Label lblNome;
        public System.Windows.Forms.Label lblVersao;
        public System.Windows.Forms.TextBox txtSenhaCriacao;
        public System.Windows.Forms.Label lblPartida;
        public System.Windows.Forms.Label lblSenha;
        public System.Windows.Forms.TextBox txtSenhaEntrar;
        public System.Windows.Forms.Label lblSenhaEntrar;
        public System.Windows.Forms.Label lblJogador;
        public System.Windows.Forms.Button btnIniciaPartida;
        public System.Windows.Forms.TextBox txtJogadores;
        public System.Windows.Forms.TextBox txtCor;
        public System.Windows.Forms.TextBox txtSenhaJogador;
        public System.Windows.Forms.TextBox txtIdJogador;
        public System.Windows.Forms.Label lblSenhaJogadorEntrada;
        public System.Windows.Forms.Label lblCor;
        public System.Windows.Forms.Label lblIdJogador;
        public System.Windows.Forms.Button bntVerificaVez;
        public System.Windows.Forms.Label lblTabelaTrilha;
        public System.Windows.Forms.Label lblTabelaPosicao;
        public System.Windows.Forms.Label lblTabelaJogador;
        public System.Windows.Forms.Label lblTabelaTipo;
        public System.Windows.Forms.Label lblTabelaVermelho;
        public System.Windows.Forms.Label lblTabelaAzul;
        public System.Windows.Forms.Label lblTabelaVerde;
        public System.Windows.Forms.Label lblTableaAmarelo;
        public System.Windows.Forms.Button btnExibirTabuleiro;
        public System.Windows.Forms.ListBox lstListaPartida;
        public System.Windows.Forms.TextBox txtVerificaVez;
        private System.Windows.Forms.TextBox txtDadoRolado4;
        private System.Windows.Forms.TextBox txtDadoRolado3;
        private System.Windows.Forms.TextBox txtDadoRolado2;
        private System.Windows.Forms.TextBox txtDadoRolado1;
        private System.Windows.Forms.PictureBox picDadoRolado4;
        private System.Windows.Forms.PictureBox picDadoRolado3;
        private System.Windows.Forms.PictureBox picDadoRolado2;
        private System.Windows.Forms.PictureBox picDadoRolado1;
        private System.Windows.Forms.TextBox txtDado;
        private System.Windows.Forms.Button btnRolarDado;
        private System.Windows.Forms.TextBox txtCombinacao0;
        private System.Windows.Forms.TextBox txtCombinacao1;
        private System.Windows.Forms.TextBox txtCombinacao2;
        private System.Windows.Forms.TextBox txtCombinacao3;
        private System.Windows.Forms.TextBox txtCombinacao4;
        private System.Windows.Forms.TextBox txtCombinacao5;
        public System.Windows.Forms.Timer tmVezDado;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.RadioButton radCombinacao3;
        private System.Windows.Forms.RadioButton radCombinacao2;
        private System.Windows.Forms.RadioButton radCombinacao1;
    }
}

