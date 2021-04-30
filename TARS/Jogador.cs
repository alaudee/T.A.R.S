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

        public static int SetarNumeroJogador(int idpartida)
        {
            string retorno = Jogo.ListarJogadores(idpartida);
            retorno = retorno.Replace("\r", " ");
            string[] linha = retorno.Split('\n');
            int teste = linha.Count();
            return teste;
        }

    }
}
