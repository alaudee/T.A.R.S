using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CantStopServer;

namespace TARS
{
    class TabuleiroP
    {
        public string Trilha { get; set; }
        public string Posicao { get; set; }
        public string Jogador { get; set; }
        public string Tipo { get; set; }

        //Trilha[0] Posicao[1] Jogador[2] Tipo[3]
        public static DataTable CriarDataTable()
        {
            DataTable tabuleiro = new DataTable();
            tabuleiro.Columns.Add("trilha", typeof(string));
            tabuleiro.Columns.Add("posicao", typeof(string));
            tabuleiro.Columns.Add("jogador", typeof(string)); // IDJogador
            tabuleiro.Columns.Add("tipo", typeof(string));
            return tabuleiro;
        }

        public static List<TabuleiroP> AdicionarMovimentos(string retornotab)
        {
            retornotab = retornotab.Replace("\r", "");
            string[] linha = retornotab.Split('\n');
            List<TabuleiroP> tabuleiro = new List<TabuleiroP>();
            for (int i = 0; i < linha.Length - 1; i++)
            {
                TabuleiroP t = new TabuleiroP();
                string[] itens = linha[i].Split(',');
                t.Trilha = itens[0];
                t.Posicao = itens[1];
                t.Jogador = itens[2];
                t.Tipo = itens[3];
                tabuleiro.Add(t);
            }
            return tabuleiro;
        }

        public static List<TabuleiroP> LimparExibirTabuleiro(string retornotab)
        {
            retornotab = retornotab.Replace("\r", " ");
            string[] linha = retornotab.Split('\n');
            List<TabuleiroP> tabuleiro = new List<TabuleiroP>();
            for (int i = 0; i < linha.Length -1; i++)
            {
                TabuleiroP t = new TabuleiroP();
                string[] itens = linha[i].Split(',');
                t.Trilha = itens[0];
                t.Posicao = itens[1];
                t.Jogador = itens[2];
                t.Tipo = itens[3];
                tabuleiro.Add(t);
            }
            return tabuleiro;

        }
    }
}