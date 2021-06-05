using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CantStopServer;
using System.Collections;
namespace TARS
{
    public class Dado
    {
        public char NumeroDado { get; set; }
        public char ValorDado { get; set; }
        public Image FaceDado { get; set; }

        public static string[] dupladodado = new string[6];
        public static string dadoescolhido = "";
        public static int cont = 1;


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

        public static string FormarDuplasSomaDados(char[] valordado, bool[] trilhaFormada, ArrayList trilhasalpinistas)
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

            preferencia(trilha, trilhaFormada, trilhasalpinistas);

            /*Jogo.VerificarTrilhas(idpartida)
              trilha[0]  jogadorid[1]
                 5           2        */


            if (dadoescolhido == "12")
            {
                dadoescolhido += 34;
                //verifica se o resultado da outra soma de dados tem sua trilha completa 
                bool bora = verificarNovamente(trilha[5], trilhaFormada);
                if (bora == true)//pode jogar
                {

                    //verifica qual é a rodada
                    if (cont == 1)
                    {
                        dadoescolhido += "e" + trilha[0] + "e" + trilha[5];
                        if (trilha[0] == trilha[5])
                        {
                            trilhasalpinistas.Add(trilha[0]);//talvez precise adicionar a outra trilha pra mostrar que é a 2 rodada
                        }
                        else
                        {
                            trilhasalpinistas.Add(trilha[0]);
                            trilhasalpinistas.Add(trilha[5]);
                        }
                        cont++;
                    }
                    else if (cont == 2)
                    {
                        cont++;
                        bool contem = false;
                        for (int i = 0; i < trilhasalpinistas.Count; i++)
                        {
                            //caso entre pode dar problema caso, a trilha já esteja completa
                            if (trilha[5] == (int)trilhasalpinistas[i])
                            {
                                if (trilhaFormada[trilha[0] - 2] == true)
                                {
                                    dadoescolhido += "e" + trilha[5] + "e" + 0;
                                }
                                else
                                {
                                    dadoescolhido += "e" + trilha[0] + "e" + trilha[5];
                                    if (trilha[5] != trilha[0])
                                    {
                                        for (int j = 0; j < trilhasalpinistas.Count; j++)
                                        {
                                            if (trilha[0] == (int)trilhasalpinistas[j])
                                            {
                                                return dadoescolhido;
                                            }
                                        }
                                        trilhasalpinistas.Add(trilha[0]);
                                    }
                                }
                                contem = true;
                                return dadoescolhido;
                            }
                            if (trilha[0] == (int)trilhasalpinistas[i])
                            {
                                if (trilhaFormada[trilha[5] - 2] == true)
                                {
                                    dadoescolhido += "e" + trilha[0] + "e" + 0;
                                }
                                else
                                {
                                    dadoescolhido += "e" + trilha[0] + "e" + trilha[5];
                                    if (trilha[0] != trilha[5])
                                    {
                                        for (int j = 0; j < trilhasalpinistas.Count; j++)
                                        {
                                            if (trilha[5] == (int)trilhasalpinistas[j])
                                            {
                                                return dadoescolhido;
                                            }
                                        }
                                        trilhasalpinistas.Add(trilha[5]);
                                    }
                                }
                                contem = true;
                                return dadoescolhido;
                            }
                        }
                        if (contem == false)
                        {
                            if (trilha[0] == trilha[5])
                            {
                                dadoescolhido += "e" + trilha[0] + "e" + trilha[5];
                            }
                            else if (trilhasalpinistas.Count < 2)//significa que tem dois alpinistas em trilha diferente, então posso colocar mais um
                            {
                                dadoescolhido += "e" + trilha[0] + "e" + trilha[5];
                                trilhasalpinistas.Add(trilha[0]);
                                trilhasalpinistas.Add(trilha[5]);
                            }
                            else
                            {
                                dadoescolhido += "e" + trilha[0] + "e" + 0;
                                trilhasalpinistas.Add(trilha[0]);
                            }

                        }
                    }
                    else
                    {
                        cont = 1;
                        int verifica = 0;
                        for (int i = 0; i < trilhasalpinistas.Count; i++)
                        {
                            if (trilha[5] == (int)trilhasalpinistas[i])
                            {
                                verifica++;
                            }
                        }

                        for (int i = 0; i < trilhasalpinistas.Count; i++)
                        {
                            if (trilha[0] == (int)trilhasalpinistas[i])
                            {
                                verifica++;
                            }
                        }

                        if (verifica != 2)
                        {
                            for (int i = 0; i < trilhasalpinistas.Count; i++)
                            {
                                if (trilhasalpinistas.Count == 2)
                                {
                                    dadoescolhido += "e" + trilha[0] + "e" + trilha[5];
                                    return dadoescolhido;
                                }
                                if (trilha[5] == (int)trilhasalpinistas[i])
                                {
                                    dadoescolhido += "e" + trilha[5] + "e" + 0;
                                    return dadoescolhido;
                                }
                                if (trilha[0] == (int)trilhasalpinistas[i])
                                {
                                    dadoescolhido += "e" + trilha[0] + "e" + 0;
                                    return dadoescolhido;
                                }
                            }
                        }
                        else
                        {
                            dadoescolhido += "e" + trilha[0] + "e" + trilha[5];
                        }
                    }

                }
                else
                {
                    dadoescolhido += "e" + trilha[0] + "e" + 0;
                    trilhasalpinistas.Add(trilha[0]);
                }
            }
            else if (dadoescolhido == "13")
            {
                dadoescolhido += "24";
                bool bora = verificarNovamente(trilha[4], trilhaFormada);
                if (bora == true)//pode jogar
                {
                    if (cont == 1)
                    {
                        dadoescolhido += "e" + trilha[1] + "e" + trilha[4];
                        if (trilha[1] == trilha[4])
                        {
                            trilhasalpinistas.Add(trilha[1]);
                        }
                        else
                        {
                            trilhasalpinistas.Add(trilha[1]);
                            trilhasalpinistas.Add(trilha[4]);
                        }
                        cont++;
                    }
                    else if (cont == 2)
                    {
                        cont++;
                        bool contem = false;
                        for (int i = 0; i < trilhasalpinistas.Count; i++)
                        {
                            if (trilha[4] == (int)trilhasalpinistas[i])//AQui
                            {
                                if (trilhaFormada[trilha[1] - 2] == true)
                                {
                                    dadoescolhido += "e" + trilha[4] + "e" + 0;
                                }
                                else
                                {
                                    dadoescolhido += "e" + trilha[1] + "e" + trilha[4];
                                    if (trilha[4] != trilha[1])
                                    {
                                        for (int j = 0; j < trilhasalpinistas.Count; j++)
                                        {
                                            if(trilha[1] == (int)trilhasalpinistas[j])
                                            {
                                                return dadoescolhido;
                                            }
                                        }
                                        trilhasalpinistas.Add(trilha[1]);
                                    }
                                }

                                contem = true;
                                return dadoescolhido;
                            }
                            if (trilha[1] == (int)trilhasalpinistas[i])
                            {
                                if (trilhaFormada[trilha[4] - 2] == true)
                                {
                                    dadoescolhido += "e" + trilha[1] + "e" + 0;
                                }
                                else
                                {
                                    dadoescolhido += "e" + trilha[1] + "e" + trilha[4];
                                    if (trilha[1] != trilha[4])
                                    {
                                        for (int j = 0; j < trilhasalpinistas.Count; j++)
                                        {
                                            if (trilha[4] == (int)trilhasalpinistas[j])
                                            {
                                                return dadoescolhido;
                                            }
                                        }
                                        trilhasalpinistas.Add(trilha[4]);
                                    }
                                }
                                contem = true;
                                return dadoescolhido;
                            }
                        }

                        if (contem == false)
                        {
                            if (trilha[1] == trilha[4])
                            {
                                dadoescolhido += "e" + trilha[1] + "e" + trilha[4];
                            }
                            else if (trilhasalpinistas.Count < 2)//significa que tem dois alpinistas em trilha diferente, então posso colocar mais um
                            {
                                dadoescolhido += "e" + trilha[1] + "e" + trilha[4];
                                trilhasalpinistas.Add(trilha[4]);
                                trilhasalpinistas.Add(trilha[1]);
                            }
                            else
                            {
                                dadoescolhido += "e" + trilha[1] + "e" + 0;
                                trilhasalpinistas.Add(trilha[1]);
                            }
                        }

                    }
                    else// cont == 3
                    {
                        cont = 1;
                        int verifica = 0;
                        for (int i = 0; i < trilhasalpinistas.Count; i++)
                        {
                            if (trilha[1] == (int)trilhasalpinistas[i])
                            {
                                verifica++;
                            }
                        }

                        for (int i = 0; i < trilhasalpinistas.Count; i++)
                        {
                            if (trilha[4] == (int)trilhasalpinistas[i])
                            {
                                verifica++;
                            }
                        }

                        if (verifica != 2)
                        {
                            for (int i = 0; i < trilhasalpinistas.Count; i++)
                            {
                                if (trilhasalpinistas.Count == 2)
                                {
                                    dadoescolhido += "e" + trilha[1] + "e" + trilha[4];
                                    return dadoescolhido;
                                }
                                if (trilha[1] == (int)trilhasalpinistas[i])
                                {
                                    dadoescolhido += "e" + trilha[1] + "e" + 0;
                                    return dadoescolhido;
                                }
                                if (trilha[4] == (int)trilhasalpinistas[i])
                                {
                                    dadoescolhido += "e" + trilha[4] + "e" + 0;
                                    return dadoescolhido;
                                }
                            }
                        }
                        else
                        {
                            dadoescolhido += "e" + trilha[1] + "e" + trilha[4];
                        }

                    }

                }
                else
                {
                    dadoescolhido += "e" + trilha[1] + "e" + 0;
                    trilhasalpinistas.Add(trilha[1]);
                }

            }
            else if (dadoescolhido == "14")
            {
                dadoescolhido += "23";
                bool bora = verificarNovamente(trilha[3], trilhaFormada);
                if (bora == true)//pode jogar
                {
                    if (cont == 1)
                    {
                        dadoescolhido += "e" + trilha[2] + "e" + trilha[3];
                        if (trilha[2] == trilha[3])
                        {
                            trilhasalpinistas.Add(trilha[2]);
                        }
                        else
                        {
                            trilhasalpinistas.Add(trilha[2]);
                            trilhasalpinistas.Add(trilha[3]);
                        }
                        cont++;
                    }
                    else if (cont == 2)
                    {
                        cont++;
                        bool contem = false;
                        for (int i = 0; i < trilhasalpinistas.Count; i++)
                        {
                            if (trilha[3] == (int)trilhasalpinistas[i])
                            {
                                if (trilhaFormada[trilha[2] - 2] == true)
                                {
                                    dadoescolhido += "e" + trilha[3] + "e" + 0;
                                }
                                else
                                {
                                    dadoescolhido += "e" + trilha[2] + "e" + trilha[3];
                                    if (trilha[3] != trilha[2])
                                    {
                                        for (int j = 0; j < trilhasalpinistas.Count; j++)
                                        {
                                            if (trilha[2] == (int)trilhasalpinistas[j])
                                            {
                                                return dadoescolhido;
                                            }
                                        }
                                        trilhasalpinistas.Add(trilha[2]);
                                    }
                                }
                                contem = true;

                                return dadoescolhido;
                            }
                            if (trilha[2] == (int)trilhasalpinistas[i])
                            {
                                if (trilhaFormada[trilha[3] - 2] == true)
                                {
                                    dadoescolhido += "e" + trilha[2] + "e" + 0;
                                }
                                else
                                {
                                    dadoescolhido += "e" + trilha[2] + "e" + trilha[3];
                                    if (trilha[2] != trilha[3])
                                    {
                                        for (int j = 0; j < trilhasalpinistas.Count; j++)
                                        {
                                            if (trilha[3] == (int)trilhasalpinistas[j])
                                            {
                                                return dadoescolhido;
                                            }
                                        }
                                        trilhasalpinistas.Add(trilha[3]);
                                    }
                                }
                                contem = true;
                                return dadoescolhido;
                            }
                        }

                        if (contem == false)
                        {

                            if (trilha[2] == trilha[3])
                            {
                                dadoescolhido += "e" + trilha[2] + "e" + trilha[3];
                            }
                            else if (trilhasalpinistas.Count < 2)//significa que tem dois alpinistas em trilha diferente, então posso colocar mais um
                            {
                                dadoescolhido += "e" + trilha[2] + "e" + trilha[3];
                                trilhasalpinistas.Add(trilha[3]);
                                trilhasalpinistas.Add(trilha[2]);
                            }
                            else
                            {
                                dadoescolhido += "e" + trilha[2] + "e" + 0;
                                trilhasalpinistas.Add(trilha[2]);
                            }

                        }

                    }
                    else
                    {
                        cont = 1;
                        int verifica = 0;
                        for (int i = 0; i < trilhasalpinistas.Count; i++)
                        {
                            if (trilha[2] == (int)trilhasalpinistas[i])
                            {
                                verifica++;
                            }
                        }

                        for (int i = 0; i < trilhasalpinistas.Count; i++)
                        {
                            if (trilha[3] == (int)trilhasalpinistas[i])
                            {
                                verifica++;
                            }
                        }

                        if (verifica != 2)
                        {
                            for (int i = 0; i < trilhasalpinistas.Count; i++)//aqui
                            {
                                if (trilhasalpinistas.Count == 2)
                                {
                                    dadoescolhido += "e" + trilha[2] + "e" + trilha[3];
                                    return dadoescolhido;
                                }
                                if (trilha[2] == (int)trilhasalpinistas[i])
                                {
                                    dadoescolhido += "e" + trilha[2] + "e" + 0;
                                    return dadoescolhido;
                                }
                                if (trilha[3] == (int)trilhasalpinistas[i])
                                {
                                    dadoescolhido += "e" + trilha[3] + "e" + 0;
                                    return dadoescolhido;
                                }
                            }
                        }
                        else
                        {
                            dadoescolhido += "e" + trilha[2] + "e" + trilha[3];
                        }
                    }
                }
                else
                {
                    dadoescolhido += "e" + trilha[2] + "e" + 0;
                    trilhasalpinistas.Add(trilha[2]);
                }
            }
            else if (dadoescolhido == "23")
            {
                dadoescolhido += "14";
                bool bora = verificarNovamente(trilha[2], trilhaFormada);
                if (bora == true)//pode jogar
                {
                    if (cont == 1)
                    {
                        dadoescolhido += "e" + trilha[3] + "e" + trilha[2];
                        if (trilha[2] == trilha[3])
                        {
                            trilhasalpinistas.Add(trilha[2]);
                        }
                        else
                        {
                            trilhasalpinistas.Add(trilha[2]);
                            trilhasalpinistas.Add(trilha[3]);
                        }
                        cont++;
                    }
                    else if (cont == 2)
                    {
                        cont++;
                        bool contem = false;
                        for (int i = 0; i < trilhasalpinistas.Count; i++)
                        {
                            if (trilha[2] == (int)trilhasalpinistas[i])
                            {
                                if (trilhaFormada[trilha[3] - 2] == true)
                                {
                                    dadoescolhido += "e" + trilha[2] + "e" + 0;
                                }
                                else
                                {
                                    dadoescolhido += "e" + trilha[3] + "e" + trilha[2];
                                    if (trilha[2] != trilha[3])
                                    {
                                        for (int j = 0; j < trilhasalpinistas.Count; j++)
                                        {
                                            if (trilha[3] == (int)trilhasalpinistas[j])
                                            {
                                                return dadoescolhido;
                                            }
                                        }
                                        trilhasalpinistas.Add(trilha[3]);
                                    }
                                }
                                contem = true;
                                return dadoescolhido;
                            }
                            if (trilha[3] == (int)trilhasalpinistas[i])
                            {
                                if (trilhaFormada[trilha[2] - 2] == true)
                                {
                                    dadoescolhido += "e" + trilha[3] + "e" + 0;
                                }
                                else
                                {
                                    dadoescolhido += "e" + trilha[3] + "e" + trilha[2];
                                    if (trilha[3] != trilha[2])
                                    {
                                        for (int j = 0; j < trilhasalpinistas.Count; j++)
                                        {
                                            if (trilha[2] == (int)trilhasalpinistas[j])
                                            {
                                                return dadoescolhido;
                                            }
                                        }
                                        trilhasalpinistas.Add(trilha[2]);
                                    }
                                }
                                contem = true;
                                return dadoescolhido;
                            }
                        }

                        if (contem == false)
                        {
                            if (trilha[2] == trilha[3])
                            {
                                dadoescolhido += "e" + trilha[3] + "e" + trilha[2];

                            }
                            else if (trilhasalpinistas.Count < 2)//significa que tem dois alpinistas em trilha diferente, então posso colocar mais um
                            {
                                dadoescolhido += "e" + trilha[3] + "e" + trilha[2];
                                trilhasalpinistas.Add(trilha[3]);
                                trilhasalpinistas.Add(trilha[2]);
                            }
                            else
                            {
                                dadoescolhido += "e" + trilha[3] + "e" + 0;
                                trilhasalpinistas.Add(trilha[3]);
                            }

                        }

                    }
                    else
                    {
                        cont = 1;
                        int verifica = 0;
                        for (int i = 0; i < trilhasalpinistas.Count; i++)
                        {
                            if (trilha[2] == (int)trilhasalpinistas[i])
                            {
                                verifica++;
                            }
                        }

                        for (int i = 0; i < trilhasalpinistas.Count; i++)
                        {
                            if (trilha[3] == (int)trilhasalpinistas[i])
                            {
                                verifica++;
                            }
                        }

                        if (verifica != 2)
                        {
                            for (int i = 0; i < trilhasalpinistas.Count; i++)
                            {
                                if (trilhasalpinistas.Count == 2)
                                {
                                    dadoescolhido += "e" + trilha[3] + "e" + trilha[2];
                                    return dadoescolhido;
                                }
                                if (trilha[2] == (int)trilhasalpinistas[i])
                                {
                                    dadoescolhido += "e" + trilha[2] + "e" + 0;
                                    return dadoescolhido;
                                }
                                if (trilha[3] == (int)trilhasalpinistas[i])
                                {
                                    dadoescolhido += "e" + trilha[3] + "e" + 0;
                                    return dadoescolhido;
                                }
                            }
                        }
                        else
                        {
                            dadoescolhido += "e" + trilha[3] + "e" + trilha[2];
                        }

                    }

                }
                else
                {
                    dadoescolhido += "e" + trilha[3] + "e" + 0;
                    trilhasalpinistas.Add(trilha[3]);
                }
            }
            else if (dadoescolhido == "24")
            {
                dadoescolhido += "13";
                bool bora = verificarNovamente(trilha[1], trilhaFormada);
                if (bora == true)//pode jogar
                {
                    if (cont == 1)
                    {
                        dadoescolhido += "e" + trilha[4] + "e" + trilha[1];
                        if (trilha[4] == trilha[1])
                        {
                            trilhasalpinistas.Add(trilha[4]);
                        }
                        else
                        {
                            trilhasalpinistas.Add(trilha[4]);
                            trilhasalpinistas.Add(trilha[1]);
                        }
                        cont++;
                    }
                    else if (cont == 2)
                    {
                        cont++;
                        bool contem = false;
                        for (int i = 0; i < trilhasalpinistas.Count; i++)
                        {
                            if (trilha[1] == (int)trilhasalpinistas[i])
                            {
                                if (trilhaFormada[trilha[4] - 2] == true)
                                {
                                    dadoescolhido += "e" + trilha[1] + "e" + 0;
                                }
                                else
                                {
                                    dadoescolhido += "e" + trilha[4] + "e" + trilha[1];
                                    if (trilha[1] != trilha[4])
                                    {
                                        for (int j = 0; j < trilhasalpinistas.Count; j++)
                                        {
                                            if (trilha[4] == (int)trilhasalpinistas[j])
                                            {
                                                return dadoescolhido;
                                            }
                                        }
                                        trilhasalpinistas.Add(trilha[4]);
                                    }
                                }
                                contem = true;
                                return dadoescolhido;
                            }
                            if (trilha[4] == (int)trilhasalpinistas[i])
                            {
                                if (trilhaFormada[trilha[1] - 2] == true)
                                {
                                    dadoescolhido += "e" + trilha[4] + "e" + 0;
                                }
                                else
                                {
                                    dadoescolhido += "e" + trilha[4] + "e" + trilha[1];
                                    if (trilha[4] != trilha[1])
                                    {
                                        for (int j = 0; j < trilhasalpinistas.Count; j++)
                                        {
                                            if (trilha[1] == (int)trilhasalpinistas[j])
                                            {
                                                return dadoescolhido;
                                            }
                                        }
                                        trilhasalpinistas.Add(trilha[1]);
                                    }
                                }
                                contem = true;
                                return dadoescolhido;
                            }
                        }
                        if (contem == false)
                        {
                            if (trilha[4] == trilha[1])
                            {
                                dadoescolhido += "e" + trilha[4] + "e" + trilha[1];
                            }
                            else if (trilhasalpinistas.Count < 2)//significa que tem dois alpinistas em trilha diferente, então posso colocar mais um
                            {
                                dadoescolhido += "e" + trilha[4] + "e" + trilha[1];
                                trilhasalpinistas.Add(trilha[1]);
                                trilhasalpinistas.Add(trilha[4]);
                            }
                            else
                            {
                                dadoescolhido += "e" + trilha[4] + "e" + 0;
                                trilhasalpinistas.Add(trilha[4]);
                            }

                        }

                    }
                    else
                    {
                        cont = 1;
                        int verifica = 0;
                        for (int i = 0; i < trilhasalpinistas.Count; i++)
                        {
                            if (trilha[4] == (int)trilhasalpinistas[i])
                            {
                                verifica++;
                            }
                        }

                        for (int i = 0; i < trilhasalpinistas.Count; i++)
                        {
                            if (trilha[1] == (int)trilhasalpinistas[i])
                            {
                                verifica++;
                            }
                        }

                        if (verifica != 2)
                        {
                            for (int i = 0; i < trilhasalpinistas.Count; i++)
                            {
                                if (trilhasalpinistas.Count == 2)
                                {
                                    dadoescolhido += "e" + trilha[4] + "e" + trilha[1];
                                    return dadoescolhido;
                                }
                                if (trilha[4] == (int)trilhasalpinistas[i])
                                {
                                    dadoescolhido += "e" + trilha[4] + "e" + 0;
                                    return dadoescolhido;
                                }
                                if (trilha[1] == (int)trilhasalpinistas[i])
                                {
                                    dadoescolhido += "e" + trilha[1] + "e" + 0;
                                    return dadoescolhido;
                                }
                            }
                        }
                        else
                        {
                            dadoescolhido += "e" + trilha[4] + "e" + trilha[1];
                        }

                    }
                }
                else
                {
                    dadoescolhido += "e" + trilha[4] + "e" + 0;
                    trilhasalpinistas.Add(trilha[4]);
                }


            }
            else if (dadoescolhido == "34")
            {
                dadoescolhido += 12;
                bool bora = verificarNovamente(trilha[0], trilhaFormada);
                if (bora == true)//pode jogar
                {
                    if (cont == 1)
                    {
                        dadoescolhido += "e" + trilha[5] + "e" + trilha[0];
                        if (trilha[5] == trilha[0])
                        {
                            trilhasalpinistas.Add(trilha[5]);
                        }
                        else
                        {
                            trilhasalpinistas.Add(trilha[5]);
                            trilhasalpinistas.Add(trilha[0]);
                        }
                    }
                    else if (cont == 2)
                    {
                        cont++;
                        bool contem = false;
                        for (int i = 0; i < trilhasalpinistas.Count; i++)
                        {
                            if (trilha[0] == (int)trilhasalpinistas[i])
                            {
                                if (trilhaFormada[trilha[5] - 2] == true)
                                {
                                    dadoescolhido += "e" + trilha[0] + "e" + 0;
                                }
                                else
                                {
                                    dadoescolhido += "e" + trilha[5] + "e" + trilha[0];
                                    if (trilha[0] != trilha[5])
                                    {
                                        for (int j = 0; j < trilhasalpinistas.Count; j++)
                                        {
                                            if (trilha[5] == (int)trilhasalpinistas[j])
                                            {
                                                return dadoescolhido;
                                            }
                                        }
                                        trilhasalpinistas.Add(trilha[5]);
                                    }
                                }
                                contem = true;
                                return dadoescolhido;
                            }
                            if (trilha[5] == (int)trilhasalpinistas[i])
                            {
                                if (trilhaFormada[trilha[0] - 2] == true)
                                {
                                    dadoescolhido += "e" + trilha[5] + "e" + 0;
                                }
                                else
                                {
                                    dadoescolhido += "e" + trilha[5] + "e" + trilha[0];
                                    if (trilha[5] != trilha[0])
                                    {
                                        for (int j = 0; j < trilhasalpinistas.Count; j++)
                                        {
                                            if (trilha[0] == (int)trilhasalpinistas[j])
                                            {
                                                return dadoescolhido;
                                            }
                                        }
                                        trilhasalpinistas.Add(trilha[0]);
                                    }
                                }
                                contem = true;
                                return dadoescolhido;
                            }
                        }

                        if (contem == false)
                        {
                            if (trilha[5] == trilha[0])
                            {
                                dadoescolhido += "e" + trilha[5] + "e" + trilha[0];
                            }
                            else if (trilhasalpinistas.Count < 2)//significa que tem dois alpinistas em trilha diferente, então posso colocar mais um
                            {
                                dadoescolhido += "e" + trilha[5] + "e" + trilha[0];
                                trilhasalpinistas.Add(trilha[0]);
                                trilhasalpinistas.Add(trilha[5]);
                            }
                            else
                            {
                                dadoescolhido += "e" + trilha[5] + "e" + 0;
                                trilhasalpinistas.Add(trilha[5]);
                            }
                        }

                    }
                    else
                    {
                        int verifica = 0;
                        cont = 1;
                        for (int i = 0; i < trilhasalpinistas.Count; i++)
                        {
                            if (trilha[5] == (int)trilhasalpinistas[i])
                            {
                                verifica++;
                            }
                        }

                        for (int i = 0; i < trilhasalpinistas.Count; i++)
                        {
                            if (trilha[0] == (int)trilhasalpinistas[i])
                            {
                                verifica++;
                            }
                        }

                        if (verifica != 2)
                        {
                            if (trilhasalpinistas.Count == 2)
                            {
                                dadoescolhido += "e" + trilha[5] + "e" + trilha[0];
                                return dadoescolhido;
                            }
                            for (int i = 0; i < trilhasalpinistas.Count; i++)
                            {
                                if (trilha[5] == (int)trilhasalpinistas[i])
                                {
                                    dadoescolhido += "e" + trilha[5] + "e" + 0;
                                    return dadoescolhido;
                                }
                                if (trilha[0] == (int)trilhasalpinistas[i])
                                {
                                    dadoescolhido += "e" + trilha[0] + "e" + 0;
                                    return dadoescolhido;
                                }
                            }
                        }
                        else
                        {
                            dadoescolhido += "e" + trilha[5] + "e" + trilha[0];
                        }

                    }
                }
                else
                {
                    dadoescolhido += "e" + trilha[5] + "e" + 0;
                    trilhasalpinistas.Add(trilha[5]);
                }
            }
            return dadoescolhido;
        }


        //Converte os valores para hetrilhaadecimal
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

        public static void preferencia(int[] trilhas, bool[] trilhaCompleta, ArrayList trilhasalpinistas)
        {
            //aqui
            for (int i = 0; i < trilhasalpinistas.Count; i++)
            {
                for (int j = 0; j < trilhas.Length; j++)
                {
                    if (trilhas[j] == (int)trilhasalpinistas[i])//ta certo aqui
                    {
                        if (trilhaCompleta[(int)trilhasalpinistas[i] - 2] == false)//pode dar erro pq fica negativo isso
                        {
                            dadoescolhido += dupladodado[j];
                            //if(j == 0)//verifica qual das trilhas tem o alpinista e forma os dados(dado escolhido)
                            //{
                            //    dadoescolhido += 12;
                            //}
                            //else if (j == 1)
                            //{
                            //    dadoescolhido += 13;
                            //}
                            //else if (j == 2)
                            //{
                            //    dadoescolhido += 14;
                            //}
                            //else if (j == 3)
                            //{
                            //    dadoescolhido += 23;
                            //}
                            //else if (j == 4)
                            //{
                            //    dadoescolhido += 24;
                            //}
                            //else if (j == 5)
                            //{
                            //    dadoescolhido += 34;
                            //}
                            return;
                        }
                    }
                }
            }
            for (int i = 0; i < trilhas.Length; i++)
            {
                if (trilhaCompleta[5] == false)
                {
                    if (trilhas[i] == 7)
                    {
                        dadoescolhido += dupladodado[i];
                        return;
                    }

                }

            }

            for (int i = 0; i < trilhas.Length; i++)
            {
                if (trilhaCompleta[0] == false)
                {
                    if (trilhas[i] == 2)
                    {
                        dadoescolhido += dupladodado[i];
                        return;
                    }
                }
                if (trilhaCompleta[10] == false)
                {
                    if (trilhas[i] == 12)
                    {
                        dadoescolhido += dupladodado[i];
                        return;
                    }
                }
                if (trilhaCompleta[4] == false)
                {
                    if (trilhas[i] == 6)
                    {
                        dadoescolhido += dupladodado[i];
                        return;
                    }
                }
                if (trilhaCompleta[6] == false)
                {
                    if (trilhas[i] == 8)
                    {
                        dadoescolhido += dupladodado[i];
                        return;
                    }
                }

            }

            for (int i = 0; i < trilhas.Length; i++)
            {
                if (trilhaCompleta[1] == false)
                {
                    if (trilhas[i] == 3)
                    {
                        dadoescolhido += dupladodado[i];
                        return;
                    }
                }
                if (trilhaCompleta[2] == false)
                {
                    if (trilhas[i] == 4)
                    {
                        dadoescolhido += dupladodado[i];
                        return;
                    }
                }
                if (trilhaCompleta[3] == false)
                {
                    if (trilhas[i] == 5)
                    {
                        dadoescolhido += dupladodado[i];
                        return;
                    }
                }
                if (trilhaCompleta[7] == false)
                {
                    if (trilhas[i] == 9)
                    {
                        dadoescolhido += dupladodado[i];
                        return;
                    }
                }
                if (trilhaCompleta[8] == false)
                {
                    if (trilhas[i] == 10)
                    {
                        dadoescolhido += dupladodado[i];
                        return;
                    }
                }
                if (trilhaCompleta[9] == false)
                {
                    if (trilhas[i] == 11)
                    {
                        dadoescolhido += dupladodado[i];
                        return;
                    }
                }

            }


        }

        public static bool verificarNovamente(int trilha, bool[] trilhaCompleta)
        {
            if (trilha == 2)
            {
                if (trilhaCompleta[0] == true)
                {
                    return false;
                }
            }
            else if (trilha == 3)
            {
                if (trilhaCompleta[1] == true)
                {
                    return false;
                }
            }
            else if (trilha == 4)
            {
                if (trilhaCompleta[2] == true)
                {
                    return false;
                }
            }
            else if (trilha == 5)
            {
                if (trilhaCompleta[3] == true)
                {
                    return false;
                }
            }
            else if (trilha == 6)
            {
                if (trilhaCompleta[4] == true)
                {
                    return false;
                }
            }
            else if (trilha == 7)
            {
                if (trilhaCompleta[5] == true)
                {
                    return false;
                }
            }
            else if (trilha == 8)
            {
                if (trilhaCompleta[6] == true)
                {
                    return false;
                }
            }
            else if (trilha == 9)
            {
                if (trilhaCompleta[7] == true)
                {
                    return false;
                }
            }
            else if (trilha == 10)
            {
                if (trilhaCompleta[8] == true)
                {
                    return false;
                }
            }
            else if (trilha == 11)
            {
                if (trilhaCompleta[9] == true)
                {
                    return false;
                }
            }
            else if (trilha == 12)
            {
                if (trilhaCompleta[10] == true)
                {
                    return false;
                }
            }
            return true;
        }

    }

}

