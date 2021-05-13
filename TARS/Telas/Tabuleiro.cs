using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CantStopServer;

namespace TARS
{
    public partial class Tabuleiro : Form
    {
        public Jogador JogadorAtivo { get; set; }
        public  string Infojogador { get; set; }
        public int IdPartida { get; set; }

        char[] valordado = new char[4];
        char[] numerodado = new char[4];
        string dadoescolha;
        string[] idJogadores = new string[4];
        string[] corJogdores = new string[4];

        int movimentosfeitos; // O bot jogará 1 vezes no maximo e logo depois irá parar

        string op_dado;

        DataTable dtb_tabuleiro;

        List<Alpinista> alpinistas = new List<Alpinista>();

        public Tabuleiro(string infojogador, int idpartida) 
        {
            InitializeComponent();
            JogadorAtivo = new Jogador();
            this.Infojogador = infojogador;
            this.IdPartida = idpartida;

            rtxt_historicoP.Text = Jogo.ExibirHistorico(IdPartida);
            string[] linha = Infojogador.Split(',');
            JogadorAtivo.Id = Convert.ToInt32(linha[0]);
            JogadorAtivo.Senha = linha[1];
            JogadorAtivo.corjogador = linha[2].Replace("\r\n", "");
            JogadorAtivo.NumeroJogador = Jogador.SetarNumeroJogador(IdPartida) - 1;

            lbl_idjogador.Text = "Id: "+ JogadorAtivo.Id;
            lbl_senhajogador.Text = "Senha: " + JogadorAtivo.Senha;
            lbl_corjogador.Text = "Cor: " + JogadorAtivo.corjogador;

            for(int i = 0; i < 1; i++)
            {
                if(JogadorAtivo.corjogador == "Vermelho")
                {
                    panel1.BackColor = Color.Red;
                }
                else if (JogadorAtivo.corjogador == "Azul")
                {
                    panel1.BackColor = Color.Blue;
                }
                else if (JogadorAtivo.corjogador == "Verde")
                {
                    panel1.BackColor = Color.Green;
                }
                else
                {
                    panel1.BackColor = Color.Yellow;
                }
            }
            panel1.Visible = true;
            panel2.Visible = true;
            lbl_corJgadorAtual.Visible = true;
            lbl_nossaCor.Visible = true;

            dtb_tabuleiro = TabuleiroP.CriarDataTable();
        }

        public void jogadorCor()
        {
            for (int i = 0; i < corJogdores.Length; i++)
            {

                string teste = Jogo.VerificarVez(IdPartida);
                string[] linha1 = teste.Split(',');
                string jogadorvez = linha1[1];
                jogadorvez = jogadorvez.Replace("\r\n", "");

                if (jogadorvez == idJogadores[i])
                {
                    if (corJogdores[i].Contains("Vermelho"))
                    {
                        panel2.BackColor = Color.Red;
                    }
                    else if (corJogdores[i] == "Azul ")
                    {
                        panel2.BackColor = Color.Blue;
                    }
                    else if (corJogdores[i] == "Verde ")
                    {
                        panel2.BackColor = Color.Green;
                    }
                    else
                    {
                        panel2.BackColor = Color.Yellow;
                    }
                }
            }
        }

        public void rolarDados()
        {
            string dados = Jogo.RolarDados(JogadorAtivo.Id, JogadorAtivo.Senha);
            if (dados.Contains("ERRO"))
            {
                MessageBox.Show(dados);
            }
            else
            {
                dados = dados.Replace("\r\n", "");
                int contador = 0;
                int contvalor = 0;

                for (int i = 0; i < dados.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        numerodado[contador] = dados[i];
                        contador++;
                    }
                    else
                    {
                        valordado[contvalor] = dados[i];
                        contvalor++;
                    }

                }

                List<Dado> ListaDados = new List<Dado>();


                for (int i = 0; i < 4; i++)
                {
                    Dado d = new Dado();
                    d.NumeroDado = numerodado[i];
                    d.ValorDado = valordado[i];
                    d.PopularImagens(d.ValorDado);
                    ListaDados.Add(d);
                }

                pcb_dado1.Image = ListaDados[0].FaceDado;
                pcb_dado2.Image = ListaDados[1].FaceDado;
                pcb_dado3.Image = ListaDados[2].FaceDado;
                pcb_dado4.Image = ListaDados[3].FaceDado;

                rtxt_historicoP.Text = Jogo.ExibirHistorico(IdPartida);
            }
        }
        public void desenharTabuleiro(string [] jogadores)
        {
            LimparTabuleiro();
            jogadorCor();

            foreach (DataRow row in dtb_tabuleiro.Rows)
            {
                DataRow newRow = dtb_tabuleiro.NewRow();
                newRow[0] = row[0];//trilha
                newRow[1] = row[1];//posição
                newRow[2] = row[2];//jogador id
                newRow[3] = row[3];//tipo

                for (int i = 0; i < 1; i++)
                {

                    if (newRow[0].ToString() == "2")
                    {
                        for (int j = 0; j < 1 ; j++)
                        {
                            if (newRow[1].ToString() == "1")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A21.BackColor = Color.Black;
                                    pcb_A21.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j121.BackColor = Color.Red;
                                        pcb_j121.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j221.BackColor = Color.Blue;
                                        pcb_j221.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j321.BackColor = Color.Green;
                                        pcb_j321.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j421.BackColor = Color.Yellow;
                                        pcb_j421.Visible = true;
                                    }
                                    pcb_A21.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "2")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A22.BackColor = Color.Black;
                                    pcb_A22.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j122.BackColor = Color.Red;
                                        pcb_j122.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j222.BackColor = Color.Blue;
                                        pcb_j222.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j322.BackColor = Color.Green;
                                        pcb_j322.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j422.BackColor = Color.Yellow;
                                        pcb_j422.Visible = true;
                                    }
                                    pcb_A21.Visible = false;
                                }
                            }

                            else if (newRow[1].ToString() == "3")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A23.BackColor = Color.Black;
                                    pcb_A23.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j123.BackColor = Color.Red;
                                        pcb_j123.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j223.BackColor = Color.Blue;
                                        pcb_j223.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j323.BackColor = Color.Green;
                                        pcb_j323.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j423.BackColor = Color.Yellow;
                                        pcb_j423.Visible = true;
                                    }
                                    pcb_A23.Visible = false;
                                }
                            }
                        }
                    }

                    if (newRow[0].ToString() == "3")
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            if (newRow[1].ToString() == "1")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A31.BackColor = Color.Black;
                                    pcb_A31.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j131.BackColor = Color.Red;
                                        pcb_j131.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j231.BackColor = Color.Blue;
                                        pcb_j231.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j331.BackColor = Color.Green;
                                        pcb_j331.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j431.BackColor = Color.Yellow;
                                        pcb_j431.Visible = true;
                                    }
                                    pcb_A31.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "2")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A32.BackColor = Color.Black;
                                    pcb_A32.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j132.BackColor = Color.Red;
                                        pcb_j132.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j232.BackColor = Color.Blue;
                                        pcb_j232.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j332.BackColor = Color.Green;
                                        pcb_j332.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j432.BackColor = Color.Yellow;
                                        pcb_j432.Visible = true;
                                    }
                                    pcb_A32.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "3")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A33.BackColor = Color.Black;
                                    pcb_A33.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j133.BackColor = Color.Red;
                                        pcb_j133.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j233.BackColor = Color.Blue;
                                        pcb_j233.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j333.BackColor = Color.Green;
                                        pcb_j333.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j433.BackColor = Color.Yellow;
                                        pcb_j433.Visible = true;
                                    }
                                    pcb_A33.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "4")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A34.BackColor = Color.Black;
                                    pcb_A34.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j134.BackColor = Color.Red;
                                        pcb_j134.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j234.BackColor = Color.Blue;
                                        pcb_j234.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j334.BackColor = Color.Green;
                                        pcb_j334.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j434.BackColor = Color.Yellow;
                                        pcb_j434.Visible = true;
                                    }
                                    pcb_A34.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "5")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A35.BackColor = Color.Black;
                                    pcb_A35.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j135.BackColor = Color.Red;
                                        pcb_j135.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j235.BackColor = Color.Blue;
                                        pcb_j235.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j335.BackColor = Color.Green;
                                        pcb_j335.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j435.BackColor = Color.Yellow;
                                        pcb_j435.Visible = true;
                                    }
                                    pcb_A35.Visible = false;
                                }
                            }
                        }
                    }

                    if (newRow[0].ToString() == "4")
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            if (newRow[1].ToString() == "1")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A41.BackColor = Color.Black;
                                    pcb_A41.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j141.BackColor = Color.Red;
                                        pcb_j141.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j241.BackColor = Color.Blue;
                                        pcb_j241.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j341.BackColor = Color.Green;
                                        pcb_j341.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j441.BackColor = Color.Yellow;
                                        pcb_j441.Visible = true;
                                    }
                                    pcb_A41.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "2")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A42.BackColor = Color.Black;
                                    pcb_A42.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j142.BackColor = Color.Red;
                                        pcb_j142.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j242.BackColor = Color.Blue;
                                        pcb_j242.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j342.BackColor = Color.Green;
                                        pcb_j342.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j442.BackColor = Color.Yellow;
                                        pcb_j442.Visible = true;
                                    }
                                    pcb_A42.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "3")
                            {

                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A43.BackColor = Color.Black;
                                    pcb_A43.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j143.BackColor = Color.Red;
                                        pcb_j143.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j243.BackColor = Color.Blue;
                                        pcb_j243.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j343.BackColor = Color.Green;
                                        pcb_j343.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j443.BackColor = Color.Yellow;
                                        pcb_j443.Visible = true;
                                    }
                                    pcb_A43.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "4")
                            {

                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A44.BackColor = Color.Black;
                                    pcb_A44.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j144.BackColor = Color.Red;
                                        pcb_j144.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j244.BackColor = Color.Blue;
                                        pcb_j244.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j344.BackColor = Color.Green;
                                        pcb_j344.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j444.BackColor = Color.Yellow;
                                        pcb_j444.Visible = true;
                                    }
                                    pcb_A44.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "5")
                            {

                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A45.BackColor = Color.Black;
                                    pcb_A45.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j145.BackColor = Color.Red;
                                        pcb_j145.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j245.BackColor = Color.Blue;
                                        pcb_j245.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j345.BackColor = Color.Green;
                                        pcb_j345.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j445.BackColor = Color.Yellow;
                                        pcb_j445.Visible = true;
                                    }
                                    pcb_A45.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "6")
                            {

                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A46.BackColor = Color.Black;
                                    pcb_A46.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j146.BackColor = Color.Red;
                                        pcb_j146.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j246.BackColor = Color.Blue;
                                        pcb_j246.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j346.BackColor = Color.Green;
                                        pcb_j346.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j446.BackColor = Color.Yellow;
                                        pcb_j446.Visible = true;
                                    }
                                    pcb_A46.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "7")
                            {

                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A47.BackColor = Color.Black;
                                    pcb_A47.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j147.BackColor = Color.Red;
                                        pcb_j147.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j247.BackColor = Color.Blue;
                                        pcb_j247.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j347.BackColor = Color.Green;
                                        pcb_j347.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j447.BackColor = Color.Yellow;
                                        pcb_j447.Visible = true;
                                    }
                                    pcb_A47.Visible = false;
                                }
                            }
                        }
                    }

                    if (newRow[0].ToString() == "5")
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            if (newRow[1].ToString() == "1")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A51.BackColor = Color.Black;
                                    pcb_A51.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j151.BackColor = Color.Red;
                                        pcb_j151.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j251.BackColor = Color.Blue;
                                        pcb_j251.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j351.BackColor = Color.Green;
                                        pcb_j351.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j451.BackColor = Color.Yellow;
                                        pcb_j451.Visible = true;
                                    }
                                    pcb_A51.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "2")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A52.BackColor = Color.Black;
                                    pcb_A52.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j152.BackColor = Color.Red;
                                        pcb_j152.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j252.BackColor = Color.Blue;
                                        pcb_j252.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j352.BackColor = Color.Green;
                                        pcb_j352.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j452.BackColor = Color.Yellow;
                                        pcb_j452.Visible = true;
                                    }
                                    pcb_A52.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "3")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A53.BackColor = Color.Black;
                                    pcb_A53.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j153.BackColor = Color.Red;
                                        pcb_j153.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j253.BackColor = Color.Blue;
                                        pcb_j253.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j353.BackColor = Color.Green;
                                        pcb_j353.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j453.BackColor = Color.Yellow;
                                        pcb_j453.Visible = true;
                                    }
                                    pcb_A53.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "4")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A54.BackColor = Color.Black;
                                    pcb_A54.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j154.BackColor = Color.Red;
                                        pcb_j154.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j254.BackColor = Color.Blue;
                                        pcb_j254.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j354.BackColor = Color.Green;
                                        pcb_j354.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j454.BackColor = Color.Yellow;
                                        pcb_j454.Visible = true;
                                    }
                                    pcb_A54.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "5")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A55.BackColor = Color.Black;
                                    pcb_A55.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j155.BackColor = Color.Red;
                                        pcb_j155.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j255.BackColor = Color.Blue;
                                        pcb_j255.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j355.BackColor = Color.Green;
                                        pcb_j355.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j455.BackColor = Color.Yellow;
                                        pcb_j455.Visible = true;
                                    }
                                    pcb_A55.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "6")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A56.BackColor = Color.Black;
                                    pcb_A56.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j156.BackColor = Color.Red;
                                        pcb_j156.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j256.BackColor = Color.Blue;
                                        pcb_j256.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j356.BackColor = Color.Green;
                                        pcb_j356.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j456.BackColor = Color.Yellow;
                                        pcb_j456.Visible = true;
                                    }
                                    pcb_A56.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "7")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A57.BackColor = Color.Black;
                                    pcb_A57.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j157.BackColor = Color.Red;
                                        pcb_j157.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j257.BackColor = Color.Blue;
                                        pcb_j257.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j357.BackColor = Color.Green;
                                        pcb_j357.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j457.BackColor = Color.Yellow;
                                        pcb_j457.Visible = true;
                                    }
                                    pcb_A57.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "8")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A58.BackColor = Color.Black;
                                    pcb_A58.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j158.BackColor = Color.Red;
                                        pcb_j158.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j258.BackColor = Color.Blue;
                                        pcb_j258.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j358.BackColor = Color.Green;
                                        pcb_j358.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j458.BackColor = Color.Yellow;
                                        pcb_j458.Visible = true;
                                    }
                                    pcb_A58.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "9")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A59.BackColor = Color.Black;
                                    pcb_A59.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j159.BackColor = Color.Red;
                                        pcb_j159.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j259.BackColor = Color.Blue;
                                        pcb_j259.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j359.BackColor = Color.Green;
                                        pcb_j359.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j459.BackColor = Color.Yellow;
                                        pcb_j459.Visible = true;
                                    }
                                    pcb_A59.Visible = false;
                                }
                            }
                        }
                    }

                    if (newRow[0].ToString() == "6")
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            if (newRow[1].ToString() == "1")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ") 
                                {
                                    pcb_A61.BackColor = Color.Black;
                                    pcb_A61.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j161.BackColor = Color.Red;
                                        pcb_j161.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j261.BackColor = Color.Blue;
                                        pcb_j261.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j361.BackColor = Color.Green;
                                        pcb_j361.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j461.BackColor = Color.Yellow;
                                        pcb_j461.Visible = true;
                                    }
                                    pcb_A61.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "2")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A62.BackColor = Color.Black;
                                    pcb_A62.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j162.BackColor = Color.Red;
                                        pcb_j162.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j262.BackColor = Color.Blue;
                                        pcb_j262.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j362.BackColor = Color.Green;
                                        pcb_j362.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j462.BackColor = Color.Yellow;
                                        pcb_j462.Visible = true;
                                    }
                                    pcb_A62.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "3")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A63.BackColor = Color.Black;
                                    pcb_A63.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j163.BackColor = Color.Red;
                                        pcb_j163.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j263.BackColor = Color.Blue;
                                        pcb_j263.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j363.BackColor = Color.Green;
                                        pcb_j363.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j463.BackColor = Color.Yellow;
                                        pcb_j463.Visible = true;
                                    }
                                    pcb_A63.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "4")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A64.BackColor = Color.Black;
                                    pcb_A64.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j164.BackColor = Color.Red;
                                        pcb_j164.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j264.BackColor = Color.Blue;
                                        pcb_j264.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j364.BackColor = Color.Green;
                                        pcb_j364.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j464.BackColor = Color.Yellow;
                                        pcb_j464.Visible = true;
                                    }
                                    pcb_A64.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "5")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A65.BackColor = Color.Black;
                                    pcb_A65.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j165.BackColor = Color.Red;
                                        pcb_j165.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j265.BackColor = Color.Blue;
                                        pcb_j265.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j365.BackColor = Color.Green;
                                        pcb_j365.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j465.BackColor = Color.Yellow;
                                        pcb_j465.Visible = true;
                                    }
                                    pcb_A65.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "6")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A66.BackColor = Color.Black;
                                    pcb_A66.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j166.BackColor = Color.Red;
                                        pcb_j166.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j266.BackColor = Color.Blue;
                                        pcb_j266.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j366.BackColor = Color.Green;
                                        pcb_j366.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j466.BackColor = Color.Yellow;
                                        pcb_j466.Visible = true;
                                    }
                                    pcb_A66.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "7")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A67.BackColor = Color.Black;
                                    pcb_A67.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j167.BackColor = Color.Red;
                                        pcb_j167.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j267.BackColor = Color.Blue;
                                        pcb_j267.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j367.BackColor = Color.Green;
                                        pcb_j367.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j467.BackColor = Color.Yellow;
                                        pcb_j467.Visible = true;
                                    }
                                    pcb_A67.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "8")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A68.BackColor = Color.Black;
                                    pcb_A68.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j168.BackColor = Color.Red;
                                        pcb_j168.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j268.BackColor = Color.Blue;
                                        pcb_j268.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j368.BackColor = Color.Green;
                                        pcb_j368.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j468.BackColor = Color.Yellow;
                                        pcb_j468.Visible = true;
                                    }
                                    pcb_A68.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "9")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A69.BackColor = Color.Black;
                                    pcb_A69.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j169.BackColor = Color.Red;
                                        pcb_j169.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j269.BackColor = Color.Blue;
                                        pcb_j269.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j369.BackColor = Color.Green;
                                        pcb_j369.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j469.BackColor = Color.Yellow;
                                        pcb_j469.Visible = true;
                                    }
                                    pcb_A69.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "10")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A610.BackColor = Color.Black;
                                    pcb_A610.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1610.BackColor = Color.Red;
                                        pcb_j1610.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2610.BackColor = Color.Blue;
                                        pcb_j2610.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3610.BackColor = Color.Green;
                                        pcb_j3610.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4610.BackColor = Color.Yellow;
                                        pcb_j4610.Visible = true;
                                    }
                                    pcb_A610.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "11")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                { 
                                    pcb_A611.BackColor = Color.Black;
                                    pcb_A611.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1611.BackColor = Color.Red;
                                        pcb_j1611.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2611.BackColor = Color.Blue;
                                        pcb_j2611.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3611.BackColor = Color.Green;
                                        pcb_j3611.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4611.BackColor = Color.Yellow;
                                        pcb_j4611.Visible = true;
                                    }
                                    pcb_A611.Visible = false;
                                }
                            }
                        }
                    }

                    if (newRow[0].ToString() == "7")
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            if (newRow[1].ToString() == "1")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A71.BackColor = Color.Black;
                                    pcb_A71.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j171.BackColor = Color.Red;
                                        pcb_j171.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j271.BackColor = Color.Blue;
                                        pcb_j271.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j371.BackColor = Color.Green;
                                        pcb_j371.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j471.BackColor = Color.Yellow;
                                        pcb_j471.Visible = true;
                                    }
                                    pcb_A71.Visible = false;
                                }

                            }
                            else if (newRow[1].ToString() == "2")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A72.BackColor = Color.Black;
                                    pcb_A72.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j172.BackColor = Color.Red;
                                        pcb_j172.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j272.BackColor = Color.Blue;
                                        pcb_j272.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j372.BackColor = Color.Green;
                                        pcb_j372.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j472.BackColor = Color.Yellow;
                                        pcb_j472.Visible = true;
                                    }
                                    pcb_A72.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "3")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A73.BackColor = Color.Black;
                                    pcb_A73.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j173.BackColor = Color.Red;
                                        pcb_j173.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j273.BackColor = Color.Blue;
                                        pcb_j273.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j373.BackColor = Color.Green;
                                        pcb_j373.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j473.BackColor = Color.Yellow;
                                        pcb_j473.Visible = true;
                                    }
                                    pcb_A73.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "4")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A74.BackColor = Color.Black;
                                    pcb_A74.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j174.BackColor = Color.Red;
                                        pcb_j174.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j274.BackColor = Color.Blue;
                                        pcb_j274.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j374.BackColor = Color.Green;
                                        pcb_j374.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j474.BackColor = Color.Yellow;
                                        pcb_j474.Visible = true;
                                    }
                                    pcb_A74.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "5")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A75.BackColor = Color.Black;
                                    pcb_A75.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j175.BackColor = Color.Red;
                                        pcb_j175.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j275.BackColor = Color.Blue;
                                        pcb_j275.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j375.BackColor = Color.Green;
                                        pcb_j375.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j475.BackColor = Color.Yellow;
                                        pcb_j475.Visible = true;
                                    }
                                    pcb_A75.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "6")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A76.BackColor = Color.Black;
                                    pcb_A76.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j176.BackColor = Color.Red;
                                        pcb_j176.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j276.BackColor = Color.Blue;
                                        pcb_j276.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j376.BackColor = Color.Green;
                                        pcb_j376.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j476.BackColor = Color.Yellow;
                                        pcb_j476.Visible = true;
                                    }
                                    pcb_A76.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "7")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A77.BackColor = Color.Black;
                                    pcb_A77.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j177.BackColor = Color.Red;
                                        pcb_j177.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j277.BackColor = Color.Blue;
                                        pcb_j277.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j377.BackColor = Color.Green;
                                        pcb_j377.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j477.BackColor = Color.Yellow;
                                        pcb_j477.Visible = true;
                                    }
                                    pcb_A77.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "8")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A78.BackColor = Color.Black;
                                    pcb_A78.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j178.BackColor = Color.Red;
                                        pcb_j178.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j278.BackColor = Color.Blue;
                                        pcb_j278.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j378.BackColor = Color.Green;
                                        pcb_j378.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j478.BackColor = Color.Yellow;
                                        pcb_j478.Visible = true;
                                    }
                                    pcb_A78.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "9")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A79.BackColor = Color.Black;
                                    pcb_A79.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j179.BackColor = Color.Red;
                                        pcb_j179.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j279.BackColor = Color.Blue;
                                        pcb_j279.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j379.BackColor = Color.Green;
                                        pcb_j379.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j479.BackColor = Color.Yellow;
                                        pcb_j479.Visible = true;
                                    }
                                    pcb_A79.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "10")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A710.BackColor = Color.Black;
                                    pcb_A710.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1710.BackColor = Color.Red;
                                        pcb_j1710.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2710.BackColor = Color.Blue;
                                        pcb_j2710.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3710.BackColor = Color.Green;
                                        pcb_j373.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4710.BackColor = Color.Yellow;
                                        pcb_j4710.Visible = true;
                                    }
                                    pcb_A710.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "11")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A711.BackColor = Color.Black;
                                    pcb_A711.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1711.BackColor = Color.Red;
                                        pcb_j1711.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2711.BackColor = Color.Blue;
                                        pcb_j2711.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3711.BackColor = Color.Green;
                                        pcb_j3711.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4711.BackColor = Color.Yellow;
                                        pcb_j4711.Visible = true;
                                    }
                                    pcb_A711.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "12")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A712.BackColor = Color.Black;
                                    pcb_A712.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1712.BackColor = Color.Red;
                                        pcb_j1712.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2712.BackColor = Color.Blue;
                                        pcb_j2712.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3712.BackColor = Color.Green;
                                        pcb_j3712.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4712.BackColor = Color.Yellow;
                                        pcb_j4712.Visible = true;
                                    }
                                    pcb_A712.Visible = false;
                                }
                            }
                            else
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A713.BackColor = Color.Black;
                                    pcb_A713.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1713.BackColor = Color.Red;
                                        pcb_j1713.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2713.BackColor = Color.Blue;
                                        pcb_j2713.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3713.BackColor = Color.Green;
                                        pcb_j3713.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4713.BackColor = Color.Yellow;
                                        pcb_j4713.Visible = true;
                                    }
                                    pcb_A713.Visible = false;
                                }
                            }
                        }
                    }

                    if (newRow[0].ToString() == "8")
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            if (newRow[1].ToString() == "1")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A81.BackColor = Color.Black;
                                    pcb_A81.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j181.BackColor = Color.Red;
                                        pcb_j181.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j281.BackColor = Color.Blue;
                                        pcb_j281.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j381.BackColor = Color.Green;
                                        pcb_j381.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j481.BackColor = Color.Yellow;
                                        pcb_j481.Visible = true;
                                    }
                                    pcb_A81.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "2")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A82.BackColor = Color.Black;
                                    pcb_A82.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j182.BackColor = Color.Red;
                                        pcb_j182.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j282.BackColor = Color.Blue;
                                        pcb_j282.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j382.BackColor = Color.Green;
                                        pcb_j382.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j482.BackColor = Color.Yellow;
                                        pcb_j482.Visible = true;
                                    }
                                    pcb_A82.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "3")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A83.BackColor = Color.Black;
                                    pcb_A83.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j183.BackColor = Color.Red;
                                        pcb_j183.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j283.BackColor = Color.Blue;
                                        pcb_j283.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j383.BackColor = Color.Green;
                                        pcb_j383.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j483.BackColor = Color.Yellow;
                                        pcb_j483.Visible = true;
                                    }
                                    pcb_A83.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "4")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A84.BackColor = Color.Black;
                                    pcb_A84.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j184.BackColor = Color.Red;
                                        pcb_j184.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j284.BackColor = Color.Blue;
                                        pcb_j284.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j384.BackColor = Color.Green;
                                        pcb_j384.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j484.BackColor = Color.Yellow;
                                        pcb_j484.Visible = true;
                                    }
                                    pcb_A84.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "5")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A85.BackColor = Color.Black;
                                    pcb_A85.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j185.BackColor = Color.Red;
                                        pcb_j185.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j285.BackColor = Color.Blue;
                                        pcb_j285.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j385.BackColor = Color.Green;
                                        pcb_j385.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j485.BackColor = Color.Yellow;
                                        pcb_j485.Visible = true;
                                    }
                                    pcb_A85.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "6")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A86.BackColor = Color.Black;
                                    pcb_A86.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j186.BackColor = Color.Red;
                                        pcb_j186.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j286.BackColor = Color.Blue;
                                        pcb_j286.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j386.BackColor = Color.Green;
                                        pcb_j386.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j486.BackColor = Color.Yellow;
                                        pcb_j486.Visible = true;
                                    }
                                    pcb_A86.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "7")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A87.BackColor = Color.Black;
                                    pcb_A87.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j187.BackColor = Color.Red;
                                        pcb_j187.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j287.BackColor = Color.Blue;
                                        pcb_j287.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j387.BackColor = Color.Green;
                                        pcb_j387.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j487.BackColor = Color.Yellow;
                                        pcb_j487.Visible = true;
                                    }
                                    pcb_A87.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "8")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A88.BackColor = Color.Black;
                                    pcb_A88.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j188.BackColor = Color.Red;
                                        pcb_j188.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j288.BackColor = Color.Blue;
                                        pcb_j288.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j388.BackColor = Color.Green;
                                        pcb_j388.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j488.BackColor = Color.Yellow;
                                        pcb_j488.Visible = true;
                                    }
                                    pcb_A88.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "9")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A89.BackColor = Color.Black;
                                    pcb_A89.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j189.BackColor = Color.Red;
                                        pcb_j189.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j289.BackColor = Color.Blue;
                                        pcb_j289.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j389.BackColor = Color.Green;
                                        pcb_j389.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j489.BackColor = Color.Yellow;
                                        pcb_j489.Visible = true;
                                    }
                                    pcb_A89.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "10")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A810.BackColor = Color.Black;
                                    pcb_A810.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1810.BackColor = Color.Red;
                                        pcb_j1810.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2810.BackColor = Color.Blue;
                                        pcb_j2810.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3810.BackColor = Color.Green;
                                        pcb_j3810.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4810.BackColor = Color.Yellow;
                                        pcb_j4810.Visible = true;
                                    }
                                    pcb_A810.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "11")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ") 
                                {
                                    pcb_A811.BackColor = Color.Black;
                                    pcb_A811.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1811.BackColor = Color.Red;
                                        pcb_j1811.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2811.BackColor = Color.Blue;
                                        pcb_j2811.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3811.BackColor = Color.Green;
                                        pcb_j3811.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4811.BackColor = Color.Yellow;
                                        pcb_j4811.Visible = true;
                                    }
                                    pcb_A811.Visible = false;
                                }
                            }
                        }
                    }

                    if (newRow[0].ToString() == "9")
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            if (newRow[1].ToString() == "1")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A91.BackColor = Color.Black;
                                    pcb_A91.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j191.BackColor = Color.Red;
                                        pcb_j191.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j291.BackColor = Color.Blue;
                                        pcb_j291.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j391.BackColor = Color.Green;
                                        pcb_j391.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j491.BackColor = Color.Yellow;
                                        pcb_j491.Visible = true;
                                    }
                                    pcb_A91.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "2")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A92.BackColor = Color.Black;
                                    pcb_A92.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j192.BackColor = Color.Red;
                                        pcb_j192.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j292.BackColor = Color.Blue;
                                        pcb_j292.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j392.BackColor = Color.Green;
                                        pcb_j392.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j492.BackColor = Color.Yellow;
                                        pcb_j491.Visible = true;
                                    }
                                    pcb_A91.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "3")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A93.BackColor = Color.Black;
                                    pcb_A93.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j193.BackColor = Color.Red;
                                        pcb_j193.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j293.BackColor = Color.Blue;
                                        pcb_j293.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j393.BackColor = Color.Green;
                                        pcb_j393.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j493.BackColor = Color.Yellow;
                                        pcb_j493.Visible = true;
                                    }
                                    pcb_A93.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "4")
                            { 
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A94.BackColor = Color.Black;
                                    pcb_A94.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j194.BackColor = Color.Red;
                                        pcb_j194.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j294.BackColor = Color.Blue;
                                        pcb_j294.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j394.BackColor = Color.Green;
                                        pcb_j394.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j494.BackColor = Color.Yellow;
                                        pcb_j494.Visible = true;
                                    }
                                    pcb_A94.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "5")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A95.BackColor = Color.Black;
                                    pcb_A95.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j195.BackColor = Color.Red;
                                        pcb_j195.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j295.BackColor = Color.Blue;
                                        pcb_j295.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j395.BackColor = Color.Green;
                                        pcb_j395.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j495.BackColor = Color.Yellow;
                                        pcb_j495.Visible = true;
                                    }
                                    pcb_A95.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "6")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ") 
                                {
                                    pcb_A96.BackColor = Color.Black;
                                    pcb_A96.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j196.BackColor = Color.Red;
                                        pcb_j196.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j296.BackColor = Color.Blue;
                                        pcb_j296.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j396.BackColor = Color.Green;
                                        pcb_j396.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j496.BackColor = Color.Yellow;
                                        pcb_j496.Visible = true;
                                    }
                                    pcb_A96.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "7")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A97.BackColor = Color.Black;
                                    pcb_A97.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j197.BackColor = Color.Red;
                                        pcb_j197.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j297.BackColor = Color.Blue;
                                        pcb_j297.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j397.BackColor = Color.Green;
                                        pcb_j397.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j497.BackColor = Color.Yellow;
                                        pcb_j497.Visible = true;
                                    }
                                    pcb_A97.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "8")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A98.BackColor = Color.Black;
                                    pcb_A98.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j198.BackColor = Color.Red;
                                        pcb_j198.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j298.BackColor = Color.Blue;
                                        pcb_j298.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j398.BackColor = Color.Green;
                                        pcb_j398.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j498.BackColor = Color.Yellow;
                                        pcb_j498.Visible = true;
                                    }
                                    pcb_A98.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "9")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A99.BackColor = Color.Black;
                                    pcb_A99.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j199.BackColor = Color.Red;
                                        pcb_j199.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j299.BackColor = Color.Blue;
                                        pcb_j299.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j399.BackColor = Color.Green;
                                        pcb_j399.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j499.BackColor = Color.Yellow;
                                        pcb_j499.Visible = true;
                                    }
                                    pcb_A99.Visible = false;
                                }
                            }
                        }
                    }

                    if (newRow[0].ToString() == "10")
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            if (newRow[1].ToString() == "1")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A101.BackColor = Color.Black;
                                    pcb_A101.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1101.BackColor = Color.Red;
                                        pcb_j1101.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2101.BackColor = Color.Blue;
                                        pcb_j2101.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3101.BackColor = Color.Green;
                                        pcb_j3101.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4101.BackColor = Color.Yellow;
                                        pcb_j4101.Visible = true;
                                    }
                                    pcb_A101.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "2")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A102.BackColor = Color.Black;
                                    pcb_A102.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1102.BackColor = Color.Red;
                                        pcb_j1102.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2102.BackColor = Color.Blue;
                                        pcb_j2102.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3102.BackColor = Color.Green;
                                        pcb_j3102.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4102.BackColor = Color.Yellow;
                                        pcb_j4102.Visible = true;
                                    }
                                    pcb_A102.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "3")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A103.BackColor = Color.Black;
                                    pcb_A103.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1103.BackColor = Color.Red;
                                        pcb_j1103.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2103.BackColor = Color.Blue;
                                        pcb_j2103.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3103.BackColor = Color.Green;
                                        pcb_j3103.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4103.BackColor = Color.Yellow;
                                        pcb_j4103.Visible = true;
                                    }
                                    pcb_A103.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "4")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A104.BackColor = Color.Black;
                                    pcb_A104.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1104.BackColor = Color.Red;
                                        pcb_j1104.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2104.BackColor = Color.Blue;
                                        pcb_j2104.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3104.BackColor = Color.Green;
                                        pcb_j3104.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4104.BackColor = Color.Yellow;
                                        pcb_j4104.Visible = true;
                                    }
                                    pcb_A104.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "5")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A105.BackColor = Color.Black;
                                    pcb_A105.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1105.BackColor = Color.Red;
                                        pcb_j1105.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2105.BackColor = Color.Blue;
                                        pcb_j2105.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3105.BackColor = Color.Green;
                                        pcb_j3105.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4105.BackColor = Color.Yellow;
                                        pcb_j4105.Visible = true;
                                    }
                                    pcb_A105.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "6")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A106.BackColor = Color.Black;
                                    pcb_A106.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1106.BackColor = Color.Red;
                                        pcb_j1106.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2106.BackColor = Color.Blue;
                                        pcb_j2106.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3106.BackColor = Color.Green;
                                        pcb_j3106.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4106.BackColor = Color.Yellow;
                                        pcb_j4106.Visible = true;
                                    }
                                    pcb_A106.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "7")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A107.BackColor = Color.Black;
                                    pcb_A107.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1107.BackColor = Color.Red;
                                        pcb_j1107.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2107.BackColor = Color.Blue;
                                        pcb_j2107.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3107.BackColor = Color.Green;
                                        pcb_j3107.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4107.BackColor = Color.Yellow;
                                        pcb_j4107.Visible = true;
                                    }
                                    pcb_A107.Visible = false;
                                }
                            }
                        }
                    }

                    if (newRow[0].ToString() == "11")
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            if (newRow[1].ToString() == "1")
                            {

                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A111.BackColor = Color.Black;
                                    pcb_A111.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1111.BackColor = Color.Red;
                                        pcb_j1111.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2111.BackColor = Color.Blue;
                                        pcb_j2111.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3111.BackColor = Color.Green;
                                        pcb_j3111.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4111.BackColor = Color.Yellow;
                                        pcb_j4111.Visible = true;
                                    }
                                    pcb_A111.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "2")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A112.BackColor = Color.Black;
                                    pcb_A112.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1112.BackColor = Color.Red;
                                        pcb_j1112.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2112.BackColor = Color.Blue;
                                        pcb_j2112.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3112.BackColor = Color.Green;
                                        pcb_j3112.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4112.BackColor = Color.Yellow;
                                        pcb_j4112.Visible = true;
                                    }
                                    pcb_A112.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "3")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A113.BackColor = Color.Black;
                                    pcb_A113.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1113.BackColor = Color.Red;
                                        pcb_j1113.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2113.BackColor = Color.Blue;
                                        pcb_j2113.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3113.BackColor = Color.Green;
                                        pcb_j3113.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4113.BackColor = Color.Yellow;
                                        pcb_j4113.Visible = true;
                                    }
                                    pcb_A113.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "4")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A114.BackColor = Color.Black;
                                    pcb_A114.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1114.BackColor = Color.Red;
                                        pcb_j1114.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2114.BackColor = Color.Blue;
                                        pcb_j2114.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3114.BackColor = Color.Green;
                                        pcb_j3114.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4114.BackColor = Color.Yellow;
                                        pcb_j4114.Visible = true;
                                    }
                                    pcb_A114.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "5")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A115.BackColor = Color.Black;
                                    pcb_A115.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1115.BackColor = Color.Red;
                                        pcb_j1115.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2115.BackColor = Color.Blue;
                                        pcb_j2115.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3115.BackColor = Color.Green;
                                        pcb_j3115.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4115.BackColor = Color.Yellow;
                                        pcb_j4115.Visible = true;
                                    }
                                    pcb_A115.Visible = false;
                                }
                            }
                        }
                    }

                    if (newRow[0].ToString() == "12")
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            if (newRow[1].ToString() == "1")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A121.BackColor = Color.Black;
                                    pcb_A121.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1121.BackColor = Color.Red;
                                        pcb_j1121.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2121.BackColor = Color.Blue;
                                        pcb_j2121.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3121.BackColor = Color.Green;
                                        pcb_j3121.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4121.BackColor = Color.Yellow;
                                        pcb_j4121.Visible = true;
                                    }
                                    pcb_A121.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "2")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A122.BackColor = Color.Black;
                                    pcb_A122.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1122.BackColor = Color.Red;
                                        pcb_j1122.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2122.BackColor = Color.Blue;
                                        pcb_j2122.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3122.BackColor = Color.Green;
                                        pcb_j3122.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4122.BackColor = Color.Yellow;
                                        pcb_j4122.Visible = true;
                                    }
                                    pcb_A122.Visible = false;
                                }
                            }
                            else if (newRow[1].ToString() == "3")
                            {
                                if (newRow[3].ToString() == "A" || newRow[3].ToString() == "A ")
                                {
                                    pcb_A123.BackColor = Color.Black;
                                    pcb_A123.Visible = true;
                                }
                                else
                                {
                                    if (newRow[2].ToString() == jogadores[0])
                                    {
                                        pcb_j1123.BackColor = Color.Red;
                                        pcb_j1123.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[1])
                                    {
                                        pcb_j2123.BackColor = Color.Blue;
                                        pcb_j2123.Visible = true;
                                    }
                                    else if (newRow[2].ToString() == jogadores[2])
                                    {
                                        pcb_j3123.BackColor = Color.Green;
                                        pcb_j3123.Visible = true;
                                    }
                                    else
                                    {
                                        pcb_j4123.BackColor = Color.Yellow;
                                        pcb_j4123.Visible = true;
                                    }
                                    pcb_A123.Visible = false;
                                }
                            }
                        }
                    }
                }

            }
        }

        public void LimparTabuleiro()
        {
            pcb_A21.Visible = false;
            pcb_A22.Visible = false;
            pcb_A23.Visible = false;

            pcb_A31.Visible = false;
            pcb_A32.Visible = false;
            pcb_A33.Visible = false;
            pcb_A34.Visible = false;
            pcb_A35.Visible = false;

            pcb_A41.Visible = false;
            pcb_A42.Visible = false;
            pcb_A43.Visible = false;
            pcb_A44.Visible = false;
            pcb_A45.Visible = false;
            pcb_A46.Visible = false;
            pcb_A47.Visible = false;

            pcb_A51.Visible = false;
            pcb_A52.Visible = false;
            pcb_A53.Visible = false;
            pcb_A54.Visible = false;
            pcb_A55.Visible = false;
            pcb_A56.Visible = false;
            pcb_A57.Visible = false;
            pcb_A58.Visible = false;
            pcb_A59.Visible = false;

            pcb_A61.Visible = false;
            pcb_A62.Visible = false;
            pcb_A63.Visible = false;
            pcb_A64.Visible = false;
            pcb_A65.Visible = false;
            pcb_A66.Visible = false;
            pcb_A67.Visible = false;
            pcb_A68.Visible = false;
            pcb_A69.Visible = false;
            pcb_A610.Visible = false;
            pcb_A611.Visible = false;

            pcb_A71.Visible = false;
            pcb_A72.Visible = false;
            pcb_A73.Visible = false;
            pcb_A74.Visible = false;
            pcb_A75.Visible = false;
            pcb_A76.Visible = false;
            pcb_A77.Visible = false;
            pcb_A78.Visible = false;
            pcb_A79.Visible = false;
            pcb_A710.Visible = false;
            pcb_A711.Visible = false;
            pcb_A712.Visible = false;
            pcb_A713.Visible = false;

            pcb_A81.Visible = false;
            pcb_A82.Visible = false;
            pcb_A83.Visible = false;
            pcb_A84.Visible = false;
            pcb_A85.Visible = false;
            pcb_A86.Visible = false;
            pcb_A87.Visible = false;
            pcb_A88.Visible = false;
            pcb_A89.Visible = false;
            pcb_A810.Visible = false;
            pcb_A811.Visible = false;

            pcb_A91.Visible = false;
            pcb_A92.Visible = false;
            pcb_A93.Visible = false;
            pcb_A94.Visible = false;
            pcb_A95.Visible = false;
            pcb_A96.Visible = false;
            pcb_A97.Visible = false;
            pcb_A98.Visible = false;
            pcb_A99.Visible = false;

            pcb_A101.Visible = false;
            pcb_A102.Visible = false;
            pcb_A103.Visible = false;
            pcb_A104.Visible = false;
            pcb_A105.Visible = false;
            pcb_A106.Visible = false;
            pcb_A107.Visible = false;

            pcb_A111.Visible = false;
            pcb_A112.Visible = false;
            pcb_A113.Visible = false;
            pcb_A114.Visible = false;
            pcb_A115.Visible = false;

            pcb_A121.Visible = false;
            pcb_A122.Visible = false;
            pcb_A123.Visible = false;

            pcb_j121.Visible = false;
            pcb_j122.Visible = false;
            pcb_j123.Visible = false;


            pcb_j221.Visible = false;
            pcb_j222.Visible = false;
            pcb_j223.Visible = false;

            pcb_j321.Visible = false;
            pcb_j322.Visible = false;
            pcb_j323.Visible = false;

            pcb_j421.Visible = false;
            pcb_j422.Visible = false;
            pcb_j423.Visible = false;

            pcb_j131.Visible = false;
            pcb_j132.Visible = false;
            pcb_j133.Visible = false;
            pcb_j134.Visible = false;
            pcb_j135.Visible = false;

            pcb_j231.Visible = false;
            pcb_j232.Visible = false;
            pcb_j233.Visible = false;
            pcb_j234.Visible = false;
            pcb_j235.Visible = false;

            pcb_j331.Visible = false;
            pcb_j332.Visible = false;
            pcb_j333.Visible = false;
            pcb_j334.Visible = false;
            pcb_j335.Visible = false;

            pcb_j431.Visible = false;
            pcb_j432.Visible = false;
            pcb_j433.Visible = false;
            pcb_j434.Visible = false;
            pcb_j435.Visible = false;

            pcb_j141.Visible = false;
            pcb_j142.Visible = false;
            pcb_j143.Visible = false;
            pcb_j144.Visible = false;
            pcb_j145.Visible = false;
            pcb_j146.Visible = false;
            pcb_j147.Visible = false;

            pcb_j241.Visible = false;
            pcb_j242.Visible = false;
            pcb_j243.Visible = false;
            pcb_j244.Visible = false;
            pcb_j245.Visible = false;
            pcb_j246.Visible = false;
            pcb_j247.Visible = false;

            pcb_j341.Visible = false;
            pcb_j342.Visible = false;
            pcb_j343.Visible = false;
            pcb_j344.Visible = false;
            pcb_j345.Visible = false;
            pcb_j346.Visible = false;
            pcb_j347.Visible = false;

            pcb_j441.Visible = false;
            pcb_j442.Visible = false;
            pcb_j443.Visible = false;
            pcb_j444.Visible = false;
            pcb_j445.Visible = false;
            pcb_j446.Visible = false;
            pcb_j447.Visible = false;

            pcb_j151.Visible = false;
            pcb_j152.Visible = false;
            pcb_j153.Visible = false;
            pcb_j154.Visible = false;
            pcb_j155.Visible = false;
            pcb_j156.Visible = false;
            pcb_j157.Visible = false;
            pcb_j158.Visible = false;
            pcb_j159.Visible = false;

            pcb_j251.Visible = false;
            pcb_j252.Visible = false;
            pcb_j253.Visible = false;
            pcb_j254.Visible = false;
            pcb_j255.Visible = false;
            pcb_j256.Visible = false;
            pcb_j257.Visible = false;
            pcb_j258.Visible = false;
            pcb_j259.Visible = false;

            pcb_j351.Visible = false;
            pcb_j352.Visible = false;
            pcb_j353.Visible = false;
            pcb_j354.Visible = false;
            pcb_j355.Visible = false;
            pcb_j356.Visible = false;
            pcb_j357.Visible = false;
            pcb_j358.Visible = false;
            pcb_j359.Visible = false;

            pcb_j451.Visible = false;
            pcb_j452.Visible = false;
            pcb_j453.Visible = false;
            pcb_j454.Visible = false;
            pcb_j455.Visible = false;
            pcb_j456.Visible = false;
            pcb_j457.Visible = false;
            pcb_j458.Visible = false;
            pcb_j459.Visible = false;


            pcb_j161.Visible = false;
            pcb_j162.Visible = false;
            pcb_j163.Visible = false;
            pcb_j164.Visible = false;
            pcb_j165.Visible = false;
            pcb_j166.Visible = false;
            pcb_j167.Visible = false;
            pcb_j168.Visible = false;
            pcb_j169.Visible = false;
            pcb_j1610.Visible = false;
            pcb_j1611.Visible = false;


            pcb_j261.Visible = false;
            pcb_j262.Visible = false;
            pcb_j263.Visible = false;
            pcb_j264.Visible = false;
            pcb_j265.Visible = false;
            pcb_j266.Visible = false;
            pcb_j267.Visible = false;
            pcb_j268.Visible = false;
            pcb_j269.Visible = false;
            pcb_j2610.Visible = false;
            pcb_j2611.Visible = false;

            pcb_j361.Visible = false;
            pcb_j362.Visible = false;
            pcb_j363.Visible = false;
            pcb_j364.Visible = false;
            pcb_j365.Visible = false;
            pcb_j366.Visible = false;
            pcb_j367.Visible = false;
            pcb_j368.Visible = false;
            pcb_j369.Visible = false;
            pcb_j3610.Visible = false;
            pcb_j3611.Visible = false;

            pcb_j461.Visible = false;
            pcb_j462.Visible = false;
            pcb_j463.Visible = false;
            pcb_j464.Visible = false;
            pcb_j465.Visible = false;
            pcb_j466.Visible = false;
            pcb_j467.Visible = false;
            pcb_j468.Visible = false;
            pcb_j469.Visible = false;
            pcb_j4610.Visible = false;
            pcb_j4611.Visible = false;

            pcb_j171.Visible = false;
            pcb_j172.Visible = false;
            pcb_j173.Visible = false;
            pcb_j174.Visible = false;
            pcb_j175.Visible = false;
            pcb_j176.Visible = false;
            pcb_j177.Visible = false;
            pcb_j178.Visible = false;
            pcb_j179.Visible = false;
            pcb_j1710.Visible = false;
            pcb_j1711.Visible = false;
            pcb_j1712.Visible = false;
            pcb_j1713.Visible = false;

            pcb_j271.Visible = false;
            pcb_j272.Visible = false;
            pcb_j273.Visible = false;
            pcb_j274.Visible = false;
            pcb_j275.Visible = false;
            pcb_j276.Visible = false;
            pcb_j277.Visible = false;
            pcb_j278.Visible = false;
            pcb_j279.Visible = false;
            pcb_j2710.Visible = false;
            pcb_j2711.Visible = false;
            pcb_j2712.Visible = false;
            pcb_j2713.Visible = false;

            pcb_j371.Visible = false;
            pcb_j372.Visible = false;
            pcb_j373.Visible = false;
            pcb_j374.Visible = false;
            pcb_j375.Visible = false;
            pcb_j376.Visible = false;
            pcb_j377.Visible = false;
            pcb_j378.Visible = false;
            pcb_j379.Visible = false;
            pcb_j3710.Visible = false;
            pcb_j3711.Visible = false;
            pcb_j3712.Visible = false;
            pcb_j3713.Visible = false;

            pcb_j471.Visible = false;
            pcb_j472.Visible = false;
            pcb_j473.Visible = false;
            pcb_j474.Visible = false;
            pcb_j475.Visible = false;
            pcb_j476.Visible = false;
            pcb_j477.Visible = false;
            pcb_j478.Visible = false;
            pcb_j479.Visible = false;
            pcb_j4710.Visible = false;
            pcb_j4711.Visible = false;
            pcb_j4712.Visible = false;
            pcb_j4713.Visible = false;

            pcb_j181.Visible = false;
            pcb_j182.Visible = false;
            pcb_j183.Visible = false;
            pcb_j184.Visible = false;
            pcb_j185.Visible = false;
            pcb_j186.Visible = false;
            pcb_j187.Visible = false;
            pcb_j188.Visible = false;
            pcb_j189.Visible = false;
            pcb_j1810.Visible = false;
            pcb_j1811.Visible = false;

            pcb_j281.Visible = false;
            pcb_j282.Visible = false;
            pcb_j283.Visible = false;
            pcb_j284.Visible = false;
            pcb_j285.Visible = false;
            pcb_j286.Visible = false;
            pcb_j287.Visible = false;
            pcb_j288.Visible = false;
            pcb_j289.Visible = false;
            pcb_j2810.Visible = false;
            pcb_j2811.Visible = false;

            pcb_j381.Visible = false;
            pcb_j382.Visible = false;
            pcb_j383.Visible = false;
            pcb_j384.Visible = false;
            pcb_j385.Visible = false;
            pcb_j386.Visible = false;
            pcb_j387.Visible = false;
            pcb_j388.Visible = false;
            pcb_j389.Visible = false;
            pcb_j3810.Visible = false;
            pcb_j3811.Visible = false;

            pcb_j481.Visible = false;
            pcb_j482.Visible = false;
            pcb_j483.Visible = false;
            pcb_j484.Visible = false;
            pcb_j485.Visible = false;
            pcb_j486.Visible = false;
            pcb_j487.Visible = false;
            pcb_j488.Visible = false;
            pcb_j489.Visible = false;
            pcb_j4810.Visible = false;
            pcb_j4811.Visible = false;

            pcb_j191.Visible = false;
            pcb_j192.Visible = false;
            pcb_j193.Visible = false;
            pcb_j194.Visible = false;
            pcb_j195.Visible = false;
            pcb_j196.Visible = false;
            pcb_j197.Visible = false;
            pcb_j198.Visible = false;
            pcb_j199.Visible = false;

            pcb_j291.Visible = false;
            pcb_j292.Visible = false;
            pcb_j293.Visible = false;
            pcb_j294.Visible = false;
            pcb_j295.Visible = false;
            pcb_j296.Visible = false;
            pcb_j297.Visible = false;
            pcb_j298.Visible = false;
            pcb_j299.Visible = false;

            pcb_j391.Visible = false;
            pcb_j392.Visible = false;
            pcb_j393.Visible = false;
            pcb_j394.Visible = false;
            pcb_j395.Visible = false;
            pcb_j396.Visible = false;
            pcb_j397.Visible = false;
            pcb_j398.Visible = false;
            pcb_j399.Visible = false;

            pcb_j491.Visible = false;
            pcb_j492.Visible = false;
            pcb_j493.Visible = false;
            pcb_j494.Visible = false;
            pcb_j495.Visible = false;
            pcb_j496.Visible = false;
            pcb_j497.Visible = false;
            pcb_j498.Visible = false;
            pcb_j499.Visible = false;

            pcb_j1101.Visible = false;
            pcb_j1102.Visible = false;
            pcb_j1103.Visible = false;
            pcb_j1104.Visible = false;
            pcb_j1105.Visible = false;
            pcb_j1106.Visible = false;
            pcb_j1107.Visible = false;

            pcb_j2101.Visible = false;
            pcb_j2102.Visible = false;
            pcb_j2103.Visible = false;
            pcb_j2104.Visible = false;
            pcb_j2105.Visible = false;
            pcb_j2106.Visible = false;
            pcb_j2107.Visible = false;

            pcb_j3101.Visible = false;
            pcb_j3102.Visible = false;
            pcb_j3103.Visible = false;
            pcb_j3104.Visible = false;
            pcb_j3105.Visible = false;
            pcb_j3106.Visible = false;
            pcb_j3107.Visible = false;

            pcb_j4101.Visible = false;
            pcb_j4102.Visible = false;
            pcb_j4103.Visible = false;
            pcb_j4104.Visible = false;
            pcb_j4105.Visible = false;
            pcb_j4106.Visible = false;
            pcb_j4107.Visible = false;

            pcb_j1111.Visible = false;
            pcb_j1112.Visible = false;
            pcb_j1113.Visible = false;
            pcb_j1114.Visible = false;
            pcb_j1115.Visible = false;

            pcb_j2111.Visible = false;
            pcb_j2112.Visible = false;
            pcb_j2113.Visible = false;
            pcb_j2114.Visible = false;
            pcb_j2115.Visible = false;

            pcb_j3111.Visible = false;
            pcb_j3112.Visible = false;
            pcb_j3113.Visible = false;
            pcb_j3114.Visible = false;
            pcb_j3115.Visible = false;

            pcb_j4111.Visible = false;
            pcb_j4112.Visible = false;
            pcb_j4113.Visible = false;
            pcb_j4114.Visible = false;
            pcb_j4115.Visible = false;

            pcb_j1121.Visible = false;
            pcb_j1122.Visible = false;
            pcb_j1123.Visible = false;

            pcb_j2121.Visible = false;
            pcb_j2122.Visible = false;
            pcb_j2123.Visible = false;

            pcb_j3121.Visible = false;
            pcb_j3122.Visible = false;
            pcb_j3123.Visible = false;

            pcb_j4121.Visible = false;
            pcb_j4122.Visible = false;
            pcb_j4123.Visible = false;
        }


        public void MovimentosBOT()
        {
            int[] trilhas = Dado.FormarDuplasSomaDados(valordado);
            string escolha1 = trilhas[0] + " e " + trilhas[5];
            string escolha2 = trilhas[1] + " e " + trilhas[4];
            string escolha3 = trilhas[2] + " e " + trilhas[3];

            Random rand = new Random();
            int escolha = rand.Next(0, 2);
            switch (escolha)
            {
                case 0:
                    op_dado = escolha1;
                    dadoescolha = "";
                    dadoescolha = numerodado[0].ToString();
                    dadoescolha += numerodado[1].ToString();
                    dadoescolha += numerodado[2].ToString();
                    dadoescolha += numerodado[3].ToString();
                    break;
                case 1:
                    op_dado = escolha2;
                    dadoescolha = "";
                    dadoescolha = numerodado[0].ToString();
                    dadoescolha += numerodado[2].ToString();
                    dadoescolha += numerodado[1].ToString();
                    dadoescolha += numerodado[3].ToString();
                    break;
                case 2:
                    op_dado = escolha3;
                    dadoescolha = "";
                    dadoescolha = numerodado[0].ToString();
                    dadoescolha += numerodado[3].ToString();
                    dadoescolha += numerodado[1].ToString();
                    dadoescolha += numerodado[2].ToString();
                    break;
            }

            string trilhasEscolhidas = Dado.tratarTextoEscolhaRadio(op_dado);
            for (int i = 0; i < trilhasEscolhidas.Length; i++)
            {
                Alpinista a = new Alpinista(trilhasEscolhidas[i].ToString());
                alpinistas.Add(a);
            }

            string movimento = Jogo.Mover(JogadorAtivo.Id, JogadorAtivo.Senha, dadoescolha, trilhasEscolhidas);

            if (movimento.Contains("ERRO"))
            {
                MessageBox.Show(movimento);
            }
            else
            {
                string retornotab = Jogo.ExibirTabuleiro(IdPartida);
                dtb_tabuleiro = TabuleiroP.AdicionarMovimentos(retornotab, dtb_tabuleiro);
                dgv_teste.DataSource = dtb_tabuleiro;
                desenharTabuleiro(idJogadores);
                rtxt_historicoP.Text = Jogo.ExibirHistorico(IdPartida);
            }
            movimentosfeitos++;
        }

        private void btn_iniciarpartida_Click(object sender, EventArgs e) 
        {
            string retorno = Jogo.IniciarPartida(JogadorAtivo.Id, JogadorAtivo.Senha);
            MessageBox.Show("Iniciada a partida");
            lbl_statuspart.Text = "Partida iniciada";
            lbl_statuspart.ForeColor = System.Drawing.Color.Green;    
            rtxt_historicoP.Text = Jogo.ExibirHistorico(IdPartida);
            btn_iniciarpartida.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string statuspartida = Jogo.ExibirHistorico(IdPartida);
            if (statuspartida.Contains("iniciou") || statuspartida.Contains("Iniciou"))
            {
                lbl_statuspart.ForeColor = System.Drawing.Color.Green;
                rtxt_historicoP.Text = Jogo.ExibirHistorico(IdPartida);

                string tabuleiro = Jogo.ExibirTabuleiro(IdPartida);
                dtb_tabuleiro = TabuleiroP.LimparExibirTabuleiro(tabuleiro, dtb_tabuleiro);
                dgv_teste.DataSource = dtb_tabuleiro;
                rtxt_historicoP.Text = Jogo.ExibirHistorico(IdPartida);
                desenharTabuleiro(idJogadores);
                
                //Mudar este código de lugar(Verificar onde coloca-lo)
                string retorno = Jogo.ListarJogadores(IdPartida);
                retorno = retorno.Replace("\r", " ");
                string[] linhar = retorno.Split('\n');
                for (int i = 0; i < linhar.Length - 1; i++)
                {
                    string[] itens = linhar[i].Split(',');
                    idJogadores[i] = itens[0];
                    corJogdores[i] = itens[2];
                }
                string teste = Jogo.VerificarVez(IdPartida);
                string[] linha = teste.Split(',');
                string jogadorvez = linha[1];
                int comparar = Convert.ToInt32(jogadorvez);

                if (comparar == JogadorAtivo.Id)
                {
                    
                    try
                    {
                        if (movimentosfeitos == 1)
                        {
                            string parar = Jogo.Parar(JogadorAtivo.Id, JogadorAtivo.Senha);
                            if (parar.Contains("ERRO"))
                            {
                                MessageBox.Show(parar);
                            }
                            movimentosfeitos = 0;
                            alpinistas = new List<Alpinista>();
                        }
                        else if(movimentosfeitos == 2)
                        {
                            rolarDados(); 

                        }
                        else
                        {
                            rolarDados();
                            MovimentosBOT();
                        }
                       

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro " + ex.Message);
                    }
                }
            }
        }

        private void Tabuleiro_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (5 * 1000); // 5 secs
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }
    }
}
