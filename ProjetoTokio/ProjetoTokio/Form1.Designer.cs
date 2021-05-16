
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
            this.tmVezDado = new System.Windows.Forms.Timer(this.components);
            this.btnMover = new System.Windows.Forms.Button();
            this.txtOrdem = new System.Windows.Forms.TextBox();
            this.txtTrilha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnParar = new System.Windows.Forms.Button();
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
            this.lblVersao.Location = new System.Drawing.Point(714, 506);
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
            this.btnIniciaPartida.Location = new System.Drawing.Point(376, 88);
            this.btnIniciaPartida.Name = "btnIniciaPartida";
            this.btnIniciaPartida.Size = new System.Drawing.Size(133, 51);
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
            this.txtCor.Location = new System.Drawing.Point(327, 175);
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
            this.txtSenhaJogador.Location = new System.Drawing.Point(450, 175);
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
            this.txtIdJogador.Location = new System.Drawing.Point(384, 228);
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
            this.lblSenhaJogadorEntrada.Location = new System.Drawing.Point(443, 157);
            this.lblSenhaJogadorEntrada.Name = "lblSenhaJogadorEntrada";
            this.lblSenhaJogadorEntrada.Size = new System.Drawing.Size(105, 15);
            this.lblSenhaJogadorEntrada.TabIndex = 27;
            this.lblSenhaJogadorEntrada.Text = "Senha do Jogador";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCor.Location = new System.Drawing.Point(324, 157);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(90, 15);
            this.lblCor.TabIndex = 28;
            this.lblCor.Text = "Cor do Jogador";
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblIdJogador.Location = new System.Drawing.Point(397, 212);
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
            this.btnExibirTabuleiro.Location = new System.Drawing.Point(362, 268);
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
            // tmVezDado
            // 
            this.tmVezDado.Interval = 3000;
//            this.tmVezDado.Tick += new System.EventHandler(this.tmVezDado_Tick);
            // 
            // btnMover
            // 
            this.btnMover.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMover.Location = new System.Drawing.Point(409, 464);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(75, 23);
            this.btnMover.TabIndex = 144;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = false;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // txtOrdem
            // 
            this.txtOrdem.Location = new System.Drawing.Point(410, 354);
            this.txtOrdem.Multiline = true;
            this.txtOrdem.Name = "txtOrdem";
            this.txtOrdem.Size = new System.Drawing.Size(74, 26);
            this.txtOrdem.TabIndex = 145;
            // 
            // txtTrilha
            // 
            this.txtTrilha.Location = new System.Drawing.Point(410, 417);
            this.txtTrilha.Multiline = true;
            this.txtTrilha.Name = "txtTrilha";
            this.txtTrilha.Size = new System.Drawing.Size(74, 26);
            this.txtTrilha.TabIndex = 146;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 147;
            this.label1.Text = "ordem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 148;
            this.label2.Text = "trilha";
            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnParar.Location = new System.Drawing.Point(410, 493);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 149;
            this.btnParar.Text = "PARAR";
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(822, 536);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTrilha);
            this.Controls.Add(this.txtOrdem);
            this.Controls.Add(this.btnMover);
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
        public System.Windows.Forms.Timer tmVezDado;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.TextBox txtOrdem;
        private System.Windows.Forms.TextBox txtTrilha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnParar;
    }
}

