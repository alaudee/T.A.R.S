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

        public static int VerificarNumeroJogador(Jogador jogadorativo)
        {
            if (jogadorativo.corjogador == "Vermelho")
            {
                return 1;
            }
            else if(jogadorativo.corjogador == "Azul")
            {
                return 2;
            }
            else if (jogadorativo.corjogador == "Verde")
            {
                return 3;
            }
            else
            {
                return 4;
            }

        }

    }
}
