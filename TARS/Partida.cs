using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CantStopServer;
using System.Threading.Tasks;

namespace TARS
{
    public class Partida
    {
        public int id { get; set; }
        public string nome{ get; set; }
        public string data { get; set; }
        public string status { get; set; }
        public string senha { get; set; }

        //Função que chama do servidor as partidas e trata elas para a grid
        public static List<Partida> listarPartidas()
        {
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", " ");
            string[] linha = retorno.Split('\n');
            List<Partida> partidas = new List<Partida>();
            for (int i = 0; i < linha.Length - 1; i++)
            {
                Partida p = new Partida();
                string[] itens = linha[i].Split(',');
                p.id = Convert.ToInt32(itens[0]);
                p.nome = itens[1];
                p.data = itens[2];
                p.status = itens[3];
                partidas.Add(p);
            }
            return partidas;
        }
    }




}
