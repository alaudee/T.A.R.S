using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARS
{
    public class Alpinista
    {
        public string SomaDados { get; set; }
        public string Trilha{ get; set; }


        /*List<SLA> s = new List<SLA>();

        public string dados { get; set; } // 12
        public string trilha { get; set; }// valor soma dos dados

        // 9 e 8
        //new SLA p1 = new SLA();
        //new SLA p2 = new SLA();
        //p1.dados = 13
        //p1.trilha = 8
        //p2.dados = 24
        //p2.trilha = 8
        //string teste = p1.dados + p2.dados = 1324
        //string teste2 = p1.trilha+p2.trilha = 98*/

        public static List<Alpinista> DefinirSoma(int[] trilhas)
        {
            List<Alpinista> alp = new List<Alpinista>();
            for (int i = 0; i < trilhas.Length; i++)
            {
                Alpinista a = new Alpinista();
                if (i == 0)
                {
                    a.Trilha = trilhas[0].ToString();
                    a.SomaDados = "12";
                    alp.Add(a);
                }
                else if (i == 1)
                {
                    a.Trilha = trilhas[1].ToString();
                    a.SomaDados = "13";
                    alp.Add(a);
                }
                else if (i == 2)
                {
                    a.Trilha = trilhas[2].ToString();
                    a.SomaDados = "14";
                    alp.Add(a);
                }
                else if (i == 3)
                {
                    a.Trilha = trilhas[3].ToString();
                    a.SomaDados = "23";
                    alp.Add(a);
                }
                else if (i == 4)
                {
                    a.Trilha = trilhas[4].ToString();
                    a.SomaDados = "24";
                    alp.Add(a);
                }
                else 
                {
                    a.Trilha = trilhas[5].ToString();
                    a.SomaDados = "34";
                    alp.Add(a);
                }
            }
            return alp;
        }

        //public static string MontarTrilhasEscolhidas(List<Alpinista> alpinistas, string escolhatrilha)
        //{
        //    string l1 = escolhatrilha[0].ToString();
        //    string l2 = escolhatrilha[1].ToString();
        //    string ret ="";
        //    for (int i = 0; i < 5; i++)
        //    {
        //        if(alpinistas[i].Trilha == l1)
        //        {
        //            ret += l1;
        //        }
        //        else
        //        {
        //            ret += l2;
        //        }
        //    }

        //    return
        //}
    }
}
