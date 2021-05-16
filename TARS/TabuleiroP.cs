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

        /*EXEMPLO DA DATATABLE
         Trilha[0] Posicao[1] Jogador[2] Tipo[3]
            1            1          2        A
            1            2          1        B  */

        //Função que gera a datatable com suas colunas
        public static DataTable CriarDataTable()
        {
            DataTable tabuleiro = new DataTable();
            tabuleiro.Columns.Add("trilha", typeof(string));
            tabuleiro.Columns.Add("posicao", typeof(string));
            tabuleiro.Columns.Add("jogador", typeof(string)); // IDJogador
            tabuleiro.Columns.Add("tipo", typeof(string));
            return tabuleiro;
        }

        /* Recria o tabuleiro para atualiza-lo e atribui 
            os dados retornados do servidor às colunas */
        public static DataTable LimparExibirTabuleiro(string retornotab)
        {
            DataTable dtb_tabuleiro = CriarDataTable();
            retornotab = retornotab.Replace("\r", " ");
            string[] linha = retornotab.Split('\n');
            for (int i = 0; i < linha.Length - 1; i++)
            {
                DataRow row = dtb_tabuleiro.NewRow();
                string[] itens = linha[i].Split(',');
                row[0] = itens[0];
                row[1] = itens[1];
                row[2] = itens[2];
                row[3] = itens[3];
                dtb_tabuleiro.Rows.Add(row);
            }
            return dtb_tabuleiro;

        }

        //Adiciona os movimentos quando o jogador faz uma inserção
        public static DataTable AdicionarMovimentos(string retornotab, DataTable dtb_tabuleiro)
        {
            retornotab = retornotab.Replace("\r", "");
            string[] linha = retornotab.Split('\n');
            for (int i = 0; i < linha.Length - 1; i++)
            {
                DataRow row = dtb_tabuleiro.NewRow();
                string[] itens = linha[i].Split(',');
                row[0] = itens[0];
                row[1] = itens[1];
                row[2] = itens[2];
                row[3] = itens[3];
                dtb_tabuleiro.Rows.Add(row);
            }
            return LimparExibirTabuleiro(retornotab);
        }
        
    }
}