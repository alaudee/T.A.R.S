﻿using System;
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
        public  string Infojogador { get; set; }
        public int IDJogador { get; set; }
        public string SenhaJogador { get; set; }

        public Tabuleiro(string infojogador)
        {
            InitializeComponent();
            this.Infojogador = infojogador;

            string[] linha = Infojogador.Split(',');
            string idjogador = linha[0];
            string senhajog = linha[1];
            string corjogador = linha[2];
            lbl_idjogador.Text = "Id: "+ idjogador;
            lbl_senhajogador.Text = "Senha: " + senhajog;
            lbl_corjogador.Text = "Cor: " + corjogador;
            IDJogador = Convert.ToInt32(idjogador);
            SenhaJogador = senhajog;

        }


        private void btn_iniciarpartida_Click(object sender, EventArgs e) 
        {
            string retorno = Jogo.IniciarPartida(IDJogador, SenhaJogador);
            MessageBox.Show("Iniciada a partida");
        }

        private void lbl_rolarDado_Click(object sender, EventArgs e)
        {
            string dados = Jogo.RolarDados(IDJogador, SenhaJogador);
            dados = dados.Replace("\r", "");
            dados = dados.Replace("\n", "");
            char[] dado = new char[4];
            char[] valordado = new char[4];
            int contador = 0;
            int contvalor = 0;

            for (int i = 0; i < dados.Length; i++)
            {
                if (i % 2 == 0)
                {
                    dado[contador] = dados[i];
                    contador++;
                }
                else
                {
                    valordado[contvalor] = dados[i];
                    contvalor++;
                }

            }

            List<Dado> ListaDados  = new List<Dado>();

            for (int i = 0; i < 4; i++)
            {
                Dado d = new Dado();
                d.NumeroDado = dado[i];
                d.ValorDado = valordado[i];
                ListaDados.Add(d);
            }
            dgv_dados.DataSource = ListaDados;
            dgv_dados.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgv_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
