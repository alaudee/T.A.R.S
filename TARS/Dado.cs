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

        public static int[] FormarDuplasSomaDados(char[] valordado)
        {
            int[] trilha = new int[6];

            trilha[0] = (int)Char.GetNumericValue(valordado[0]) + (int)Char.GetNumericValue(valordado[1]);

            trilha[1] = (int)Char.GetNumericValue(valordado[0]) + (int)Char.GetNumericValue(valordado[2]);

            trilha[2] = (int)Char.GetNumericValue(valordado[0]) + (int)Char.GetNumericValue(valordado[3]);

            trilha[3] = (int)Char.GetNumericValue(valordado[1]) + (int)Char.GetNumericValue(valordado[2]);

            trilha[4] = (int)Char.GetNumericValue(valordado[1]) + (int)Char.GetNumericValue(valordado[3]);

            trilha[5] = (int)Char.GetNumericValue(valordado[2]) + (int)Char.GetNumericValue(valordado[3]);

            return trilha;
        }


    }
}
