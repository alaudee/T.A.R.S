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

        public static void Adicionar2Movimentos(string retornotab, DataTable dtb_tabuleiro)
        {
            retornotab = retornotab.Replace("\r", "");
            string[] linha = retornotab.Split('\n');
            string[] mov1 = linha[0].Split(',');
            string[] mov2 = linha[1].Split(',');
            dtb_tabuleiro.Rows.Add(mov1[0], mov1[1], mov1[2], mov1[3]);
            dtb_tabuleiro.Rows.Add(mov2[0], mov2[1], mov2[2], mov2[3]);
        }
    }
}