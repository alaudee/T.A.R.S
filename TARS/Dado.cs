using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CantStopServer;

namespace TARS
{
    public class Dado
    {
        public char NumeroDado { get; set; }
        public char ValorDado { get; set; }
        public Image FaceDado { get; set; }

        public static string[] dupladodado = new string[6];
        public static string dadoescolhido = "";

        
        //Coloca a imagem do respectivo valor do dado 
        public void PopularImagens(char valordado)
        {
            if (this.ValorDado == '1')
                 this.FaceDado = TARS.Properties.Resources.dado1; 
            else if (this.ValorDado == '2')
                 this.FaceDado = TARS.Properties.Resources.dado2;
            else if (this.ValorDado == '3')
                 this.FaceDado = TARS.Properties.Resources.dado3;
            else if (this.ValorDado == '4')
                 this.FaceDado = TARS.Properties.Resources.dado4;
            else if (this.ValorDado == '5')
                 this.FaceDado = TARS.Properties.Resources.dado5;
            else 
                 this.FaceDado = TARS.Properties.Resources.dado6;
        }


        //Gera todas as combinações possiveis da rolagem de dados

        public static string FormarDuplasSomaDados(char[] valordado)
        {
            int[] trilha = new int[6];
            dadoescolhido = "";

            trilha[0] = (int)Char.GetNumericValue(valordado[0]) + (int)Char.GetNumericValue(valordado[1]);//dado 1 e 2
            dupladodado[0] = "12";

            trilha[1] = (int)Char.GetNumericValue(valordado[0]) + (int)Char.GetNumericValue(valordado[2]);// dado 1 e 3
            dupladodado[1] = "13";

            trilha[2] = (int)Char.GetNumericValue(valordado[0]) + (int)Char.GetNumericValue(valordado[3]);// dado 1 e 4
            dupladodado[2] = "14";

            trilha[3] = (int)Char.GetNumericValue(valordado[1]) + (int)Char.GetNumericValue(valordado[2]);// dado 2 e 3
            dupladodado[3] = "23";

            trilha[4] = (int)Char.GetNumericValue(valordado[1]) + (int)Char.GetNumericValue(valordado[3]);// dado 2 e 4
            dupladodado[4] = "24";

            trilha[5] = (int)Char.GetNumericValue(valordado[2]) + (int)Char.GetNumericValue(valordado[3]);// dado 3 e 4
            dupladodado[5] = "34";

            preferencia(trilha);

            /*Jogo.VerificarTrilhas(idpartida)
              trilha[0]  jogadorid[1]
                 5           2        */

            if(dadoescolhido == "12")
            {
                dadoescolhido += 34;
                dadoescolhido += "e" + trilha[0] + "e" + trilha[5];
            }
            else if(dadoescolhido == "13")
            {
                dadoescolhido += "24";
                dadoescolhido += "e" + trilha[1] + "e" + trilha[4];
            }
            else if (dadoescolhido == "14")
            {
                dadoescolhido += "23";
                dadoescolhido += "e" + trilha[2] + "e" + trilha[3];
            }
            else if (dadoescolhido == "23")
            {
                dadoescolhido += "14";
                dadoescolhido += "e" + trilha[3] + "e" + trilha[2];
            }
            else if (dadoescolhido == "24")
            {
                dadoescolhido += "13";
                dadoescolhido += "e" + trilha[4] + "e" + trilha[1];
            }
            else
            {
                dadoescolhido += "12";
                dadoescolhido += "e" + trilha[5] + "e" + trilha[0];
            }

            return dadoescolhido;
        }


        //Converte os valores para hexadecimal
        public static string converteHexadecimal(string caso)
        {
            if (int.Parse(caso) == 10)
            {
                caso = "A";
            }
            else if (int.Parse(caso) == 11)
            {
                caso = "B";
            }
            else if (int.Parse(caso) == 12)
            {
                caso = "C";
            }
            return caso;
        }

        public static void preferencia(int [] trilhas)
        {
            for (int i = 0; i < trilhas.Length; i++)
            {
                if (trilhas[i] == 7)
                {
                    dadoescolhido += dupladodado[i];
                    return;
                }
            }

            for (int i = 0; i < trilhas.Length; i++)
            {
                if (trilhas[i] == 2)
                {
                    dadoescolhido += dupladodado[i];
                    return;
                }
                else if (trilhas[i] == 12)
                {
                    dadoescolhido += dupladodado[i];
                    return;
                }
                else if (trilhas[i] == 6)
                {
                    dadoescolhido += dupladodado[i];
                    return;
                }
                else if (trilhas[i] == 8)
                {
                    dadoescolhido += dupladodado[i];
                    return;
                }
            }

            for (int i = 0; i < trilhas.Length; i++)
            {
                if (trilhas[i] == 3)
                {
                    dadoescolhido += dupladodado[i];
                    return;
                }
                else if (trilhas[i] == 4)
                {
                    dadoescolhido += dupladodado[i];
                    return;
                }
                else if (trilhas[i] == 5)
                {
                    dadoescolhido += dupladodado[i];
                    return;
                }
                else if (trilhas[i] == 9)
                {
                    dadoescolhido += dupladodado[i];
                    return;
                }
                else if (trilhas[i] == 10)
                {
                    dadoescolhido += dupladodado[i];
                    return;
                }
                else if (trilhas[i] == 11)
                {
                    dadoescolhido += dupladodado[i];
                    return;
                }

            }


        }
    }
}
