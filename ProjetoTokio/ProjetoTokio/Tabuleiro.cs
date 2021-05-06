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

namespace ProjetoTokio
{
    public partial class Tabuleiro : Form
    {

       
        public Tabuleiro()
        {
            InitializeComponent();


            //this.pictureBox78.Image = ProjetoTokio.Properties.Resources.alpinista;

            this.tmExibirTabu.Start();

            this.tabuleiro = new DataTable();

            this.tabuleiro.Columns.Add("Trilha");
            this.tabuleiro.Columns.Add("Posicao");
            this.tabuleiro.Columns.Add("Jogador");
            this.tabuleiro.Columns.Add("Tipo");


            
        }

        //declarar imagem em picturebox
        //this.pct2_1.Image = ProjetoTokio.Properties.Resources.alpinista;
         public int idPartida { get; set; }

        public string idJogador { get; set; }

        public string senhaJogador { get; set; }

        public string nickName { get; set; }

        public string corJogador { get; set; }


        public DataTable tabuleiro { get; set; }
        public void mapaTabu(string trilha, string posicao, string jogador, string tipo)
        {
            /*Ideia de movimentar
             * y = Convert.ToInt32(posicao);

            pictureBox10.Location = new Point(x, posicaoAtual);

            pictureBox10.Location = new Point(x, y);

            x = 230;
            int posicaoAtual = 530 - (y * 40);*/

            /***********************TRILHA**********************/

            

            switch (trilha)
            {
                //TRILHA 2
                case "2":
                    //POSICAO 1
                    if (posicao == "1")
                    {

                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct2_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct2_1.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct2_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct2_1.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct2_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct2_1.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct2_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct2_1.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }



                    }

                    //POSICAO 2
                    else if (posicao == "2")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct2_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct2_2.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct2_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct2_2.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct2_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct2_2.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct2_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct2_2.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }

                    }

                    //POSICAO 3
                    else if (posicao == "3")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct2_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct2_final.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct2_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct2_final.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct2_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct2_final.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct2_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct2_final.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }
                    break;


                //TRILHA 3
                case "3":

                    //POSICAO 1
                    if (posicao == "1")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct3_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct3_1.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct3_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct3_1.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct3_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct3_1.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct3_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct3_1.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 2
                    else if (posicao == "2")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct3_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct3_2.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct3_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct3_2.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct3_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct3_2.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct3_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct3_2.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 3
                    else if (posicao == "3")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct3_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct3_3.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct3_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct3_3.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct3_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct3_3.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct3_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct3_3.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 4
                    else if (posicao == "4")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct3_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct3_4.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct3_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct3_4.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct3_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct3_4.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct3_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct3_4.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 5
                    else if (posicao == "5")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct3_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct3_final.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct3_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct3_final.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct3_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct3_final.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct3_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct3_final.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }
                    break;


                //TRILHA 4
                case "4":

                    //POSICAO 1
                    if (posicao == "1")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_1.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_1.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_1.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_1.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 2
                    else if (posicao == "2")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_2.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_2.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_2.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_2.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 3
                    else if (posicao == "3")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_3.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_3.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_3.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_3.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 4
                    else if (posicao == "4")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_4.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_4.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_4.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_4.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 5
                    else if (posicao == "5")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_5.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_5.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_5.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_5.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 6
                    else if (posicao == "6")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_6.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_6.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_6.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_6.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 7
                    else if (posicao == "7")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_final.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_final.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_final.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct4_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct4_final.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }
                    break;

                //TRILHA 5
                case "5":

                    //POSICAO 1
                    if (posicao == "1")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_1.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_1.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_1.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_1.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 2
                    else if (posicao == "2")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_2.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_2.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_2.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_2.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 3
                    else if (posicao == "3")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_3.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_3.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_3.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_3.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 4
                    else if (posicao == "4")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_4.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_4.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_4.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_4.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 5
                    else if (posicao == "5")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_5.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_5.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_5.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_5.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 6
                    else if (posicao == "6")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_6.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_6.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_6.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_6.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 7
                    else if (posicao == "7")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_7.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_7.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_7.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_7.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_7.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_7.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_7.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_7.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 8
                    else if (posicao == "8")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_8.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_8.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_8.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_8.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_8.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_8.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_8.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_8.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 9
                    else if (posicao == "9")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_final.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_final.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_final.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct5_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct5_final.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }
                    break;

                //TRILHA 6
                case "6":

                    //POSICAO 1
                    if (posicao == "1")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_1.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_1.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_1.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_1.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 2
                    else if (posicao == "2")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_2.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_2.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_2.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_2.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 3
                    else if (posicao == "3")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_3.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_3.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_3.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_3.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 4
                    else if (posicao == "4")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_4.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_4.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_4.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_4.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 5
                    else if (posicao == "5")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_5.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_5.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_5.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_5.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 6
                    else if (posicao == "6")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_6.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_6.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_6.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_6.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 7
                    else if (posicao == "7")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_7.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_7.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_7.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_7.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_7.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_7.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_7.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_7.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 8
                    else if (posicao == "8")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_8.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_8.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_8.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_8.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_8.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_8.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_8.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_8.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 9
                    else if (posicao == "9")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_9.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_9.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_9.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_9.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_9.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_9.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_9.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_9.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 10
                    else if (posicao == "10")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_10.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_10.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_10.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_10.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_10.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_10.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_10.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_10.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 11
                    else if (posicao == "11")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_final.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_final.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_final.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct6_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct6_final.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }
                    break;

                //TRILHA 7
                case "7":

                    //POSICAO 1
                    if (posicao == "1")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_1.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_1.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_1.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_1.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 2
                    else if (posicao == "2")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_2.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_2.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_2.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_2.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 3
                    else if (posicao == "3")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_3.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_3.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_3.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_3.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 4
                    else if (posicao == "4")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_4.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_4.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_4.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_4.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 5
                    else if (posicao == "5")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_5.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_5.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_5.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_5.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 6
                    else if (posicao == "6")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_6.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_6.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_6.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_6.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 7
                    else if (posicao == "7")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_7.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_7.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_7.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_7.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_7.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_7.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_7.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_7.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 8
                    else if (posicao == "8")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_8.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_8.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_8.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_8.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_8.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_8.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_8.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_8.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 9
                    else if (posicao == "9")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_9.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_9.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_9.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_9.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_9.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_9.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_9.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_9.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 10
                    else if (posicao == "10")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_10.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_10.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_10.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_10.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_10.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_10.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_10.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_10.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 11
                    else if (posicao == "11")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_11.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_11.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_11.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_11.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_11.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_11.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_11.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_11.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 12
                    else if (posicao == "12")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_12.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_12.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_12.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_12.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_12.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_12.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_12.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_12.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 13
                    else if (posicao == "13")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_final.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_final.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_final.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct7_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct7_final.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }
                    break;

                //TRILHA 8
                case "8":

                    //POSICAO 1
                    if (posicao == "1")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_1.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_1.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_1.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_1.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 2
                    else if (posicao == "2")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_2.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_2.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_2.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_2.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 3
                    else if (posicao == "3")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_3.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_3.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_3.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_3.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 4
                    else if (posicao == "4")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_4.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_4.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_4.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_4.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 5
                    else if (posicao == "5")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_5.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_5.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_5.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_5.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 6
                    else if (posicao == "6")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_6.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_6.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_6.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_6.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 7
                    else if (posicao == "7")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_7.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_7.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_7.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_7.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_7.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_7.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_7.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_7.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 8
                    else if (posicao == "8")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_8.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_8.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_8.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_8.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_8.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_8.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_8.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_8.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 9
                    else if (posicao == "9")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_9.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_9.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_9.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_9.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_9.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_9.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_9.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_9.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 10
                    else if (posicao == "10")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_10.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_10.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_10.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_10.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_10.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_10.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_10.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_10.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 11
                    else if (posicao == "11")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_final.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_final.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_final.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct8_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct8_final.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }
                    break;

                //TRILHA 9
                case "9":

                    //POSICAO 1
                    if (posicao == "1")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_1.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_1.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_1.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_1.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 2
                    else if (posicao == "2")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_2.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_2.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_2.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_2.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 3
                    else if (posicao == "3")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_3.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_3.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_3.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_3.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 4
                    else if (posicao == "4")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_4.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_4.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_4.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_4.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 5
                    else if (posicao == "5")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_5.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_5.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_5.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_5.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 6
                    else if (posicao == "6")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_6.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_6.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_6.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_6.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 7
                    else if (posicao == "7")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_7.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_7.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_7.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_7.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_7.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_7.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_7.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_7.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 8
                    else if (posicao == "8")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_8.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_8.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_8.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_8.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_8.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_8.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_8.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_8.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 9
                    else if (posicao == "9")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_final.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_final.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_final.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct9_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct9_final.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }
                    break;

                //TRILHA 10
                case "10":

                    //POSICAO 1
                    if (posicao == "1")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_1.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_1.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_1.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_1.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 2
                    else if (posicao == "2")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_2.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_2.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_2.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_2.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 3
                    else if (posicao == "3")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_3.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_3.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_3.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_3.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 4
                    else if (posicao == "4")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_4.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_4.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_4.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_4.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 5
                    else if (posicao == "5")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_5.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_5.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_5.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_5.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_5.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 6
                    else if (posicao == "6")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_6.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_6.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_6.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_6.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_6.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 7
                    else if (posicao == "7")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_final.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_final.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_final.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct10_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct10_final.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }
                    break;

                //TRILHA 11
                case "11":

                    //POSICAO 1
                    if (posicao == "1")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct11_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct11_1.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct11_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct11_1.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct11_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct11_1.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct11_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct11_1.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 2
                    else if (posicao == "2")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct11_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct11_2.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct11_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct11_2.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct11_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct11_2.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct11_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct11_2.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 3
                    else if (posicao == "3")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct11_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct11_3.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct11_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct11_3.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct11_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct11_3.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct11_3.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct11_3.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 4
                    else if (posicao == "4")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct11_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct11_4.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct11_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct11_4.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct11_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct11_4.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct11_4.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct11_4.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }

                    //POSICAO 5
                    else if (posicao == "5")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct11_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct11_final.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct11_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct11_final.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct11_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct11_final.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct11_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct11_final.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }
                    break;

                //TRILHA 12
                case "12":

                    //POSICAO 1
                    if (posicao == "1")
                    {

                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct12_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct12_1.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct12_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct12_1.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct12_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct12_1.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct12_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct12_1.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }


                    }

                    //POSICAO 2
                    else if (posicao == "2")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct12_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct12_2.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct12_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct12_2.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct12_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct12_2.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct12_2.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct12_2.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }

                    }

                    //POSICAO 3
                    else if (posicao == "3")
                    {
                        if (jogador == txtId1.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct12_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct12_final.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }

                        else if (jogador == txtId2.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct12_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct12_final.Image = ProjetoTokio.Properties.Resources.baseAzul;
                            }
                        }
                        else if (jogador == txtId3.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct12_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct12_final.Image = ProjetoTokio.Properties.Resources.baseVerde;
                            }
                        }
                        else if (jogador == txtId4.Text)
                        {
                            if (tipo == "A")
                            {
                                this.pct12_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct12_final.Image = ProjetoTokio.Properties.Resources.baseAmarela;
                            }
                        }
                    }
                    break;
            }


        }

        public void btnExibirTabuleiro_Click(object sender, EventArgs e)
        {

        }
      
        public void Tabuleiro_Load(object sender, EventArgs e)
        {
            Load_Historico();
            pegarCorJog();
        }

        public void label8_Click(object sender, EventArgs e)
        {

        }

        public void label10_Click(object sender, EventArgs e)
        {

        }

        public void label5_Click(object sender, EventArgs e)
        {

        }


        private void tmExibirTabu_Tick(object sender, EventArgs e)
        {

            string exibirTabu = Jogo.ExibirTabuleiro(this.idPartida);

            if (exibirTabu == "")
            {
                InitializeComponent();
            }
            else
            {

                exibirTabu = exibirTabu.Replace("\r\n", "-");

                exibirTabu = exibirTabu.Remove(exibirTabu.Length - 1);
                string[] tabuleiroSplit = exibirTabu.Split('-');

                foreach (string linhaTabu in tabuleiroSplit)
                {

                    string[] valor = linhaTabu.Split(',');

                    DataRow datarow = tabuleiro.NewRow();
                    datarow["Trilha"] = valor[0];
                    datarow["Posicao"] = valor[1];
                    datarow["Jogador"] = valor[2];
                    datarow["Tipo"] = valor[3];



                    tabuleiro.Rows.Add(datarow);

                    this.mapaTabu(valor[0], valor[1], valor[2], valor[3]);

                }
            }

        }

        void pegarCorJog()
        {
            string listarJog = Jogo.ListarJogadores(idPartida);
            listarJog = listarJog.Replace("\r", "");
            string[] splitListJog = listarJog.Split('\n');

            string jogador1 = splitListJog[0]; //vermelho
            string jogador2 = splitListJog[1]; //azul
            string jogador3 = splitListJog[2]; //verde
            string jogador4 = splitListJog[3]; //amarelo

            string[] splitJog1 = jogador1.Split(',');
            string idJog1 = splitJog1[0];
            string nickJog1 = splitJog1[1];
            string corJog1 = splitJog1[2];

            string[] splitJog2 = jogador2.Split(',');
            string idJog2 = splitJog2[0];
            string nickJog2 = splitJog2[1];
            string corJog2 = splitJog2[2];

            string[] splitJog3 = jogador3.Split(',');
            string idJog3 = splitJog3[0];
            string nickJog3 = splitJog3[1];
            string corJog3 = splitJog3[2];

            string[] splitJog4 = jogador4.Split(',');
            string idJog4 = splitJog4[0];
            string nickJog4 = splitJog4[1];
            string corJog4 = splitJog4[2];

            txtId1.Text = idJog1;
            txtId2.Text = idJog2;
            txtId3.Text = idJog3;
            txtId4.Text = idJog4;

            //criar txt no design
            /*txtNickJog1.Text = nickJog1;
            txtNickJog2.Text = nickJog2;
            txtNickJog3.Text = nickJog3;
            txtNickJog4.Text = nickJog4;*/

        }
         /*void verificarVez()
        {
            string verifVez = Jogo.VerificarVez(idPartida);
            //fazer um split para separa a posição 1 e 2. Posição 1 é igual id do jogador que é a vez. Comparar posição 1 com txt de id's na função acima
            
        }*/
        
        private void txtCombinacao1_TextChanged(object sender, EventArgs e)
        {

        }
        void Load_Historico()
        {
            string narra = Jogo.ExibirHistorico(idPartida);
            if (narra.StartsWith("ERRO"))
            {
                MessageBox.Show(narra);
            }
            else
            {
                txtNarracao1.Text = Jogo.ExibirHistorico(idPartida);
            }



        }

        private void btnDadoRolado_Click(object sender, EventArgs e)
        {
            txtDice.Clear(); //limpar textbox

            string rolar = txtDice.Text = Jogo.RolarDados(Convert.ToInt32(idJogador), senhaJogador);




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

                txtDice1.Text = dado1[1];
                txtDice2.Text = dado2[1];
                txtDice3.Text = dado3[1];
                txtDice4.Text = dado4[1];

                RollDice1();
                RollDice2();
                RollDice3();
                RollDice4();

                int valores1 = Convert.ToInt32(txtDice1.Text);
                int valores2 = Convert.ToInt32(txtDice2.Text);
                int valores3 = Convert.ToInt32(txtDice3.Text);
                int valores4 = Convert.ToInt32(txtDice4.Text);

                int resultado0 = valores1 + valores2;
                int resultado1 = valores3 + valores4;
                int resultado2 = valores2 + valores4;
                int resultado3 = valores1 + valores3;
                int resultado4 = valores1 + valores4;
                int resultado5 = valores2 + valores3;

                string res1 = resultado0.ToString();
                txtCom0.Text = res1;

                string res2 = resultado1.ToString();
                txtCom1.Text = res2;

                string res3 = resultado2.ToString();
                txtCom2.Text = res3;

                string res4 = resultado3.ToString();
                txtCom3.Text = res4;

                string res5 = resultado4.ToString();
                txtCom4.Text = res5;

                string res6 = resultado5.ToString();
                txtCom5.Text = res6;

                rdoCom1.Visible = true;
                rdoCom2.Visible = true;
                rdoCom3.Visible = true;

                rdoCom1.Text = txtCom0.Text + " " + txtCom1.Text;
                rdoCom2.Text = txtCom2.Text + " " + txtCom3.Text;
                rdoCom3.Text = txtCom4.Text + " " + txtCom5.Text;


            }

        }
        void RollDice1()
        {
            if (txtDice1.Text == "1")
            {
                picDice1.Image = ProjetoTokio.Properties.Resources.dado1;

            }
            if (txtDice1.Text == "2")
            {
                picDice1.Image = ProjetoTokio.Properties.Resources.dado2;

            }
            if (txtDice1.Text == "3")
            {
                picDice1.Image = ProjetoTokio.Properties.Resources.dado3;

            }
            if (txtDice1.Text == "4")
            {
                picDice1.Image = ProjetoTokio.Properties.Resources.dado4;

            }
            if (txtDice1.Text == "5")
            {
                picDice1.Image = ProjetoTokio.Properties.Resources.dado5;

            }
            if (txtDice1.Text == "6")
            {
                picDice1.Image = ProjetoTokio.Properties.Resources.dado6;

            }
        }
        void RollDice2()
        {
            if (txtDice2.Text == "1")
            {
                picDice2.Image = ProjetoTokio.Properties.Resources.dado1;

            }
            if (txtDice2.Text == "2")
            {
                picDice2.Image = ProjetoTokio.Properties.Resources.dado2;

            }
            if (txtDice2.Text == "3")
            {
                picDice2.Image = ProjetoTokio.Properties.Resources.dado3;

            }
            if (txtDice2.Text == "4")
            {
                picDice2.Image = ProjetoTokio.Properties.Resources.dado4;

            }
            if (txtDice2.Text == "5")
            {
                picDice2.Image = ProjetoTokio.Properties.Resources.dado5;

            }
            if (txtDice2.Text == "6")
            {
                picDice2.Image = ProjetoTokio.Properties.Resources.dado6;

            }

        }
        void RollDice3()
        {
            if (txtDice3.Text == "1")
            {
                picDice3.Image = ProjetoTokio.Properties.Resources.dado1;

            }
            if (txtDice3.Text == "2")
            {
                picDice3.Image = ProjetoTokio.Properties.Resources.dado2;

            }
            if (txtDice3.Text == "3")
            {
                picDice3.Image = ProjetoTokio.Properties.Resources.dado3;

            }
            if (txtDice3.Text == "4")
            {
                picDice3.Image = ProjetoTokio.Properties.Resources.dado4;

            }
            if (txtDice3.Text == "5")
            {
                picDice3.Image = ProjetoTokio.Properties.Resources.dado5;

            }
            if (txtDice3.Text == "6")
            {
                picDice3.Image = ProjetoTokio.Properties.Resources.dado6;

            }
        }
        void RollDice4()
        {
            if (txtDice4.Text == "1")
            {
                picDice4.Image = ProjetoTokio.Properties.Resources.dado1;

            }
            if (txtDice4.Text == "2")
            {
                picDice4.Image = ProjetoTokio.Properties.Resources.dado2;

            }
            if (txtDice4.Text == "3")
            {
                picDice4.Image = ProjetoTokio.Properties.Resources.dado3;

            }
            if (txtDice4.Text == "4")
            {
                picDice4.Image = ProjetoTokio.Properties.Resources.dado4;

            }
            if (txtDice4.Text == "5")
            {
                picDice4.Image = ProjetoTokio.Properties.Resources.dado5;

            }
            if (txtDice4.Text == "6")
            {
                picDice4.Image = ProjetoTokio.Properties.Resources.dado6;

            }
        }
    }
}
