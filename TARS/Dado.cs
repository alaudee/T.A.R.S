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
    class Dado
    {
        public char NumeroDado { get; set; }
        public char ValorDado { get; set; }
        public Image FaceDado { get; set; }

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

        public static int[] FormarDuplasSomaDados(char[] valordado)
        {
            int[] trilha = new int[6];

            trilha[0] = (int)Char.GetNumericValue(valordado[0]) + (int)Char.GetNumericValue(valordado[1]);//dado 1 e 2

            trilha[1] = (int)Char.GetNumericValue(valordado[0]) + (int)Char.GetNumericValue(valordado[2]);// dado 1 e 3

            trilha[2] = (int)Char.GetNumericValue(valordado[0]) + (int)Char.GetNumericValue(valordado[3]);// dado 1 e 4

            trilha[3] = (int)Char.GetNumericValue(valordado[1]) + (int)Char.GetNumericValue(valordado[2]);// dado 2 e 3

            trilha[4] = (int)Char.GetNumericValue(valordado[1]) + (int)Char.GetNumericValue(valordado[3]);// dado 2 e 4

            trilha[5] = (int)Char.GetNumericValue(valordado[2]) + (int)Char.GetNumericValue(valordado[3]);// dado 3 e 4

            return trilha;
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
    }
}
