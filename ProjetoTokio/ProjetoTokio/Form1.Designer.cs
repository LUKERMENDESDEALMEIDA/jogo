
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
            this.lblTabelaTrilha = new System.Windows.Forms.Label();
            this.lblTabelaPosicao = new System.Windows.Forms.Label();
            this.lblTabelaJogador = new System.Windows.Forms.Label();
            this.lblTabelaTipo = new System.Windows.Forms.Label();
            this.lblTabelaVermelho = new System.Windows.Forms.Label();
            this.lblTabelaAzul = new System.Windows.Forms.Label();
            this.lblTabelaVerde = new System.Windows.Forms.Label();
            this.lblTableaAmarelo = new System.Windows.Forms.Label();
            this.btnExibirTabuleiro = new System.Windows.Forms.Button();
            this.tmVezDado = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnListaPartida
            // 
            this.btnListaPartida.BackColor = System.Drawing.Color.Turquoise;
            this.btnListaPartida.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnListaPartida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListaPartida.Location = new System.Drawing.Point(635, 222);
            this.btnListaPartida.Name = "btnListaPartida";
            this.btnListaPartida.Size = new System.Drawing.Size(155, 39);
            this.btnListaPartida.TabIndex = 0;
            this.btnListaPartida.Text = "Partidas";
            this.btnListaPartida.UseVisualStyleBackColor = false;
            this.btnListaPartida.Click += new System.EventHandler(this.btnListaPartida_Click);
            // 
            // BtnJogadores
            // 
            this.BtnJogadores.BackColor = System.Drawing.Color.Turquoise;
            this.BtnJogadores.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnJogadores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnJogadores.Location = new System.Drawing.Point(95, 552);
            this.BtnJogadores.Name = "BtnJogadores";
            this.BtnJogadores.Size = new System.Drawing.Size(120, 35);
            this.BtnJogadores.TabIndex = 2;
            this.BtnJogadores.Text = "Jogadores";
            this.BtnJogadores.UseVisualStyleBackColor = false;
            this.BtnJogadores.Click += new System.EventHandler(this.BtnJogadores_Click);
            // 
            // btnEntraPartida
            // 
            this.btnEntraPartida.BackColor = System.Drawing.Color.Turquoise;
            this.btnEntraPartida.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEntraPartida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEntraPartida.Location = new System.Drawing.Point(84, 393);
            this.btnEntraPartida.Name = "btnEntraPartida";
            this.btnEntraPartida.Size = new System.Drawing.Size(153, 35);
            this.btnEntraPartida.TabIndex = 4;
            this.btnEntraPartida.Text = "Entrar na Partida";
            this.btnEntraPartida.UseVisualStyleBackColor = false;
            this.btnEntraPartida.Click += new System.EventHandler(this.btnEntraPartida_Click);
            // 
            // bntCriarPartida
            // 
            this.bntCriarPartida.BackColor = System.Drawing.Color.Turquoise;
            this.bntCriarPartida.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.bntCriarPartida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bntCriarPartida.Location = new System.Drawing.Point(79, 127);
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
            this.txtNomeJogador.Location = new System.Drawing.Point(83, 320);
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
            this.txtCriacao.Location = new System.Drawing.Point(80, 51);
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
            this.lstListaPartida.Location = new System.Drawing.Point(592, 72);
            this.lstListaPartida.Name = "lstListaPartida";
            this.lstListaPartida.Size = new System.Drawing.Size(230, 144);
            this.lstListaPartida.TabIndex = 1;
            this.lstListaPartida.SelectedIndexChanged += new System.EventHandler(this.lstListaPartida_SelectedIndexChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblNome.Location = new System.Drawing.Point(280, 28);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(285, 59);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Can\'t Stokyo";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.BackColor = System.Drawing.Color.Transparent;
            this.lblVersao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVersao.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblVersao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVersao.Location = new System.Drawing.Point(737, 583);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(57, 19);
            this.lblVersao.TabIndex = 10;
            this.lblVersao.Text = "Versão:";
            this.lblVersao.Click += new System.EventHandler(this.lblVersao_Click);
            // 
            // txtSenhaCriacao
            // 
            this.txtSenhaCriacao.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtSenhaCriacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenhaCriacao.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaCriacao.Location = new System.Drawing.Point(79, 84);
            this.txtSenhaCriacao.Multiline = true;
            this.txtSenhaCriacao.Name = "txtSenhaCriacao";
            this.txtSenhaCriacao.Size = new System.Drawing.Size(159, 27);
            this.txtSenhaCriacao.TabIndex = 11;
            this.txtSenhaCriacao.TextChanged += new System.EventHandler(this.txtSenhaCriacao_TextChanged);
            // 
            // lblPartida
            // 
            this.lblPartida.AutoSize = true;
            this.lblPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblPartida.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPartida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPartida.Location = new System.Drawing.Point(25, 54);
            this.lblPartida.Name = "lblPartida";
            this.lblPartida.Size = new System.Drawing.Size(54, 19);
            this.lblPartida.TabIndex = 12;
            this.lblPartida.Text = "Partida";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSenha.Location = new System.Drawing.Point(29, 94);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(47, 19);
            this.lblSenha.TabIndex = 13;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenhaEntrar
            // 
            this.txtSenhaEntrar.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtSenhaEntrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenhaEntrar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaEntrar.Location = new System.Drawing.Point(83, 350);
            this.txtSenhaEntrar.Multiline = true;
            this.txtSenhaEntrar.Name = "txtSenhaEntrar";
            this.txtSenhaEntrar.Size = new System.Drawing.Size(159, 28);
            this.txtSenhaEntrar.TabIndex = 14;
            this.txtSenhaEntrar.TextChanged += new System.EventHandler(this.txtSenhaEntrar_TextChanged);
            // 
            // lblSenhaEntrar
            // 
            this.lblSenhaEntrar.AutoSize = true;
            this.lblSenhaEntrar.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaEntrar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSenhaEntrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSenhaEntrar.Location = new System.Drawing.Point(25, 340);
            this.lblSenhaEntrar.Name = "lblSenhaEntrar";
            this.lblSenhaEntrar.Size = new System.Drawing.Size(54, 38);
            this.lblSenhaEntrar.TabIndex = 15;
            this.lblSenhaEntrar.Text = "Senha \r\nPartida";
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblJogador.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblJogador.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblJogador.Location = new System.Drawing.Point(22, 313);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(60, 19);
            this.lblJogador.TabIndex = 16;
            this.lblJogador.Text = "Jogador";
            // 
            // btnIniciaPartida
            // 
            this.btnIniciaPartida.BackColor = System.Drawing.Color.Turquoise;
            this.btnIniciaPartida.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnIniciaPartida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIniciaPartida.Location = new System.Drawing.Point(627, 344);
            this.btnIniciaPartida.Name = "btnIniciaPartida";
            this.btnIniciaPartida.Size = new System.Drawing.Size(156, 56);
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
            this.txtJogadores.Location = new System.Drawing.Point(79, 434);
            this.txtJogadores.Multiline = true;
            this.txtJogadores.Name = "txtJogadores";
            this.txtJogadores.Size = new System.Drawing.Size(158, 112);
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
            this.txtCor.Location = new System.Drawing.Point(311, 187);
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
            this.txtSenhaJogador.Location = new System.Drawing.Point(434, 187);
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
            this.txtIdJogador.Location = new System.Drawing.Point(368, 240);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdJogador.Size = new System.Drawing.Size(100, 16);
            this.txtIdJogador.TabIndex = 25;
            this.txtIdJogador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSenhaJogadorEntrada
            // 
            this.lblSenhaJogadorEntrada.AutoSize = true;
            this.lblSenhaJogadorEntrada.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaJogadorEntrada.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaJogadorEntrada.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSenhaJogadorEntrada.Location = new System.Drawing.Point(427, 169);
            this.lblSenhaJogadorEntrada.Name = "lblSenhaJogadorEntrada";
            this.lblSenhaJogadorEntrada.Size = new System.Drawing.Size(125, 19);
            this.lblSenhaJogadorEntrada.TabIndex = 27;
            this.lblSenhaJogadorEntrada.Text = "Senha do Jogador";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.BackColor = System.Drawing.Color.Transparent;
            this.lblCor.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCor.Location = new System.Drawing.Point(308, 169);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(108, 19);
            this.lblCor.TabIndex = 28;
            this.lblCor.Text = "Cor do Jogador";
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblIdJogador.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblIdJogador.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIdJogador.Location = new System.Drawing.Point(365, 218);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(103, 19);
            this.lblIdJogador.TabIndex = 29;
            this.lblIdJogador.Text = "ID do Jogador";
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
            this.btnExibirTabuleiro.BackColor = System.Drawing.Color.Turquoise;
            this.btnExibirTabuleiro.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExibirTabuleiro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExibirTabuleiro.Location = new System.Drawing.Point(627, 434);
            this.btnExibirTabuleiro.Name = "btnExibirTabuleiro";
            this.btnExibirTabuleiro.Size = new System.Drawing.Size(156, 55);
            this.btnExibirTabuleiro.TabIndex = 43;
            this.btnExibirTabuleiro.Text = "Exibir Tabuleiro";
            this.btnExibirTabuleiro.UseVisualStyleBackColor = false;
            this.btnExibirTabuleiro.Click += new System.EventHandler(this.btnExibirTabuleiro_Click);
            // 
            // tmVezDado
            // 
            this.tmVezDado.Interval = 3000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.BackgroundImage = global::ProjetoTokio.Properties.Resources.banner3_teletubbies;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.btnExibirTabuleiro);
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
        public System.Windows.Forms.Timer tmVezDado;
        private System.ComponentModel.IContainer components;
    }
}

