using CantStopServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARS
{
    public class Jogador
    {
        public int Id { get; set; }
        public string Nomejogador { get; set; }
        public string corjogador { get; set; }
        public string Senha { get; set; }
        public int NumeroJogador { get; set; }


        /*Quando alguem entrar na partida, é colocado um numero para ele 
        para saber qual numero do jogador é para ter sua cor*/
        public static int SetarNumeroJogador(int idpartida)
        {
            string retorno = Jogo.ListarJogadores(idpartida);
            retorno = retorno.Replace("\r", " ");
            string[] linha = retorno.Split('\n');
            int teste = linha.Count();
            return teste;
        }

        //Função que chama do servidor os jogadores e é tratada para a Grid
        public static List<Jogador> listarJogadores(int idpartida)
        {
            List<Jogador> jogadores = new List<Jogador>();
            string retorno = Jogo.ListarJogadores(idpartida);
            retorno = retorno.Replace("\r", " ");
            string[] linha = retorno.Split('\n');
            for (int i = 0; i < linha.Length - 1; i++)
            {
                Jogador j = new Jogador();
                string[] itens = linha[i].Split(',');
                j.Id = Convert.ToInt32(itens[0]);
                j.Nomejogador = itens[1];
                j.corjogador = itens[2];
                jogadores.Add(j);
            }
            return jogadores;
        }

    }
}
