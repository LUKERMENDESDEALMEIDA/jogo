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
                        
                        if(jogador == "1")
                        {
                            if(tipo == "A")
                            {
                                this.pct2_1.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct2_1.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }
                      
                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                       if(jogador == "1")
                        {
                            if(tipo == "A")
                            {
                                this.pct2_final.Image = ProjetoTokio.Properties.Resources.alpinista;
                            }
                            else
                            {
                                this.pct2_final.Image = ProjetoTokio.Properties.Resources.baseVermelho;
                            }

                        }
                      
                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                    if(posicao == "1")
                    {
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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

                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
                        if (jogador == "1")
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

                        else if (jogador == "2")
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
                        else if (jogador == "3")
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
                        else if (jogador == "4")
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
        public void txtVerificaVez_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtTabu_TextChanged(object sender, EventArgs e)
        {

        }

        public void pictureBox85_Click(object sender, EventArgs e)
        {

        }

        public void Tabuleiro_Load(object sender, EventArgs e)
        {
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

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void txtTrilha_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmExibirTabu_Tick(object sender, EventArgs e)
        {
            
            string exibirTabu = Jogo.ExibirTabuleiro(this.idPartida);

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

        public void btnRolarDado_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            
            txtDado.Clear(); //limpar textbox

            int idJogador = Convert.ToInt32(form1.txtIdJogador.Text);//converte o primeiro item[0] do vetor em numero inteiro
            string senhaJogador = form1.txtSenhaJogador.Text;

            string rolar = txtDado.Text = Jogo.RolarDados(idJogador, senhaJogador);

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


            if (rolar.StartsWith("ERRO"))//se as 4 letras(ERRO) = true
            {
                MessageBox.Show(rolar); //exibe o erro na tela
            }
        }
        void Dice1()
        {

            if (txtDadoRolado1.Text == "1")
            {
                picDadoRolado1.Image = ProjetoTokio.Properties.Resources.dado1;
            }
            if (txtDadoRolado1.Text == "2")
            {
                picDadoRolado2.Image = ProjetoTokio.Properties.Resources.dado2;
            }
            if (txtDadoRolado1.Text == "3")
            {
                picDadoRolado3.Image = ProjetoTokio.Properties.Resources.dado3;
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

        private void picDadoRolado4_Click(object sender, EventArgs e)
        {

        }
    }
}
